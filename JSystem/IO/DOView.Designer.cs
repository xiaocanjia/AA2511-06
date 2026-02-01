namespace JSystem.IO
{
    partial class DOView
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
            this.Panel_Back = new Sunny.UI.UIPanel();
            this.Switch_IsOn = new Sunny.UI.UISwitch();
            this.Lbl_Name = new Sunny.UI.UILabel();
            this.Panel_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Back
            // 
            this.Panel_Back.Controls.Add(this.Switch_IsOn);
            this.Panel_Back.Controls.Add(this.Lbl_Name);
            this.Panel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Back.FillColor = System.Drawing.Color.Gainsboro;
            this.Panel_Back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_Back.Location = new System.Drawing.Point(0, 0);
            this.Panel_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Back.MinimumSize = new System.Drawing.Size(1, 1);
            this.Panel_Back.Name = "Panel_Back";
            this.Panel_Back.Radius = 10;
            this.Panel_Back.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Panel_Back.Size = new System.Drawing.Size(245, 40);
            this.Panel_Back.Style = Sunny.UI.UIStyle.Custom;
            this.Panel_Back.StyleCustomMode = true;
            this.Panel_Back.TabIndex = 0;
            this.Panel_Back.Text = null;
            this.Panel_Back.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Switch_IsOn
            // 
            this.Switch_IsOn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Switch_IsOn.BackColor = System.Drawing.Color.Transparent;
            this.Switch_IsOn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Switch_IsOn.Location = new System.Drawing.Point(166, 7);
            this.Switch_IsOn.MinimumSize = new System.Drawing.Size(1, 1);
            this.Switch_IsOn.Name = "Switch_IsOn";
            this.Switch_IsOn.Size = new System.Drawing.Size(75, 29);
            this.Switch_IsOn.Style = Sunny.UI.UIStyle.Custom;
            this.Switch_IsOn.StyleCustomMode = true;
            this.Switch_IsOn.TabIndex = 169;
            this.Switch_IsOn.Text = "uiSwitch1";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Name.Location = new System.Drawing.Point(7, 5);
            this.Lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(155, 31);
            this.Lbl_Name.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Name.TabIndex = 168;
            this.Lbl_Name.Text = "名称";
            this.Lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Name.Click += new System.EventHandler(this.Lbl_Name_Click);
            // 
            // DOView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel_Back);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 5, 4);
            this.Name = "DOView";
            this.Size = new System.Drawing.Size(245, 40);
            this.Panel_Back.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel Panel_Back;
        private Sunny.UI.UISwitch Switch_IsOn;
        private Sunny.UI.UILabel Lbl_Name;
    }
}
