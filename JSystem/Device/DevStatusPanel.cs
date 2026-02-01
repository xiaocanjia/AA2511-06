using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class DevStatusPanel : UserControl
    {
        private DeviceBase _device;

        public DevStatusPanel(DeviceBase device)
        {
            _device = device;
            InitializeComponent();
            device.OnUpdateStatus += UpdateStatus;
        }

        public void UpdateStatus(bool isConnected)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { UpdateStatus(isConnected); }));
            }
            else
            {
                Lbl_Name.Text =_device.Name;
                if (!_device.IsEnable)
                {
                    Lbl_Status.Text = "未启用";
                    Lbl_Status.ForeColor = Color.Orange;
                    return;
                }
                if (isConnected)
                {
                    Lbl_Status.Text ="已连接";
                    Lbl_Status.ForeColor = Color.Green;
                }
                else
                {
                    Lbl_Status.Text = "未连接";
                    Lbl_Status.ForeColor = Color.Red;
                }
            }
        }

        private void Lbl_Status_Click(object sender, EventArgs e)
        {
            if (!_device.Name.Contains("Mes系统"))
                return;
            if (Lbl_Status.Text == "已连接")
            {
                _device.IsEnable = false;
                _device.DisConnect();
            }
            else
            {
                _device.IsEnable = true;
                _device.Connect();
            }
            ((MesSysView)_device.View).CB_Enable.Checked = _device.IsEnable;
        }
    }
}
