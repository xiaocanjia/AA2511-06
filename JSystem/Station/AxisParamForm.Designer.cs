namespace JSystem.Station
{
    partial class AxisParamForm
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TB_MoveVelL = new Sunny.UI.UITextBox();
            this.TB_MoveVelH = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.TB_MoveAcc = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.TB_MoveDcc = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.TB_PlusePerMM = new Sunny.UI.UITextBox();
            this.Lb_Unit = new Sunny.UI.UILabel();
            this.TB_HomeVelL = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.TB_HomeVelH = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.TB_HomeMode = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.TB_HomeDcc = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.TB_HomeAcc = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.TB_HomeOffset = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.TB_HomeDir = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.Btn_Cancel = new Sunny.UI.UISymbolButton();
            this.Btn_Apply = new Sunny.UI.UISymbolButton();
            this.TB_ManulVel = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Accuracy = new Sunny.UI.UITextBox();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.TB_Security_Level = new Sunny.UI.UITextBox();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.TB_Security_Pos = new Sunny.UI.UITextBox();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(45, 102);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(121, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "移动起步速度";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_MoveVelL
            // 
            this.TB_MoveVelL.ButtonSymbol = 61761;
            this.TB_MoveVelL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_MoveVelL.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_MoveVelL.Location = new System.Drawing.Point(173, 99);
            this.TB_MoveVelL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_MoveVelL.Maximum = 2147483647D;
            this.TB_MoveVelL.Minimum = -2147483648D;
            this.TB_MoveVelL.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_MoveVelL.Name = "TB_MoveVelL";
            this.TB_MoveVelL.Size = new System.Drawing.Size(125, 29);
            this.TB_MoveVelL.Style = Sunny.UI.UIStyle.Custom;
            this.TB_MoveVelL.TabIndex = 1;
            this.TB_MoveVelL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_MoveVelH
            // 
            this.TB_MoveVelH.ButtonSymbol = 61761;
            this.TB_MoveVelH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_MoveVelH.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_MoveVelH.Location = new System.Drawing.Point(173, 138);
            this.TB_MoveVelH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_MoveVelH.Maximum = 2147483647D;
            this.TB_MoveVelH.Minimum = -2147483648D;
            this.TB_MoveVelH.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_MoveVelH.Name = "TB_MoveVelH";
            this.TB_MoveVelH.Size = new System.Drawing.Size(125, 29);
            this.TB_MoveVelH.Style = Sunny.UI.UIStyle.Custom;
            this.TB_MoveVelH.TabIndex = 4;
            this.TB_MoveVelH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(45, 141);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(121, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "自动运行速度";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_MoveAcc
            // 
            this.TB_MoveAcc.ButtonSymbol = 61761;
            this.TB_MoveAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_MoveAcc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_MoveAcc.Location = new System.Drawing.Point(173, 216);
            this.TB_MoveAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_MoveAcc.Maximum = 2147483647D;
            this.TB_MoveAcc.Minimum = -2147483648D;
            this.TB_MoveAcc.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_MoveAcc.Name = "TB_MoveAcc";
            this.TB_MoveAcc.Size = new System.Drawing.Size(125, 29);
            this.TB_MoveAcc.Style = Sunny.UI.UIStyle.Custom;
            this.TB_MoveAcc.TabIndex = 4;
            this.TB_MoveAcc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(45, 219);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(121, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "移动加速度";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_MoveDcc
            // 
            this.TB_MoveDcc.ButtonSymbol = 61761;
            this.TB_MoveDcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_MoveDcc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_MoveDcc.Location = new System.Drawing.Point(173, 255);
            this.TB_MoveDcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_MoveDcc.Maximum = 2147483647D;
            this.TB_MoveDcc.Minimum = -2147483648D;
            this.TB_MoveDcc.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_MoveDcc.Name = "TB_MoveDcc";
            this.TB_MoveDcc.Size = new System.Drawing.Size(125, 29);
            this.TB_MoveDcc.Style = Sunny.UI.UIStyle.Custom;
            this.TB_MoveDcc.TabIndex = 4;
            this.TB_MoveDcc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(45, 258);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(121, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "移动减速度";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_PlusePerMM
            // 
            this.TB_PlusePerMM.ButtonSymbol = 61761;
            this.TB_PlusePerMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_PlusePerMM.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_PlusePerMM.Location = new System.Drawing.Point(173, 60);
            this.TB_PlusePerMM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_PlusePerMM.Maximum = 2147483647D;
            this.TB_PlusePerMM.Minimum = -2147483648D;
            this.TB_PlusePerMM.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_PlusePerMM.Name = "TB_PlusePerMM";
            this.TB_PlusePerMM.Size = new System.Drawing.Size(125, 29);
            this.TB_PlusePerMM.Style = Sunny.UI.UIStyle.Custom;
            this.TB_PlusePerMM.TabIndex = 4;
            this.TB_PlusePerMM.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Unit
            // 
            this.Lb_Unit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_Unit.Location = new System.Drawing.Point(45, 63);
            this.Lb_Unit.Name = "Lb_Unit";
            this.Lb_Unit.Size = new System.Drawing.Size(121, 23);
            this.Lb_Unit.Style = Sunny.UI.UIStyle.Custom;
            this.Lb_Unit.TabIndex = 3;
            this.Lb_Unit.Text = "脉冲每";
            this.Lb_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_HomeVelL
            // 
            this.TB_HomeVelL.ButtonSymbol = 61761;
            this.TB_HomeVelL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_HomeVelL.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_HomeVelL.Location = new System.Drawing.Point(489, 177);
            this.TB_HomeVelL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_HomeVelL.Maximum = 2147483647D;
            this.TB_HomeVelL.Minimum = -2147483648D;
            this.TB_HomeVelL.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_HomeVelL.Name = "TB_HomeVelL";
            this.TB_HomeVelL.Size = new System.Drawing.Size(125, 29);
            this.TB_HomeVelL.Style = Sunny.UI.UIStyle.Custom;
            this.TB_HomeVelL.TabIndex = 4;
            this.TB_HomeVelL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(361, 180);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(121, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 3;
            this.uiLabel6.Text = "回零起步速度";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_HomeVelH
            // 
            this.TB_HomeVelH.ButtonSymbol = 61761;
            this.TB_HomeVelH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_HomeVelH.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_HomeVelH.Location = new System.Drawing.Point(489, 216);
            this.TB_HomeVelH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_HomeVelH.Maximum = 2147483647D;
            this.TB_HomeVelH.Minimum = -2147483648D;
            this.TB_HomeVelH.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_HomeVelH.Name = "TB_HomeVelH";
            this.TB_HomeVelH.Size = new System.Drawing.Size(125, 29);
            this.TB_HomeVelH.Style = Sunny.UI.UIStyle.Custom;
            this.TB_HomeVelH.TabIndex = 6;
            this.TB_HomeVelH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(361, 219);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(121, 23);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 5;
            this.uiLabel7.Text = "回零运行速度";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_HomeMode
            // 
            this.TB_HomeMode.ButtonSymbol = 61761;
            this.TB_HomeMode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_HomeMode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_HomeMode.Location = new System.Drawing.Point(489, 60);
            this.TB_HomeMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_HomeMode.Maximum = 2147483647D;
            this.TB_HomeMode.Minimum = -2147483648D;
            this.TB_HomeMode.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_HomeMode.Name = "TB_HomeMode";
            this.TB_HomeMode.Size = new System.Drawing.Size(125, 29);
            this.TB_HomeMode.Style = Sunny.UI.UIStyle.Custom;
            this.TB_HomeMode.TabIndex = 8;
            this.TB_HomeMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(361, 63);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(121, 23);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 5;
            this.uiLabel8.Text = "回零方式";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_HomeDcc
            // 
            this.TB_HomeDcc.ButtonSymbol = 61761;
            this.TB_HomeDcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_HomeDcc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_HomeDcc.Location = new System.Drawing.Point(489, 294);
            this.TB_HomeDcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_HomeDcc.Maximum = 2147483647D;
            this.TB_HomeDcc.Minimum = -2147483648D;
            this.TB_HomeDcc.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_HomeDcc.Name = "TB_HomeDcc";
            this.TB_HomeDcc.Size = new System.Drawing.Size(125, 29);
            this.TB_HomeDcc.Style = Sunny.UI.UIStyle.Custom;
            this.TB_HomeDcc.TabIndex = 9;
            this.TB_HomeDcc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(361, 297);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(121, 23);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 6;
            this.uiLabel9.Text = "回零减速度";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_HomeAcc
            // 
            this.TB_HomeAcc.ButtonSymbol = 61761;
            this.TB_HomeAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_HomeAcc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_HomeAcc.Location = new System.Drawing.Point(489, 255);
            this.TB_HomeAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_HomeAcc.Maximum = 2147483647D;
            this.TB_HomeAcc.Minimum = -2147483648D;
            this.TB_HomeAcc.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_HomeAcc.Name = "TB_HomeAcc";
            this.TB_HomeAcc.Size = new System.Drawing.Size(125, 29);
            this.TB_HomeAcc.Style = Sunny.UI.UIStyle.Custom;
            this.TB_HomeAcc.TabIndex = 10;
            this.TB_HomeAcc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.Location = new System.Drawing.Point(361, 258);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(121, 23);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 7;
            this.uiLabel10.Text = "回零加速度";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_HomeOffset
            // 
            this.TB_HomeOffset.ButtonSymbol = 61761;
            this.TB_HomeOffset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_HomeOffset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_HomeOffset.Location = new System.Drawing.Point(489, 99);
            this.TB_HomeOffset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_HomeOffset.Maximum = 2147483647D;
            this.TB_HomeOffset.Minimum = -2147483648D;
            this.TB_HomeOffset.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_HomeOffset.Name = "TB_HomeOffset";
            this.TB_HomeOffset.Size = new System.Drawing.Size(125, 29);
            this.TB_HomeOffset.Style = Sunny.UI.UIStyle.Custom;
            this.TB_HomeOffset.TabIndex = 10;
            this.TB_HomeOffset.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(361, 102);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(121, 23);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 9;
            this.uiLabel11.Text = "回零偏移量";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_HomeDir
            // 
            this.TB_HomeDir.ButtonSymbol = 61761;
            this.TB_HomeDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_HomeDir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_HomeDir.Location = new System.Drawing.Point(489, 138);
            this.TB_HomeDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_HomeDir.Maximum = 2147483647D;
            this.TB_HomeDir.Minimum = -2147483648D;
            this.TB_HomeDir.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_HomeDir.Name = "TB_HomeDir";
            this.TB_HomeDir.Size = new System.Drawing.Size(125, 29);
            this.TB_HomeDir.Style = Sunny.UI.UIStyle.Custom;
            this.TB_HomeDir.TabIndex = 12;
            this.TB_HomeDir.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.Location = new System.Drawing.Point(361, 141);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(121, 23);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 11;
            this.uiLabel12.Text = "回零方向";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Cancel.Location = new System.Drawing.Point(365, 390);
            this.Btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Cancel.Size = new System.Drawing.Size(132, 45);
            this.Btn_Cancel.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Cancel.StyleCustomMode = true;
            this.Btn_Cancel.Symbol = 61453;
            this.Btn_Cancel.SymbolSize = 32;
            this.Btn_Cancel.TabIndex = 98;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Apply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Apply.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Apply.Location = new System.Drawing.Point(164, 390);
            this.Btn_Apply.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Apply.Size = new System.Drawing.Size(132, 45);
            this.Btn_Apply.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Apply.StyleCustomMode = true;
            this.Btn_Apply.SymbolSize = 32;
            this.Btn_Apply.TabIndex = 97;
            this.Btn_Apply.Text = "应用";
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // TB_ManulVel
            // 
            this.TB_ManulVel.ButtonSymbol = 61761;
            this.TB_ManulVel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_ManulVel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_ManulVel.Location = new System.Drawing.Point(173, 177);
            this.TB_ManulVel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_ManulVel.Maximum = 2147483647D;
            this.TB_ManulVel.Minimum = -2147483648D;
            this.TB_ManulVel.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_ManulVel.Name = "TB_ManulVel";
            this.TB_ManulVel.Size = new System.Drawing.Size(125, 29);
            this.TB_ManulVel.Style = Sunny.UI.UIStyle.Custom;
            this.TB_ManulVel.TabIndex = 6;
            this.TB_ManulVel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(45, 180);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(121, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 5;
            this.uiLabel5.Text = "手动运行速度";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Accuracy
            // 
            this.TB_Accuracy.ButtonSymbol = 61761;
            this.TB_Accuracy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Accuracy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Accuracy.Location = new System.Drawing.Point(173, 294);
            this.TB_Accuracy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Accuracy.Maximum = 2147483647D;
            this.TB_Accuracy.Minimum = -2147483648D;
            this.TB_Accuracy.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Accuracy.Name = "TB_Accuracy";
            this.TB_Accuracy.Size = new System.Drawing.Size(125, 29);
            this.TB_Accuracy.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Accuracy.TabIndex = 6;
            this.TB_Accuracy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(45, 297);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(121, 23);
            this.uiLabel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel13.TabIndex = 5;
            this.uiLabel13.Text = "轴精度";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Security_Level
            // 
            this.TB_Security_Level.ButtonSymbol = 61761;
            this.TB_Security_Level.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Security_Level.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Security_Level.Location = new System.Drawing.Point(173, 333);
            this.TB_Security_Level.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Security_Level.Maximum = 2147483647D;
            this.TB_Security_Level.Minimum = -2147483648D;
            this.TB_Security_Level.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Security_Level.Name = "TB_Security_Level";
            this.TB_Security_Level.Size = new System.Drawing.Size(125, 29);
            this.TB_Security_Level.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Security_Level.TabIndex = 100;
            this.TB_Security_Level.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel14.Location = new System.Drawing.Point(45, 336);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(121, 23);
            this.uiLabel14.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel14.TabIndex = 99;
            this.uiLabel14.Text = "安全等级";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Security_Pos
            // 
            this.TB_Security_Pos.ButtonSymbol = 61761;
            this.TB_Security_Pos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Security_Pos.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Security_Pos.Location = new System.Drawing.Point(489, 333);
            this.TB_Security_Pos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Security_Pos.Maximum = 2147483647D;
            this.TB_Security_Pos.Minimum = -2147483648D;
            this.TB_Security_Pos.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Security_Pos.Name = "TB_Security_Pos";
            this.TB_Security_Pos.Size = new System.Drawing.Size(125, 29);
            this.TB_Security_Pos.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Security_Pos.TabIndex = 102;
            this.TB_Security_Pos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel15
            // 
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel15.Location = new System.Drawing.Point(361, 336);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(121, 23);
            this.uiLabel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel15.TabIndex = 101;
            this.uiLabel15.Text = "安全位";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AxisParamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 460);
            this.Controls.Add(this.TB_Security_Pos);
            this.Controls.Add(this.uiLabel15);
            this.Controls.Add(this.TB_Security_Level);
            this.Controls.Add(this.uiLabel14);
            this.Controls.Add(this.TB_Accuracy);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.TB_ManulVel);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Apply);
            this.Controls.Add(this.TB_HomeDir);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.TB_HomeOffset);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.TB_HomeMode);
            this.Controls.Add(this.TB_HomeVelH);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.TB_HomeDcc);
            this.Controls.Add(this.TB_HomeVelL);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.TB_HomeAcc);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.TB_PlusePerMM);
            this.Controls.Add(this.Lb_Unit);
            this.Controls.Add(this.TB_MoveDcc);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.TB_MoveAcc);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.TB_MoveVelH);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.TB_MoveVelL);
            this.Controls.Add(this.uiLabel1);
            this.Name = "AxisParamForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "轴参数设置";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TB_MoveVelL;
        private Sunny.UI.UITextBox TB_MoveVelH;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox TB_MoveAcc;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox TB_MoveDcc;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox TB_PlusePerMM;
        private Sunny.UI.UILabel Lb_Unit;
        private Sunny.UI.UITextBox TB_HomeVelL;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox TB_HomeVelH;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox TB_HomeMode;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox TB_HomeDcc;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox TB_HomeAcc;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox TB_HomeOffset;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox TB_HomeDir;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UISymbolButton Btn_Cancel;
        private Sunny.UI.UISymbolButton Btn_Apply;
        private Sunny.UI.UITextBox TB_ManulVel;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Accuracy;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UITextBox TB_Security_Level;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UITextBox TB_Security_Pos;
        private Sunny.UI.UILabel uiLabel15;
    }
}