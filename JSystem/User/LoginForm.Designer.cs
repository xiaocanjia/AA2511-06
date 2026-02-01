namespace JSystem.User
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.Lbl_Password = new Sunny.UI.UILabel();
            this.TB_Password = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.CbB_Operator = new Sunny.UI.UIComboBox();
            this.Btn_Confirm = new Sunny.UI.UIButton();
            this.Lbl_Modify_Password = new Sunny.UI.UILinkLabel();
            this.Timer_Monitor = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Location = new System.Drawing.Point(151, 52);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(82, 89);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Password.Location = new System.Drawing.Point(52, 208);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(66, 23);
            this.Lbl_Password.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Password.TabIndex = 1;
            this.Lbl_Password.Text = "密码";
            this.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Password.Visible = false;
            // 
            // TB_Password
            // 
            this.TB_Password.ButtonSymbol = 61761;
            this.TB_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Password.Location = new System.Drawing.Point(134, 205);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Password.Maximum = 2147483647D;
            this.TB_Password.Minimum = -2147483648D;
            this.TB_Password.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(150, 29);
            this.TB_Password.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Password.TabIndex = 2;
            this.TB_Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Password.Visible = false;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(52, 155);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(66, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "用户";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Operator
            // 
            this.CbB_Operator.DataSource = null;
            this.CbB_Operator.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Operator.FillColor = System.Drawing.Color.White;
            this.CbB_Operator.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbB_Operator.Items.AddRange(new object[] {
            "操作员",
            "工程师",
            "管理员"});
            this.CbB_Operator.Location = new System.Drawing.Point(134, 152);
            this.CbB_Operator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Operator.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Operator.Name = "CbB_Operator";
            this.CbB_Operator.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CbB_Operator.Size = new System.Drawing.Size(150, 29);
            this.CbB_Operator.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Operator.TabIndex = 4;
            this.CbB_Operator.Text = "操作员";
            this.CbB_Operator.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CbB_Operator.SelectedIndexChanged += new System.EventHandler(this.CbB_Operator_SelectedIndexChanged);
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
            this.Btn_Confirm.Location = new System.Drawing.Point(145, 268);
            this.Btn_Confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.RectColor = System.Drawing.Color.Black;
            this.Btn_Confirm.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Confirm.Size = new System.Drawing.Size(100, 35);
            this.Btn_Confirm.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Confirm.StyleCustomMode = true;
            this.Btn_Confirm.TabIndex = 5;
            this.Btn_Confirm.Text = "登录";
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Lbl_Modify_Password
            // 
            this.Lbl_Modify_Password.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Lbl_Modify_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Modify_Password.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.Lbl_Modify_Password.LinkColor = System.Drawing.Color.Black;
            this.Lbl_Modify_Password.Location = new System.Drawing.Point(291, 211);
            this.Lbl_Modify_Password.Name = "Lbl_Modify_Password";
            this.Lbl_Modify_Password.Size = new System.Drawing.Size(84, 20);
            this.Lbl_Modify_Password.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Modify_Password.StyleCustomMode = true;
            this.Lbl_Modify_Password.TabIndex = 9;
            this.Lbl_Modify_Password.TabStop = true;
            this.Lbl_Modify_Password.Text = "修改密码";
            this.Lbl_Modify_Password.Visible = false;
            this.Lbl_Modify_Password.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Lbl_Modify_Password.Click += new System.EventHandler(this.Lbl_Modify_Password_Click);
            // 
            // Timer_Monitor
            // 
            this.Timer_Monitor.Interval = 1000;
            this.Timer_Monitor.Tick += new System.EventHandler(this.Timer_Monitor_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Confirm;
            this.ClientSize = new System.Drawing.Size(383, 331);
            this.Controls.Add(this.Lbl_Modify_Password);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.CbB_Operator);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.uiAvatar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "登录";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel Lbl_Password;
        private Sunny.UI.UITextBox TB_Password;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Operator;
        private Sunny.UI.UIButton Btn_Confirm;
        private Sunny.UI.UILinkLabel Lbl_Modify_Password;
        private System.Windows.Forms.Timer Timer_Monitor;
    }
}