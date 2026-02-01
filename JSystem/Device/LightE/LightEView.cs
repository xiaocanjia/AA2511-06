using System;
using System.Linq;
using System.Windows.Forms;
using Sunny.UI;

namespace JSystem.Device
{
    public partial class LightEView : UserControl
    {
        private LightE _device;

        public LightEView()
        {
            InitializeComponent();
        }

        public LightEView(LightE device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
            CbB_SN.Items.Clear();
            int mDeviceCnt = LEConfocalDLL.LE_GetSpecCount();               //获取已连接控制器数量
            mDeviceCnt = mDeviceCnt <= 0 ? 0 : mDeviceCnt;
            char[] mAryChar = new char[32 * mDeviceCnt];                    //保存控制器序列号，该数组最大能保存2个
            bool bSta = LEConfocalDLL.LE_GetSpecSN(mAryChar, mDeviceCnt);   //获取已连接控制器序列号
            string[] names = new string[mDeviceCnt];
            for (int i = 0; i < mDeviceCnt; i++)
            {
                char[] pSN1 = new char[32];
                Array.Copy(mAryChar, i * 32, pSN1, 0, 32);
                names[i] = new string(pSN1);
            }
            CbB_SN.Items.AddRange(names);
            CbB_SN.SelectedItem = _device.CurrSN;
            Btn_Connect.Selected = _device.CheckConnection();
            CB_Enabled.Checked = _device.IsEnable;
            TB_Read_Count.Text = _device.ReadCount.ToString();
            TB_Time_Out.Text = _device.TimeOut.ToString();
            CB_Enabled.CheckedChanged += new EventHandler(CB_Enabled_CheckedChanged);
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                _device.CurrSN = CbB_SN.SelectedText;
                if (!_device.Connect())
                    UIMessageBox.Show("传感器连接失败，请检查是否被占用");
            }
            else
            {
                _device.DisConnect();
            }
        }

        public void UpdateStatus(bool isConnected)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { UpdateStatus(isConnected); }));
            }
            else
            {
                if (Btn_Connect.Selected == isConnected)
                    return;
                if (isConnected)
                {
                    Btn_Connect.Selected = true;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox)
                            control.Enabled = false;
                    }
                }
                else
                {
                    Btn_Connect.Selected = false;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox)
                            control.Enabled = true;
                    }
                }
            }
        }

        private void CB_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            _device.IsEnable = CB_Enabled.Checked;
        }

        private void Btn_Select_Config_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "控制器配置文件|*.dcfg";
            fileDlg.Title = "请选择匹配的控制器配置文件";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                _device.ConfigPath = fileDlg.FileName;
                TB_Config_File.Text = fileDlg.FileName;
            }
        }

        private void Btn_Select_Calib_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "控制器位移校准文件|*.hwc";
            fileDlg.Title = "请选择匹配的控制器位移校准文件";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                _device.CalibPath = fileDlg.FileName;
                TB_Calib_File.Text = fileDlg.FileName;
            }
        }

        private void Btn_Read_Once_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _device.mChnCount; i++)
            {
                double[] heightList = _device.ReadData();
                ((UILabel)Controls.Find($"Lbl_Chn{i + 1}", true)[0]).Text = heightList[i].ToString();
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                UpdateValue();
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            UITextBox tb = sender as UITextBox;
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
                _device.ReadCount = Convert.ToInt32(TB_Read_Count.Text);
                _device.TimeOut = Convert.ToInt32(TB_Time_Out.Text);
            }
            catch
            {
                UIMessageBox.Show("参数格式填写错误，请检查！");
                return;
            }
        }
    }
}
