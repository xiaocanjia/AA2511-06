namespace JSystem.Device
{
    partial class IOTSysView
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
            this.TB_Device = new Sunny.UI.UITextBox();
            this.TB_URL = new Sunny.UI.UITextBox();
            this.CB_Enabled = new System.Windows.Forms.CheckBox();
            this.Btn_Connect = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.CbB_Cmd = new Sunny.UI.UIComboBox();
            this.TB_OperatorName = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.TB_SoftName = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.TB_TokenData = new Sunny.UI.UITextBox();
            this.TB_Business = new Sunny.UI.UITextBox();
            this.TB_Department = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.TB_SeparateLine = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.TB_Station = new Sunny.UI.UITextBox();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.Btn_SendCmd = new Sunny.UI.UIButton();
            this.TB_Msg = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TB_SoftVer = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_LogPath = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.TB_LogName = new Sunny.UI.UITextBox();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.TB_IP = new Sunny.UI.UITextBox();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.TB_Port = new Sunny.UI.UITextBox();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.TB_Interval = new Sunny.UI.UITextBox();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.CbB_Type = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // TB_Device
            // 
            this.TB_Device.ButtonSymbol = 61761;
            this.TB_Device.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Device.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Device.Location = new System.Drawing.Point(145, 358);
            this.TB_Device.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_Device.Maximum = 2147483647D;
            this.TB_Device.Minimum = -2147483648D;
            this.TB_Device.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Device.Name = "TB_Device";
            this.TB_Device.Padding = new System.Windows.Forms.Padding(9);
            this.TB_Device.Size = new System.Drawing.Size(266, 30);
            this.TB_Device.TabIndex = 254;
            this.TB_Device.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Device.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Device.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_URL
            // 
            this.TB_URL.ButtonSymbol = 61761;
            this.TB_URL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_URL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_URL.Location = new System.Drawing.Point(145, 72);
            this.TB_URL.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_URL.Maximum = 2147483647D;
            this.TB_URL.Minimum = -2147483648D;
            this.TB_URL.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_URL.Name = "TB_URL";
            this.TB_URL.Padding = new System.Windows.Forms.Padding(9);
            this.TB_URL.Size = new System.Drawing.Size(266, 29);
            this.TB_URL.TabIndex = 252;
            this.TB_URL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_URL.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // CB_Enabled
            // 
            this.CB_Enabled.AutoSize = true;
            this.CB_Enabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Enabled.ForeColor = System.Drawing.Color.White;
            this.CB_Enabled.Location = new System.Drawing.Point(56, 719);
            this.CB_Enabled.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Enabled.Name = "CB_Enabled";
            this.CB_Enabled.Size = new System.Drawing.Size(93, 25);
            this.CB_Enabled.TabIndex = 256;
            this.CB_Enabled.Text = "是否启用";
            this.CB_Enabled.UseVisualStyleBackColor = true;
            this.CB_Enabled.CheckedChanged += new System.EventHandler(this.CB_Enabled_CheckedChanged);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(270, 711);
            this.Btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 255;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(549, 33);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(51, 25);
            this.uiLabel2.TabIndex = 258;
            this.uiLabel2.Text = "指令";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Cmd
            // 
            this.CbB_Cmd.DataSource = null;
            this.CbB_Cmd.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Cmd.FillColor = System.Drawing.Color.White;
            this.CbB_Cmd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Cmd.Items.AddRange(new object[] {
            "上传报警",
            "消除报警",
            "上传产品状态",
            "上传设备状态",
            "上传数据"});
            this.CbB_Cmd.Location = new System.Drawing.Point(609, 30);
            this.CbB_Cmd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CbB_Cmd.MinimumSize = new System.Drawing.Size(84, 0);
            this.CbB_Cmd.Name = "CbB_Cmd";
            this.CbB_Cmd.Padding = new System.Windows.Forms.Padding(11, 0, 40, 3);
            this.CbB_Cmd.Size = new System.Drawing.Size(187, 30);
            this.CbB_Cmd.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Cmd.StyleCustomMode = true;
            this.CbB_Cmd.TabIndex = 257;
            this.CbB_Cmd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_OperatorName
            // 
            this.TB_OperatorName.ButtonSymbol = 61761;
            this.TB_OperatorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_OperatorName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_OperatorName.Location = new System.Drawing.Point(145, 276);
            this.TB_OperatorName.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_OperatorName.Maximum = 2147483647D;
            this.TB_OperatorName.Minimum = -2147483648D;
            this.TB_OperatorName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_OperatorName.Name = "TB_OperatorName";
            this.TB_OperatorName.Padding = new System.Windows.Forms.Padding(9);
            this.TB_OperatorName.Size = new System.Drawing.Size(266, 30);
            this.TB_OperatorName.TabIndex = 258;
            this.TB_OperatorName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_OperatorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_OperatorName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(43, 279);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(94, 25);
            this.uiLabel3.TabIndex = 257;
            this.uiLabel3.Text = "作业员";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_SoftName
            // 
            this.TB_SoftName.ButtonSymbol = 61761;
            this.TB_SoftName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SoftName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_SoftName.Location = new System.Drawing.Point(145, 399);
            this.TB_SoftName.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_SoftName.Maximum = 2147483647D;
            this.TB_SoftName.Minimum = -2147483648D;
            this.TB_SoftName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_SoftName.Name = "TB_SoftName";
            this.TB_SoftName.Padding = new System.Windows.Forms.Padding(9);
            this.TB_SoftName.Size = new System.Drawing.Size(266, 30);
            this.TB_SoftName.TabIndex = 256;
            this.TB_SoftName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_SoftName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_SoftName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(43, 361);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(94, 25);
            this.uiLabel4.TabIndex = 255;
            this.uiLabel4.Text = "设备编号";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.White;
            this.uiLabel7.Location = new System.Drawing.Point(43, 402);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(94, 25);
            this.uiLabel7.TabIndex = 257;
            this.uiLabel7.Text = "软件名称";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(43, 74);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(94, 25);
            this.uiLabel8.TabIndex = 255;
            this.uiLabel8.Text = "URL";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.White;
            this.uiLabel9.Location = new System.Drawing.Point(43, 320);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(94, 25);
            this.uiLabel9.TabIndex = 253;
            this.uiLabel9.Text = "Token";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_TokenData
            // 
            this.TB_TokenData.ButtonSymbol = 61761;
            this.TB_TokenData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_TokenData.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_TokenData.Location = new System.Drawing.Point(145, 317);
            this.TB_TokenData.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_TokenData.Maximum = 2147483647D;
            this.TB_TokenData.Minimum = -2147483648D;
            this.TB_TokenData.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_TokenData.Name = "TB_TokenData";
            this.TB_TokenData.Padding = new System.Windows.Forms.Padding(9);
            this.TB_TokenData.Size = new System.Drawing.Size(266, 30);
            this.TB_TokenData.TabIndex = 258;
            this.TB_TokenData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_TokenData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_TokenData.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_Business
            // 
            this.TB_Business.ButtonSymbol = 61761;
            this.TB_Business.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Business.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Business.Location = new System.Drawing.Point(145, 112);
            this.TB_Business.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_Business.Maximum = 2147483647D;
            this.TB_Business.Minimum = -2147483648D;
            this.TB_Business.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Business.Name = "TB_Business";
            this.TB_Business.Padding = new System.Windows.Forms.Padding(9);
            this.TB_Business.Size = new System.Drawing.Size(266, 30);
            this.TB_Business.TabIndex = 252;
            this.TB_Business.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Business.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Business.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_Department
            // 
            this.TB_Department.ButtonSymbol = 61761;
            this.TB_Department.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Department.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Department.Location = new System.Drawing.Point(145, 153);
            this.TB_Department.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_Department.Maximum = 2147483647D;
            this.TB_Department.Minimum = -2147483648D;
            this.TB_Department.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Department.Name = "TB_Department";
            this.TB_Department.Padding = new System.Windows.Forms.Padding(9);
            this.TB_Department.Size = new System.Drawing.Size(266, 30);
            this.TB_Department.TabIndex = 254;
            this.TB_Department.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Department.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Department.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.ForeColor = System.Drawing.Color.White;
            this.uiLabel10.Location = new System.Drawing.Point(43, 156);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(94, 25);
            this.uiLabel10.TabIndex = 255;
            this.uiLabel10.Text = "部门";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_SeparateLine
            // 
            this.TB_SeparateLine.ButtonSymbol = 61761;
            this.TB_SeparateLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SeparateLine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_SeparateLine.Location = new System.Drawing.Point(145, 194);
            this.TB_SeparateLine.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_SeparateLine.Maximum = 2147483647D;
            this.TB_SeparateLine.Minimum = -2147483648D;
            this.TB_SeparateLine.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_SeparateLine.Name = "TB_SeparateLine";
            this.TB_SeparateLine.Padding = new System.Windows.Forms.Padding(9);
            this.TB_SeparateLine.Size = new System.Drawing.Size(266, 30);
            this.TB_SeparateLine.TabIndex = 256;
            this.TB_SeparateLine.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_SeparateLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_SeparateLine.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.ForeColor = System.Drawing.Color.White;
            this.uiLabel11.Location = new System.Drawing.Point(43, 115);
            this.uiLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(94, 25);
            this.uiLabel11.TabIndex = 255;
            this.uiLabel11.Text = "事业部";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.White;
            this.uiLabel12.Location = new System.Drawing.Point(43, 197);
            this.uiLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(94, 25);
            this.uiLabel12.TabIndex = 257;
            this.uiLabel12.Text = "线别";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Station
            // 
            this.TB_Station.ButtonSymbol = 61761;
            this.TB_Station.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Station.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Station.Location = new System.Drawing.Point(145, 235);
            this.TB_Station.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_Station.Maximum = 2147483647D;
            this.TB_Station.Minimum = -2147483648D;
            this.TB_Station.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Station.Name = "TB_Station";
            this.TB_Station.Padding = new System.Windows.Forms.Padding(9);
            this.TB_Station.Size = new System.Drawing.Size(266, 30);
            this.TB_Station.TabIndex = 256;
            this.TB_Station.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Station.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Station.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel13
            // 
            this.uiLabel13.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel13.ForeColor = System.Drawing.Color.White;
            this.uiLabel13.Location = new System.Drawing.Point(43, 238);
            this.uiLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(94, 25);
            this.uiLabel13.TabIndex = 257;
            this.uiLabel13.Text = "站位";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_SendCmd
            // 
            this.Btn_SendCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SendCmd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_SendCmd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_SendCmd.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_SendCmd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_SendCmd.Location = new System.Drawing.Point(818, 30);
            this.Btn_SendCmd.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SendCmd.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_SendCmd.Name = "Btn_SendCmd";
            this.Btn_SendCmd.RectColor = System.Drawing.Color.White;
            this.Btn_SendCmd.Size = new System.Drawing.Size(88, 32);
            this.Btn_SendCmd.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_SendCmd.StyleCustomMode = true;
            this.Btn_SendCmd.TabIndex = 275;
            this.Btn_SendCmd.Text = "发送";
            this.Btn_SendCmd.Click += new System.EventHandler(this.Btn_SendCmd_Click);
            // 
            // TB_Msg
            // 
            this.TB_Msg.AutoScroll = true;
            this.TB_Msg.ButtonSymbol = 61761;
            this.TB_Msg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Msg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Msg.Location = new System.Drawing.Point(553, 85);
            this.TB_Msg.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_Msg.Maximum = 2147483647D;
            this.TB_Msg.Minimum = -2147483648D;
            this.TB_Msg.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Msg.Multiline = true;
            this.TB_Msg.Name = "TB_Msg";
            this.TB_Msg.Padding = new System.Windows.Forms.Padding(9);
            this.TB_Msg.Size = new System.Drawing.Size(366, 408);
            this.TB_Msg.TabIndex = 276;
            this.TB_Msg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(43, 443);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(94, 25);
            this.uiLabel1.TabIndex = 278;
            this.uiLabel1.Text = "软件版本";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_SoftVer
            // 
            this.TB_SoftVer.ButtonSymbol = 61761;
            this.TB_SoftVer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SoftVer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_SoftVer.Location = new System.Drawing.Point(145, 440);
            this.TB_SoftVer.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_SoftVer.Maximum = 2147483647D;
            this.TB_SoftVer.Minimum = -2147483648D;
            this.TB_SoftVer.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_SoftVer.Name = "TB_SoftVer";
            this.TB_SoftVer.Padding = new System.Windows.Forms.Padding(9);
            this.TB_SoftVer.Size = new System.Drawing.Size(266, 30);
            this.TB_SoftVer.TabIndex = 277;
            this.TB_SoftVer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_SoftVer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_SoftVer.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(43, 484);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(94, 25);
            this.uiLabel5.TabIndex = 280;
            this.uiLabel5.Text = "日志路径";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_LogPath
            // 
            this.TB_LogPath.ButtonSymbol = 61761;
            this.TB_LogPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_LogPath.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_LogPath.Location = new System.Drawing.Point(145, 481);
            this.TB_LogPath.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_LogPath.Maximum = 2147483647D;
            this.TB_LogPath.Minimum = -2147483648D;
            this.TB_LogPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_LogPath.Name = "TB_LogPath";
            this.TB_LogPath.Padding = new System.Windows.Forms.Padding(9);
            this.TB_LogPath.Size = new System.Drawing.Size(266, 30);
            this.TB_LogPath.TabIndex = 279;
            this.TB_LogPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_LogPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_LogPath.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(43, 525);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(94, 25);
            this.uiLabel6.TabIndex = 282;
            this.uiLabel6.Text = "日志名称";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_LogName
            // 
            this.TB_LogName.ButtonSymbol = 61761;
            this.TB_LogName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_LogName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_LogName.Location = new System.Drawing.Point(145, 522);
            this.TB_LogName.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_LogName.Maximum = 2147483647D;
            this.TB_LogName.Minimum = -2147483648D;
            this.TB_LogName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_LogName.Name = "TB_LogName";
            this.TB_LogName.Padding = new System.Windows.Forms.Padding(9);
            this.TB_LogName.Size = new System.Drawing.Size(266, 30);
            this.TB_LogName.TabIndex = 281;
            this.TB_LogName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_LogName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_LogName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel14
            // 
            this.uiLabel14.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel14.ForeColor = System.Drawing.Color.White;
            this.uiLabel14.Location = new System.Drawing.Point(43, 566);
            this.uiLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(94, 25);
            this.uiLabel14.TabIndex = 284;
            this.uiLabel14.Text = "IP";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_IP
            // 
            this.TB_IP.ButtonSymbol = 61761;
            this.TB_IP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_IP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_IP.Location = new System.Drawing.Point(145, 563);
            this.TB_IP.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_IP.Maximum = 2147483647D;
            this.TB_IP.Minimum = -2147483648D;
            this.TB_IP.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Padding = new System.Windows.Forms.Padding(9);
            this.TB_IP.Size = new System.Drawing.Size(266, 30);
            this.TB_IP.TabIndex = 283;
            this.TB_IP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_IP.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel15
            // 
            this.uiLabel15.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel15.ForeColor = System.Drawing.Color.White;
            this.uiLabel15.Location = new System.Drawing.Point(43, 607);
            this.uiLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(94, 25);
            this.uiLabel15.TabIndex = 286;
            this.uiLabel15.Text = "端口";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Port
            // 
            this.TB_Port.ButtonSymbol = 61761;
            this.TB_Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Port.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Port.Location = new System.Drawing.Point(145, 604);
            this.TB_Port.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_Port.Maximum = 2147483647D;
            this.TB_Port.Minimum = -2147483648D;
            this.TB_Port.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Port.Name = "TB_Port";
            this.TB_Port.Padding = new System.Windows.Forms.Padding(9);
            this.TB_Port.Size = new System.Drawing.Size(266, 30);
            this.TB_Port.TabIndex = 285;
            this.TB_Port.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Port.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel16
            // 
            this.uiLabel16.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel16.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel16.ForeColor = System.Drawing.Color.White;
            this.uiLabel16.Location = new System.Drawing.Point(43, 648);
            this.uiLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(94, 25);
            this.uiLabel16.TabIndex = 288;
            this.uiLabel16.Text = "心跳间隔";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Interval
            // 
            this.TB_Interval.ButtonSymbol = 61761;
            this.TB_Interval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Interval.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Interval.Location = new System.Drawing.Point(145, 645);
            this.TB_Interval.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.TB_Interval.Maximum = 2147483647D;
            this.TB_Interval.Minimum = -2147483648D;
            this.TB_Interval.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Interval.Name = "TB_Interval";
            this.TB_Interval.Padding = new System.Windows.Forms.Padding(9);
            this.TB_Interval.Size = new System.Drawing.Size(266, 30);
            this.TB_Interval.TabIndex = 287;
            this.TB_Interval.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Interval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Interval.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel17
            // 
            this.uiLabel17.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel17.ForeColor = System.Drawing.Color.White;
            this.uiLabel17.Location = new System.Drawing.Point(43, 35);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(78, 23);
            this.uiLabel17.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel17.StyleCustomMode = true;
            this.uiLabel17.TabIndex = 290;
            this.uiLabel17.Text = "类型";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Type
            // 
            this.CbB_Type.DataSource = null;
            this.CbB_Type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Type.FillColor = System.Drawing.Color.White;
            this.CbB_Type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Type.Location = new System.Drawing.Point(145, 29);
            this.CbB_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Type.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Type.Name = "CbB_Type";
            this.CbB_Type.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Type.Size = new System.Drawing.Size(266, 29);
            this.CbB_Type.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Type.StyleCustomMode = true;
            this.CbB_Type.TabIndex = 289;
            this.CbB_Type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CbB_Type.SelectedIndexChanged += new System.EventHandler(this.CbB_Type_SelectedIndexChanged);
            // 
            // IOTSysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.uiLabel17);
            this.Controls.Add(this.CbB_Type);
            this.Controls.Add(this.uiLabel16);
            this.Controls.Add(this.TB_Interval);
            this.Controls.Add(this.uiLabel15);
            this.Controls.Add(this.TB_Port);
            this.Controls.Add(this.uiLabel14);
            this.Controls.Add(this.TB_IP);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.TB_LogName);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.TB_LogPath);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.TB_SoftVer);
            this.Controls.Add(this.TB_Msg);
            this.Controls.Add(this.Btn_SendCmd);
            this.Controls.Add(this.TB_TokenData);
            this.Controls.Add(this.TB_OperatorName);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.TB_SeparateLine);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.TB_Station);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.TB_SoftName);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_Cmd);
            this.Controls.Add(this.CB_Enabled);
            this.Controls.Add(this.TB_Department);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.TB_Device);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.TB_Business);
            this.Controls.Add(this.TB_URL);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Name = "IOTSysView";
            this.Size = new System.Drawing.Size(1090, 1067);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CB_Enabled;
        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Cmd;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        public Sunny.UI.UITextBox TB_TokenData;
        public Sunny.UI.UITextBox TB_Device;
        public Sunny.UI.UITextBox TB_URL;
        public Sunny.UI.UITextBox TB_OperatorName;
        public Sunny.UI.UITextBox TB_SoftName;
        public Sunny.UI.UITextBox TB_Business;
        public Sunny.UI.UITextBox TB_Department;
        private Sunny.UI.UILabel uiLabel10;
        public Sunny.UI.UITextBox TB_SeparateLine;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel12;
        public Sunny.UI.UITextBox TB_Station;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UIButton Btn_SendCmd;
        public Sunny.UI.UITextBox TB_Msg;
        private Sunny.UI.UILabel uiLabel1;
        public Sunny.UI.UITextBox TB_SoftVer;
        private Sunny.UI.UILabel uiLabel5;
        public Sunny.UI.UITextBox TB_LogPath;
        private Sunny.UI.UILabel uiLabel6;
        public Sunny.UI.UITextBox TB_LogName;
        private Sunny.UI.UILabel uiLabel14;
        public Sunny.UI.UITextBox TB_IP;
        private Sunny.UI.UILabel uiLabel15;
        public Sunny.UI.UITextBox TB_Port;
        private Sunny.UI.UILabel uiLabel16;
        public Sunny.UI.UITextBox TB_Interval;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UIComboBox CbB_Type;
    }
}
