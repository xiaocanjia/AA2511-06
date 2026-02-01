namespace JSystem.Device
{
    partial class LightControllerView
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
            this.TB_Lightness = new Sunny.UI.UITextBox();
            this.Btn_Set_Lightness = new Sunny.UI.UIButton();
            this.TB_Channel = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(17, 304);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(85, 27);
            this.uiLabel5.TabIndex = 246;
            this.uiLabel5.Text = "亮度值";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Lightness
            // 
            this.TB_Lightness.ButtonSymbol = 61761;
            this.TB_Lightness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Lightness.DoubleValue = 250D;
            this.TB_Lightness.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Lightness.IntValue = 250;
            this.TB_Lightness.Location = new System.Drawing.Point(111, 302);
            this.TB_Lightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Lightness.Maximum = 2147483647D;
            this.TB_Lightness.Minimum = -2147483648D;
            this.TB_Lightness.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Lightness.Name = "TB_Lightness";
            this.TB_Lightness.Size = new System.Drawing.Size(161, 29);
            this.TB_Lightness.TabIndex = 247;
            this.TB_Lightness.Text = "250";
            this.TB_Lightness.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Set_Lightness
            // 
            this.Btn_Set_Lightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Set_Lightness.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Set_Lightness.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Set_Lightness.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Set_Lightness.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Set_Lightness.Location = new System.Drawing.Point(284, 338);
            this.Btn_Set_Lightness.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Set_Lightness.Name = "Btn_Set_Lightness";
            this.Btn_Set_Lightness.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Set_Lightness.Size = new System.Drawing.Size(78, 32);
            this.Btn_Set_Lightness.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Set_Lightness.StyleCustomMode = true;
            this.Btn_Set_Lightness.TabIndex = 248;
            this.Btn_Set_Lightness.Text = "测试";
            this.Btn_Set_Lightness.Click += new System.EventHandler(this.Btn_Set_Lightness_Click);
            // 
            // TB_Channel
            // 
            this.TB_Channel.ButtonSymbol = 61761;
            this.TB_Channel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Channel.DoubleValue = 1D;
            this.TB_Channel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Channel.IntValue = 1;
            this.TB_Channel.Location = new System.Drawing.Point(111, 341);
            this.TB_Channel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Channel.Maximum = 2147483647D;
            this.TB_Channel.Minimum = -2147483648D;
            this.TB_Channel.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Channel.Name = "TB_Channel";
            this.TB_Channel.Size = new System.Drawing.Size(161, 29);
            this.TB_Channel.TabIndex = 249;
            this.TB_Channel.Text = "1";
            this.TB_Channel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(17, 343);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(85, 27);
            this.uiLabel6.TabIndex = 248;
            this.uiLabel6.Text = "通道号";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LightControllerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.TB_Channel);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.Btn_Set_Lightness);
            this.Controls.Add(this.TB_Lightness);
            this.Controls.Add(this.uiLabel5);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "LightControllerView";
            this.Size = new System.Drawing.Size(1023, 800);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.TB_Lightness, 0);
            this.Controls.SetChildIndex(this.Btn_Set_Lightness, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.TB_Channel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Lightness;
        private Sunny.UI.UIButton Btn_Set_Lightness;
        private Sunny.UI.UITextBox TB_Channel;
        private Sunny.UI.UILabel uiLabel6;
    }
}
