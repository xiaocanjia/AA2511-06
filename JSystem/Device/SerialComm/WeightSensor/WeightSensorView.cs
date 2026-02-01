using System;

namespace JSystem.Device
{
    public partial class WeightSensorView : SerialCommView
    {
        public WeightSensorView(WeightSensor device)
        {
            InitializeComponent();
            _device = device;
            device.OnUpdateDisp = UpdateWeight;
        }

        public void UpdateWeight()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => { UpdateWeight(); }));
            }
            else
            {
                WeightSensor device = (WeightSensor)_device;
                Lbl_Weight1.Text = device.WeightList[0].ToString();
                Lbl_Weight2.Text = device.WeightList[1].ToString();
            }
        }
    }
}
