namespace JSystem.Device
{
    partial class RollPressSensorView
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
            this.components = new System.ComponentModel.Container();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Lb_Pressure = new Sunny.UI.UILabel();
            this.Btn_Read = new Sunny.UI.UIButton();
            this.MonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(18, 261);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(74, 27);
            this.uiLabel6.TabIndex = 249;
            this.uiLabel6.Text = "当前压力";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Pressure
            // 
            this.Lb_Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Pressure.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lb_Pressure.ForeColor = System.Drawing.Color.White;
            this.Lb_Pressure.Location = new System.Drawing.Point(104, 261);
            this.Lb_Pressure.Name = "Lb_Pressure";
            this.Lb_Pressure.Size = new System.Drawing.Size(91, 27);
            this.Lb_Pressure.TabIndex = 250;
            this.Lb_Pressure.Text = "0.0";
            this.Lb_Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Read
            // 
            this.Btn_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Read.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Read.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Read.Location = new System.Drawing.Point(243, 261);
            this.Btn_Read.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.RectColor = System.Drawing.Color.White;
            this.Btn_Read.Size = new System.Drawing.Size(66, 26);
            this.Btn_Read.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Read.StyleCustomMode = true;
            this.Btn_Read.TabIndex = 251;
            this.Btn_Read.Text = "读取";
            this.Btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // MonitorTimer
            // 
            this.MonitorTimer.Tick += new System.EventHandler(this.MonitorTimer_Tick);
            // 
            // RollPressSensorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Btn_Read);
            this.Controls.Add(this.Lb_Pressure);
            this.Controls.Add(this.uiLabel6);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "RollPressSensorView";
            this.Size = new System.Drawing.Size(1023, 800);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.Lb_Pressure, 0);
            this.Controls.SetChildIndex(this.Btn_Read, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel Lb_Pressure;
        private Sunny.UI.UIButton Btn_Read;
        private System.Windows.Forms.Timer MonitorTimer;
    }
}
