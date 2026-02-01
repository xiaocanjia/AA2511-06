using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Sunny.UI;
using System.Windows.Forms;

namespace JSystem.Project
{
    public partial class PasswordForm : UIForm
    {
        public bool IsRight = false;

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (TB_Password.Text == "CS123")
            {
                IsRight = true;
                Close();
            }
            else
            {
                IsRight = false;
                UIMessageTip.ShowError("密码错误");
            }
        }
    }
}
