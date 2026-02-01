namespace JSystem.Device
{
    partial class ModbusTcpView
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
            this.TB_Read_Coils_Addr = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Read_Coils = new Sunny.UI.UIButton();
            this.Lbl_Coils_Value = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.TB_Read_Coils_Count = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Read_HRs = new Sunny.UI.UIButton();
            this.Lbl_HRs_Value = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.TB_Read_HRs_Count = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.TB_Read_HRs_Addr = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Write_HRs = new Sunny.UI.UIButton();
            this.TB_Write_HRs_Data = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.TB_Write_HRs_Addr = new Sunny.UI.UITextBox();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Write_Coils = new Sunny.UI.UIButton();
            this.TB_Write_Coils_Data = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.TB_Write_Coils_Addr = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TB_Slave_Addr = new Sunny.UI.UITextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Read_Coils_Addr
            // 
            this.TB_Read_Coils_Addr.ButtonSymbol = 61761;
            this.TB_Read_Coils_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_Coils_Addr.DoubleValue = 1D;
            this.TB_Read_Coils_Addr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_Coils_Addr.IntValue = 1;
            this.TB_Read_Coils_Addr.Location = new System.Drawing.Point(71, 29);
            this.TB_Read_Coils_Addr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_Coils_Addr.Maximum = 2147483647D;
            this.TB_Read_Coils_Addr.Minimum = -2147483648D;
            this.TB_Read_Coils_Addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_Coils_Addr.Name = "TB_Read_Coils_Addr";
            this.TB_Read_Coils_Addr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_Coils_Addr.Size = new System.Drawing.Size(86, 29);
            this.TB_Read_Coils_Addr.TabIndex = 237;
            this.TB_Read_Coils_Addr.Text = "1";
            this.TB_Read_Coils_Addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(7, 33);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(56, 25);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 236;
            this.uiLabel2.Text = "地址";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Read_Coils);
            this.groupBox1.Controls.Add(this.Lbl_Coils_Value);
            this.groupBox1.Controls.Add(this.uiLabel4);
            this.groupBox1.Controls.Add(this.TB_Read_Coils_Count);
            this.groupBox1.Controls.Add(this.uiLabel3);
            this.groupBox1.Controls.Add(this.TB_Read_Coils_Addr);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 238;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读多个线圈（01）";
            // 
            // Btn_Read_Coils
            // 
            this.Btn_Read_Coils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Read_Coils.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read_Coils.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read_Coils.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Read_Coils.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Read_Coils.Location = new System.Drawing.Point(262, 68);
            this.Btn_Read_Coils.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Read_Coils.Name = "Btn_Read_Coils";
            this.Btn_Read_Coils.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read_Coils.Size = new System.Drawing.Size(66, 26);
            this.Btn_Read_Coils.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Read_Coils.StyleCustomMode = true;
            this.Btn_Read_Coils.TabIndex = 239;
            this.Btn_Read_Coils.Text = "读取";
            this.Btn_Read_Coils.Click += new System.EventHandler(this.Btn_Read_Coils_Click);
            // 
            // Lbl_Coils_Value
            // 
            this.Lbl_Coils_Value.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Coils_Value.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Coils_Value.Location = new System.Drawing.Point(85, 69);
            this.Lbl_Coils_Value.Name = "Lbl_Coils_Value";
            this.Lbl_Coils_Value.Size = new System.Drawing.Size(157, 25);
            this.Lbl_Coils_Value.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Coils_Value.TabIndex = 241;
            this.Lbl_Coils_Value.Text = "00";
            this.Lbl_Coils_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(7, 69);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(60, 25);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 240;
            this.uiLabel4.Text = "当前值";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_Coils_Count
            // 
            this.TB_Read_Coils_Count.ButtonSymbol = 61761;
            this.TB_Read_Coils_Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_Coils_Count.DoubleValue = 1D;
            this.TB_Read_Coils_Count.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_Coils_Count.IntValue = 1;
            this.TB_Read_Coils_Count.Location = new System.Drawing.Point(242, 29);
            this.TB_Read_Coils_Count.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_Coils_Count.Maximum = 2147483647D;
            this.TB_Read_Coils_Count.Minimum = -2147483648D;
            this.TB_Read_Coils_Count.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_Coils_Count.Name = "TB_Read_Coils_Count";
            this.TB_Read_Coils_Count.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_Coils_Count.Size = new System.Drawing.Size(86, 29);
            this.TB_Read_Coils_Count.TabIndex = 239;
            this.TB_Read_Coils_Count.Text = "1";
            this.TB_Read_Coils_Count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(178, 33);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(56, 25);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 238;
            this.uiLabel3.Text = "个数";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Read_HRs);
            this.groupBox2.Controls.Add(this.Lbl_HRs_Value);
            this.groupBox2.Controls.Add(this.uiLabel8);
            this.groupBox2.Controls.Add(this.TB_Read_HRs_Count);
            this.groupBox2.Controls.Add(this.uiLabel9);
            this.groupBox2.Controls.Add(this.TB_Read_HRs_Addr);
            this.groupBox2.Controls.Add(this.uiLabel10);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 100);
            this.groupBox2.TabIndex = 242;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读多个保存寄存器（03）";
            // 
            // Btn_Read_HRs
            // 
            this.Btn_Read_HRs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Read_HRs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read_HRs.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read_HRs.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Read_HRs.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Read_HRs.Location = new System.Drawing.Point(262, 68);
            this.Btn_Read_HRs.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Read_HRs.Name = "Btn_Read_HRs";
            this.Btn_Read_HRs.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read_HRs.Size = new System.Drawing.Size(66, 26);
            this.Btn_Read_HRs.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Read_HRs.StyleCustomMode = true;
            this.Btn_Read_HRs.TabIndex = 239;
            this.Btn_Read_HRs.Text = "读取";
            this.Btn_Read_HRs.Click += new System.EventHandler(this.Btn_Read_HRs_Click);
            // 
            // Lbl_HRs_Value
            // 
            this.Lbl_HRs_Value.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_HRs_Value.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_HRs_Value.Location = new System.Drawing.Point(85, 69);
            this.Lbl_HRs_Value.Name = "Lbl_HRs_Value";
            this.Lbl_HRs_Value.Size = new System.Drawing.Size(157, 25);
            this.Lbl_HRs_Value.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_HRs_Value.TabIndex = 241;
            this.Lbl_HRs_Value.Text = "0000";
            this.Lbl_HRs_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(7, 69);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(60, 25);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 240;
            this.uiLabel8.Text = "当前值";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_HRs_Count
            // 
            this.TB_Read_HRs_Count.ButtonSymbol = 61761;
            this.TB_Read_HRs_Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_HRs_Count.DoubleValue = 1D;
            this.TB_Read_HRs_Count.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_HRs_Count.IntValue = 1;
            this.TB_Read_HRs_Count.Location = new System.Drawing.Point(242, 29);
            this.TB_Read_HRs_Count.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_HRs_Count.Maximum = 2147483647D;
            this.TB_Read_HRs_Count.Minimum = -2147483648D;
            this.TB_Read_HRs_Count.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_HRs_Count.Name = "TB_Read_HRs_Count";
            this.TB_Read_HRs_Count.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_HRs_Count.Size = new System.Drawing.Size(86, 29);
            this.TB_Read_HRs_Count.TabIndex = 239;
            this.TB_Read_HRs_Count.Text = "1";
            this.TB_Read_HRs_Count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.White;
            this.uiLabel9.Location = new System.Drawing.Point(178, 33);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(56, 25);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 238;
            this.uiLabel9.Text = "个数";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_HRs_Addr
            // 
            this.TB_Read_HRs_Addr.ButtonSymbol = 61761;
            this.TB_Read_HRs_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_HRs_Addr.DoubleValue = 1D;
            this.TB_Read_HRs_Addr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_HRs_Addr.IntValue = 1;
            this.TB_Read_HRs_Addr.Location = new System.Drawing.Point(71, 29);
            this.TB_Read_HRs_Addr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_HRs_Addr.Maximum = 2147483647D;
            this.TB_Read_HRs_Addr.Minimum = -2147483648D;
            this.TB_Read_HRs_Addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_HRs_Addr.Name = "TB_Read_HRs_Addr";
            this.TB_Read_HRs_Addr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_HRs_Addr.Size = new System.Drawing.Size(86, 29);
            this.TB_Read_HRs_Addr.TabIndex = 237;
            this.TB_Read_HRs_Addr.Text = "1";
            this.TB_Read_HRs_Addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.ForeColor = System.Drawing.Color.White;
            this.uiLabel10.Location = new System.Drawing.Point(7, 33);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(56, 25);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 236;
            this.uiLabel10.Text = "地址";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Write_HRs);
            this.groupBox3.Controls.Add(this.TB_Write_HRs_Data);
            this.groupBox3.Controls.Add(this.uiLabel12);
            this.groupBox3.Controls.Add(this.TB_Write_HRs_Addr);
            this.groupBox3.Controls.Add(this.uiLabel13);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(23, 628);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 100);
            this.groupBox3.TabIndex = 243;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "写多个保存寄存器（10）";
            // 
            // Btn_Write_HRs
            // 
            this.Btn_Write_HRs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Write_HRs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Write_HRs.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Write_HRs.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Write_HRs.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Write_HRs.Location = new System.Drawing.Point(262, 67);
            this.Btn_Write_HRs.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Write_HRs.Name = "Btn_Write_HRs";
            this.Btn_Write_HRs.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Write_HRs.Size = new System.Drawing.Size(66, 26);
            this.Btn_Write_HRs.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Write_HRs.StyleCustomMode = true;
            this.Btn_Write_HRs.TabIndex = 239;
            this.Btn_Write_HRs.Text = "写入";
            this.Btn_Write_HRs.Click += new System.EventHandler(this.Btn_Write_HRs_Click);
            // 
            // TB_Write_HRs_Data
            // 
            this.TB_Write_HRs_Data.ButtonSymbol = 61761;
            this.TB_Write_HRs_Data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Write_HRs_Data.DoubleValue = 1D;
            this.TB_Write_HRs_Data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Write_HRs_Data.IntValue = 1;
            this.TB_Write_HRs_Data.Location = new System.Drawing.Point(71, 29);
            this.TB_Write_HRs_Data.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_HRs_Data.Maximum = 2147483647D;
            this.TB_Write_HRs_Data.Minimum = -2147483648D;
            this.TB_Write_HRs_Data.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_HRs_Data.Name = "TB_Write_HRs_Data";
            this.TB_Write_HRs_Data.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_HRs_Data.Size = new System.Drawing.Size(257, 29);
            this.TB_Write_HRs_Data.TabIndex = 239;
            this.TB_Write_HRs_Data.Text = "0001";
            this.TB_Write_HRs_Data.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.White;
            this.uiLabel12.Location = new System.Drawing.Point(7, 33);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(56, 25);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 238;
            this.uiLabel12.Text = "数据";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Write_HRs_Addr
            // 
            this.TB_Write_HRs_Addr.ButtonSymbol = 61761;
            this.TB_Write_HRs_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Write_HRs_Addr.DoubleValue = 1D;
            this.TB_Write_HRs_Addr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Write_HRs_Addr.IntValue = 1;
            this.TB_Write_HRs_Addr.Location = new System.Drawing.Point(71, 64);
            this.TB_Write_HRs_Addr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_HRs_Addr.Maximum = 2147483647D;
            this.TB_Write_HRs_Addr.Minimum = -2147483648D;
            this.TB_Write_HRs_Addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_HRs_Addr.Name = "TB_Write_HRs_Addr";
            this.TB_Write_HRs_Addr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_HRs_Addr.Size = new System.Drawing.Size(86, 29);
            this.TB_Write_HRs_Addr.TabIndex = 237;
            this.TB_Write_HRs_Addr.Text = "1";
            this.TB_Write_HRs_Addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel13
            // 
            this.uiLabel13.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel13.ForeColor = System.Drawing.Color.White;
            this.uiLabel13.Location = new System.Drawing.Point(7, 68);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(56, 25);
            this.uiLabel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel13.TabIndex = 236;
            this.uiLabel13.Text = "地址";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Write_Coils);
            this.groupBox4.Controls.Add(this.TB_Write_Coils_Data);
            this.groupBox4.Controls.Add(this.uiLabel7);
            this.groupBox4.Controls.Add(this.TB_Write_Coils_Addr);
            this.groupBox4.Controls.Add(this.uiLabel11);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(23, 392);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 100);
            this.groupBox4.TabIndex = 244;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "写多个线圈（0F）";
            // 
            // Btn_Write_Coils
            // 
            this.Btn_Write_Coils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Write_Coils.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Write_Coils.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Write_Coils.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Write_Coils.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Write_Coils.Location = new System.Drawing.Point(262, 67);
            this.Btn_Write_Coils.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Write_Coils.Name = "Btn_Write_Coils";
            this.Btn_Write_Coils.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Write_Coils.Size = new System.Drawing.Size(66, 26);
            this.Btn_Write_Coils.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Write_Coils.StyleCustomMode = true;
            this.Btn_Write_Coils.TabIndex = 239;
            this.Btn_Write_Coils.Text = "写入";
            this.Btn_Write_Coils.Click += new System.EventHandler(this.Btn_Write_Coils_Click);
            // 
            // TB_Write_Coils_Data
            // 
            this.TB_Write_Coils_Data.ButtonSymbol = 61761;
            this.TB_Write_Coils_Data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Write_Coils_Data.DoubleValue = 1D;
            this.TB_Write_Coils_Data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Write_Coils_Data.IntValue = 1;
            this.TB_Write_Coils_Data.Location = new System.Drawing.Point(71, 29);
            this.TB_Write_Coils_Data.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_Coils_Data.Maximum = 2147483647D;
            this.TB_Write_Coils_Data.Minimum = -2147483648D;
            this.TB_Write_Coils_Data.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_Coils_Data.Name = "TB_Write_Coils_Data";
            this.TB_Write_Coils_Data.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_Coils_Data.Size = new System.Drawing.Size(257, 29);
            this.TB_Write_Coils_Data.TabIndex = 239;
            this.TB_Write_Coils_Data.Text = "01";
            this.TB_Write_Coils_Data.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.White;
            this.uiLabel7.Location = new System.Drawing.Point(7, 33);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(56, 25);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 238;
            this.uiLabel7.Text = "数据";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Write_Coils_Addr
            // 
            this.TB_Write_Coils_Addr.ButtonSymbol = 61761;
            this.TB_Write_Coils_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Write_Coils_Addr.DoubleValue = 1D;
            this.TB_Write_Coils_Addr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Write_Coils_Addr.IntValue = 1;
            this.TB_Write_Coils_Addr.Location = new System.Drawing.Point(71, 64);
            this.TB_Write_Coils_Addr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_Coils_Addr.Maximum = 2147483647D;
            this.TB_Write_Coils_Addr.Minimum = -2147483648D;
            this.TB_Write_Coils_Addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_Coils_Addr.Name = "TB_Write_Coils_Addr";
            this.TB_Write_Coils_Addr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_Coils_Addr.Size = new System.Drawing.Size(86, 29);
            this.TB_Write_Coils_Addr.TabIndex = 237;
            this.TB_Write_Coils_Addr.Text = "1";
            this.TB_Write_Coils_Addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.ForeColor = System.Drawing.Color.White;
            this.uiLabel11.Location = new System.Drawing.Point(7, 68);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(56, 25);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 236;
            this.uiLabel11.Text = "地址";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(19, 226);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(81, 25);
            this.uiLabel1.TabIndex = 234;
            this.uiLabel1.Text = "Slave地址";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Slave_Addr
            // 
            this.TB_Slave_Addr.ButtonSymbol = 61761;
            this.TB_Slave_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Slave_Addr.DoubleValue = 1D;
            this.TB_Slave_Addr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Slave_Addr.IntValue = 1;
            this.TB_Slave_Addr.Location = new System.Drawing.Point(108, 224);
            this.TB_Slave_Addr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Slave_Addr.Maximum = 2147483647D;
            this.TB_Slave_Addr.Minimum = -2147483648D;
            this.TB_Slave_Addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Slave_Addr.Name = "TB_Slave_Addr";
            this.TB_Slave_Addr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Slave_Addr.Size = new System.Drawing.Size(260, 29);
            this.TB_Slave_Addr.TabIndex = 235;
            this.TB_Slave_Addr.Text = "1";
            this.TB_Slave_Addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModbusTcpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_Slave_Addr);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ModbusTcpView";
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.TB_Slave_Addr, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox TB_Read_Coils_Addr;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UILabel Lbl_Coils_Value;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox TB_Read_Coils_Count;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton Btn_Read_Coils;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIButton Btn_Read_HRs;
        private Sunny.UI.UILabel Lbl_HRs_Value;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox TB_Read_HRs_Count;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox TB_Read_HRs_Addr;
        private Sunny.UI.UILabel uiLabel10;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UIButton Btn_Write_HRs;
        private Sunny.UI.UITextBox TB_Write_HRs_Addr;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UITextBox TB_Write_HRs_Data;
        private Sunny.UI.UILabel uiLabel12;
        private System.Windows.Forms.GroupBox groupBox4;
        private Sunny.UI.UIButton Btn_Write_Coils;
        private Sunny.UI.UITextBox TB_Write_Coils_Data;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox TB_Write_Coils_Addr;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TB_Slave_Addr;
    }
}
