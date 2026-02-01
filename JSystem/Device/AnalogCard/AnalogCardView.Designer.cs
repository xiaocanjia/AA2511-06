namespace JSystem.Device
{
    partial class AnalogCardView
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
            this.Btn_Connect = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(191, 138);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 173;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // AnalogCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Btn_Connect);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnalogCardView";
            this.Size = new System.Drawing.Size(540, 790);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton Btn_Connect;
    }
}
