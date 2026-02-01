using System;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class TPSocketView : SerialCommView
    {
        public TPSocketView(TPSocket device)
        {
            InitializeComponent();
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
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
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }

        private void CbB_IsHex_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
