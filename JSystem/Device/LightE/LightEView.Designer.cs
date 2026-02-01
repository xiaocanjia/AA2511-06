namespace JSystem.Device
{
    partial class LightEView
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
            this.CbB_SN = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Lbl_Chn1 = new Sunny.UI.UILabel();
            this.CB_Enabled = new System.Windows.Forms.CheckBox();
            this.Btn_Read_Once = new Sunny.UI.UIButton();
            this.TB_Time_Out = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.TB_Read_Count = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Calib_File = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.TB_Config_File = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Btn_Select_Config_File = new Sunny.UI.UIButton();
            this.Btn_Select_Calib_File = new Sunny.UI.UIButton();
            this.Lbl_Chn2 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.Lbl_Chn3 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.Lbl_Chn4 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
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
            this.Btn_Connect.Location = new System.Drawing.Point(180, 279);
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
            this.uiLabel2.Text = "SN号";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_SN
            // 
            this.CbB_SN.DataSource = null;
            this.CbB_SN.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_SN.FillColor = System.Drawing.Color.White;
            this.CbB_SN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_SN.Location = new System.Drawing.Point(116, 33);
            this.CbB_SN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_SN.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_SN.Name = "CbB_SN";
            this.CbB_SN.Padding = new System.Windows.Forms.Padding(8, 0, 40, 3);
            this.CbB_SN.Size = new System.Drawing.Size(267, 31);
            this.CbB_SN.TabIndex = 227;
            this.CbB_SN.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(21, 457);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(85, 27);
            this.uiLabel1.TabIndex = 255;
            this.uiLabel1.Text = "通道1";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Chn1
            // 
            this.Lbl_Chn1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Chn1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Chn1.ForeColor = System.Drawing.Color.White;
            this.Lbl_Chn1.Location = new System.Drawing.Point(112, 457);
            this.Lbl_Chn1.Name = "Lbl_Chn1";
            this.Lbl_Chn1.Size = new System.Drawing.Size(103, 27);
            this.Lbl_Chn1.TabIndex = 256;
            this.Lbl_Chn1.Text = "0.0";
            this.Lbl_Chn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_Enabled
            // 
            this.CB_Enabled.AutoSize = true;
            this.CB_Enabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Enabled.ForeColor = System.Drawing.Color.White;
            this.CB_Enabled.Location = new System.Drawing.Point(37, 287);
            this.CB_Enabled.Name = "CB_Enabled";
            this.CB_Enabled.Size = new System.Drawing.Size(93, 25);
            this.CB_Enabled.TabIndex = 257;
            this.CB_Enabled.Text = "是否启用";
            this.CB_Enabled.UseVisualStyleBackColor = true;
            this.CB_Enabled.CheckedChanged += new System.EventHandler(this.CB_Enabled_CheckedChanged);
            // 
            // Btn_Read_Once
            // 
            this.Btn_Read_Once.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read_Once.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Read_Once.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read_Once.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read_Once.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Read_Once.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Read_Once.Location = new System.Drawing.Point(26, 383);
            this.Btn_Read_Once.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Read_Once.Name = "Btn_Read_Once";
            this.Btn_Read_Once.RectColor = System.Drawing.Color.White;
            this.Btn_Read_Once.Size = new System.Drawing.Size(100, 40);
            this.Btn_Read_Once.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Read_Once.StyleCustomMode = true;
            this.Btn_Read_Once.TabIndex = 258;
            this.Btn_Read_Once.Text = "读取一次";
            this.Btn_Read_Once.Click += new System.EventHandler(this.Btn_Read_Once_Click);
            // 
            // TB_Time_Out
            // 
            this.TB_Time_Out.ButtonSymbol = 61761;
            this.TB_Time_Out.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Time_Out.DoubleValue = 1D;
            this.TB_Time_Out.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Time_Out.IntValue = 1;
            this.TB_Time_Out.Location = new System.Drawing.Point(116, 215);
            this.TB_Time_Out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Time_Out.Maximum = 2147483647D;
            this.TB_Time_Out.Minimum = -2147483648D;
            this.TB_Time_Out.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Time_Out.Name = "TB_Time_Out";
            this.TB_Time_Out.Size = new System.Drawing.Size(267, 29);
            this.TB_Time_Out.TabIndex = 262;
            this.TB_Time_Out.Text = "1";
            this.TB_Time_Out.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Time_Out.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Time_Out.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(22, 215);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(85, 27);
            this.uiLabel3.TabIndex = 261;
            this.uiLabel3.Text = "超时时间";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_Count
            // 
            this.TB_Read_Count.ButtonSymbol = 61761;
            this.TB_Read_Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_Count.DoubleValue = 10D;
            this.TB_Read_Count.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Read_Count.IntValue = 10;
            this.TB_Read_Count.Location = new System.Drawing.Point(116, 170);
            this.TB_Read_Count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Read_Count.Maximum = 2147483647D;
            this.TB_Read_Count.Minimum = -2147483648D;
            this.TB_Read_Count.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Read_Count.Name = "TB_Read_Count";
            this.TB_Read_Count.Size = new System.Drawing.Size(267, 29);
            this.TB_Read_Count.TabIndex = 260;
            this.TB_Read_Count.Text = "10";
            this.TB_Read_Count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Read_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Read_Count.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(22, 170);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(85, 27);
            this.uiLabel5.TabIndex = 259;
            this.uiLabel5.Text = "读取次数";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Calib_File
            // 
            this.TB_Calib_File.ButtonSymbol = 61761;
            this.TB_Calib_File.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Calib_File.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Calib_File.Location = new System.Drawing.Point(116, 125);
            this.TB_Calib_File.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Calib_File.Maximum = 2147483647D;
            this.TB_Calib_File.Minimum = -2147483648D;
            this.TB_Calib_File.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Calib_File.Name = "TB_Calib_File";
            this.TB_Calib_File.Size = new System.Drawing.Size(267, 29);
            this.TB_Calib_File.TabIndex = 266;
            this.TB_Calib_File.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(22, 125);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(85, 27);
            this.uiLabel4.TabIndex = 265;
            this.uiLabel4.Text = "校准文件";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Config_File
            // 
            this.TB_Config_File.ButtonSymbol = 61761;
            this.TB_Config_File.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Config_File.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Config_File.Location = new System.Drawing.Point(116, 80);
            this.TB_Config_File.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Config_File.Maximum = 2147483647D;
            this.TB_Config_File.Minimum = -2147483648D;
            this.TB_Config_File.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Config_File.Name = "TB_Config_File";
            this.TB_Config_File.Size = new System.Drawing.Size(267, 29);
            this.TB_Config_File.TabIndex = 264;
            this.TB_Config_File.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(22, 80);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(85, 27);
            this.uiLabel6.TabIndex = 263;
            this.uiLabel6.Text = "配置文件";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Select_Config_File
            // 
            this.Btn_Select_Config_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Select_Config_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Select_Config_File.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Select_Config_File.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Select_Config_File.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Select_Config_File.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Select_Config_File.Location = new System.Drawing.Point(409, 80);
            this.Btn_Select_Config_File.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Select_Config_File.Name = "Btn_Select_Config_File";
            this.Btn_Select_Config_File.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Select_Config_File.Size = new System.Drawing.Size(64, 30);
            this.Btn_Select_Config_File.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Select_Config_File.StyleCustomMode = true;
            this.Btn_Select_Config_File.TabIndex = 267;
            this.Btn_Select_Config_File.Text = "选择";
            this.Btn_Select_Config_File.Click += new System.EventHandler(this.Btn_Select_Config_File_Click);
            // 
            // Btn_Select_Calib_File
            // 
            this.Btn_Select_Calib_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Select_Calib_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Select_Calib_File.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Select_Calib_File.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Select_Calib_File.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Select_Calib_File.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Select_Calib_File.Location = new System.Drawing.Point(409, 125);
            this.Btn_Select_Calib_File.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Select_Calib_File.Name = "Btn_Select_Calib_File";
            this.Btn_Select_Calib_File.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Select_Calib_File.Size = new System.Drawing.Size(64, 30);
            this.Btn_Select_Calib_File.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Select_Calib_File.StyleCustomMode = true;
            this.Btn_Select_Calib_File.TabIndex = 268;
            this.Btn_Select_Calib_File.Text = "选择";
            this.Btn_Select_Calib_File.Click += new System.EventHandler(this.Btn_Select_Calib_File_Click);
            // 
            // Lbl_Chn2
            // 
            this.Lbl_Chn2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Chn2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Chn2.ForeColor = System.Drawing.Color.White;
            this.Lbl_Chn2.Location = new System.Drawing.Point(112, 497);
            this.Lbl_Chn2.Name = "Lbl_Chn2";
            this.Lbl_Chn2.Size = new System.Drawing.Size(103, 27);
            this.Lbl_Chn2.TabIndex = 270;
            this.Lbl_Chn2.Text = "0.0";
            this.Lbl_Chn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(21, 497);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(85, 27);
            this.uiLabel8.TabIndex = 269;
            this.uiLabel8.Text = "通道2";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Chn3
            // 
            this.Lbl_Chn3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Chn3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Chn3.ForeColor = System.Drawing.Color.White;
            this.Lbl_Chn3.Location = new System.Drawing.Point(113, 540);
            this.Lbl_Chn3.Name = "Lbl_Chn3";
            this.Lbl_Chn3.Size = new System.Drawing.Size(103, 27);
            this.Lbl_Chn3.TabIndex = 272;
            this.Lbl_Chn3.Text = "0.0";
            this.Lbl_Chn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.ForeColor = System.Drawing.Color.White;
            this.uiLabel10.Location = new System.Drawing.Point(22, 540);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(85, 27);
            this.uiLabel10.TabIndex = 271;
            this.uiLabel10.Text = "通道3";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Chn4
            // 
            this.Lbl_Chn4.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Chn4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Chn4.ForeColor = System.Drawing.Color.White;
            this.Lbl_Chn4.Location = new System.Drawing.Point(113, 582);
            this.Lbl_Chn4.Name = "Lbl_Chn4";
            this.Lbl_Chn4.Size = new System.Drawing.Size(103, 27);
            this.Lbl_Chn4.TabIndex = 274;
            this.Lbl_Chn4.Text = "0.0";
            this.Lbl_Chn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.White;
            this.uiLabel12.Location = new System.Drawing.Point(22, 582);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(85, 27);
            this.uiLabel12.TabIndex = 273;
            this.uiLabel12.Text = "通道4";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LightEView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Lbl_Chn4);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.Lbl_Chn3);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.Lbl_Chn2);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.Btn_Select_Calib_File);
            this.Controls.Add(this.Btn_Select_Config_File);
            this.Controls.Add(this.TB_Calib_File);
            this.Controls.Add(this.TB_Time_Out);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.TB_Config_File);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.TB_Read_Count);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.Btn_Read_Once);
            this.Controls.Add(this.CB_Enabled);
            this.Controls.Add(this.Lbl_Chn1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_SN);
            this.Controls.Add(this.Btn_Connect);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LightEView";
            this.Size = new System.Drawing.Size(496, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_SN;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel Lbl_Chn1;
        private System.Windows.Forms.CheckBox CB_Enabled;
        private Sunny.UI.UIButton Btn_Read_Once;
        private Sunny.UI.UITextBox TB_Time_Out;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox TB_Read_Count;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Calib_File;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox TB_Config_File;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton Btn_Select_Config_File;
        private Sunny.UI.UIButton Btn_Select_Calib_File;
        private Sunny.UI.UILabel Lbl_Chn2;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel Lbl_Chn3;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel Lbl_Chn4;
        private Sunny.UI.UILabel uiLabel12;
    }
}
