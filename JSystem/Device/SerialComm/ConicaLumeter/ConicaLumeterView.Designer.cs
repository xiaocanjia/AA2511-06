namespace JSystem.Device
{
    partial class ConicaLumeterView
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
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Lbl_Lux = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Offset = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(28, 374);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(74, 27);
            this.uiLabel6.TabIndex = 249;
            this.uiLabel6.Text = "当前照度";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Lux
            // 
            this.Lbl_Lux.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Lux.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Lux.ForeColor = System.Drawing.Color.White;
            this.Lbl_Lux.Location = new System.Drawing.Point(114, 374);
            this.Lbl_Lux.Name = "Lbl_Lux";
            this.Lbl_Lux.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Lux.TabIndex = 250;
            this.Lbl_Lux.Text = "0.0";
            this.Lbl_Lux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(22, 309);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(76, 25);
            this.uiLabel5.TabIndex = 252;
            this.uiLabel5.Text = "偏移量";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Offset
            // 
            this.TB_Offset.ButtonSymbol = 61761;
            this.TB_Offset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Offset.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Offset.Location = new System.Drawing.Point(118, 305);
            this.TB_Offset.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Offset.Maximum = 2147483647D;
            this.TB_Offset.Minimum = -2147483648D;
            this.TB_Offset.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Offset.Name = "TB_Offset";
            this.TB_Offset.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Offset.Size = new System.Drawing.Size(241, 29);
            this.TB_Offset.TabIndex = 251;
            this.TB_Offset.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Offset.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ConicaLumeterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.TB_Offset);
            this.Controls.Add(this.Lbl_Lux);
            this.Controls.Add(this.uiLabel6);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ConicaLumeterView";
            this.Size = new System.Drawing.Size(1023, 800);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.Lbl_Lux, 0);
            this.Controls.SetChildIndex(this.TB_Offset, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel Lbl_Lux;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Offset;
    }
}
