using System;

namespace JSystem.Device
{
    public partial class DirectPressSensorView : TCPClientView
    {
        public DirectPressSensorView(DirectPressSensor device)
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
            DirectPressSensor device = (DirectPressSensor)_device;
            double[] pressArr = device.ReadPressure();
            if (pressArr == null)
            {
                Btn_Read.Selected = false;
                MonitorTimer.Enabled = false;
                return;
            }
            Lbl_Height1.Text = pressArr[0].ToString("F3");
            Lbl_Height2.Text = pressArr[1].ToString("F3");
            Lbl_Height3.Text = pressArr[2].ToString("F3");
            Lbl_Height4.Text = pressArr[3].ToString("F3");
            Lbl_Height5.Text = pressArr[4].ToString("F3");
            Lbl_Height6.Text = pressArr[5].ToString("F3");
            if (!Visible)
                Btn_Read.Selected = false;
            MonitorTimer.Enabled = Btn_Read.Selected;
        }
    }
}
