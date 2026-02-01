namespace JSystem.Device
{
    partial class ProgramPowerView
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
            this.Btn_Connect = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.CbB_Port_Name = new Sunny.UI.UIComboBox();
            this.TB_Channel = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.TB_Voltage = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.Btn_Set_Volt = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Lbl_Curr = new Sunny.UI.UILabel();
            this.TB_Curr = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.CB_Enabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(209, 112);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 177;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(22, 35);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(85, 27);
            this.uiLabel2.TabIndex = 228;
            this.uiLabel2.Text = "端口名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Port_Name
            // 
            this.CbB_Port_Name.DataSource = null;
            this.CbB_Port_Name.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Port_Name.FillColor = System.Drawing.Color.White;
            this.CbB_Port_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Port_Name.Location = new System.Drawing.Point(116, 29);
            this.CbB_Port_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Port_Name.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Port_Name.Name = "CbB_Port_Name";
            this.CbB_Port_Name.Padding = new System.Windows.Forms.Padding(8, 0, 40, 3);
            this.CbB_Port_Name.Size = new System.Drawing.Size(267, 31);
            this.CbB_Port_Name.TabIndex = 227;
            this.CbB_Port_Name.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.CbB_Port_Name.ButtonClick += new System.EventHandler(this.CbB_Port_Name_ButtonClick);
            // 
            // TB_Channel
            // 
            this.TB_Channel.ButtonSymbol = 61761;
            this.TB_Channel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Channel.DoubleValue = 1D;
            this.TB_Channel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Channel.IntValue = 1;
            this.TB_Channel.Location = new System.Drawing.Point(116, 231);
            this.TB_Channel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Channel.Maximum = 2147483647D;
            this.TB_Channel.Minimum = -2147483648D;
            this.TB_Channel.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Channel.Name = "TB_Channel";
            this.TB_Channel.Size = new System.Drawing.Size(267, 29);
            this.TB_Channel.TabIndex = 253;
            this.TB_Channel.Text = "1";
            this.TB_Channel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(22, 233);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(85, 27);
            this.uiLabel6.TabIndex = 252;
            this.uiLabel6.Text = "通道号";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Voltage
            // 
            this.TB_Voltage.ButtonSymbol = 61761;
            this.TB_Voltage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Voltage.DoubleValue = 5.2D;
            this.TB_Voltage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Voltage.Location = new System.Drawing.Point(116, 270);
            this.TB_Voltage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Voltage.Maximum = 2147483647D;
            this.TB_Voltage.Minimum = -2147483648D;
            this.TB_Voltage.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Voltage.Name = "TB_Voltage";
            this.TB_Voltage.Size = new System.Drawing.Size(267, 29);
            this.TB_Voltage.TabIndex = 251;
            this.TB_Voltage.Text = "5.2";
            this.TB_Voltage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(22, 272);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(85, 27);
            this.uiLabel5.TabIndex = 250;
            this.uiLabel5.Text = "电压";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Set_Volt
            // 
            this.Btn_Set_Volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Set_Volt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Set_Volt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Set_Volt.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Set_Volt.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Set_Volt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Set_Volt.Location = new System.Drawing.Point(309, 356);
            this.Btn_Set_Volt.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Set_Volt.Name = "Btn_Set_Volt";
            this.Btn_Set_Volt.RectColor = System.Drawing.Color.White;
            this.Btn_Set_Volt.Size = new System.Drawing.Size(64, 30);
            this.Btn_Set_Volt.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Set_Volt.StyleCustomMode = true;
            this.Btn_Set_Volt.TabIndex = 254;
            this.Btn_Set_Volt.Text = "测试";
            this.Btn_Set_Volt.Click += new System.EventHandler(this.Btn_Set_Volt_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(21, 356);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(85, 27);
            this.uiLabel1.TabIndex = 255;
            this.uiLabel1.Text = "当前电流";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Curr
            // 
            this.Lbl_Curr.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Curr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Curr.ForeColor = System.Drawing.Color.White;
            this.Lbl_Curr.Location = new System.Drawing.Point(112, 356);
            this.Lbl_Curr.Name = "Lbl_Curr";
            this.Lbl_Curr.Size = new System.Drawing.Size(103, 27);
            this.Lbl_Curr.TabIndex = 256;
            this.Lbl_Curr.Text = "0.0";
            this.Lbl_Curr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Curr
            // 
            this.TB_Curr.ButtonSymbol = 61761;
            this.TB_Curr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Curr.DoubleValue = 1D;
            this.TB_Curr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Curr.IntValue = 1;
            this.TB_Curr.Location = new System.Drawing.Point(116, 309);
            this.TB_Curr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Curr.Maximum = 2147483647D;
            this.TB_Curr.Minimum = -2147483648D;
            this.TB_Curr.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Curr.Name = "TB_Curr";
            this.TB_Curr.Size = new System.Drawing.Size(267, 29);
            this.TB_Curr.TabIndex = 253;
            this.TB_Curr.Text = "1";
            this.TB_Curr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(22, 311);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(85, 27);
            this.uiLabel3.TabIndex = 252;
            this.uiLabel3.Text = "电流";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_Enabled
            // 
            this.CB_Enabled.AutoSize = true;
            this.CB_Enabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Enabled.ForeColor = System.Drawing.Color.White;
            this.CB_Enabled.Location = new System.Drawing.Point(25, 121);
            this.CB_Enabled.Name = "CB_Enabled";
            this.CB_Enabled.Size = new System.Drawing.Size(93, 25);
            this.CB_Enabled.TabIndex = 257;
            this.CB_Enabled.Text = "是否启用";
            this.CB_Enabled.UseVisualStyleBackColor = true;
            // 
            // ProgramPowerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.CB_Enabled);
            this.Controls.Add(this.TB_Curr);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.Lbl_Curr);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Btn_Set_Volt);
            this.Controls.Add(this.TB_Channel);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.TB_Voltage);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_Port_Name);
            this.Controls.Add(this.Btn_Connect);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProgramPowerView";
            this.Size = new System.Drawing.Size(400, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Port_Name;
        private Sunny.UI.UITextBox TB_Channel;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox TB_Voltage;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton Btn_Set_Volt;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel Lbl_Curr;
        private Sunny.UI.UITextBox TB_Curr;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.CheckBox CB_Enabled;
    }
}
