using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Sunny.UI;
using MesSDK;

namespace JSystem.Device
{
    public partial class MesSysView : UserControl
    {
        private MesSys _device;

        public MesSysView()
        {
            InitializeComponent();
        }

        public MesSysView(MesSys device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
            CbB_Mes_Type.Items.Clear();
            foreach (EMesType type in Enum.GetValues(typeof(EMesType)))
                CbB_Mes_Type.Items.Add(type.ToString());
            CbB_Mes_Type.SelectedIndex = _device.Type;
            TB_IP.Text = _device.Param.IP;
            TB_Port.Text = _device.Param.Port.ToString();
            TB_Station.Text = _device.Param.StationID;
            TB_Lot.Text = _device.Param.Lot;
            TB_Device.Text = _device.Param.DeviceID;
            TB_Staff.Text = _device.Param.StaffID;
            TB_Line.Text = _device.Param.LineID;
            TB_Product.Text = _device.Param.ProductID;
            TB_Version.Text = _device.Param.Version;
            CB_Enable.Checked = _device.IsEnable;
            Btn_Connect.Selected = _device.CheckConnection();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                if (!_device.Connect())
                {
                    UIMessageBox.Show("MES连接失败，请检查网线是否插好");
                }
            }
            else
            {
                _device.DisConnect();
            }
        }

        private void CbB_Cam_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            _device.Type = CbB_Mes_Type.SelectedIndex;
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
                        if (control is UIComboBox || control is UITextBox || control is UICheckBox)
                            control.Enabled = false;
                    }
                }
                else
                {
                    Btn_Connect.Selected = false;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox || control is UITextBox || control is UICheckBox)
                            control.Enabled = true;
                    }
                }
            }
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
            UITextBox tb = sender as UITextBox;
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
                _device.Param.IP = TB_IP.Text;
                _device.Param.Port = Convert.ToInt32(TB_Port.Text);
                _device.Param.StationID = TB_Station.Text;
                _device.Param.Lot = TB_Lot.Text;
                _device.Param.DeviceID = TB_Device.Text;
                _device.Param.StaffID = TB_Staff.Text;
                _device.Param.LineID = TB_Line.Text;
                _device.Param.ProductID = TB_Product.Text;
                _device.Param.Version = TB_Version.Text;
            }
            catch
            {
                UIMessageBox.Show("参数格式填写错误，请检查！");
                return;
            }
        }

        private void CB_Enable_CheckedChanged(object sender, EventArgs e)
        {
            _device.IsEnable = CB_Enable.Checked;
        }

        private void Btn_Arrival_Click(object sender, EventArgs e)
        {
            _device.Arrival(TB_SN.Text, out string msg);
            TB_Log.AppendText(msg + "\r\n");
        }

        private void Btn_Departure_Click(object sender, EventArgs e)
        {
            _device.Departure(TB_SN.Text, new List<MesResult>(), out string msg);
            TB_Log.AppendText(msg + "\r\n");
        }
    }
}