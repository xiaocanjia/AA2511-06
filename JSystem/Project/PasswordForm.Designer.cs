namespace JSystem.Project
{
    partial class PasswordForm
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
            this.Btn_Connect = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // TB_Password
            // 
            this.TB_Password.ButtonSymbol = 61761;
            this.TB_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Password.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Password.Location = new System.Drawing.Point(35, 48);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Password.Maximum = 2147483647D;
            this.TB_Password.Minimum = -2147483648D;
            this.TB_Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Password.Size = new System.Drawing.Size(205, 29);
            this.TB_Password.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Password.TabIndex = 219;
            this.TB_Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(84, 93);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(89, 30);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 220;
            this.Btn_Connect.Text = "确定";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 134);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.TB_Password);
            this.Name = "PasswordForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "输入密码";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox TB_Password;
        private Sunny.UI.UIButton Btn_Connect;
    }
}