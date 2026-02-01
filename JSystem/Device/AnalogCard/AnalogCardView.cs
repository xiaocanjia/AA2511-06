using System;
using System.Windows.Forms;
using Sunny.UI;
using BoardSDK;

namespace JSystem.Device
{
    public partial class AnalogCardView : UserControl
    {
        private AnalogCard _device;

        public AnalogCardView()
        {
            InitializeComponent();
        }

        public AnalogCardView(AnalogCard device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
            Btn_Connect.Selected = _device.CheckConnection();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                if (!_device.Connect())
                    UIMessageBox.Show("板卡连接失败，请检查是否被占用");
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
    }
}
