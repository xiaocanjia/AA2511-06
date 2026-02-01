using System;
using Sunny.UI;
using FileHelper;

namespace JSystem.User
{
    public partial class ModifyPasswordForm : UIForm
    {
        private string _user;

        public ModifyPasswordForm(string user)
        {
            InitializeComponent();
            _user = user;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "user.ini";
            string password = IniHelper.INIGetStringValue(filePath, _user, "Password", "");
            if (TB_Password.Text != "" && TB_Password.Text == password)
            {
                if (TB_NewPassword.Text == TB_NewPassword_Confirm.Text)
                {
                    IniHelper.INIWriteValue(filePath, _user, "Password", TB_NewPassword.Text);
                    UIMessageBox.Show("密码修改成功");
                    Close();
                }
                else
                {
                    UIMessageBox.Show("两次输入的密码不一致");
                }
            }
            else
            {
                UIMessageBox.Show("原密码输入错误");
            }
        }
    }
}
