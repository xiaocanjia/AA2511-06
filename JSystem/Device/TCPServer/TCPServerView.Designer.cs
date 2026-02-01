namespace JSystem.Device
{
    partial class TCPServerView
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
            this.TB_Port = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Btn_Connect = new Sunny.UI.UIButton();
            this.CB_Enabled = new System.Windows.Forms.CheckBox();
            this.CB_Disp_Sync = new System.Windows.Forms.CheckBox();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.TB_Send = new Sunny.UI.UITextBox();
            this.CB_Is_Hex = new System.Windows.Forms.CheckBox();
            this.Btn_Send = new Sunny.UI.UIButton();
            this.TB_Log = new Sunny.UI.UITextBox();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Port
            // 
            this.TB_Port.ButtonSymbol = 61761;
            this.TB_Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Port.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Port.Location = new System.Drawing.Point(109, 36);
            this.TB_Port.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Port.Maximum = 2147483647D;
            this.TB_Port.Minimum = -2147483648D;
            this.TB_Port.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Port.Name = "TB_Port";
            this.TB_Port.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Port.Size = new System.Drawing.Size(260, 29);
            this.TB_Port.TabIndex = 216;
            this.TB_Port.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Port.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(20, 38);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(67, 25);
            this.uiLabel6.TabIndex = 215;
            this.uiLabel6.Text = "Port";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(232, 109);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 217;
            this.Btn_Connect.Text = "开始监听";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // CB_Enabled
            // 
            this.CB_Enabled.AutoSize = true;
            this.CB_Enabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Enabled.ForeColor = System.Drawing.Color.White;
            this.CB_Enabled.Location = new System.Drawing.Point(27, 117);
            this.CB_Enabled.Name = "CB_Enabled";
            this.CB_Enabled.Size = new System.Drawing.Size(93, 25);
            this.CB_Enabled.TabIndex = 230;
            this.CB_Enabled.Text = "是否启用";
            this.CB_Enabled.UseVisualStyleBackColor = true;
            // 
            // CB_Disp_Sync
            // 
            this.CB_Disp_Sync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Disp_Sync.AutoSize = true;
            this.CB_Disp_Sync.BackColor = System.Drawing.Color.Transparent;
            this.CB_Disp_Sync.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Disp_Sync.ForeColor = System.Drawing.Color.White;
            this.CB_Disp_Sync.Location = new System.Drawing.Point(405, 694);
            this.CB_Disp_Sync.Name = "CB_Disp_Sync";
            this.CB_Disp_Sync.Size = new System.Drawing.Size(93, 25);
            this.CB_Disp_Sync.TabIndex = 233;
            this.CB_Disp_Sync.Text = "实时显示";
            this.CB_Disp_Sync.UseVisualStyleBackColor = false;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTitlePanel1.Controls.Add(this.TB_Send);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(539, 659);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.Size = new System.Drawing.Size(479, 118);
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 237;
            this.uiTitlePanel1.Text = "发送区";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            // 
            // TB_Send
            // 
            this.TB_Send.AutoScroll = true;
            this.TB_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Send.ButtonSymbol = 61761;
            this.TB_Send.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Send.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Send.Location = new System.Drawing.Point(0, 35);
            this.TB_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Send.Maximum = 10D;
            this.TB_Send.MaxLength = 1024;
            this.TB_Send.Minimum = -2147483648D;
            this.TB_Send.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Send.Multiline = true;
            this.TB_Send.Name = "TB_Send";
            this.TB_Send.Size = new System.Drawing.Size(479, 83);
            this.TB_Send.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Send.StyleCustomMode = true;
            this.TB_Send.TabIndex = 229;
            this.TB_Send.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_Is_Hex
            // 
            this.CB_Is_Hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Is_Hex.AutoSize = true;
            this.CB_Is_Hex.BackColor = System.Drawing.Color.Transparent;
            this.CB_Is_Hex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Is_Hex.ForeColor = System.Drawing.Color.White;
            this.CB_Is_Hex.Location = new System.Drawing.Point(405, 661);
            this.CB_Is_Hex.Name = "CB_Is_Hex";
            this.CB_Is_Hex.Size = new System.Drawing.Size(111, 25);
            this.CB_Is_Hex.TabIndex = 236;
            this.CB_Is_Hex.Text = "16进制收发";
            this.CB_Is_Hex.UseVisualStyleBackColor = false;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Send.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Send.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Send.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Send.Location = new System.Drawing.Point(405, 737);
            this.Btn_Send.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.RectColor = System.Drawing.Color.White;
            this.Btn_Send.Size = new System.Drawing.Size(100, 40);
            this.Btn_Send.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Send.StyleCustomMode = true;
            this.Btn_Send.TabIndex = 235;
            this.Btn_Send.Text = "发送";
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // TB_Log
            // 
            this.TB_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Log.AutoScroll = true;
            this.TB_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Log.ButtonSymbol = 61761;
            this.TB_Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Log.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Log.Location = new System.Drawing.Point(405, 26);
            this.TB_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Log.Maximum = 10D;
            this.TB_Log.MaxLength = 1;
            this.TB_Log.Minimum = -2147483648D;
            this.TB_Log.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Log.Multiline = true;
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.ReadOnly = true;
            this.TB_Log.ShowScrollBar = true;
            this.TB_Log.Size = new System.Drawing.Size(613, 627);
            this.TB_Log.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Log.StyleCustomMode = true;
            this.TB_Log.TabIndex = 234;
            this.TB_Log.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TCPServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.CB_Is_Hex);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.TB_Log);
            this.Controls.Add(this.CB_Disp_Sync);
            this.Controls.Add(this.CB_Enabled);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.TB_Port);
            this.Controls.Add(this.uiLabel6);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCPServerView";
            this.Size = new System.Drawing.Size(1041, 800);
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox TB_Port;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton Btn_Connect;
        private System.Windows.Forms.CheckBox CB_Enabled;
        private System.Windows.Forms.CheckBox CB_Disp_Sync;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITextBox TB_Send;
        private System.Windows.Forms.CheckBox CB_Is_Hex;
        private Sunny.UI.UIButton Btn_Send;
        private Sunny.UI.UITextBox TB_Log;
    }
}
