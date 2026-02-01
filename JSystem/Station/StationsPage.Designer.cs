namespace JSystem.Station
{
    partial class StationsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBx_Points = new Sunny.UI.UIListBox();
            this.Panel_Point_Axes = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Stop = new Sunny.UI.UISymbolButton();
            this.Btn_Record = new Sunny.UI.UISymbolButton();
            this.Panel_Axes = new Sunny.UI.UIFlowLayoutPanel();
            this.panel1 = new Sunny.UI.UIPanel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.lblEnabled = new Sunny.UI.UILabel();
            this.lblPM = new Sunny.UI.UILabel();
            this.lblOrg = new Sunny.UI.UILabel();
            this.lblNM = new Sunny.UI.UILabel();
            this.lblHome = new Sunny.UI.UILabel();
            this.lblAlarm = new Sunny.UI.UILabel();
            this.lblEMG = new Sunny.UI.UILabel();
            this.CbB_MoveType = new Sunny.UI.UIComboBox();
            this.lblActPos = new Sunny.UI.UILabel();
            this.Btn_Add_Axis = new Sunny.UI.UISymbolButton();
            this.Btn_Remove_Axis = new Sunny.UI.UISymbolButton();
            this.Btn_TestL = new Sunny.UI.UIButton();
            this.Btn_TestR = new Sunny.UI.UIButton();
            this.Panel_Axes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBx_Points
            // 
            this.LBx_Points.BackColor = System.Drawing.Color.Transparent;
            this.LBx_Points.FillColor = System.Drawing.Color.White;
            this.LBx_Points.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBx_Points.FormatString = "";
            this.LBx_Points.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.LBx_Points.Location = new System.Drawing.Point(13, 7);
            this.LBx_Points.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBx_Points.MinimumSize = new System.Drawing.Size(1, 1);
            this.LBx_Points.Name = "LBx_Points";
            this.LBx_Points.Padding = new System.Windows.Forms.Padding(2);
            this.LBx_Points.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.LBx_Points.Size = new System.Drawing.Size(184, 198);
            this.LBx_Points.Style = Sunny.UI.UIStyle.White;
            this.LBx_Points.StyleCustomMode = true;
            this.LBx_Points.TabIndex = 201;
            this.LBx_Points.Text = "uiListBox1";
            this.LBx_Points.ItemClick += new System.EventHandler(this.LBx_Points_ItemClick);
            // 
            // Panel_Point_Axes
            // 
            this.Panel_Point_Axes.AutoScroll = true;
            this.Panel_Point_Axes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Panel_Point_Axes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Point_Axes.Location = new System.Drawing.Point(204, 7);
            this.Panel_Point_Axes.Name = "Panel_Point_Axes";
            this.Panel_Point_Axes.Size = new System.Drawing.Size(638, 198);
            this.Panel_Point_Axes.TabIndex = 200;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Stop.FillColor = System.Drawing.Color.Brown;
            this.Btn_Stop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.Btn_Stop.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.Btn_Stop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.Btn_Stop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Stop.Location = new System.Drawing.Point(856, 148);
            this.Btn_Stop.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Stop.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.Btn_Stop.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.Btn_Stop.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.Btn_Stop.Size = new System.Drawing.Size(148, 45);
            this.Btn_Stop.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Stop.StyleCustomMode = true;
            this.Btn_Stop.Symbol = 61517;
            this.Btn_Stop.SymbolSize = 20;
            this.Btn_Stop.TabIndex = 199;
            this.Btn_Stop.Text = "停止";
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Record
            // 
            this.Btn_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Record.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Record.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Record.Location = new System.Drawing.Point(856, 84);
            this.Btn_Record.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Record.Name = "Btn_Record";
            this.Btn_Record.Size = new System.Drawing.Size(148, 45);
            this.Btn_Record.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Record.StyleCustomMode = true;
            this.Btn_Record.Symbol = 61713;
            this.Btn_Record.SymbolOffset = new System.Drawing.Point(0, 2);
            this.Btn_Record.SymbolSize = 25;
            this.Btn_Record.TabIndex = 198;
            this.Btn_Record.Text = "示教点位";
            this.Btn_Record.Click += new System.EventHandler(this.Btn_Record_Click);
            // 
            // Panel_Axes
            // 
            this.Panel_Axes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Axes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Panel_Axes.Controls.Add(this.panel1);
            this.Panel_Axes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Panel_Axes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_Axes.Location = new System.Drawing.Point(13, 213);
            this.Panel_Axes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Axes.MinimumSize = new System.Drawing.Size(1, 1);
            this.Panel_Axes.Name = "Panel_Axes";
            this.Panel_Axes.Padding = new System.Windows.Forms.Padding(2);
            this.Panel_Axes.Size = new System.Drawing.Size(1039, 630);
            this.Panel_Axes.Style = Sunny.UI.UIStyle.Custom;
            this.Panel_Axes.TabIndex = 197;
            this.Panel_Axes.Text = "uiFlowLayoutPanel2";
            this.Panel_Axes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.lblEnabled);
            this.panel1.Controls.Add(this.lblPM);
            this.panel1.Controls.Add(this.lblOrg);
            this.panel1.Controls.Add(this.lblNM);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Controls.Add(this.lblAlarm);
            this.panel1.Controls.Add(this.lblEMG);
            this.panel1.Controls.Add(this.CbB_MoveType);
            this.panel1.Controls.Add(this.lblActPos);
            this.panel1.FillColor = System.Drawing.Color.GhostWhite;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.panel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel1.RectColor = System.Drawing.Color.Transparent;
            this.panel1.Size = new System.Drawing.Size(1015, 39);
            this.panel1.Style = Sunny.UI.UIStyle.Custom;
            this.panel1.StyleCustomMode = true;
            this.panel1.TabIndex = 100;
            this.panel1.Text = null;
            this.panel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(502, 9);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(42, 21);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.StyleCustomMode = true;
            this.uiLabel3.TabIndex = 104;
            this.uiLabel3.Text = "使能";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(318, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 21);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 103;
            this.uiLabel1.Text = "命令位置";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(7, 9);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(42, 21);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 93;
            this.uiLabel2.Text = "轴名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnabled
            // 
            this.lblEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.BackColor = System.Drawing.Color.Transparent;
            this.lblEnabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblEnabled.Location = new System.Drawing.Point(166, 9);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(58, 21);
            this.lblEnabled.Style = Sunny.UI.UIStyle.Custom;
            this.lblEnabled.StyleCustomMode = true;
            this.lblEnabled.TabIndex = 94;
            this.lblEnabled.Text = "轴使能";
            this.lblEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPM
            // 
            this.lblPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPM.AutoSize = true;
            this.lblPM.BackColor = System.Drawing.Color.Transparent;
            this.lblPM.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblPM.Location = new System.Drawing.Point(608, 9);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(42, 21);
            this.lblPM.Style = Sunny.UI.UIStyle.Custom;
            this.lblPM.StyleCustomMode = true;
            this.lblPM.TabIndex = 98;
            this.lblPM.Text = "正限";
            this.lblPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrg
            // 
            this.lblOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrg.AutoSize = true;
            this.lblOrg.BackColor = System.Drawing.Color.Transparent;
            this.lblOrg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblOrg.Location = new System.Drawing.Point(661, 9);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(42, 21);
            this.lblOrg.Style = Sunny.UI.UIStyle.Custom;
            this.lblOrg.StyleCustomMode = true;
            this.lblOrg.TabIndex = 97;
            this.lblOrg.Text = "原点";
            this.lblOrg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNM
            // 
            this.lblNM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNM.AutoSize = true;
            this.lblNM.BackColor = System.Drawing.Color.Transparent;
            this.lblNM.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblNM.Location = new System.Drawing.Point(714, 9);
            this.lblNM.Name = "lblNM";
            this.lblNM.Size = new System.Drawing.Size(42, 21);
            this.lblNM.Style = Sunny.UI.UIStyle.Custom;
            this.lblNM.StyleCustomMode = true;
            this.lblNM.TabIndex = 101;
            this.lblNM.Text = "负限";
            this.lblNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHome
            // 
            this.lblHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblHome.Location = new System.Drawing.Point(247, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(58, 21);
            this.lblHome.Style = Sunny.UI.UIStyle.Custom;
            this.lblHome.StyleCustomMode = true;
            this.lblHome.TabIndex = 95;
            this.lblHome.Text = "轴回原";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlarm
            // 
            this.lblAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.BackColor = System.Drawing.Color.Transparent;
            this.lblAlarm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblAlarm.Location = new System.Drawing.Point(555, 9);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(42, 21);
            this.lblAlarm.Style = Sunny.UI.UIStyle.Custom;
            this.lblAlarm.StyleCustomMode = true;
            this.lblAlarm.TabIndex = 99;
            this.lblAlarm.Text = "报警";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEMG
            // 
            this.lblEMG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEMG.AutoSize = true;
            this.lblEMG.BackColor = System.Drawing.Color.Transparent;
            this.lblEMG.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblEMG.Location = new System.Drawing.Point(767, 9);
            this.lblEMG.Name = "lblEMG";
            this.lblEMG.Size = new System.Drawing.Size(42, 21);
            this.lblEMG.Style = Sunny.UI.UIStyle.Custom;
            this.lblEMG.StyleCustomMode = true;
            this.lblEMG.TabIndex = 100;
            this.lblEMG.Text = "急停";
            this.lblEMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_MoveType
            // 
            this.CbB_MoveType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbB_MoveType.DataSource = null;
            this.CbB_MoveType.FillColor = System.Drawing.Color.White;
            this.CbB_MoveType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_MoveType.Items.AddRange(new object[] {
            "Jog",
            "0.01",
            "0.05",
            "0.1",
            "0.5",
            "1",
            "5",
            "10",
            "50",
            "100",
            "300"});
            this.CbB_MoveType.Location = new System.Drawing.Point(832, 5);
            this.CbB_MoveType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_MoveType.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_MoveType.Name = "CbB_MoveType";
            this.CbB_MoveType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CbB_MoveType.Size = new System.Drawing.Size(156, 29);
            this.CbB_MoveType.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_MoveType.TabIndex = 102;
            this.CbB_MoveType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CbB_MoveType.TextChanged += new System.EventHandler(this.CbB_MoveType_TextChanged);
            this.CbB_MoveType.SelectedIndexChanged += new System.EventHandler(this.CbB_MoveType_SelectedIndexChanged);
            // 
            // lblActPos
            // 
            this.lblActPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActPos.AutoSize = true;
            this.lblActPos.BackColor = System.Drawing.Color.Transparent;
            this.lblActPos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblActPos.Location = new System.Drawing.Point(407, 9);
            this.lblActPos.Name = "lblActPos";
            this.lblActPos.Size = new System.Drawing.Size(74, 21);
            this.lblActPos.Style = Sunny.UI.UIStyle.Custom;
            this.lblActPos.StyleCustomMode = true;
            this.lblActPos.TabIndex = 96;
            this.lblActPos.Text = "实际位置";
            this.lblActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Add_Axis
            // 
            this.Btn_Add_Axis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add_Axis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Add_Axis.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Add_Axis.Location = new System.Drawing.Point(859, 20);
            this.Btn_Add_Axis.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Add_Axis.Name = "Btn_Add_Axis";
            this.Btn_Add_Axis.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Add_Axis.Size = new System.Drawing.Size(50, 30);
            this.Btn_Add_Axis.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Add_Axis.StyleCustomMode = true;
            this.Btn_Add_Axis.Symbol = 61543;
            this.Btn_Add_Axis.TabIndex = 196;
            this.Btn_Add_Axis.Click += new System.EventHandler(this.Btn_Add_Axis_Click);
            // 
            // Btn_Remove_Axis
            // 
            this.Btn_Remove_Axis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Remove_Axis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Remove_Axis.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Remove_Axis.Location = new System.Drawing.Point(944, 20);
            this.Btn_Remove_Axis.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Remove_Axis.Name = "Btn_Remove_Axis";
            this.Btn_Remove_Axis.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Remove_Axis.Size = new System.Drawing.Size(50, 30);
            this.Btn_Remove_Axis.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Remove_Axis.StyleCustomMode = true;
            this.Btn_Remove_Axis.Symbol = 61544;
            this.Btn_Remove_Axis.TabIndex = 195;
            this.Btn_Remove_Axis.Click += new System.EventHandler(this.Btn_Remove_Axis_Click);
            // 
            // Btn_TestL
            // 
            this.Btn_TestL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_TestL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TestL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_TestL.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_TestL.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_TestL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_TestL.Location = new System.Drawing.Point(1226, 24);
            this.Btn_TestL.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_TestL.Name = "Btn_TestL";
            this.Btn_TestL.RectColor = System.Drawing.Color.White;
            this.Btn_TestL.Size = new System.Drawing.Size(121, 48);
            this.Btn_TestL.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_TestL.StyleCustomMode = true;
            this.Btn_TestL.TabIndex = 264;
            this.Btn_TestL.Text = "左工位测试";
            this.Btn_TestL.Click += new System.EventHandler(this.Btn_TestL_Click);
            // 
            // Btn_TestR
            // 
            this.Btn_TestR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_TestR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TestR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_TestR.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_TestR.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_TestR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_TestR.Location = new System.Drawing.Point(1226, 84);
            this.Btn_TestR.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_TestR.Name = "Btn_TestR";
            this.Btn_TestR.RectColor = System.Drawing.Color.White;
            this.Btn_TestR.Size = new System.Drawing.Size(121, 48);
            this.Btn_TestR.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_TestR.StyleCustomMode = true;
            this.Btn_TestR.TabIndex = 265;
            this.Btn_TestR.Text = "右工位测试";
            // 
            // StationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1359, 851);
            this.Controls.Add(this.Btn_TestR);
            this.Controls.Add(this.Btn_TestL);
            this.Controls.Add(this.LBx_Points);
            this.Controls.Add(this.Panel_Point_Axes);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Record);
            this.Controls.Add(this.Panel_Axes);
            this.Controls.Add(this.Btn_Add_Axis);
            this.Controls.Add(this.Btn_Remove_Axis);
            this.Name = "StationsPage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "StationsWindow";
            this.Panel_Axes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox LBx_Points;
        private System.Windows.Forms.FlowLayoutPanel Panel_Point_Axes;
        private Sunny.UI.UISymbolButton Btn_Stop;
        private Sunny.UI.UISymbolButton Btn_Record;
        private Sunny.UI.UIFlowLayoutPanel Panel_Axes;
        private Sunny.UI.UIPanel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel lblEnabled;
        private Sunny.UI.UILabel lblPM;
        private Sunny.UI.UILabel lblOrg;
        private Sunny.UI.UILabel lblNM;
        private Sunny.UI.UILabel lblHome;
        private Sunny.UI.UILabel lblAlarm;
        private Sunny.UI.UILabel lblEMG;
        private Sunny.UI.UIComboBox CbB_MoveType;
        private Sunny.UI.UILabel lblActPos;
        private Sunny.UI.UISymbolButton Btn_Add_Axis;
        private Sunny.UI.UISymbolButton Btn_Remove_Axis;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton Btn_TestL;
        private Sunny.UI.UIButton Btn_TestR;
    }
}