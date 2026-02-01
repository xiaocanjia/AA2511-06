using System;
namespace JSystem.Device
{
    public partial class LightControllerView : SerialCommView
    {
        public LightControllerView(LightController device)
        {
            InitializeComponent();
            _device = device;
        }

        private void Btn_Set_Lightness_Click(object sender, EventArgs e)
        {
            ((LightController)_device).SetLightness(Convert.ToInt32(TB_Channel.Text), Convert.ToInt32(TB_Lightness.Text));
        }
    }
}
