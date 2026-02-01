namespace JSystem.Device
{
    partial class TempControllerView
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
            this.Lbl_CurrTemp = new Sunny.UI.UILabel();
            this.TB_High = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Temp = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.TB_Low = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.Btn_Open = new Sunny.UI.UIButton();
            this.Btn_Stop = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // Lbl_CurrTemp
            // 
            this.Lbl_CurrTemp.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CurrTemp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_CurrTemp.Location = new System.Drawing.Point(105, 308);
            this.Lbl_CurrTemp.Name = "Lbl_CurrTemp";
            this.Lbl_CurrTemp.Size = new System.Drawing.Size(60, 27);
            this.Lbl_CurrTemp.TabIndex = 250;
            this.Lbl_CurrTemp.Text = "0.0";
            this.Lbl_CurrTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_High
            // 
            this.TB_High.ButtonSymbol = 61761;
            this.TB_High.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_High.DoubleValue = 60D;
            this.TB_High.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_High.IntValue = 60;
            this.TB_High.Location = new System.Drawing.Point(210, 347);
            this.TB_High.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_High.Maximum = 2147483647D;
            this.TB_High.Minimum = -2147483648D;
            this.TB_High.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_High.Name = "TB_High";
            this.TB_High.Padding = new System.Windows.Forms.Padding(7);
            this.TB_High.Size = new System.Drawing.Size(100, 29);
            this.TB_High.TabIndex = 257;
            this.TB_High.Text = "60";
            this.TB_High.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(22, 308);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(77, 25);
            this.uiLabel5.TabIndex = 258;
            this.uiLabel5.Text = "当前温度";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Temp
            // 
            this.TB_Temp.ButtonSymbol = 61761;
            this.TB_Temp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Temp.DoubleValue = 10D;
            this.TB_Temp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Temp.IntValue = 10;
            this.TB_Temp.Location = new System.Drawing.Point(107, 390);
            this.TB_Temp.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Temp.Maximum = 2147483647D;
            this.TB_Temp.Minimum = -2147483648D;
            this.TB_Temp.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Temp.Name = "TB_Temp";
            this.TB_Temp.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Temp.Size = new System.Drawing.Size(203, 29);
            this.TB_Temp.TabIndex = 256;
            this.TB_Temp.Text = "10";
            this.TB_Temp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(22, 392);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(77, 25);
            this.uiLabel8.TabIndex = 255;
            this.uiLabel8.Text = "目标温度";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Low
            // 
            this.TB_Low.ButtonSymbol = 61761;
            this.TB_Low.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Low.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Low.Location = new System.Drawing.Point(107, 347);
            this.TB_Low.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Low.Maximum = 2147483647D;
            this.TB_Low.Minimum = -2147483648D;
            this.TB_Low.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Low.Name = "TB_Low";
            this.TB_Low.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Low.Size = new System.Drawing.Size(100, 29);
            this.TB_Low.TabIndex = 254;
            this.TB_Low.Text = "0";
            this.TB_Low.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(22, 349);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(77, 25);
            this.uiLabel10.TabIndex = 253;
            this.uiLabel10.Text = "温度范围";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Open.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Open.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Open.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Open.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Open.Location = new System.Drawing.Point(107, 435);
            this.Btn_Open.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Open.Size = new System.Drawing.Size(85, 40);
            this.Btn_Open.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Open.StyleCustomMode = true;
            this.Btn_Open.TabIndex = 260;
            this.Btn_Open.Text = "启动";
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Stop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Stop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Stop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Stop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Stop.Location = new System.Drawing.Point(225, 435);
            this.Btn_Stop.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Stop.Size = new System.Drawing.Size(85, 40);
            this.Btn_Stop.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Stop.StyleCustomMode = true;
            this.Btn_Stop.TabIndex = 261;
            this.Btn_Stop.Text = "停止";
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // TemperatureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.TB_High);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.TB_Temp);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.TB_Low);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.Lbl_CurrTemp);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "TemperatureView";
            this.Size = new System.Drawing.Size(1023, 800);
            this.Controls.SetChildIndex(this.Lbl_CurrTemp, 0);
            this.Controls.SetChildIndex(this.uiLabel10, 0);
            this.Controls.SetChildIndex(this.TB_Low, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.TB_Temp, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.TB_High, 0);
            this.Controls.SetChildIndex(this.Btn_Open, 0);
            this.Controls.SetChildIndex(this.Btn_Stop, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel Lbl_CurrTemp;
        private Sunny.UI.UITextBox TB_High;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Temp;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox TB_Low;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIButton Btn_Open;
        private Sunny.UI.UIButton Btn_Stop;
    }
}
