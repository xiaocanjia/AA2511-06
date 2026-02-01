namespace JSystem.IO
{
    partial class IOCfgForm
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.TB_Point_Idx = new Sunny.UI.UITextBox();
            this.TB_Axis_Idx = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Btn_Cancel = new Sunny.UI.UISymbolButton();
            this.Btn_Apply = new Sunny.UI.UISymbolButton();
            this.CbB_Board_Name = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(21, 55);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(94, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 177;
            this.uiLabel2.Text = "板卡名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Point_Idx
            // 
            this.TB_Point_Idx.ButtonSymbol = 61761;
            this.TB_Point_Idx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Point_Idx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Point_Idx.Location = new System.Drawing.Point(135, 126);
            this.TB_Point_Idx.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Point_Idx.Maximum = 2147483647D;
            this.TB_Point_Idx.Minimum = -2147483648D;
            this.TB_Point_Idx.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Point_Idx.Name = "TB_Point_Idx";
            this.TB_Point_Idx.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Point_Idx.Size = new System.Drawing.Size(266, 29);
            this.TB_Point_Idx.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Point_Idx.TabIndex = 181;
            this.TB_Point_Idx.Text = "0";
            this.TB_Point_Idx.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Axis_Idx
            // 
            this.TB_Axis_Idx.ButtonSymbol = 61761;
            this.TB_Axis_Idx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Axis_Idx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Axis_Idx.Location = new System.Drawing.Point(135, 89);
            this.TB_Axis_Idx.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Axis_Idx.Maximum = 2147483647D;
            this.TB_Axis_Idx.Minimum = -2147483648D;
            this.TB_Axis_Idx.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Axis_Idx.Name = "TB_Axis_Idx";
            this.TB_Axis_Idx.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Axis_Idx.Size = new System.Drawing.Size(266, 29);
            this.TB_Axis_Idx.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Axis_Idx.TabIndex = 180;
            this.TB_Axis_Idx.Text = "0";
            this.TB_Axis_Idx.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(21, 127);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(101, 25);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 179;
            this.uiLabel9.Text = "点序号";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(21, 90);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(101, 25);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 178;
            this.uiLabel1.Text = "轴序号";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Cancel.Location = new System.Drawing.Point(243, 186);
            this.Btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Cancel.Size = new System.Drawing.Size(108, 38);
            this.Btn_Cancel.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Cancel.StyleCustomMode = true;
            this.Btn_Cancel.Symbol = 61453;
            this.Btn_Cancel.SymbolSize = 32;
            this.Btn_Cancel.TabIndex = 183;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Apply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Apply.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Apply.Location = new System.Drawing.Point(77, 186);
            this.Btn_Apply.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Apply.Size = new System.Drawing.Size(108, 38);
            this.Btn_Apply.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Apply.StyleCustomMode = true;
            this.Btn_Apply.SymbolSize = 32;
            this.Btn_Apply.TabIndex = 182;
            this.Btn_Apply.Text = "应用";
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // CbB_Board_Name
            // 
            this.CbB_Board_Name.DataSource = null;
            this.CbB_Board_Name.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Board_Name.FillColor = System.Drawing.Color.White;
            this.CbB_Board_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Board_Name.Location = new System.Drawing.Point(135, 52);
            this.CbB_Board_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Board_Name.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Board_Name.Name = "CbB_Board_Name";
            this.CbB_Board_Name.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Board_Name.Size = new System.Drawing.Size(266, 29);
            this.CbB_Board_Name.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Board_Name.StyleCustomMode = true;
            this.CbB_Board_Name.TabIndex = 184;
            this.CbB_Board_Name.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // IOCfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 241);
            this.Controls.Add(this.CbB_Board_Name);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Apply);
            this.Controls.Add(this.TB_Point_Idx);
            this.Controls.Add(this.TB_Axis_Idx);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Name = "IOCfgForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "IO参数配置";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox TB_Point_Idx;
        private Sunny.UI.UITextBox TB_Axis_Idx;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton Btn_Cancel;
        private Sunny.UI.UISymbolButton Btn_Apply;
        private Sunny.UI.UIComboBox CbB_Board_Name;
    }
}