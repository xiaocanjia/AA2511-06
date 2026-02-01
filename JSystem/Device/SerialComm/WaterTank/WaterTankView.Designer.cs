namespace JSystem.Device
{
    partial class WaterTankView
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
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Temp = new Sunny.UI.UITextBox();
            this.Btn_Set_Temp = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Lbl_Temp1 = new Sunny.UI.UILabel();
            this.Lbl_Temp3 = new Sunny.UI.UILabel();
            this.Lbl_Temp4 = new Sunny.UI.UILabel();
            this.Lbl_Temp5 = new Sunny.UI.UILabel();
            this.Lbl_Temp2 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel21 = new Sunny.UI.UILabel();
            this.Light_Low = new Sunny.UI.UILight();
            this.Light_Middle = new Sunny.UI.UILight();
            this.Light_High = new Sunny.UI.UILight();
            this.SuspendLayout();
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(17, 304);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(85, 27);
            this.uiLabel5.TabIndex = 246;
            this.uiLabel5.Text = "温度值";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Temp
            // 
            this.TB_Temp.ButtonSymbol = 61761;
            this.TB_Temp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Temp.DoubleValue = 250D;
            this.TB_Temp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Temp.IntValue = 250;
            this.TB_Temp.Location = new System.Drawing.Point(111, 302);
            this.TB_Temp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Temp.Maximum = 2147483647D;
            this.TB_Temp.Minimum = -2147483648D;
            this.TB_Temp.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Temp.Name = "TB_Temp";
            this.TB_Temp.Size = new System.Drawing.Size(161, 29);
            this.TB_Temp.TabIndex = 247;
            this.TB_Temp.Text = "250";
            this.TB_Temp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Temp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Temp.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // Btn_Set_Temp
            // 
            this.Btn_Set_Temp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Set_Temp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Set_Temp.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Set_Temp.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Set_Temp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Set_Temp.Location = new System.Drawing.Point(288, 301);
            this.Btn_Set_Temp.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Set_Temp.Name = "Btn_Set_Temp";
            this.Btn_Set_Temp.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Set_Temp.Size = new System.Drawing.Size(78, 32);
            this.Btn_Set_Temp.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Set_Temp.StyleCustomMode = true;
            this.Btn_Set_Temp.TabIndex = 248;
            this.Btn_Set_Temp.Text = "测试";
            this.Btn_Set_Temp.Click += new System.EventHandler(this.Btn_Set_Temp_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(17, 367);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(74, 27);
            this.uiLabel6.TabIndex = 249;
            this.uiLabel6.Text = "温度1";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Temp1
            // 
            this.Lbl_Temp1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Temp1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Temp1.Location = new System.Drawing.Point(103, 367);
            this.Lbl_Temp1.Name = "Lbl_Temp1";
            this.Lbl_Temp1.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Temp1.TabIndex = 250;
            this.Lbl_Temp1.Text = "2000.0";
            this.Lbl_Temp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Temp3
            // 
            this.Lbl_Temp3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Temp3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Temp3.Location = new System.Drawing.Point(103, 441);
            this.Lbl_Temp3.Name = "Lbl_Temp3";
            this.Lbl_Temp3.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Temp3.TabIndex = 259;
            this.Lbl_Temp3.Text = "2000.0";
            this.Lbl_Temp3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Temp4
            // 
            this.Lbl_Temp4.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Temp4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Temp4.Location = new System.Drawing.Point(103, 478);
            this.Lbl_Temp4.Name = "Lbl_Temp4";
            this.Lbl_Temp4.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Temp4.TabIndex = 260;
            this.Lbl_Temp4.Text = "2000.0";
            this.Lbl_Temp4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Temp5
            // 
            this.Lbl_Temp5.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Temp5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Temp5.Location = new System.Drawing.Point(103, 515);
            this.Lbl_Temp5.Name = "Lbl_Temp5";
            this.Lbl_Temp5.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Temp5.TabIndex = 261;
            this.Lbl_Temp5.Text = "2000.0";
            this.Lbl_Temp5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Temp2
            // 
            this.Lbl_Temp2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Temp2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Temp2.Location = new System.Drawing.Point(103, 404);
            this.Lbl_Temp2.Name = "Lbl_Temp2";
            this.Lbl_Temp2.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Temp2.TabIndex = 262;
            this.Lbl_Temp2.Text = "2000.0";
            this.Lbl_Temp2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(17, 404);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(74, 27);
            this.uiLabel7.TabIndex = 263;
            this.uiLabel7.Text = "温度2";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(17, 441);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(74, 27);
            this.uiLabel8.TabIndex = 264;
            this.uiLabel8.Text = "温度3";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(17, 478);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(74, 27);
            this.uiLabel10.TabIndex = 265;
            this.uiLabel10.Text = "温度4";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(17, 515);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(74, 27);
            this.uiLabel11.TabIndex = 266;
            this.uiLabel11.Text = "温度5";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(17, 675);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(74, 27);
            this.uiLabel12.TabIndex = 272;
            this.uiLabel12.Text = "高水位";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel13
            // 
            this.uiLabel13.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel13.Location = new System.Drawing.Point(17, 628);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(74, 27);
            this.uiLabel13.TabIndex = 271;
            this.uiLabel13.Text = "中水位";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel21
            // 
            this.uiLabel21.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel21.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel21.Location = new System.Drawing.Point(17, 581);
            this.uiLabel21.Name = "uiLabel21";
            this.uiLabel21.Size = new System.Drawing.Size(74, 27);
            this.uiLabel21.TabIndex = 267;
            this.uiLabel21.Text = "低水位";
            this.uiLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Light_Low
            // 
            this.Light_Low.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Light_Low.Location = new System.Drawing.Point(111, 577);
            this.Light_Low.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_Low.Name = "Light_Low";
            this.Light_Low.Radius = 35;
            this.Light_Low.Size = new System.Drawing.Size(35, 35);
            this.Light_Low.TabIndex = 273;
            this.Light_Low.Text = "uiLight1";
            // 
            // Light_Middle
            // 
            this.Light_Middle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Light_Middle.Location = new System.Drawing.Point(111, 624);
            this.Light_Middle.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_Middle.Name = "Light_Middle";
            this.Light_Middle.Radius = 35;
            this.Light_Middle.Size = new System.Drawing.Size(35, 35);
            this.Light_Middle.TabIndex = 274;
            this.Light_Middle.Text = "uiLight2";
            // 
            // Light_High
            // 
            this.Light_High.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Light_High.Location = new System.Drawing.Point(111, 671);
            this.Light_High.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_High.Name = "Light_High";
            this.Light_High.Radius = 35;
            this.Light_High.Size = new System.Drawing.Size(35, 35);
            this.Light_High.TabIndex = 275;
            this.Light_High.Text = "uiLight3";
            // 
            // WaterTankView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Light_High);
            this.Controls.Add(this.Light_Middle);
            this.Controls.Add(this.Light_Low);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.uiLabel21);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.Lbl_Temp2);
            this.Controls.Add(this.Lbl_Temp5);
            this.Controls.Add(this.Lbl_Temp4);
            this.Controls.Add(this.Lbl_Temp3);
            this.Controls.Add(this.Lbl_Temp1);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.Btn_Set_Temp);
            this.Controls.Add(this.TB_Temp);
            this.Controls.Add(this.uiLabel5);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "WaterTankView";
            this.Size = new System.Drawing.Size(1023, 800);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.TB_Temp, 0);
            this.Controls.SetChildIndex(this.Btn_Set_Temp, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.Lbl_Temp1, 0);
            this.Controls.SetChildIndex(this.Lbl_Temp3, 0);
            this.Controls.SetChildIndex(this.Lbl_Temp4, 0);
            this.Controls.SetChildIndex(this.Lbl_Temp5, 0);
            this.Controls.SetChildIndex(this.Lbl_Temp2, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.uiLabel10, 0);
            this.Controls.SetChildIndex(this.uiLabel11, 0);
            this.Controls.SetChildIndex(this.uiLabel21, 0);
            this.Controls.SetChildIndex(this.uiLabel13, 0);
            this.Controls.SetChildIndex(this.uiLabel12, 0);
            this.Controls.SetChildIndex(this.Light_Low, 0);
            this.Controls.SetChildIndex(this.Light_Middle, 0);
            this.Controls.SetChildIndex(this.Light_High, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Temp;
        private Sunny.UI.UIButton Btn_Set_Temp;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel Lbl_Temp1;
        private Sunny.UI.UILabel Lbl_Temp3;
        private Sunny.UI.UILabel Lbl_Temp4;
        private Sunny.UI.UILabel Lbl_Temp5;
        private Sunny.UI.UILabel Lbl_Temp2;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel21;
        private Sunny.UI.UILight Light_Low;
        private Sunny.UI.UILight Light_Middle;
        private Sunny.UI.UILight Light_High;
    }
}
