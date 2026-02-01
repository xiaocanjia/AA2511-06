using Sunny.UI;
using System;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class WaterTankView : SerialCommView
    {
        public WaterTankView(WaterTank device)
        {
            InitializeComponent();
            _device = device;
            TB_Temp.Text = device.TargetTemp.ToString();
        }

        private void Btn_Set_Temp_Click(object sender, EventArgs e)
        {
            WaterTank device = (WaterTank)_device;
            ((WaterTank)_device).SwitchTank(true);
            device.SetTemp(device.TargetTemp);
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
                ((WaterTank)_device).TargetTemp = Convert.ToDouble(TB_Temp.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }

        public void UpdateStatus()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { UpdateStatus(); }));
            }
            else
            {
                WaterTank device = (WaterTank)_device;
                Lbl_Temp1.Text = device.CurrTemp[0].ToString();
                Lbl_Temp2.Text = device.CurrTemp[1].ToString();
                Lbl_Temp3.Text = device.CurrTemp[2].ToString();
                Lbl_Temp4.Text = device.CurrTemp[3].ToString();
                Lbl_Temp5.Text = device.CurrTemp[4].ToString();
                Light_Low.State = device.CurrStage[0] ? UILightState.On : UILightState.Off;
                Light_Middle.State = device.CurrStage[1] ? UILightState.On : UILightState.Off;
                Light_High.State = device.CurrStage[2] ? UILightState.On : UILightState.Off;
            }
        }
    }
}
