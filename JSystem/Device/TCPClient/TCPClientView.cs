using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;

namespace JSystem.Device
{
    public partial class TCPClientView : UserControl
    {
        protected TCPClient _device;

        public TCPClientView()
        {
            InitializeComponent();
        }

        public TCPClientView(TCPClient device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
            device.OnDispMsg = DispMsg;
        }

        public override void Refresh()
        {
            base.Refresh();
            TB_IP.Text = _device.IP;
            TB_Port.Text = _device.Port.ToString();
            Btn_Connect.Selected = _device.CheckConnection();
            CB_Enabled.Checked = _device.IsEnable;
            CB_Enabled.CheckedChanged += new EventHandler(CB_Enabled_CheckedChanged);
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                if (!_device.Connect())
                    UIMessageBox.Show("连接失败，可能被占用或者IP端口填写错误");
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
                    TB_IP.Enabled = false;
                    TB_Port.Enabled = false;
                    CB_Enabled.Enabled = false;
                }
                else
                {
                    Btn_Connect.Selected = false;
                    TB_IP.Enabled = true;
                    TB_Port.Enabled = true;
                    CB_Enabled.Enabled = true;
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
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
                _device.IP = TB_IP.Text;
                _device.Port = Convert.ToInt32(TB_Port.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }

        private void CB_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            _device.IsEnable = CB_Enabled.Checked;
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (CB_Is_Hex.Checked)
                {
                    string[] cmd = TB_Send.Text.Split(' ');
                    List<byte> dataBytes = new List<byte>();
                    foreach (string c in cmd)
                        dataBytes.Add(Convert.ToByte("0x" + c, 16));
                    _device.WriteData(dataBytes.ToArray());
                }
                else
                {
                    _device.WriteData(Encoding.Default.GetBytes(TB_Send.Text));
                }
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }

        private void DispMsg(string type, byte[] buffer)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { DispMsg(type, buffer); }));
            }
            else
            {
                try
                {
                    string msg = "";
                    if (CB_Is_Hex.Checked)
                    {
                        foreach (byte b in buffer)
                            msg += b.ToString("X2") + " ";
                    }
                    else
                    {
                        msg = Encoding.Default.GetString(buffer);
                    }
                    DispMsg(type + "->" + msg);
                }
                catch
                {
                    MessageBox.Show("输入字符串格式不正确！");
                }
            }
        }

        private void DispMsg(string msg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { DispMsg(msg); }));
            }
            else
            {
                if (!CB_Disp_Sync.Checked)
                    return;
                TB_Log.AppendText(DateTime.Now.ToString("HH:mm:ss:fff") + "   " + msg + "\r\n");
            }
        }
    }
}
