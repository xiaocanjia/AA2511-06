namespace JSystem.Device
{
    partial class BoardView
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
            this.CbB_Board_Type = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Connect.Location = new System.Drawing.Point(157, 108);
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
            this.uiLabel2.Cursor = System.Windows.Forms.Cursors.No;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(21, 36);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(78, 23);
            this.uiLabel2.TabIndex = 171;
            this.uiLabel2.Text = "板卡类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Board_Type
            // 
            this.CbB_Board_Type.DataSource = null;
            this.CbB_Board_Type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Board_Type.FillColor = System.Drawing.Color.White;
            this.CbB_Board_Type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Board_Type.Location = new System.Drawing.Point(116, 30);
            this.CbB_Board_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Board_Type.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Board_Type.Name = "CbB_Board_Type";
            this.CbB_Board_Type.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Board_Type.Size = new System.Drawing.Size(266, 29);
            this.CbB_Board_Type.TabIndex = 170;
            this.CbB_Board_Type.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.CbB_Board_Type.SelectedIndexChanged += new System.EventHandler(this.CbB_Cam_Type_SelectedIndexChanged);
            // 
            // BoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.CbB_Board_Type);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BoardView";
            this.Size = new System.Drawing.Size(552, 800);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton Btn_Connect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox CbB_Board_Type;
    }
}
