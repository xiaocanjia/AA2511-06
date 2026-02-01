    using System;
using System.Windows.Forms;
using Sunny.UI;
using Camera3DSDK;

namespace JSystem.Device
{
    public partial class Cam3DView : UserControl
    {
        private Camera3D _device;

        public Cam3DView()
        {
            InitializeComponent();
        }

        public Cam3DView(Camera3D device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
            CbB_Cam_Name.Items.Clear();
            foreach (ECamera3DType type in Enum.GetValues(typeof(ECamera3DType)))
                CbB_Cam_Name.Items.Add(type.ToString());
            CbB_Cam_Name.SelectedIndex = _device.CamType;
            TB_IP.Text = _device.IP;
            TB_Port.Text = _device.Port;
            TB_Trigger_Interval.Text = _device.TriggerInterval.ToString();
            TB_Valiad_Width.Text = _device.ValidWidth.ToString();
            CB_Enable.Checked = _device.IsEnable;
            TB_Config_Path.Text = _device.CfgName;
            Btn_Connect.Selected = _device.CheckConnection();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                if (!_device.Connect())
                    UIMessageBox.Show("相机连接失败，可能被占用或者相机信息填写错误");
            }
            else
            {
                _device.DisConnect();
            }
        }

        private void CbB_Cam_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            _device.CamType = CbB_Cam_Name.SelectedIndex;
        }

        private void Btn_Export_Config_Click(object sender, EventArgs e)
        {
            if (_device.CheckConnection() == false)
            {
                UIMessageTip.ShowWarning("请先连接相机");
                return;
            }
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "配置文件|*.cfg";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                _device.SaveJob(dialog.FileName);
            }
        }

        private void TB_Config_Path_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "配置文件|*.cfg";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                TB_Config_Path.Text = dialog.FileName;
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
                        if (control is UIComboBox || control is UITextBox)
                            control.Enabled = false;
                    }
                }
                else
                {
                    Btn_Connect.Selected = false;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox || control is UITextBox)
                            control.Enabled = true;
                    }
                }
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
                _device.IP = TB_IP.Text;
                _device.Port = TB_Port.Text;
                _device.ValidWidth = Convert.ToSingle(TB_Valiad_Width.Text);
                _device.TriggerInterval = Convert.ToSingle(TB_Trigger_Interval.Text);
            }
            catch
            {
                UIMessageBox.Show("参数格式填写错误，请检查！");
                return;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TB_Config_Path.Text = dialog.FileName;
                    _device.CfgName = TB_Config_Path.Text;
                }
            }
        }

        private void CB_Enable_CheckedChanged(object sender, EventArgs e)
        {
            _device.IsEnable = CB_Enable.Checked;
        }



    }
}
