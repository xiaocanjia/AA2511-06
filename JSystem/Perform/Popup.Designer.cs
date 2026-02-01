namespace JSystem.Perform
{
    partial class Popup
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
            this.Btn_Retry = new Sunny.UI.UIButton();
            this.Btn_Abort = new Sunny.UI.UIButton();
            this.Lb_Content = new Sunny.UI.UILabel();
            this.Btn_Confirm = new Sunny.UI.UIButton();
            this.Btn_Ignore = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // Btn_Retry
            // 
            this.Btn_Retry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(197)))), ((int)(((byte)(244)))));
            this.Btn_Retry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Retry.FillColor = System.Drawing.Color.White;
            this.Btn_Retry.FillHoverColor = System.Drawing.Color.BurlyWood;
            this.Btn_Retry.FillPressColor = System.Drawing.Color.BurlyWood;
            this.Btn_Retry.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Retry.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Retry.ForeColor = System.Drawing.Color.Black;
            this.Btn_Retry.Location = new System.Drawing.Point(296, 131);
            this.Btn_Retry.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Retry.Name = "Btn_Retry";
            this.Btn_Retry.RectColor = System.Drawing.Color.BurlyWood;
            this.Btn_Retry.Size = new System.Drawing.Size(100, 40);
            this.Btn_Retry.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Retry.StyleCustomMode = true;
            this.Btn_Retry.TabIndex = 178;
            this.Btn_Retry.Text = "重试";
            this.Btn_Retry.Click += new System.EventHandler(this.Btn_Retry_Click);
            // 
            // Btn_Abort
            // 
            this.Btn_Abort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(197)))), ((int)(((byte)(244)))));
            this.Btn_Abort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Abort.FillColor = System.Drawing.Color.White;
            this.Btn_Abort.FillHoverColor = System.Drawing.Color.BurlyWood;
            this.Btn_Abort.FillPressColor = System.Drawing.Color.BurlyWood;
            this.Btn_Abort.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Abort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Abort.ForeColor = System.Drawing.Color.Black;
            this.Btn_Abort.Location = new System.Drawing.Point(62, 131);
            this.Btn_Abort.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Abort.Name = "Btn_Abort";
            this.Btn_Abort.RectColor = System.Drawing.Color.BurlyWood;
            this.Btn_Abort.Size = new System.Drawing.Size(100, 40);
            this.Btn_Abort.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Abort.StyleCustomMode = true;
            this.Btn_Abort.TabIndex = 179;
            this.Btn_Abort.Text = "中止";
            this.Btn_Abort.Click += new System.EventHandler(this.Btn_Abort_Click);
            // 
            // Lb_Content
            // 
            this.Lb_Content.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_Content.Location = new System.Drawing.Point(15, 50);
            this.Lb_Content.Name = "Lb_Content";
            this.Lb_Content.Size = new System.Drawing.Size(422, 68);
            this.Lb_Content.Style = Sunny.UI.UIStyle.Custom;
            this.Lb_Content.StyleCustomMode = true;
            this.Lb_Content.TabIndex = 182;
            this.Lb_Content.Text = "内容";
            this.Lb_Content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(197)))), ((int)(((byte)(244)))));
            this.Btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Confirm.FillColor = System.Drawing.Color.White;
            this.Btn_Confirm.FillHoverColor = System.Drawing.Color.BurlyWood;
            this.Btn_Confirm.FillPressColor = System.Drawing.Color.BurlyWood;
            this.Btn_Confirm.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Confirm.ForeColor = System.Drawing.Color.Black;
            this.Btn_Confirm.Location = new System.Drawing.Point(179, 131);
            this.Btn_Confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.RectColor = System.Drawing.Color.BurlyWood;
            this.Btn_Confirm.Size = new System.Drawing.Size(100, 40);
            this.Btn_Confirm.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Confirm.StyleCustomMode = true;
            this.Btn_Confirm.TabIndex = 177;
            this.Btn_Confirm.Text = "确定";
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Ignore
            // 
            this.Btn_Ignore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(197)))), ((int)(((byte)(244)))));
            this.Btn_Ignore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ignore.FillColor = System.Drawing.Color.White;
            this.Btn_Ignore.FillHoverColor = System.Drawing.Color.BurlyWood;
            this.Btn_Ignore.FillPressColor = System.Drawing.Color.BurlyWood;
            this.Btn_Ignore.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Ignore.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Ignore.ForeColor = System.Drawing.Color.Black;
            this.Btn_Ignore.Location = new System.Drawing.Point(179, 131);
            this.Btn_Ignore.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Ignore.Name = "Btn_Ignore";
            this.Btn_Ignore.RectColor = System.Drawing.Color.BurlyWood;
            this.Btn_Ignore.Size = new System.Drawing.Size(100, 40);
            this.Btn_Ignore.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Ignore.StyleCustomMode = true;
            this.Btn_Ignore.TabIndex = 183;
            this.Btn_Ignore.Text = "忽略";
            this.Btn_Ignore.Click += new System.EventHandler(this.Btn_Ignore_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 187);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Ignore);
            this.Controls.Add(this.Lb_Content);
            this.Controls.Add(this.Btn_Abort);
            this.Controls.Add(this.Btn_Retry);
            this.Controls.Add(this.Btn_Confirm);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.RectColor = System.Drawing.Color.BurlyWood;
            this.ShowRect = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "工站名称";
            this.TitleColor = System.Drawing.Color.BurlyWood;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton Btn_Retry;
        private Sunny.UI.UIButton Btn_Abort;
        private Sunny.UI.UILabel Lb_Content;
        private Sunny.UI.UIButton Btn_Confirm;
        private Sunny.UI.UIButton Btn_Ignore;
    }
}