using System;
using Sunny.UI;
using System.Windows.Forms;
using FileHelper;
using JSystem.Perform;

namespace JSystem.User
{
    public partial class LoginForm : UIForm, IMessageFilter
    {
        public bool IsLogin = false;

        private static int Counter = 0;

        private int _timeOut = 0;

        public static string User { get; private set; }

        public Action OnChangeUserRight;

        public LoginForm()
        {
            InitializeComponent();
            FormClosed += LoginForm_FormClosed;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            User = IsLogin ? CbB_Operator.Text : "操作员";
            OnChangeUserRight?.Invoke();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Display()
        {
            IsLogin = false;
            CbB_Operator.SelectedItem = "操作员";
            TB_Password.Text = "";
            ShowDialog();
        }

        private void Login()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "user.ini";
            _timeOut = Convert.ToInt32(IniHelper.INIGetStringValue(filePath, "超时", "TimeOut", ""));
            if (CbB_Operator.Text == "操作员")
            {
                IsLogin = true;
                Timer_Monitor.Enabled = false;
                Close();
            }
            else if (CbB_Operator.Text == "工程师" && TB_Password.Text == IniHelper.INIGetStringValue(filePath, "工程师", "Password", ""))
            {
                IsLogin = true;
                Timer_Monitor.Enabled = true;
                Close();
            }
            else if (CbB_Operator.Text == "管理员" && TB_Password.Text == IniHelper.INIGetStringValue(filePath, "管理员", "Password", ""))
            {
                IsLogin = true;
                Timer_Monitor.Enabled = true;
                Close();
            }
            else
            {
                IsLogin = false;
                UIMessageTip.ShowError("密码错误");
            }
            LogManager.Instance.AddLog("主流程", $"切换登录权限为{CbB_Operator.Text}", JLogging.LogLevels.Debug);
        }

        private void CbB_Operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbB_Operator.Text == "操作员")
            {
                Lbl_Password.Visible = false;
                TB_Password.Visible = false;
                Lbl_Modify_Password.Visible = false;
            }
            else
            {
                Lbl_Password.Visible = true;
                TB_Password.Visible = true;
                Lbl_Modify_Password.Visible = true;
                TB_Password.Focus();
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Login();
            }
        }

        private void Lbl_Modify_Password_Click(object sender, EventArgs e)
        {
            ModifyPasswordForm form = new ModifyPasswordForm(CbB_Operator.Text);
            form.ShowDialog();
        }

        public bool PreFilterMessage(ref Message msg)
        {
            if (msg.Msg == 0x0200 || msg.Msg == 0x0201 || msg.Msg == 0x0204 || msg.Msg == 0x0207)
                Counter = 0;
            return false;
        }

        private void Timer_Monitor_Tick(object sender, EventArgs e)
        {
            Counter++;
            if (Counter > _timeOut)
            {
                if (User != "操作员")
                {
                    User = "操作员";
                    OnChangeUserRight?.Invoke();
                    Timer_Monitor.Enabled = false;
                }
                Counter = 0;
            }
        }
    }
}
