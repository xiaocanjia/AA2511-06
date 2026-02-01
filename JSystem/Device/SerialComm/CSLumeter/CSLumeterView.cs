using System;

namespace JSystem.Device
{
    public partial class CSLumeterView : SerialCommView
    {
        public CSLumeterView(CSLumeter device)
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
                CSLumeter device = (CSLumeter)_device;
                Lbl_Lux1.Text = device.LuxList[0].ToString();
                Lbl_Lux2.Text = device.LuxList[1].ToString();
                Lbl_Lux3.Text = device.LuxList[2].ToString();
                Lbl_Lux4.Text = device.LuxList[3].ToString();
                Lbl_Lux5.Text = device.LuxList[4].ToString();
                Lbl_Lux6.Text = device.LuxList[5].ToString();
            }
        }
    }
}
