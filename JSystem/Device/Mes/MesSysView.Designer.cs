namespace JSystem.Device
{
    partial class MesSysView
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
            this.TB_Product = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.TB_Line = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.TB_Staff = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.TB_Device = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.TB_Lot = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.Btn_Connect = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.CbB_Mes_Type = new Sunny.UI.UIComboBox();
            this.TB_Station = new Sunny.UI.UITextBox();
            this.TB_Port = new Sunny.UI.UITextBox();
            this.TB_IP = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.CB_Enable = new Sunny.UI.UICheckBox();
            this.TB_Version = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.Btn_Arrival = new Sunny.UI.UIButton();
            this.Btn_Departure = new Sunny.UI.UIButton();
            this.TB_SN = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.TB_Log = new Sunny.UI.UITextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Product
            // 
            this.TB_Product.ButtonSymbol = 61761;
            this.TB_Product.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Product.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Product.Location = new System.Drawing.Point(114, 196);
            this.TB_Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Product.Maximum = 2147483647D;
            this.TB_Product.Minimum = -2147483648D;
            this.TB_Product.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Product.Name = "TB_Product";
            this.TB_Product.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Product.Size = new System.Drawing.Size(266, 29);
            this.TB_Product.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Product.TabIndex = 235;
            this.TB_Product.Text = "0";
            this.TB_Product.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Product.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.White;
            this.uiLabel12.Location = new System.Drawing.Point(19, 199);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(88, 23);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.StyleCustomMode = true;
            this.uiLabel12.TabIndex = 234;
            this.uiLabel12.Text = "产品名称";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Line
            // 
            this.TB_Line.ButtonSymbol = 61761;
            this.TB_Line.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Line.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Line.Location = new System.Drawing.Point(114, 266);
            this.TB_Line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Line.Maximum = 2147483647D;
            this.TB_Line.Minimum = -2147483648D;
            this.TB_Line.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Line.Name = "TB_Line";
            this.TB_Line.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Line.Size = new System.Drawing.Size(266, 29);
            this.TB_Line.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Line.TabIndex = 233;
            this.TB_Line.Text = "0";
            this.TB_Line.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Line.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Line.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.ForeColor = System.Drawing.Color.White;
            this.uiLabel11.Location = new System.Drawing.Point(19, 270);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(88, 23);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.StyleCustomMode = true;
            this.uiLabel11.TabIndex = 232;
            this.uiLabel11.Text = "厂线ID";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Staff
            // 
            this.TB_Staff.ButtonSymbol = 61761;
            this.TB_Staff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Staff.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Staff.Location = new System.Drawing.Point(114, 231);
            this.TB_Staff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Staff.Maximum = 2147483647D;
            this.TB_Staff.Minimum = -2147483648D;
            this.TB_Staff.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Staff.Name = "TB_Staff";
            this.TB_Staff.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Staff.Size = new System.Drawing.Size(266, 29);
            this.TB_Staff.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Staff.TabIndex = 229;
            this.TB_Staff.Text = "0";
            this.TB_Staff.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Staff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Staff.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.ForeColor = System.Drawing.Color.White;
            this.uiLabel10.Location = new System.Drawing.Point(19, 235);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(85, 23);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.StyleCustomMode = true;
            this.uiLabel10.TabIndex = 227;
            this.uiLabel10.Text = "员工号";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Device
            // 
            this.TB_Device.ButtonSymbol = 61761;
            this.TB_Device.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Device.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Device.Location = new System.Drawing.Point(114, 161);
            this.TB_Device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Device.Maximum = 2147483647D;
            this.TB_Device.Minimum = -2147483648D;
            this.TB_Device.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Device.Name = "TB_Device";
            this.TB_Device.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Device.Size = new System.Drawing.Size(266, 29);
            this.TB_Device.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Device.TabIndex = 228;
            this.TB_Device.Text = "0";
            this.TB_Device.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Device.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Device.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(19, 165);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(88, 23);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.StyleCustomMode = true;
            this.uiLabel8.TabIndex = 226;
            this.uiLabel8.Text = "设备名称";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Lot
            // 
            this.TB_Lot.ButtonSymbol = 61761;
            this.TB_Lot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Lot.DoubleValue = 1D;
            this.TB_Lot.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Lot.IntValue = 1;
            this.TB_Lot.Location = new System.Drawing.Point(114, 301);
            this.TB_Lot.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Lot.Maximum = 2147483647D;
            this.TB_Lot.Minimum = -2147483648D;
            this.TB_Lot.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Lot.Name = "TB_Lot";
            this.TB_Lot.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Lot.Size = new System.Drawing.Size(266, 29);
            this.TB_Lot.TabIndex = 223;
            this.TB_Lot.Text = "1";
            this.TB_Lot.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Lot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Lot.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(19, 303);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(85, 25);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.StyleCustomMode = true;
            this.uiLabel3.TabIndex = 221;
            this.uiLabel3.Text = "Lot号";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(232, 405);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 224;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(19, 27);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(78, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 222;
            this.uiLabel2.Text = "MES类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Mes_Type
            // 
            this.CbB_Mes_Type.DataSource = null;
            this.CbB_Mes_Type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Mes_Type.FillColor = System.Drawing.Color.White;
            this.CbB_Mes_Type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Mes_Type.Location = new System.Drawing.Point(114, 21);
            this.CbB_Mes_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Mes_Type.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Mes_Type.Name = "CbB_Mes_Type";
            this.CbB_Mes_Type.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Mes_Type.Size = new System.Drawing.Size(266, 29);
            this.CbB_Mes_Type.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Mes_Type.StyleCustomMode = true;
            this.CbB_Mes_Type.TabIndex = 220;
            this.CbB_Mes_Type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CbB_Mes_Type.SelectedIndexChanged += new System.EventHandler(this.CbB_Cam_Type_SelectedIndexChanged);
            // 
            // TB_Station
            // 
            this.TB_Station.ButtonSymbol = 61761;
            this.TB_Station.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Station.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Station.Location = new System.Drawing.Point(114, 126);
            this.TB_Station.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Station.Maximum = 2147483647D;
            this.TB_Station.Minimum = -2147483648D;
            this.TB_Station.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Station.Name = "TB_Station";
            this.TB_Station.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Station.Size = new System.Drawing.Size(266, 29);
            this.TB_Station.TabIndex = 219;
            this.TB_Station.Text = "Test";
            this.TB_Station.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Station.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Station.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_Port
            // 
            this.TB_Port.ButtonSymbol = 61761;
            this.TB_Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Port.DoubleValue = 8898D;
            this.TB_Port.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Port.IntValue = 8898;
            this.TB_Port.Location = new System.Drawing.Point(114, 91);
            this.TB_Port.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Port.Maximum = 2147483647D;
            this.TB_Port.Minimum = -2147483648D;
            this.TB_Port.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Port.Name = "TB_Port";
            this.TB_Port.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Port.Size = new System.Drawing.Size(266, 29);
            this.TB_Port.TabIndex = 218;
            this.TB_Port.Text = "8898";
            this.TB_Port.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Port.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_IP
            // 
            this.TB_IP.ButtonSymbol = 61761;
            this.TB_IP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_IP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_IP.Location = new System.Drawing.Point(114, 56);
            this.TB_IP.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_IP.Maximum = 2147483647D;
            this.TB_IP.Minimum = -2147483648D;
            this.TB_IP.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Padding = new System.Windows.Forms.Padding(7);
            this.TB_IP.Size = new System.Drawing.Size(266, 29);
            this.TB_IP.TabIndex = 217;
            this.TB_IP.Text = "127.0.0.1";
            this.TB_IP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_IP.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.White;
            this.uiLabel9.Location = new System.Drawing.Point(19, 95);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(85, 25);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.StyleCustomMode = true;
            this.uiLabel9.TabIndex = 216;
            this.uiLabel9.Text = "端口号";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(19, 130);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(85, 25);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.StyleCustomMode = true;
            this.uiLabel6.TabIndex = 215;
            this.uiLabel6.Text = "工站名称";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(19, 60);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(85, 25);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 214;
            this.uiLabel1.Text = "IP地址";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_Enable
            // 
            this.CB_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Enable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_Enable.ForeColor = System.Drawing.Color.White;
            this.CB_Enable.Location = new System.Drawing.Point(27, 411);
            this.CB_Enable.MinimumSize = new System.Drawing.Size(1, 1);
            this.CB_Enable.Name = "CB_Enable";
            this.CB_Enable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.CB_Enable.Size = new System.Drawing.Size(103, 29);
            this.CB_Enable.Style = Sunny.UI.UIStyle.Custom;
            this.CB_Enable.TabIndex = 236;
            this.CB_Enable.Text = "是否启用";
            this.CB_Enable.CheckedChanged += new System.EventHandler(this.CB_Enable_CheckedChanged);
            // 
            // TB_Version
            // 
            this.TB_Version.ButtonSymbol = 61761;
            this.TB_Version.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Version.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Version.Location = new System.Drawing.Point(114, 336);
            this.TB_Version.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Version.Maximum = 2147483647D;
            this.TB_Version.Minimum = -2147483648D;
            this.TB_Version.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Version.Name = "TB_Version";
            this.TB_Version.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Version.Size = new System.Drawing.Size(266, 29);
            this.TB_Version.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Version.TabIndex = 237;
            this.TB_Version.Text = "1.0.0";
            this.TB_Version.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Version.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Version.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(19, 339);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(88, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.StyleCustomMode = true;
            this.uiLabel4.TabIndex = 236;
            this.uiLabel4.Text = "版本号";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Arrival
            // 
            this.Btn_Arrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Arrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Arrival.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Arrival.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Arrival.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Arrival.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Arrival.Location = new System.Drawing.Point(106, 79);
            this.Btn_Arrival.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Arrival.Name = "Btn_Arrival";
            this.Btn_Arrival.RectColor = System.Drawing.Color.White;
            this.Btn_Arrival.Size = new System.Drawing.Size(86, 29);
            this.Btn_Arrival.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Arrival.StyleCustomMode = true;
            this.Btn_Arrival.TabIndex = 238;
            this.Btn_Arrival.Text = "进站";
            this.Btn_Arrival.Click += new System.EventHandler(this.Btn_Arrival_Click);
            // 
            // Btn_Departure
            // 
            this.Btn_Departure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Departure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Departure.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Departure.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Departure.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Departure.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Departure.Location = new System.Drawing.Point(231, 79);
            this.Btn_Departure.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Departure.Name = "Btn_Departure";
            this.Btn_Departure.RectColor = System.Drawing.Color.White;
            this.Btn_Departure.Size = new System.Drawing.Size(86, 29);
            this.Btn_Departure.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Departure.StyleCustomMode = true;
            this.Btn_Departure.TabIndex = 239;
            this.Btn_Departure.Text = "出站";
            this.Btn_Departure.Click += new System.EventHandler(this.Btn_Departure_Click);
            // 
            // TB_SN
            // 
            this.TB_SN.ButtonSymbol = 61761;
            this.TB_SN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SN.DoubleValue = 123456789D;
            this.TB_SN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_SN.IntValue = 123456789;
            this.TB_SN.Location = new System.Drawing.Point(74, 29);
            this.TB_SN.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_SN.Maximum = 2147483647D;
            this.TB_SN.Minimum = -2147483648D;
            this.TB_SN.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_SN.Name = "TB_SN";
            this.TB_SN.Padding = new System.Windows.Forms.Padding(7);
            this.TB_SN.Size = new System.Drawing.Size(308, 29);
            this.TB_SN.TabIndex = 218;
            this.TB_SN.Text = "123456789";
            this.TB_SN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(29, 32);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(37, 23);
            this.uiLabel5.TabIndex = 240;
            this.uiLabel5.Text = "SN";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.uiLabel7);
            this.groupBox1.Controls.Add(this.TB_Log);
            this.groupBox1.Controls.Add(this.TB_SN);
            this.groupBox1.Controls.Add(this.uiLabel5);
            this.groupBox1.Controls.Add(this.Btn_Arrival);
            this.groupBox1.Controls.Add(this.Btn_Departure);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(444, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 705);
            this.groupBox1.TabIndex = 241;
            this.groupBox1.TabStop = false;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(6, 140);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(47, 23);
            this.uiLabel7.TabIndex = 242;
            this.uiLabel7.Text = "返回";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.TB_Log.Location = new System.Drawing.Point(7, 175);
            this.TB_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Log.Maximum = 10D;
            this.TB_Log.MaxLength = 1;
            this.TB_Log.Minimum = -2147483648D;
            this.TB_Log.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Log.Multiline = true;
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.ReadOnly = true;
            this.TB_Log.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_Log.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_Log.ShowScrollBar = true;
            this.TB_Log.Size = new System.Drawing.Size(388, 522);
            this.TB_Log.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Log.StyleCustomMode = true;
            this.TB_Log.TabIndex = 241;
            this.TB_Log.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MesSysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_Version);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.CB_Enable);
            this.Controls.Add(this.TB_Product);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.TB_Line);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.TB_Staff);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.TB_Device);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.TB_Lot);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_Mes_Type);
            this.Controls.Add(this.TB_Station);
            this.Controls.Add(this.TB_Port);
            this.Controls.Add(this.TB_IP);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MesSysView";
            this.Size = new System.Drawing.Size(913, 744);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox TB_Product;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox TB_Line;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox TB_Staff;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox TB_Device;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox TB_Lot;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Mes_Type;
        private Sunny.UI.UITextBox TB_Station;
        private Sunny.UI.UITextBox TB_Port;
        private Sunny.UI.UITextBox TB_IP;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TB_Version;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton Btn_Arrival;
        private Sunny.UI.UIButton Btn_Departure;
        private Sunny.UI.UITextBox TB_SN;
        private Sunny.UI.UILabel uiLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox TB_Log;
        public Sunny.UI.UICheckBox CB_Enable;
    }
}
