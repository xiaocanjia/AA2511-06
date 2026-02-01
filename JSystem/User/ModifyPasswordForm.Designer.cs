namespace JSystem.User
{
    partial class ModifyPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Password = new Sunny.UI.UITextBox();
            this.Lbl_Password = new Sunny.UI.UILabel();
            this.TB_NewPassword = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TB_NewPassword_Confirm = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Btn_Confirm = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // TB_Password
            // 
            this.TB_Password.ButtonSymbol = 61761;
            this.TB_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Password.ForeColor = System.Drawing.Color.Black;
            this.TB_Password.Location = new System.Drawing.Point(133, 58);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Password.Maximum = 2147483647D;
            this.TB_Password.Minimum = -2147483648D;
            this.TB_Password.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_Password.Size = new System.Drawing.Size(150, 29);
            this.TB_Password.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Password.TabIndex = 4;
            this.TB_Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Password.Location = new System.Drawing.Point(27, 61);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(99, 23);
            this.Lbl_Password.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "原密码";
            this.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_NewPassword
            // 
            this.TB_NewPassword.ButtonSymbol = 61761;
            this.TB_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_NewPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_NewPassword.ForeColor = System.Drawing.Color.Black;
            this.TB_NewPassword.Location = new System.Drawing.Point(133, 97);
            this.TB_NewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NewPassword.Maximum = 2147483647D;
            this.TB_NewPassword.Minimum = -2147483648D;
            this.TB_NewPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_NewPassword.Name = "TB_NewPassword";
            this.TB_NewPassword.PasswordChar = '*';
            this.TB_NewPassword.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_NewPassword.Size = new System.Drawing.Size(150, 29);
            this.TB_NewPassword.Style = Sunny.UI.UIStyle.Custom;
            this.TB_NewPassword.TabIndex = 6;
            this.TB_NewPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(27, 100);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(99, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "新密码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_NewPassword_Confirm
            // 
            this.TB_NewPassword_Confirm.ButtonSymbol = 61761;
            this.TB_NewPassword_Confirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_NewPassword_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_NewPassword_Confirm.ForeColor = System.Drawing.Color.Black;
            this.TB_NewPassword_Confirm.Location = new System.Drawing.Point(133, 136);
            this.TB_NewPassword_Confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NewPassword_Confirm.Maximum = 2147483647D;
            this.TB_NewPassword_Confirm.Minimum = -2147483648D;
            this.TB_NewPassword_Confirm.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_NewPassword_Confirm.Name = "TB_NewPassword_Confirm";
            this.TB_NewPassword_Confirm.PasswordChar = '*';
            this.TB_NewPassword_Confirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_NewPassword_Confirm.Size = new System.Drawing.Size(150, 29);
            this.TB_NewPassword_Confirm.Style = Sunny.UI.UIStyle.Custom;
            this.TB_NewPassword_Confirm.TabIndex = 6;
            this.TB_NewPassword_Confirm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(27, 139);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(99, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "新密码确认";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Confirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Confirm.ForeDisableColor = System.Drawing.Color.DimGray;
            this.Btn_Confirm.Location = new System.Drawing.Point(133, 185);
            this.Btn_Confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.Size = new System.Drawing.Size(100, 35);
            this.Btn_Confirm.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Confirm.StyleCustomMode = true;
            this.Btn_Confirm.TabIndex = 7;
            this.Btn_Confirm.Text = "确认";
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // ModifyPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 232);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.TB_NewPassword_Confirm);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.TB_NewPassword);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Name = "ModifyPasswordForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "修改密码";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox TB_Password;
        private Sunny.UI.UILabel Lbl_Password;
        private Sunny.UI.UITextBox TB_NewPassword;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TB_NewPassword_Confirm;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton Btn_Confirm;
    }
}