namespace JSystem.Device
{
    partial class WeightSensorView
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
            this.Lbl_Weight1 = new Sunny.UI.UILabel();
            this.Lbl_Weight2 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(28, 303);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(74, 27);
            this.uiLabel6.TabIndex = 249;
            this.uiLabel6.Text = "通道1";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Weight1
            // 
            this.Lbl_Weight1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Weight1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Weight1.Location = new System.Drawing.Point(114, 303);
            this.Lbl_Weight1.Name = "Lbl_Weight1";
            this.Lbl_Weight1.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Weight1.TabIndex = 250;
            this.Lbl_Weight1.Text = "0.0";
            this.Lbl_Weight1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Weight2
            // 
            this.Lbl_Weight2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Weight2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Weight2.Location = new System.Drawing.Point(292, 303);
            this.Lbl_Weight2.Name = "Lbl_Weight2";
            this.Lbl_Weight2.Size = new System.Drawing.Size(60, 27);
            this.Lbl_Weight2.TabIndex = 252;
            this.Lbl_Weight2.Text = "0.0";
            this.Lbl_Weight2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(206, 303);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(74, 27);
            this.uiLabel7.TabIndex = 251;
            this.uiLabel7.Text = "通道2";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WeightSensorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Lbl_Weight2);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.Lbl_Weight1);
            this.Controls.Add(this.uiLabel6);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "WeightSensorView";
            this.Size = new System.Drawing.Size(1023, 800);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.Lbl_Weight1, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.Lbl_Weight2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel Lbl_Weight1;
        private Sunny.UI.UILabel Lbl_Weight2;
        private Sunny.UI.UILabel uiLabel7;
    }
}
