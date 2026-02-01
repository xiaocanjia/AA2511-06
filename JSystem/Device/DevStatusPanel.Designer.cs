namespace JSystem.Device
{
    partial class DevStatusPanel
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.Lbl_Status = new Sunny.UI.UILabel();
            this.Lbl_Name = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.Lbl_Status);
            this.uiPanel1.Controls.Add(this.Lbl_Name);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.Gainsboro;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.uiPanel1.Size = new System.Drawing.Size(260, 40);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Status.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Status.Location = new System.Drawing.Point(176, 9);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(79, 23);
            this.Lbl_Status.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Status.TabIndex = 1;
            this.Lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Status.Click += new System.EventHandler(this.Lbl_Status_Click);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Name.Location = new System.Drawing.Point(3, 9);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(143, 23);
            this.Lbl_Name.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Name";
            this.Lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DevStatusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.Name = "DevStatusPanel";
            this.Size = new System.Drawing.Size(260, 40);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel Lbl_Status;
        private Sunny.UI.UILabel Lbl_Name;
    }
}
