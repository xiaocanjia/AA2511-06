using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using Sunny.UI;
using NationalInstruments.Visa;

namespace JSystem.Device
{
    public partial class ProgramPowerView : UserControl
    {
        private ProgramPower _device;

        public ProgramPowerView()
        {
            InitializeComponent();
        }

        public ProgramPowerView(ProgramPower device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
            CbB_Port_Name.Items.Clear();
            try
            {
                ResourceManager manager = new ResourceManager();
                CbB_Port_Name.Items.AddRange(manager.Find("GPIB?*").ToArray());
            }
            catch { }
            CbB_Port_Name.SelectedItem = _device.PortName;
            Btn_Connect.Selected = _device.CheckConnection();
            CB_Enabled.Checked = _device.IsEnable;
            CB_Enabled.CheckedChanged += new EventHandler(CB_Enabled_CheckedChanged);
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                _device.PortName = CbB_Port_Name.SelectedText;
                if (!_device.Connect())
                    UIMessageBox.Show("程控电源连接失败，可能被占用或者没有该串口");
            }
            else
            {
                _device.DisConnect();
            }
        }

        public void UpdateStatus(bool isConnected)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { UpdateStatus(isConnected); }));
            }
            else
            {
                if (Btn_Connect.Selected == isConnected)
                    return;
                if (isConnected)
                {
                    Btn_Connect.Selected = true;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox || control is UICheckBox)
                            control.Enabled = false;
                    }
                }
                else
                {
                    Btn_Connect.Selected = false;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox || control is UICheckBox)
                            control.Enabled = true;
                    }
                }
            }
        }

        private void Btn_Set_Volt_Click(object sender, EventArgs e)
        {
            _device.SetVolt(Convert.ToInt32(TB_Channel.Text), Convert.ToDouble(TB_Voltage.Text));
            _device.SetCurr(Convert.ToInt32(TB_Channel.Text), Convert.ToDouble(TB_Curr.Text));
            Thread.Sleep(500);
            Lbl_Curr.Text = _device.GetCurr(Convert.ToInt32(TB_Channel.Text), 100, 5).ToString();
        }

        private void CbB_Port_Name_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                ResourceManager manager = new ResourceManager();
                string[] array = manager.Find("GPIB?*").ToArray();
                if (array.Length == CbB_Port_Name.Items.Count)
                    return;
                CbB_Port_Name.Items.Clear();
                CbB_Port_Name.Items.AddRange(array);
            }
            catch { }
        }

        private void CB_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            _device.IsEnable = CB_Enabled.Checked;
        }
    }
}
