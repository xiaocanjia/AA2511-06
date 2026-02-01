using System;

namespace JSystem.Device
{
    public partial class TempControllerView : SerialCommView
    {
        public TempControllerView(TempController device)
        {
            InitializeComponent();
            _device = device;
        }

        public override void Refresh()
        {
            base.Refresh();
            TB_Low.Text = ((TempController)_device).Low.ToString();
            TB_High.Text = ((TempController)_device).High.ToString();
            TB_Temp.Text= ((TempController)_device).Temp.ToString();
        }
        
        public void UpdateTemp()
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => { UpdateTemp(); }));
                }
                else
                {
                    TempController device = (TempController)_device;
                    device.Low = Convert.ToInt32(TB_Low.Text);
                    device.High = Convert.ToInt32(TB_High.Text);
                    device.Temp = Convert.ToInt32(TB_Temp.Text);
                    Lbl_CurrTemp.Text = device.CurrTemp.ToString();
                }

            }
            catch (Exception)
            {
               return;
            }
            
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            TempController device = (TempController)_device;
            device.Low = Convert.ToInt32(TB_Low.Text);
            device.High = Convert.ToInt32(TB_High.Text);
            device.Temp = Convert.ToInt32(TB_Temp.Text);
            device.SetTemp();
            device.Run(true);
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            TempController device = (TempController)_device;
            device.Run(false);
        }
    }
}
