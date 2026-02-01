using System;
using System.Windows.Forms;
using IOTSDK;
using Sunny.UI;

namespace JSystem.Device
{
    public partial class IOTSysView : UserControl
    {
        protected IOTSys _device;

        public IOTSysView(IOTSys device)
        {
            InitializeComponent();
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
            CbB_Cmd.SelectedIndex = 0;
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
                    CbB_Type.Enabled = false;
                    foreach (Control control in Controls)
                    {
                        if (control is UITextBox || control is UICheckBox)
                            control.Enabled = false;
                    }
                }
                else
                {
                    Btn_Connect.Selected = false;
                    CbB_Type.Enabled = true;
                    foreach (Control control in Controls)
                    {
                        if (control is UITextBox || control is UICheckBox)
                            control.Enabled = true;
                    }
                }
            }
        }
        
        public override void Refresh()
        {
            base.Refresh();
            CbB_Type.Items.Clear();
            foreach (EIOTType type in Enum.GetValues(typeof(EIOTType)))
                CbB_Type.Items.Add(type.ToString());
            CbB_Type.SelectedIndex = _device.Type;
            TB_URL.Text = _device.Param.URI;
            TB_Device.Text = _device.Param.DeviceName;
            TB_OperatorName.Text = _device.Param.User;
            TB_SoftName.Text = _device.Param.SoftName;
            TB_SoftVer.Text = _device.Param.SoftVer;
            TB_TokenData.Text = _device.Param.Token;
            TB_Business.Text = _device.Param.Business;
            TB_Department.Text = _device.Param.Department;
            TB_Station.Text = _device.Param.Station;
            TB_SeparateLine.Text = _device.Param.Line;
            TB_Interval.Text = _device.Param.HeartBeatInterval.ToString();
            TB_LogName.Text = _device.Param.LogName;
            TB_LogPath.Text = _device.Param.LogPath;
            TB_IP.Text = _device.Param.IP;
            TB_Port.Text = _device.Param.Port.ToString();
            Btn_Connect.Selected = _device.CheckConnection();
            CB_Enabled.Checked = _device.IsEnable;
            CB_Enabled.CheckedChanged += new EventHandler(CB_Enabled_CheckedChanged);
        }

        private void CbB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            _device.Type = CbB_Type.SelectedIndex;
        }

        private void CB_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            _device.IsEnable = CB_Enabled.Checked;
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
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
                _device.Param.URI = TB_URL.Text;
                _device.Param.DeviceName = TB_Device.Text;
                _device.Param.User = TB_OperatorName.Text;
                _device.Param.SoftName = TB_SoftName.Text;
                _device.Param.SoftVer = TB_SoftVer.Text;
                _device.Param.Token = TB_TokenData.Text;
                _device.Param.Business = TB_Business.Text;
                _device.Param.Department = TB_Department.Text;
                _device.Param.Station = TB_Station.Text;
                _device.Param.Line = TB_SeparateLine.Text;
                _device.Param.HeartBeatInterval = Convert.ToInt32(TB_Interval.Text);
                _device.Param.LogName = TB_LogName.Text;
                _device.Param.LogPath = TB_LogPath.Text;
                _device.Param.IP = TB_IP.Text;
                _device.Param.Port = Convert.ToInt32(TB_Port.Text);
            }
            catch
            {
                MessageBox.Show("参数格式填写错误，请检查！");
            }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                if (!_device.Connect())
                {
                    UIMessageBox.Show("连接失败，可能被占用或者IP端口填写错误");
                    return;
                }
                else
                {
                    Btn_Connect.Selected = true;
                    CbB_Type.Enabled = false;
                    foreach (Control control in Controls)
                    {
                        if (control is UITextBox || control is UICheckBox)
                            control.Enabled = false;
                    }
                }
            }
            else
            {
                _device.DisConnect();
                Btn_Connect.Selected = false;
                CbB_Type.Enabled = true;
                foreach (Control control in Controls)
                {
                    if (control is UITextBox || control is UICheckBox)
                        control.Enabled = true;
                }
            }
        }

        private void Btn_SendCmd_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (CbB_Cmd.Text == "")
                return;
            else if (CbB_Cmd.Text == "上传报警")
                _device.UploadAlarm("Warning", "Parameter control warning", "HY001", "报警测试", out msg);
            else if (CbB_Cmd.Text == "消除报警")
                _device.ClearAlarm(out msg);
            else if (CbB_Cmd.Text == "上传产品状态")
                _device.UploadProductState("1", "SUBLOT_LOADED", out msg);
            else if (CbB_Cmd.Text == "上传设备状态")
                _device.UploadDeviceState("PM:MAINTENANCE", out msg);
            else if (CbB_Cmd.Text == "上传数据")
                _device.UploadResults("1", 1, null, out msg);
            TB_Msg.Text = msg;
        }
    }
}