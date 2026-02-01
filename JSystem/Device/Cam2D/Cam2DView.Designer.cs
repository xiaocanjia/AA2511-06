namespace JSystem.Device
{
    partial class Cam2DView
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.CbB_Cam_Type = new Sunny.UI.UIComboBox();
            this.TB_Gain = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.Btn_Grab = new Sunny.UI.UIButton();
            this.HControl = new HalconDotNet.HWindowControl();
            this.CB_Enabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(52, 220);
            this.Btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.RectColor = System.Drawing.Color.White;
            this.Btn_Connect.Size = new System.Drawing.Size(100, 40);
            this.Btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Connect.StyleCustomMode = true;
            this.Btn_Connect.TabIndex = 172;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(21, 36);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(78, 23);
            this.uiLabel2.TabIndex = 171;
            this.uiLabel2.Text = "相机类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Cam_Type
            // 
            this.CbB_Cam_Type.DataSource = null;
            this.CbB_Cam_Type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Cam_Type.FillColor = System.Drawing.Color.White;
            this.CbB_Cam_Type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Cam_Type.Location = new System.Drawing.Point(116, 30);
            this.CbB_Cam_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Cam_Type.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Cam_Type.Name = "CbB_Cam_Type";
            this.CbB_Cam_Type.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Cam_Type.Size = new System.Drawing.Size(266, 29);
            this.CbB_Cam_Type.TabIndex = 170;
            this.CbB_Cam_Type.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.CbB_Cam_Type.SelectedIndexChanged += new System.EventHandler(this.CbB_Cam_Type_SelectedIndexChanged);
            // 
            // TB_Gain
            // 
            this.TB_Gain.ButtonSymbol = 61761;
            this.TB_Gain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Gain.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Gain.Location = new System.Drawing.Point(116, 82);
            this.TB_Gain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Gain.Maximum = 2147483647D;
            this.TB_Gain.Minimum = -2147483648D;
            this.TB_Gain.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Gain.Name = "TB_Gain";
            this.TB_Gain.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Gain.Size = new System.Drawing.Size(266, 29);
            this.TB_Gain.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Gain.TabIndex = 217;
            this.TB_Gain.Text = "0";
            this.TB_Gain.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Gain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Gain.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(21, 86);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(78, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 216;
            this.uiLabel4.Text = "增益";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Grab
            // 
            this.Btn_Grab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Grab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Grab.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Grab.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Grab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Grab.Location = new System.Drawing.Point(244, 220);
            this.Btn_Grab.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Grab.Name = "Btn_Grab";
            this.Btn_Grab.RectColor = System.Drawing.Color.White;
            this.Btn_Grab.Size = new System.Drawing.Size(100, 40);
            this.Btn_Grab.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Grab.StyleCustomMode = true;
            this.Btn_Grab.TabIndex = 218;
            this.Btn_Grab.Text = "采集";
            this.Btn_Grab.Click += new System.EventHandler(this.Btn_Grab_Click);
            // 
            // HControl
            // 
            this.HControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HControl.BackColor = System.Drawing.Color.Black;
            this.HControl.BorderColor = System.Drawing.Color.Black;
            this.HControl.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.HControl.Location = new System.Drawing.Point(430, 30);
            this.HControl.Name = "HControl";
            this.HControl.Size = new System.Drawing.Size(866, 747);
            this.HControl.TabIndex = 219;
            this.HControl.WindowSize = new System.Drawing.Size(866, 747);
            // 
            // CB_Enabled
            // 
            this.CB_Enabled.AutoSize = true;
            this.CB_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.CB_Enabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CB_Enabled.ForeColor = System.Drawing.Color.White;
            this.CB_Enabled.Location = new System.Drawing.Point(25, 149);
            this.CB_Enabled.Name = "CB_Enabled";
            this.CB_Enabled.Size = new System.Drawing.Size(93, 25);
            this.CB_Enabled.TabIndex = 226;
            this.CB_Enabled.Text = "是否启用";
            this.CB_Enabled.UseVisualStyleBackColor = false;
            // 
            // Cam2DView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.CB_Enabled);
            this.Controls.Add(this.HControl);
            this.Controls.Add(this.Btn_Grab);
            this.Controls.Add(this.TB_Gain);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_Cam_Type);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cam2DView";
            this.Size = new System.Drawing.Size(1323, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Cam_Type;
        private Sunny.UI.UITextBox TB_Gain;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton Btn_Grab;
        private HalconDotNet.HWindowControl HControl;
        private System.Windows.Forms.CheckBox CB_Enabled;
    }
}
