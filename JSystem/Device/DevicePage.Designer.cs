namespace JSystem.Device
{
    partial class DevicePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab_Devices = new Sunny.UI.UITabControlMenu();
            this.SuspendLayout();
            // 
            // Tab_Devices
            // 
            this.Tab_Devices.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Tab_Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Devices.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Tab_Devices.FillColor = System.Drawing.Color.Black;
            this.Tab_Devices.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Tab_Devices.ItemSize = new System.Drawing.Size(28, 160);
            this.Tab_Devices.Location = new System.Drawing.Point(0, 0);
            this.Tab_Devices.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Tab_Devices.Multiline = true;
            this.Tab_Devices.Name = "Tab_Devices";
            this.Tab_Devices.SelectedIndex = 0;
            this.Tab_Devices.Size = new System.Drawing.Size(1300, 788);
            this.Tab_Devices.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tab_Devices.Style = Sunny.UI.UIStyle.Custom;
            this.Tab_Devices.StyleCustomMode = true;
            this.Tab_Devices.TabBackColor = System.Drawing.Color.Gainsboro;
            this.Tab_Devices.TabIndex = 0;
            this.Tab_Devices.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Tab_Devices.TabSelectedForeColor = System.Drawing.Color.White;
            this.Tab_Devices.TabSelectedHighColor = System.Drawing.Color.Gainsboro;
            this.Tab_Devices.TabUnSelectedForeColor = System.Drawing.Color.Black;
            // 
            // DevicePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 788);
            this.Controls.Add(this.Tab_Devices);
            this.Name = "DevicePage";
            this.Text = "DebuggingPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu Tab_Devices;
    }
}