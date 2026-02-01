namespace JSystem.Device
{
    partial class Cam3DView
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
            this.CbB_Cam_Name = new Sunny.UI.UIComboBox();
            this.TB_Trigger_Interval = new Sunny.UI.UITextBox();
            this.TB_Port = new Sunny.UI.UITextBox();
            this.TB_IP = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TB_Valiad_Width = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.TB_Config_Path = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.Btn_Export_Config = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.CB_Enable = new Sunny.UI.UICheckBox();
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
            this.Btn_Connect.Location = new System.Drawing.Point(140, 278);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 176;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(18, 27);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(94, 23);
            this.uiLabel2.TabIndex = 175;
            this.uiLabel2.Text = "相机类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Cam_Name
            // 
            this.CbB_Cam_Name.DataSource = null;
            this.CbB_Cam_Name.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Cam_Name.FillColor = System.Drawing.Color.White;
            this.CbB_Cam_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Cam_Name.Location = new System.Drawing.Point(132, 21);
            this.CbB_Cam_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Cam_Name.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Cam_Name.Name = "CbB_Cam_Name";
            this.CbB_Cam_Name.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Cam_Name.Size = new System.Drawing.Size(266, 29);
            this.CbB_Cam_Name.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Cam_Name.StyleCustomMode = true;
            this.CbB_Cam_Name.TabIndex = 174;
            this.CbB_Cam_Name.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.CbB_Cam_Name.SelectedIndexChanged += new System.EventHandler(this.CbB_Cam_Type_SelectedIndexChanged);
            // 
            // TB_Trigger_Interval
            // 
            this.TB_Trigger_Interval.ButtonSymbol = 61761;
            this.TB_Trigger_Interval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Trigger_Interval.DoubleValue = 0.01D;
            this.TB_Trigger_Interval.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Trigger_Interval.Location = new System.Drawing.Point(132, 123);
            this.TB_Trigger_Interval.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Trigger_Interval.Maximum = 2147483647D;
            this.TB_Trigger_Interval.Minimum = -2147483648D;
            this.TB_Trigger_Interval.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Trigger_Interval.Name = "TB_Trigger_Interval";
            this.TB_Trigger_Interval.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Trigger_Interval.Size = new System.Drawing.Size(266, 29);
            this.TB_Trigger_Interval.TabIndex = 173;
            this.TB_Trigger_Interval.Text = "0.01";
            this.TB_Trigger_Interval.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Trigger_Interval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Trigger_Interval.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_Port
            // 
            this.TB_Port.ButtonSymbol = 61761;
            this.TB_Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Port.DoubleValue = 8898D;
            this.TB_Port.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Port.IntValue = 8898;
            this.TB_Port.Location = new System.Drawing.Point(132, 89);
            this.TB_Port.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Port.Maximum = 2147483647D;
            this.TB_Port.Minimum = -2147483648D;
            this.TB_Port.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Port.Name = "TB_Port";
            this.TB_Port.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Port.Size = new System.Drawing.Size(266, 29);
            this.TB_Port.TabIndex = 172;
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
            this.TB_IP.Location = new System.Drawing.Point(132, 55);
            this.TB_IP.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_IP.Maximum = 2147483647D;
            this.TB_IP.Minimum = -2147483648D;
            this.TB_IP.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Padding = new System.Windows.Forms.Padding(7);
            this.TB_IP.Size = new System.Drawing.Size(266, 29);
            this.TB_IP.TabIndex = 171;
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
            this.uiLabel9.Location = new System.Drawing.Point(18, 93);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(94, 25);
            this.uiLabel9.TabIndex = 170;
            this.uiLabel9.Text = "端口号";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(18, 127);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(94, 25);
            this.uiLabel6.TabIndex = 169;
            this.uiLabel6.Text = "触发间隔";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(18, 59);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(94, 25);
            this.uiLabel1.TabIndex = 168;
            this.uiLabel1.Text = "IP地址";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Valiad_Width
            // 
            this.TB_Valiad_Width.ButtonSymbol = 61761;
            this.TB_Valiad_Width.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Valiad_Width.DoubleValue = 30D;
            this.TB_Valiad_Width.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Valiad_Width.IntValue = 30;
            this.TB_Valiad_Width.Location = new System.Drawing.Point(132, 157);
            this.TB_Valiad_Width.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Valiad_Width.Maximum = 2147483647D;
            this.TB_Valiad_Width.Minimum = -2147483648D;
            this.TB_Valiad_Width.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Valiad_Width.Name = "TB_Valiad_Width";
            this.TB_Valiad_Width.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Valiad_Width.Size = new System.Drawing.Size(266, 29);
            this.TB_Valiad_Width.TabIndex = 175;
            this.TB_Valiad_Width.Text = "30";
            this.TB_Valiad_Width.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Valiad_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Valiad_Width.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(18, 161);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(94, 25);
            this.uiLabel3.TabIndex = 174;
            this.uiLabel3.Text = "有效线宽";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Config_Path
            // 
            this.TB_Config_Path.ButtonSymbol = 61761;
            this.TB_Config_Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Config_Path.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Config_Path.Location = new System.Drawing.Point(132, 196);
            this.TB_Config_Path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Config_Path.Maximum = 2147483647D;
            this.TB_Config_Path.Minimum = -2147483648D;
            this.TB_Config_Path.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Config_Path.Name = "TB_Config_Path";
            this.TB_Config_Path.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Config_Path.Size = new System.Drawing.Size(266, 29);
            this.TB_Config_Path.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Config_Path.TabIndex = 209;
            this.TB_Config_Path.Text = "0";
            this.TB_Config_Path.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Config_Path.DoubleClick += new System.EventHandler(this.TB_Config_Path_DoubleClick);
            this.TB_Config_Path.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Config_Path.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.White;
            this.uiLabel7.Location = new System.Drawing.Point(17, 200);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(94, 23);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 208;
            this.uiLabel7.Text = "配置文件";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Export_Config
            // 
            this.Btn_Export_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Export_Config.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Export_Config.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Export_Config.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Export_Config.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Export_Config.Location = new System.Drawing.Point(281, 278);
            this.Btn_Export_Config.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Export_Config.Name = "Btn_Export_Config";
            this.Btn_Export_Config.RectColor = System.Drawing.Color.White;
            this.Btn_Export_Config.Size = new System.Drawing.Size(100, 40);
            this.Btn_Export_Config.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Export_Config.StyleCustomMode = true;
            this.Btn_Export_Config.TabIndex = 210;
            this.Btn_Export_Config.Text = "导出配置";
            this.Btn_Export_Config.Click += new System.EventHandler(this.Btn_Export_Config_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(414, 196);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.uiButton1.Size = new System.Drawing.Size(80, 29);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.StyleCustomMode = true;
            this.uiButton1.TabIndex = 214;
            this.uiButton1.Text = "浏览";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // CB_Enable
            // 
            this.CB_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Enable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_Enable.ForeColor = System.Drawing.Color.White;
            this.CB_Enable.Location = new System.Drawing.Point(22, 289);
            this.CB_Enable.MinimumSize = new System.Drawing.Size(1, 1);
            this.CB_Enable.Name = "CB_Enable";
            this.CB_Enable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.CB_Enable.Size = new System.Drawing.Size(103, 29);
            this.CB_Enable.Style = Sunny.UI.UIStyle.Custom;
            this.CB_Enable.TabIndex = 237;
            this.CB_Enable.Text = "是否启用";
            this.CB_Enable.CheckedChanged += new System.EventHandler(this.CB_Enable_CheckedChanged);
            // 
            // Cam3DView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.CB_Enable);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.Btn_Export_Config);
            this.Controls.Add(this.TB_Config_Path);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.TB_Valiad_Width);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_Cam_Name);
            this.Controls.Add(this.TB_Trigger_Interval);
            this.Controls.Add(this.TB_Port);
            this.Controls.Add(this.TB_IP);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cam3DView";
            this.Size = new System.Drawing.Size(523, 800);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Cam_Name;
        private Sunny.UI.UITextBox TB_Trigger_Interval;
        private Sunny.UI.UITextBox TB_Port;
        private Sunny.UI.UITextBox TB_IP;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TB_Valiad_Width;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox TB_Config_Path;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIButton Btn_Export_Config;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UICheckBox CB_Enable;
    }
}
