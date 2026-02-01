using System;

namespace JSystem.Device
{
    public partial class RollPressSensorView : TCPClientView
    {
        public RollPressSensorView(RollPressSensor device)
        {
            InitializeComponent();
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            if (!_device.CheckConnection())
                return;
            if (!Btn_Read.Selected)
            {
                Btn_Read.Selected = true;
                MonitorTimer.Enabled = true;
            }
            else
            {
                Btn_Read.Selected = false;
                MonitorTimer.Enabled = false;
            }
        }

        private void MonitorTimer_Tick(object sender, EventArgs e)
        {
            MonitorTimer.Enabled = false;
            RollPressSensor device = (RollPressSensor)_device;
            double press = device.ReadPressure();
            if (double.IsNaN(press))
            {
                Btn_Read.Selected = false;
                MonitorTimer.Enabled = false;
                return;
            }
            Lb_Pressure.Text = press.ToString("F3");
            if (!Visible)
                Btn_Read.Selected = false;
            MonitorTimer.Enabled = Btn_Read.Selected;
        }
    }
}
