namespace JSystem.IO
{
    partial class IOPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Out = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_In = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Panel_Out, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Panel_In, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1378, 788);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Panel_Out
            // 
            this.Panel_Out.AutoScroll = true;
            this.Panel_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Panel_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Out.Location = new System.Drawing.Point(3, 3);
            this.Panel_Out.Name = "Panel_Out";
            this.Panel_Out.Size = new System.Drawing.Size(683, 782);
            this.Panel_Out.TabIndex = 5;
            // 
            // Panel_In
            // 
            this.Panel_In.AutoScroll = true;
            this.Panel_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Panel_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_In.Location = new System.Drawing.Point(692, 3);
            this.Panel_In.Name = "Panel_In";
            this.Panel_In.Size = new System.Drawing.Size(683, 782);
            this.Panel_In.TabIndex = 3;
            // 
            // IOPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1378, 788);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IOPage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "IOPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel Panel_In;
        private System.Windows.Forms.FlowLayoutPanel Panel_Out;
    }
}