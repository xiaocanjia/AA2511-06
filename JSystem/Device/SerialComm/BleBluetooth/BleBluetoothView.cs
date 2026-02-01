using System;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class BleBluetoothView : SerialCommView
    {
        public BleBluetoothView(BleBluetooth device) 
        {
            InitializeComponent();
            _device = device;
        }

        public override void Refresh()
        {
            base.Refresh();
            TB_Guid_Tx.Text = ((BleBluetooth)_device).GuidTx;
            TB_Guid_Rx.Text = ((BleBluetooth)_device).GuidRx;
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
                ((BleBluetooth)_device).GuidTx = TB_Guid_Tx.Text;
                ((BleBluetooth)_device).GuidRx = TB_Guid_Rx.Text;
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }
    }
}
