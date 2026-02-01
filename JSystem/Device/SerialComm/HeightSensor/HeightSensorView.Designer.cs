namespace JSystem.Device
{
    partial class HeightSensorView
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
            this.Lbl_Height = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(28, 303);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(74, 27);
            this.uiLabel6.TabIndex = 249;
            this.uiLabel6.Text = "当前高度";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Height
            // 
            this.Lbl_Height.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Height.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Height.ForeColor = System.Drawing.Color.White;
            this.Lbl_Height.Location = new System.Drawing.Point(114, 303);
            this.Lbl_Height.Name = "Lbl_Height";
            this.Lbl_Height.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Height.TabIndex = 250;
            this.Lbl_Height.Text = "0.0";
            this.Lbl_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightSensorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Lbl_Height);
            this.Controls.Add(this.uiLabel6);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "HeightSensorView";
            this.Size = new System.Drawing.Size(1023, 800);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.Lbl_Height, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel Lbl_Height;
    }
}
