namespace JSystem
{
    partial class MainWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("主页");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("I/O");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("点位");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("设备");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("参数");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("视觉");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Label_Pdt = new Sunny.UI.UILabel();
            this.RBtn_Manual = new Sunny.UI.UIRadioButton();
            this.RBtn_Auto = new Sunny.UI.UIRadioButton();
            this.Lb_User = new Sunny.UI.UILabel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this._projectPanel = new JSystem.Project.ProjectPanel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Header.Controls.Add(this.uiAvatar1);
            this.Header.Controls.Add(this.Lb_User);
            this.Header.Controls.Add(this.Label_Pdt);
            this.Header.Controls.Add(this.RBtn_Manual);
            this.Header.Controls.Add(this.RBtn_Auto);
            this.Header.Controls.Add(this._projectPanel);
            this.Header.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.MenuHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Header.MenuSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.NodeAlignment = System.Drawing.StringAlignment.Near;
            treeNode1.Name = "Node_Home";
            treeNode1.Text = "主页";
            treeNode2.Name = "节点0";
            treeNode2.Text = "I/O";
            treeNode3.Name = "Node_Station";
            treeNode3.Text = "点位";
            treeNode4.Name = "Node_Device";
            treeNode4.Text = "设备";
            treeNode5.Name = "Node_Param";
            treeNode5.Text = "参数";
            treeNode6.Name = "节点0";
            treeNode6.Text = "视觉";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.Header.NodeSize = new System.Drawing.Size(105, 50);
            this.Header.SelectedForeColor = System.Drawing.Color.White;
            this.Header.SelectedHighColor = System.Drawing.Color.Gainsboro;
            this.Header.Size = new System.Drawing.Size(1700, 90);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // Label_Pdt
            // 
            this.Label_Pdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Pdt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Pdt.ForeColor = System.Drawing.Color.White;
            this.Label_Pdt.Location = new System.Drawing.Point(1354, 15);
            this.Label_Pdt.Name = "Label_Pdt";
            this.Label_Pdt.Size = new System.Drawing.Size(82, 23);
            this.Label_Pdt.Style = Sunny.UI.UIStyle.Custom;
            this.Label_Pdt.TabIndex = 157;
            this.Label_Pdt.Text = "当前模式:";
            this.Label_Pdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RBtn_Manual
            // 
            this.RBtn_Manual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtn_Manual.BackColor = System.Drawing.Color.Transparent;
            this.RBtn_Manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBtn_Manual.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RBtn_Manual.ForeColor = System.Drawing.Color.White;
            this.RBtn_Manual.Location = new System.Drawing.Point(1557, 12);
            this.RBtn_Manual.MinimumSize = new System.Drawing.Size(1, 1);
            this.RBtn_Manual.Name = "RBtn_Manual";
            this.RBtn_Manual.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.RBtn_Manual.Size = new System.Drawing.Size(65, 29);
            this.RBtn_Manual.Style = Sunny.UI.UIStyle.Custom;
            this.RBtn_Manual.TabIndex = 156;
            this.RBtn_Manual.Text = "手动";
            this.RBtn_Manual.CheckedChanged += new System.EventHandler(this.RBtn_Mode_CheckedChanged);
            // 
            // RBtn_Auto
            // 
            this.RBtn_Auto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtn_Auto.BackColor = System.Drawing.Color.Transparent;
            this.RBtn_Auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBtn_Auto.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RBtn_Auto.ForeColor = System.Drawing.Color.White;
            this.RBtn_Auto.Location = new System.Drawing.Point(1463, 12);
            this.RBtn_Auto.MinimumSize = new System.Drawing.Size(1, 1);
            this.RBtn_Auto.Name = "RBtn_Auto";
            this.RBtn_Auto.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.RBtn_Auto.Size = new System.Drawing.Size(65, 29);
            this.RBtn_Auto.Style = Sunny.UI.UIStyle.Custom;
            this.RBtn_Auto.TabIndex = 155;
            this.RBtn_Auto.Text = "自动";
            this.RBtn_Auto.CheckedChanged += new System.EventHandler(this.RBtn_Mode_CheckedChanged);
            // 
            // Lb_User
            // 
            this.Lb_User.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_User.ForeColor = System.Drawing.Color.White;
            this.Lb_User.Location = new System.Drawing.Point(20, 69);
            this.Lb_User.Name = "Lb_User";
            this.Lb_User.Size = new System.Drawing.Size(60, 21);
            this.Lb_User.Style = Sunny.UI.UIStyle.Custom;
            this.Lb_User.TabIndex = 158;
            this.Lb_User.Text = "操作员";
            this.Lb_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Location = new System.Drawing.Point(11, 3);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(74, 63);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.TabIndex = 159;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Click += new System.EventHandler(this.Avatar_Click);
            // 
            // _projectPanel
            // 
            this._projectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._projectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this._projectPanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._projectPanel.Location = new System.Drawing.Point(1351, 48);
            this._projectPanel.Margin = new System.Windows.Forms.Padding(4);
            this._projectPanel.Name = "_projectPanel";
            this._projectPanel.Size = new System.Drawing.Size(337, 38);
            this._projectPanel.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1700, 1030);
            this.CloseAskString = "";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1030);
            this.Name = "MainWindow";
            this.RectColor = System.Drawing.Color.Gainsboro;
            this.ShowIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "滚压&压合设备 V1.27";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.Gainsboro;
            this.TitleFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleForeColor = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Project.ProjectPanel _projectPanel;
        private Sunny.UI.UILabel Label_Pdt;
        private Sunny.UI.UIRadioButton RBtn_Manual;
        private Sunny.UI.UIRadioButton RBtn_Auto;
        private Sunny.UI.UILabel Lb_User;
        private Sunny.UI.UIAvatar uiAvatar1;
    }
}