namespace JSystem.Device
{
    partial class BarometerView
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
            this.Btn_Write = new Sunny.UI.UIButton();
            this.TB_Write_HRs_Data = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.Btn_Read = new Sunny.UI.UIButton();
            this.Lbl_HRs_Value = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // Btn_Write
            // 
            this.Btn_Write.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Write.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Write.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Write.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Write.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Write.Location = new System.Drawing.Point(210, 377);
            this.Btn_Write.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Write.Name = "Btn_Write";
            this.Btn_Write.RectColor = System.Drawing.Color.White;
            this.Btn_Write.Size = new System.Drawing.Size(66, 26);
            this.Btn_Write.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Write.StyleCustomMode = true;
            this.Btn_Write.TabIndex = 239;
            this.Btn_Write.Text = "设置";
            this.Btn_Write.Click += new System.EventHandler(this.Btn_Write_Click);
            // 
            // TB_Write_HRs_Data
            // 
            this.TB_Write_HRs_Data.ButtonSymbol = 61761;
            this.TB_Write_HRs_Data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Write_HRs_Data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Write_HRs_Data.Location = new System.Drawing.Point(85, 374);
            this.TB_Write_HRs_Data.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Write_HRs_Data.Maximum = 2147483647D;
            this.TB_Write_HRs_Data.Minimum = -2147483648D;
            this.TB_Write_HRs_Data.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Write_HRs_Data.Name = "TB_Write_HRs_Data";
            this.TB_Write_HRs_Data.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Write_HRs_Data.Size = new System.Drawing.Size(86, 29);
            this.TB_Write_HRs_Data.TabIndex = 239;
            this.TB_Write_HRs_Data.Text = "0";
            this.TB_Write_HRs_Data.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.White;
            this.uiLabel12.Location = new System.Drawing.Point(21, 378);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(56, 25);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.StyleCustomMode = true;
            this.uiLabel12.TabIndex = 238;
            this.uiLabel12.Text = "数据";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Read
            // 
            this.Btn_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Read.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Read.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Read.Location = new System.Drawing.Point(210, 331);
            this.Btn_Read.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.RectColor = System.Drawing.Color.White;
            this.Btn_Read.Size = new System.Drawing.Size(66, 26);
            this.Btn_Read.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Read.StyleCustomMode = true;
            this.Btn_Read.TabIndex = 239;
            this.Btn_Read.Text = "读取";
            this.Btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // Lbl_HRs_Value
            // 
            this.Lbl_HRs_Value.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_HRs_Value.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_HRs_Value.ForeColor = System.Drawing.Color.White;
            this.Lbl_HRs_Value.Location = new System.Drawing.Point(81, 332);
            this.Lbl_HRs_Value.Name = "Lbl_HRs_Value";
            this.Lbl_HRs_Value.Size = new System.Drawing.Size(113, 25);
            this.Lbl_HRs_Value.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_HRs_Value.StyleCustomMode = true;
            this.Lbl_HRs_Value.TabIndex = 241;
            this.Lbl_HRs_Value.Text = "0";
            this.Lbl_HRs_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(22, 332);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(60, 25);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.StyleCustomMode = true;
            this.uiLabel8.TabIndex = 240;
            this.uiLabel8.Text = "当前值";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarometerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Read);
            this.Controls.Add(this.Lbl_HRs_Value);
            this.Controls.Add(this.Btn_Write);
            this.Controls.Add(this.TB_Write_HRs_Data);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel8);
            this.Name = "BarometerView";
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.uiLabel12, 0);
            this.Controls.SetChildIndex(this.TB_Write_HRs_Data, 0);
            this.Controls.SetChildIndex(this.Btn_Write, 0);
            this.Controls.SetChildIndex(this.Lbl_HRs_Value, 0);
            this.Controls.SetChildIndex(this.Btn_Read, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIButton Btn_Write;
        private Sunny.UI.UITextBox TB_Write_HRs_Data;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIButton Btn_Read;
        private Sunny.UI.UILabel Lbl_HRs_Value;
        private Sunny.UI.UILabel uiLabel8;
    }
}
