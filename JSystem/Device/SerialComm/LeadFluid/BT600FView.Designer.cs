namespace JSystem.Device
{
    partial class BT600FView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Run = new Sunny.UI.UIButton();
            this.TB_Speed = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Mill = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.Btn_Stop = new Sunny.UI.UIButton();
            this.TB_Adress = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // Btn_Run
            // 
            this.Btn_Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Run.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Run.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Run.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Run.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Run.Location = new System.Drawing.Point(93, 441);
            this.Btn_Run.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Run.Name = "Btn_Run";
            this.Btn_Run.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Run.Size = new System.Drawing.Size(85, 40);
            this.Btn_Run.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Run.StyleCustomMode = true;
            this.Btn_Run.TabIndex = 241;
            this.Btn_Run.Text = "启动";
            this.Btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // TB_Speed
            // 
            this.TB_Speed.ButtonSymbol = 61761;
            this.TB_Speed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Speed.DoubleValue = 20D;
            this.TB_Speed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Speed.IntValue = 20;
            this.TB_Speed.Location = new System.Drawing.Point(118, 296);
            this.TB_Speed.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Speed.Maximum = 2147483647D;
            this.TB_Speed.Minimum = -2147483648D;
            this.TB_Speed.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Speed.Name = "TB_Speed";
            this.TB_Speed.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Speed.Size = new System.Drawing.Size(241, 29);
            this.TB_Speed.TabIndex = 240;
            this.TB_Speed.Text = "20";
            this.TB_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Speed.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(33, 298);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(77, 25);
            this.uiLabel5.TabIndex = 239;
            this.uiLabel5.Text = "速度";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Mill
            // 
            this.TB_Mill.ButtonSymbol = 61761;
            this.TB_Mill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Mill.DoubleValue = 20D;
            this.TB_Mill.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Mill.IntValue = 20;
            this.TB_Mill.Location = new System.Drawing.Point(118, 339);
            this.TB_Mill.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Mill.Maximum = 2147483647D;
            this.TB_Mill.Minimum = -2147483648D;
            this.TB_Mill.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Mill.Name = "TB_Mill";
            this.TB_Mill.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Mill.Size = new System.Drawing.Size(241, 29);
            this.TB_Mill.TabIndex = 242;
            this.TB_Mill.Text = "20";
            this.TB_Mill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Mill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Mill.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(33, 341);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(77, 25);
            this.uiLabel6.TabIndex = 241;
            this.uiLabel6.Text = "液量";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(33, 386);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(77, 25);
            this.uiLabel7.TabIndex = 243;
            this.uiLabel7.Text = "地址";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Stop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Stop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Stop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Stop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Stop.Location = new System.Drawing.Point(210, 441);
            this.Btn_Stop.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Stop.Size = new System.Drawing.Size(85, 40);
            this.Btn_Stop.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Stop.StyleCustomMode = true;
            this.Btn_Stop.TabIndex = 247;
            this.Btn_Stop.Text = "停止";
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // TB_Adress
            // 
            this.TB_Adress.ButtonSymbol = 61761;
            this.TB_Adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Adress.DoubleValue = 1D;
            this.TB_Adress.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Adress.IntValue = 1;
            this.TB_Adress.Location = new System.Drawing.Point(118, 382);
            this.TB_Adress.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Adress.Maximum = 2147483647D;
            this.TB_Adress.Minimum = -2147483648D;
            this.TB_Adress.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Adress.Name = "TB_Adress";
            this.TB_Adress.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Adress.Size = new System.Drawing.Size(241, 29);
            this.TB_Adress.TabIndex = 243;
            this.TB_Adress.Text = "1";
            this.TB_Adress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BT600FView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_Adress);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.TB_Mill);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.Btn_Run);
            this.Controls.Add(this.TB_Speed);
            this.Controls.Add(this.uiLabel5);
            this.Name = "BT600FView";
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.TB_Speed, 0);
            this.Controls.SetChildIndex(this.Btn_Run, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.TB_Mill, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.Btn_Stop, 0);
            this.Controls.SetChildIndex(this.TB_Adress, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton Btn_Run;
        private Sunny.UI.UITextBox TB_Speed;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox TB_Mill;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIButton Btn_Stop;
        private Sunny.UI.UITextBox TB_Adress;
    }
}
