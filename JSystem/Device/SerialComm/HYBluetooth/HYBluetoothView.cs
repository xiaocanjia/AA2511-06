using System;

namespace JSystem.Device
{
    public partial class HYBluetoothView : SerialCommView
    {
        public HYBluetoothView(HYBluetooth device)
        {
            InitializeComponent();
            _device = device;
        }

        private void Btn_ConnectBT_Click(object sender, EventArgs e)
        {
            ((HYBluetooth)_device).ConnectBT("", TB_Mac.Text);
        }

        private void Btn_DisConnectBT_Click(object sender, EventArgs e)
        {
            ((HYBluetooth)_device).DisConnectBT("");
        }
    }
}
