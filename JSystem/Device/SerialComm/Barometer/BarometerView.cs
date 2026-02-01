using System;

namespace JSystem.Device
{
    public partial class BarometerView : SerialCommView
    {
        public BarometerView(Barometer device)
        {
            InitializeComponent();
            _device = device;
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            Lbl_HRs_Value.Text = "";
            Lbl_HRs_Value.Text = ((Barometer)_device).ReadPressure().ToString();
        }

        private void Btn_Write_Click(object sender, EventArgs e)
        {
            ((Barometer)_device).SetPressure(Convert.ToUInt16(TB_Write_HRs_Data.Text));
        }
    }
}
