using System;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class ConicaLumeterView : SerialCommView
    {
        public ConicaLumeterView(ConicaLumeter device)
        {
            InitializeComponent();
            _device = device;
            device.OnUpdateDisp = UpdateLumeter;
        }

        public void UpdateLumeter()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { UpdateLumeter(); }));
            }
            else
            {
                ConicaLumeter device = (ConicaLumeter)_device;
                Lbl_Lux.Text = device.CurrLux.ToString();
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            TB_Offset.Text = ((ConicaLumeter)_device).Offset.ToString();
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
                ((ConicaLumeter)_device).Offset = Convert.ToDouble(TB_Offset.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }
    }
}
