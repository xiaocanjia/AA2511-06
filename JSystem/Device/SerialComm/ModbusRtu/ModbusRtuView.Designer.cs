namespace JSystem.Device
{
    partial class ModbusRtuView
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Write_Coils = new Sunny.UI.UIButton();
            this.TB_Write_Coils_Data = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.TB_Write_Coils_Addr = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Write_HRs = new Sunny.UI.UIButton();
            this.TB_Write_HRs_Data = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.TB_Write_HRs_Addr = new Sunny.UI.UITextBox();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Read_HRs = new Sunny.UI.UIButton();
            this.Lbl_HRs_Value = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.TB_Read_HRs_Count = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Read_HRs_Addr = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Read_Coils = new Sunny.UI.UIButton();
            this.Lbl_Coils_Value = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.TB_Read_Coils_Count = new Sunny.UI.UITextBox();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.TB_Read_Coils_Addr = new Sunny.UI.UITextBox();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.TB_Read_Coils_SAddr = new Sunny.UI.UITextBox();
            this.TB_Write_Coils_SAddr = new Sunny.UI.UITextBox();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.TB_Read_HRs_SAddr = new Sunny.UI.UITextBox();
            this.uiLabel18 = new Sunny.UI.UILabel();
            this.TB_Write_HRs_SAddr = new Sunny.UI.UITextBox();
            this.uiLabel19 = new Sunny.UI.UILabel();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TB_Write_Coils_SAddr);
            this.groupBox4.Controls.Add(this.uiLabel17);
            this.groupBox4.Controls.Add(this.Btn_Write_Coils);
            this.groupBox4.Controls.Add(this.TB_Write_Coils_Data);
            this.groupBox4.Controls.Add(this.uiLabel7);
            this.groupBox4.Controls.Add(this.TB_Write_Coils_Addr);
            this.groupBox4.Controls.Add(this.uiLabel11);
            this.groupBox4.Location = new System.Drawing.Point(14, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 100);
            this.groupBox4.TabIndex = 250;
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
            this.TB_Write_Coils_Data.Location = new System.Drawing.Point(64, 29);
            this.TB_Write_Coils_Data.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_Coils_Data.Maximum = 2147483647D;
            this.TB_Write_Coils_Data.Minimum = -2147483648D;
            this.TB_Write_Coils_Data.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_Coils_Data.Name = "TB_Write_Coils_Data";
            this.TB_Write_Coils_Data.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_Coils_Data.Size = new System.Drawing.Size(86, 29);
            this.TB_Write_Coils_Data.TabIndex = 239;
            this.TB_Write_Coils_Data.Text = "01";
            this.TB_Write_Coils_Data.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(7, 33);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(56, 25);
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
            this.TB_Write_Coils_Addr.Location = new System.Drawing.Point(242, 29);
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
            this.uiLabel11.Location = new System.Drawing.Point(185, 33);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(56, 25);
            this.uiLabel11.TabIndex = 236;
            this.uiLabel11.Text = "地址";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_Write_HRs_SAddr);
            this.groupBox3.Controls.Add(this.uiLabel19);
            this.groupBox3.Controls.Add(this.Btn_Write_HRs);
            this.groupBox3.Controls.Add(this.TB_Write_HRs_Data);
            this.groupBox3.Controls.Add(this.uiLabel12);
            this.groupBox3.Controls.Add(this.TB_Write_HRs_Addr);
            this.groupBox3.Controls.Add(this.uiLabel13);
            this.groupBox3.Location = new System.Drawing.Point(14, 648);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 100);
            this.groupBox3.TabIndex = 249;
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
            this.TB_Write_HRs_Data.Size = new System.Drawing.Size(86, 29);
            this.TB_Write_HRs_Data.TabIndex = 239;
            this.TB_Write_HRs_Data.Text = "0001";
            this.TB_Write_HRs_Data.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(7, 33);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(56, 25);
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
            this.TB_Write_HRs_Addr.Location = new System.Drawing.Point(242, 29);
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
            this.uiLabel13.Location = new System.Drawing.Point(178, 33);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(56, 25);
            this.uiLabel13.TabIndex = 236;
            this.uiLabel13.Text = "地址";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_Read_HRs_SAddr);
            this.groupBox2.Controls.Add(this.uiLabel18);
            this.groupBox2.Controls.Add(this.Btn_Read_HRs);
            this.groupBox2.Controls.Add(this.Lbl_HRs_Value);
            this.groupBox2.Controls.Add(this.uiLabel8);
            this.groupBox2.Controls.Add(this.TB_Read_HRs_Count);
            this.groupBox2.Controls.Add(this.uiLabel5);
            this.groupBox2.Controls.Add(this.TB_Read_HRs_Addr);
            this.groupBox2.Controls.Add(this.uiLabel10);
            this.groupBox2.Location = new System.Drawing.Point(14, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 100);
            this.groupBox2.TabIndex = 248;
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
            this.Btn_Read_HRs.Location = new System.Drawing.Point(265, 31);
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
            this.Lbl_HRs_Value.Location = new System.Drawing.Point(223, 66);
            this.Lbl_HRs_Value.Name = "Lbl_HRs_Value";
            this.Lbl_HRs_Value.Size = new System.Drawing.Size(113, 25);
            this.Lbl_HRs_Value.TabIndex = 241;
            this.Lbl_HRs_Value.Text = "00 00";
            this.Lbl_HRs_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(164, 66);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(60, 25);
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
            this.TB_Read_HRs_Count.Location = new System.Drawing.Point(176, 29);
            this.TB_Read_HRs_Count.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_HRs_Count.Maximum = 2147483647D;
            this.TB_Read_HRs_Count.Minimum = -2147483648D;
            this.TB_Read_HRs_Count.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_HRs_Count.Name = "TB_Read_HRs_Count";
            this.TB_Read_HRs_Count.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_HRs_Count.Size = new System.Drawing.Size(61, 29);
            this.TB_Read_HRs_Count.TabIndex = 239;
            this.TB_Read_HRs_Count.Text = "1";
            this.TB_Read_HRs_Count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(123, 33);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(56, 25);
            this.uiLabel5.TabIndex = 238;
            this.uiLabel5.Text = "个数";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_HRs_Addr
            // 
            this.TB_Read_HRs_Addr.ButtonSymbol = 61761;
            this.TB_Read_HRs_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_HRs_Addr.DoubleValue = 1D;
            this.TB_Read_HRs_Addr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_HRs_Addr.IntValue = 1;
            this.TB_Read_HRs_Addr.Location = new System.Drawing.Point(54, 29);
            this.TB_Read_HRs_Addr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_HRs_Addr.Maximum = 2147483647D;
            this.TB_Read_HRs_Addr.Minimum = -2147483648D;
            this.TB_Read_HRs_Addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_HRs_Addr.Name = "TB_Read_HRs_Addr";
            this.TB_Read_HRs_Addr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_HRs_Addr.Size = new System.Drawing.Size(61, 29);
            this.TB_Read_HRs_Addr.TabIndex = 237;
            this.TB_Read_HRs_Addr.Text = "1";
            this.TB_Read_HRs_Addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(7, 33);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(56, 25);
            this.uiLabel10.TabIndex = 236;
            this.uiLabel10.Text = "地址";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Read_Coils);
            this.groupBox1.Controls.Add(this.Lbl_Coils_Value);
            this.groupBox1.Controls.Add(this.uiLabel6);
            this.groupBox1.Controls.Add(this.TB_Read_Coils_Count);
            this.groupBox1.Controls.Add(this.uiLabel14);
            this.groupBox1.Controls.Add(this.TB_Read_Coils_Addr);
            this.groupBox1.Controls.Add(this.uiLabel15);
            this.groupBox1.Controls.Add(this.TB_Read_Coils_SAddr);
            this.groupBox1.Controls.Add(this.uiLabel16);
            this.groupBox1.Location = new System.Drawing.Point(14, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 247;
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
            this.Btn_Read_Coils.Location = new System.Drawing.Point(267, 32);
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
            this.Lbl_Coils_Value.Location = new System.Drawing.Point(246, 68);
            this.Lbl_Coils_Value.Name = "Lbl_Coils_Value";
            this.Lbl_Coils_Value.Size = new System.Drawing.Size(85, 25);
            this.Lbl_Coils_Value.TabIndex = 241;
            this.Lbl_Coils_Value.Text = "00";
            this.Lbl_Coils_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(180, 68);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(60, 25);
            this.uiLabel6.TabIndex = 240;
            this.uiLabel6.Text = "当前值";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_Coils_Count
            // 
            this.TB_Read_Coils_Count.ButtonSymbol = 61761;
            this.TB_Read_Coils_Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_Coils_Count.DoubleValue = 1D;
            this.TB_Read_Coils_Count.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_Coils_Count.IntValue = 1;
            this.TB_Read_Coils_Count.Location = new System.Drawing.Point(176, 29);
            this.TB_Read_Coils_Count.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_Coils_Count.Maximum = 2147483647D;
            this.TB_Read_Coils_Count.Minimum = -2147483648D;
            this.TB_Read_Coils_Count.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_Coils_Count.Name = "TB_Read_Coils_Count";
            this.TB_Read_Coils_Count.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_Coils_Count.Size = new System.Drawing.Size(61, 29);
            this.TB_Read_Coils_Count.TabIndex = 239;
            this.TB_Read_Coils_Count.Text = "1";
            this.TB_Read_Coils_Count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel14
            // 
            this.uiLabel14.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel14.Location = new System.Drawing.Point(126, 33);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(56, 25);
            this.uiLabel14.TabIndex = 238;
            this.uiLabel14.Text = "个数";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_Coils_Addr
            // 
            this.TB_Read_Coils_Addr.ButtonSymbol = 61761;
            this.TB_Read_Coils_Addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_Coils_Addr.DoubleValue = 1D;
            this.TB_Read_Coils_Addr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_Coils_Addr.IntValue = 1;
            this.TB_Read_Coils_Addr.Location = new System.Drawing.Point(54, 29);
            this.TB_Read_Coils_Addr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_Coils_Addr.Maximum = 2147483647D;
            this.TB_Read_Coils_Addr.Minimum = -2147483648D;
            this.TB_Read_Coils_Addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_Coils_Addr.Name = "TB_Read_Coils_Addr";
            this.TB_Read_Coils_Addr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_Coils_Addr.Size = new System.Drawing.Size(61, 29);
            this.TB_Read_Coils_Addr.TabIndex = 237;
            this.TB_Read_Coils_Addr.Text = "1";
            this.TB_Read_Coils_Addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel15
            // 
            this.uiLabel15.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel15.Location = new System.Drawing.Point(7, 33);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(56, 25);
            this.uiLabel15.TabIndex = 236;
            this.uiLabel15.Text = "地址";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel16
            // 
            this.uiLabel16.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel16.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel16.Location = new System.Drawing.Point(9, 67);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(81, 25);
            this.uiLabel16.TabIndex = 245;
            this.uiLabel16.Text = "Slave地址";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_Coils_SAddr
            // 
            this.TB_Read_Coils_SAddr.ButtonSymbol = 61761;
            this.TB_Read_Coils_SAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_Coils_SAddr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_Coils_SAddr.Location = new System.Drawing.Point(94, 65);
            this.TB_Read_Coils_SAddr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_Coils_SAddr.Maximum = 2147483647D;
            this.TB_Read_Coils_SAddr.Minimum = -2147483648D;
            this.TB_Read_Coils_SAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_Coils_SAddr.Name = "TB_Read_Coils_SAddr";
            this.TB_Read_Coils_SAddr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_Coils_SAddr.Size = new System.Drawing.Size(71, 29);
            this.TB_Read_Coils_SAddr.TabIndex = 246;
            this.TB_Read_Coils_SAddr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Read_Coils_SAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Read_Coils_SAddr.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_Write_Coils_SAddr
            // 
            this.TB_Write_Coils_SAddr.ButtonSymbol = 61761;
            this.TB_Write_Coils_SAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Write_Coils_SAddr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Write_Coils_SAddr.Location = new System.Drawing.Point(93, 64);
            this.TB_Write_Coils_SAddr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_Coils_SAddr.Maximum = 2147483647D;
            this.TB_Write_Coils_SAddr.Minimum = -2147483648D;
            this.TB_Write_Coils_SAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_Coils_SAddr.Name = "TB_Write_Coils_SAddr";
            this.TB_Write_Coils_SAddr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_Coils_SAddr.Size = new System.Drawing.Size(72, 29);
            this.TB_Write_Coils_SAddr.TabIndex = 248;
            this.TB_Write_Coils_SAddr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel17
            // 
            this.uiLabel17.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel17.Location = new System.Drawing.Point(8, 66);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(81, 25);
            this.uiLabel17.TabIndex = 247;
            this.uiLabel17.Text = "Slave地址";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Read_HRs_SAddr
            // 
            this.TB_Read_HRs_SAddr.ButtonSymbol = 61761;
            this.TB_Read_HRs_SAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Read_HRs_SAddr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Read_HRs_SAddr.Location = new System.Drawing.Point(94, 65);
            this.TB_Read_HRs_SAddr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Read_HRs_SAddr.Maximum = 2147483647D;
            this.TB_Read_HRs_SAddr.Minimum = -2147483648D;
            this.TB_Read_HRs_SAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Read_HRs_SAddr.Name = "TB_Read_HRs_SAddr";
            this.TB_Read_HRs_SAddr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Read_HRs_SAddr.Size = new System.Drawing.Size(61, 29);
            this.TB_Read_HRs_SAddr.TabIndex = 248;
            this.TB_Read_HRs_SAddr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel18
            // 
            this.uiLabel18.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel18.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel18.Location = new System.Drawing.Point(9, 67);
            this.uiLabel18.Name = "uiLabel18";
            this.uiLabel18.Size = new System.Drawing.Size(81, 25);
            this.uiLabel18.TabIndex = 247;
            this.uiLabel18.Text = "Slave地址";
            this.uiLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Write_HRs_SAddr
            // 
            this.TB_Write_HRs_SAddr.ButtonSymbol = 61761;
            this.TB_Write_HRs_SAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Write_HRs_SAddr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Write_HRs_SAddr.Location = new System.Drawing.Point(95, 64);
            this.TB_Write_HRs_SAddr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_HRs_SAddr.Maximum = 2147483647D;
            this.TB_Write_HRs_SAddr.Minimum = -2147483648D;
            this.TB_Write_HRs_SAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_HRs_SAddr.Name = "TB_Write_HRs_SAddr";
            this.TB_Write_HRs_SAddr.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_HRs_SAddr.Size = new System.Drawing.Size(72, 29);
            this.TB_Write_HRs_SAddr.TabIndex = 250;
            this.TB_Write_HRs_SAddr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel19
            // 
            this.uiLabel19.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel19.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel19.Location = new System.Drawing.Point(10, 66);
            this.uiLabel19.Name = "uiLabel19";
            this.uiLabel19.Size = new System.Drawing.Size(81, 25);
            this.uiLabel19.TabIndex = 249;
            this.uiLabel19.Text = "Slave地址";
            this.uiLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModbusRtuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModbusRtuView";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private Sunny.UI.UIButton Btn_Write_Coils;
        private Sunny.UI.UITextBox TB_Write_Coils_Data;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox TB_Write_Coils_Addr;
        private Sunny.UI.UILabel uiLabel11;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UIButton Btn_Write_HRs;
        private Sunny.UI.UITextBox TB_Write_HRs_Data;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox TB_Write_HRs_Addr;
        private Sunny.UI.UILabel uiLabel13;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIButton Btn_Read_HRs;
        private Sunny.UI.UILabel Lbl_HRs_Value;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox TB_Read_HRs_Count;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Read_HRs_Addr;
        private Sunny.UI.UILabel uiLabel10;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIButton Btn_Read_Coils;
        private Sunny.UI.UILabel Lbl_Coils_Value;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox TB_Read_Coils_Count;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UITextBox TB_Read_Coils_Addr;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UITextBox TB_Read_Coils_SAddr;
        private Sunny.UI.UITextBox TB_Write_Coils_SAddr;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UITextBox TB_Write_HRs_SAddr;
        private Sunny.UI.UILabel uiLabel19;
        private Sunny.UI.UITextBox TB_Read_HRs_SAddr;
        private Sunny.UI.UILabel uiLabel18;
    }
}
