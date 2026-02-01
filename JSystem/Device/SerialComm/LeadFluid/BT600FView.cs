using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class BT600FView : SerialCommView
    {
        public BT600FView(BT600F device)
        {
            InitializeComponent();
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
            TB_Speed.Text = ((BT600F)_device).Speed.ToString();
            TB_Mill.Text = ((BT600F)_device).Mill.ToString();
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
                ((BT600F)_device).Speed = Convert.ToSingle(TB_Speed.Text);
                ((BT600F)_device).Mill = Convert.ToSingle(TB_Mill.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }

        private void Btn_Run_Click(object sender, EventArgs e)
        {
            ((BT600F)_device).Inject(Convert.ToByte(TB_Adress.Text), true);
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            ((BT600F)_device).Inject(Convert.ToByte(TB_Adress.Text),false);

        }
    }
}
