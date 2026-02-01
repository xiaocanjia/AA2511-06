namespace JSystem.Device
{
    partial class SerialCommView
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
            this.components = new System.ComponentModel.Container();
            this.CbB_DataBits = new Sunny.UI.UIComboBox();
            this.CbB_BaudRate = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.CbB_Parity = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.CbB_StopBits = new Sunny.UI.UIComboBox();
            this.Btn_Connect = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.CbB_Port_Name = new Sunny.UI.UIComboBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.CB_Enabled = new System.Windows.Forms.CheckBox();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.TB_Send = new Sunny.UI.UITextBox();
            this.CB_Disp_Sync = new System.Windows.Forms.CheckBox();
            this.CB_Is_Hex = new System.Windows.Forms.CheckBox();
            this.Btn_Send = new Sunny.UI.UIButton();
            this.TB_Log = new Sunny.UI.UITextBox();
            this.Timer_Monitor = new System.Windows.Forms.Timer(this.components);
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbB_DataBits
            // 
            this.CbB_DataBits.DataSource = null;
            this.CbB_DataBits.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_DataBits.FillColor = System.Drawing.Color.White;
            this.CbB_DataBits.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CbB_DataBits.Location = new System.Drawing.Point(118, 98);
            this.CbB_DataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_DataBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_DataBits.Name = "CbB_DataBits";
            this.CbB_DataBits.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_DataBits.Size = new System.Drawing.Size(241, 29);
            this.CbB_DataBits.TabIndex = 201;
            this.CbB_DataBits.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CbB_BaudRate
            // 
            this.CbB_BaudRate.DataSource = null;
            this.CbB_BaudRate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_BaudRate.FillColor = System.Drawing.Color.White;
            this.CbB_BaudRate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.CbB_BaudRate.Location = new System.Drawing.Point(118, 62);
            this.CbB_BaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_BaudRate.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_BaudRate.Name = "CbB_BaudRate";
            this.CbB_BaudRate.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_BaudRate.Size = new System.Drawing.Size(241, 29);
            this.CbB_BaudRate.TabIndex = 202;
            this.CbB_BaudRate.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(22, 176);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(85, 25);
            this.uiLabel4.TabIndex = 208;
            this.uiLabel4.Text = "校验位";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Parity
            // 
            this.CbB_Parity.DataSource = null;
            this.CbB_Parity.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Parity.FillColor = System.Drawing.Color.White;
            this.CbB_Parity.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Parity.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.CbB_Parity.Location = new System.Drawing.Point(118, 170);
            this.CbB_Parity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Parity.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Parity.Name = "CbB_Parity";
            this.CbB_Parity.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Parity.Size = new System.Drawing.Size(241, 29);
            this.CbB_Parity.TabIndex = 207;
            this.CbB_Parity.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(22, 140);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(85, 25);
            this.uiLabel3.TabIndex = 206;
            this.uiLabel3.Text = "停止位";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_StopBits
            // 
            this.CbB_StopBits.DataSource = null;
            this.CbB_StopBits.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_StopBits.FillColor = System.Drawing.Color.White;
            this.CbB_StopBits.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_StopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.CbB_StopBits.Location = new System.Drawing.Point(118, 134);
            this.CbB_StopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_StopBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_StopBits.Name = "CbB_StopBits";
            this.CbB_StopBits.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_StopBits.Size = new System.Drawing.Size(241, 29);
            this.CbB_StopBits.TabIndex = 205;
            this.CbB_StopBits.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(210, 222);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 204;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(22, 32);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(85, 25);
            this.uiLabel2.TabIndex = 203;
            this.uiLabel2.Text = "串口号";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Port_Name
            // 
            this.CbB_Port_Name.DataSource = null;
            this.CbB_Port_Name.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Port_Name.FillColor = System.Drawing.Color.White;
            this.CbB_Port_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Port_Name.Location = new System.Drawing.Point(118, 26);
            this.CbB_Port_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Port_Name.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Port_Name.Name = "CbB_Port_Name";
            this.CbB_Port_Name.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Port_Name.Size = new System.Drawing.Size(241, 29);
            this.CbB_Port_Name.TabIndex = 200;
            this.CbB_Port_Name.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.CbB_Port_Name.ButtonClick += new System.EventHandler(this.CbB_Port_Name_ButtonClick);
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.White;
            this.uiLabel9.Location = new System.Drawing.Point(22, 104);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(85, 25);
            this.uiLabel9.TabIndex = 199;
            this.uiLabel9.Text = "数据位";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(22, 68);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(85, 25);
            this.uiLabel1.TabIndex = 198;
            this.uiLabel1.Text = "波特率";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_Enabled
            // 
            this.CB_Enabled.AutoSize = true;
            this.CB_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.CB_Enabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Enabled.ForeColor = System.Drawing.Color.White;
            this.CB_Enabled.Location = new System.Drawing.Point(26, 230);
            this.CB_Enabled.Name = "CB_Enabled";
            this.CB_Enabled.Size = new System.Drawing.Size(93, 25);
            this.CB_Enabled.TabIndex = 225;
            this.CB_Enabled.Text = "是否启用";
            this.CB_Enabled.UseVisualStyleBackColor = false;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiTitlePanel1.Controls.Add(this.TB_Send);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(521, 673);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.Size = new System.Drawing.Size(477, 118);
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 238;
            this.uiTitlePanel1.Text = "发送区";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            // 
            // TB_Send
            // 
            this.TB_Send.AutoScroll = true;
            this.TB_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Send.ButtonSymbol = 61761;
            this.TB_Send.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Send.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Send.Location = new System.Drawing.Point(0, 35);
            this.TB_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Send.Maximum = 10D;
            this.TB_Send.MaxLength = 1024;
            this.TB_Send.Minimum = -2147483648D;
            this.TB_Send.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Send.Multiline = true;
            this.TB_Send.Name = "TB_Send";
            this.TB_Send.Size = new System.Drawing.Size(477, 83);
            this.TB_Send.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Send.StyleCustomMode = true;
            this.TB_Send.TabIndex = 229;
            this.TB_Send.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_Disp_Sync
            // 
            this.CB_Disp_Sync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CB_Disp_Sync.AutoSize = true;
            this.CB_Disp_Sync.BackColor = System.Drawing.Color.Transparent;
            this.CB_Disp_Sync.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Disp_Sync.ForeColor = System.Drawing.Color.White;
            this.CB_Disp_Sync.Location = new System.Drawing.Point(387, 708);
            this.CB_Disp_Sync.Name = "CB_Disp_Sync";
            this.CB_Disp_Sync.Size = new System.Drawing.Size(93, 25);
            this.CB_Disp_Sync.TabIndex = 237;
            this.CB_Disp_Sync.Text = "实时显示";
            this.CB_Disp_Sync.UseVisualStyleBackColor = false;
            // 
            // CB_Is_Hex
            // 
            this.CB_Is_Hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CB_Is_Hex.AutoSize = true;
            this.CB_Is_Hex.BackColor = System.Drawing.Color.Transparent;
            this.CB_Is_Hex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Is_Hex.ForeColor = System.Drawing.Color.White;
            this.CB_Is_Hex.Location = new System.Drawing.Point(387, 675);
            this.CB_Is_Hex.Name = "CB_Is_Hex";
            this.CB_Is_Hex.Size = new System.Drawing.Size(111, 25);
            this.CB_Is_Hex.TabIndex = 236;
            this.CB_Is_Hex.Text = "16进制收发";
            this.CB_Is_Hex.UseVisualStyleBackColor = false;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Send.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Send.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Send.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Send.Location = new System.Drawing.Point(387, 751);
            this.Btn_Send.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Send.Size = new System.Drawing.Size(100, 40);
            this.Btn_Send.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Send.StyleCustomMode = true;
            this.Btn_Send.TabIndex = 235;
            this.Btn_Send.Text = "发送";
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // TB_Log
            // 
            this.TB_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Log.AutoScroll = true;
            this.TB_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Log.ButtonSymbol = 61761;
            this.TB_Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Log.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Log.Location = new System.Drawing.Point(385, 26);
            this.TB_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Log.Maximum = 10D;
            this.TB_Log.MaxLength = 1;
            this.TB_Log.Minimum = -2147483648D;
            this.TB_Log.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Log.Multiline = true;
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.ReadOnly = true;
            this.TB_Log.ShowScrollBar = true;
            this.TB_Log.Size = new System.Drawing.Size(613, 637);
            this.TB_Log.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Log.StyleCustomMode = true;
            this.TB_Log.TabIndex = 234;
            this.TB_Log.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer_Monitor
            // 
            this.Timer_Monitor.Enabled = true;
            this.Timer_Monitor.Interval = 200;
            this.Timer_Monitor.Tick += new System.EventHandler(this.Timer_Monitor_Tick);
            // 
            // SerialCommView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.CB_Disp_Sync);
            this.Controls.Add(this.CB_Is_Hex);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.TB_Log);
            this.Controls.Add(this.CB_Enabled);
            this.Controls.Add(this.CbB_DataBits);
            this.Controls.Add(this.CbB_BaudRate);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.CbB_Parity);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.CbB_StopBits);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_Port_Name);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SerialCommView";
            this.Size = new System.Drawing.Size(1027, 798);
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIComboBox CbB_DataBits;
        private Sunny.UI.UIComboBox CbB_BaudRate;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox CbB_Parity;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox CbB_StopBits;
        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Port_Name;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.CheckBox CB_Enabled;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITextBox TB_Send;
        private System.Windows.Forms.CheckBox CB_Disp_Sync;
        private System.Windows.Forms.CheckBox CB_Is_Hex;
        private Sunny.UI.UIButton Btn_Send;
        private Sunny.UI.UITextBox TB_Log;
        private System.Windows.Forms.Timer Timer_Monitor;
    }
}
