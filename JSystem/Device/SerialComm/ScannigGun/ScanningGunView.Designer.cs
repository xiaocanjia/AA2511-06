namespace JSystem.Device
{
    partial class SerialScanningGunView
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
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Start_Command = new Sunny.UI.UITextBox();
            this.Lb_SN = new Sunny.UI.UILabel();
            this.Btn_Read = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.TB_Max_Length = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.TB_End_Command = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.CbB_IsHex = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(17, 369);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(85, 25);
            this.uiLabel5.TabIndex = 193;
            this.uiLabel5.Text = "触发指令";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Start_Command
            // 
            this.TB_Start_Command.ButtonSymbol = 61761;
            this.TB_Start_Command.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Start_Command.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Start_Command.Location = new System.Drawing.Point(118, 367);
            this.TB_Start_Command.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Start_Command.Maximum = 2147483647D;
            this.TB_Start_Command.Minimum = -2147483648D;
            this.TB_Start_Command.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Start_Command.Name = "TB_Start_Command";
            this.TB_Start_Command.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Start_Command.Size = new System.Drawing.Size(159, 29);
            this.TB_Start_Command.TabIndex = 194;
            this.TB_Start_Command.Text = "K";
            this.TB_Start_Command.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Start_Command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Start_Command.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // Lb_SN
            // 
            this.Lb_SN.BackColor = System.Drawing.Color.Transparent;
            this.Lb_SN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_SN.ForeColor = System.Drawing.Color.White;
            this.Lb_SN.Location = new System.Drawing.Point(114, 518);
            this.Lb_SN.Name = "Lb_SN";
            this.Lb_SN.Size = new System.Drawing.Size(264, 28);
            this.Lb_SN.TabIndex = 195;
            this.Lb_SN.Text = "无";
            this.Lb_SN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Read
            // 
            this.Btn_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Read.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Read.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Read.Location = new System.Drawing.Point(297, 410);
            this.Btn_Read.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.RectColor = System.Drawing.Color.White;
            this.Btn_Read.Size = new System.Drawing.Size(62, 30);
            this.Btn_Read.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Read.StyleCustomMode = true;
            this.Btn_Read.TabIndex = 196;
            this.Btn_Read.Text = "读取";
            this.Btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(17, 520);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(91, 25);
            this.uiLabel6.TabIndex = 197;
            this.uiLabel6.Text = "当前二维码";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Max_Length
            // 
            this.TB_Max_Length.ButtonSymbol = 61761;
            this.TB_Max_Length.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Max_Length.DoubleValue = 27D;
            this.TB_Max_Length.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Max_Length.IntValue = 27;
            this.TB_Max_Length.Location = new System.Drawing.Point(118, 324);
            this.TB_Max_Length.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Max_Length.Maximum = 2147483647D;
            this.TB_Max_Length.Minimum = -2147483648D;
            this.TB_Max_Length.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Max_Length.Name = "TB_Max_Length";
            this.TB_Max_Length.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Max_Length.Size = new System.Drawing.Size(159, 29);
            this.TB_Max_Length.TabIndex = 240;
            this.TB_Max_Length.Text = "27";
            this.TB_Max_Length.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Max_Length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Max_Length.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.White;
            this.uiLabel7.Location = new System.Drawing.Point(17, 326);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(85, 25);
            this.uiLabel7.TabIndex = 239;
            this.uiLabel7.Text = "最大长度";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_End_Command
            // 
            this.TB_End_Command.ButtonSymbol = 61761;
            this.TB_End_Command.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_End_Command.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_End_Command.Location = new System.Drawing.Point(118, 410);
            this.TB_End_Command.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_End_Command.Maximum = 2147483647D;
            this.TB_End_Command.Minimum = -2147483648D;
            this.TB_End_Command.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_End_Command.Name = "TB_End_Command";
            this.TB_End_Command.Padding = new System.Windows.Forms.Padding(7);
            this.TB_End_Command.Size = new System.Drawing.Size(159, 29);
            this.TB_End_Command.TabIndex = 242;
            this.TB_End_Command.Text = "K";
            this.TB_End_Command.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_End_Command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_End_Command.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(17, 412);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(85, 25);
            this.uiLabel8.TabIndex = 241;
            this.uiLabel8.Text = "结束指令";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_IsHex
            // 
            this.CbB_IsHex.AutoSize = true;
            this.CbB_IsHex.BackColor = System.Drawing.Color.Transparent;
            this.CbB_IsHex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_IsHex.ForeColor = System.Drawing.Color.White;
            this.CbB_IsHex.Location = new System.Drawing.Point(21, 462);
            this.CbB_IsHex.Name = "CbB_IsHex";
            this.CbB_IsHex.Size = new System.Drawing.Size(111, 25);
            this.CbB_IsHex.TabIndex = 243;
            this.CbB_IsHex.Text = "16进制收发";
            this.CbB_IsHex.UseVisualStyleBackColor = false;
            this.CbB_IsHex.CheckedChanged += new System.EventHandler(this.CbB_IsHex_CheckedChanged);
            // 
            // SerialScanningGunView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.CbB_IsHex);
            this.Controls.Add(this.TB_End_Command);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.TB_Max_Length);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.Btn_Read);
            this.Controls.Add(this.Lb_SN);
            this.Controls.Add(this.TB_Start_Command);
            this.Controls.Add(this.uiLabel5);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "SerialScanningGunView";
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.TB_Start_Command, 0);
            this.Controls.SetChildIndex(this.Lb_SN, 0);
            this.Controls.SetChildIndex(this.Btn_Read, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.TB_Max_Length, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.TB_End_Command, 0);
            this.Controls.SetChildIndex(this.CbB_IsHex, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Start_Command;
        private Sunny.UI.UILabel Lb_SN;
        private Sunny.UI.UIButton Btn_Read;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox TB_Max_Length;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox TB_End_Command;
        private Sunny.UI.UILabel uiLabel8;
        private System.Windows.Forms.CheckBox CbB_IsHex;
    }
}
