using System;
using System.Windows.Forms;
using Sunny.UI;

namespace JSystem.Device
{
    public partial class CmdView : UserControl
    {
        private Cmd _device;

        private string _msgList = "";

        public CmdView()
        {
            InitializeComponent();
        }

        public CmdView(Cmd device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
            device.OnDispMsg = AddLog;
        }

        private void SetEnable(bool isEnable)
        {
            foreach (Control control in Controls)
            {
                if (control is UIComboBox || control is UIButton)
                    control.Enabled = isEnable;
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            Btn_Connect.Selected = _device.CheckConnection();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                if (!_device.Connect())
                    UIMessageBox.Show("命令窗口打开失败，请检查是否被占用");
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
                }
                else
                {
                    Btn_Connect.Selected = false;
                }
            }
        }

        public void AddLog(string msg)
        {
            if (!CB_Disp_Sync.Checked)
                return;
            _msgList += msg + "\r\n";
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            _device.WriteCommand(TB_Send.Text);
        }

        private void CB_Disp_Sync_CheckedChanged(object sender, EventArgs e)
        {
            Timer_Monitor.Enabled = CB_Disp_Sync.Checked;
        }

        private void Timer_Monitor_Tick(object sender, EventArgs e)
        {
            TB_Log.AppendText(_msgList);
            _msgList = "";
        }
    }
}
