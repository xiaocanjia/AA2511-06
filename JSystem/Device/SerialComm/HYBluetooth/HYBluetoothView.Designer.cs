namespace JSystem.Device
{
    partial class HYBluetoothView
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
            this.Btn_ConnectBT = new Sunny.UI.UIButton();
            this.TB_Mac = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.Btn_DisConnectBT = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // Btn_ConnectBT
            // 
            this.Btn_ConnectBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ConnectBT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_ConnectBT.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_ConnectBT.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_ConnectBT.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_ConnectBT.Location = new System.Drawing.Point(118, 428);
            this.Btn_ConnectBT.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_ConnectBT.Name = "Btn_ConnectBT";
            this.Btn_ConnectBT.RectColor = System.Drawing.Color.White;
            this.Btn_ConnectBT.Size = new System.Drawing.Size(77, 33);
            this.Btn_ConnectBT.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_ConnectBT.StyleCustomMode = true;
            this.Btn_ConnectBT.TabIndex = 239;
            this.Btn_ConnectBT.Text = "连接";
            this.Btn_ConnectBT.Click += new System.EventHandler(this.Btn_ConnectBT_Click);
            // 
            // TB_Mac
            // 
            this.TB_Mac.ButtonSymbol = 61761;
            this.TB_Mac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Mac.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Mac.Location = new System.Drawing.Point(118, 377);
            this.TB_Mac.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Mac.Maximum = 2147483647D;
            this.TB_Mac.Minimum = -2147483648D;
            this.TB_Mac.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Mac.Name = "TB_Mac";
            this.TB_Mac.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Mac.Size = new System.Drawing.Size(241, 29);
            this.TB_Mac.TabIndex = 240;
            this.TB_Mac.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(22, 381);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(76, 25);
            this.uiLabel5.TabIndex = 241;
            this.uiLabel5.Text = "蓝牙地址";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_DisConnectBT
            // 
            this.Btn_DisConnectBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DisConnectBT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_DisConnectBT.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_DisConnectBT.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_DisConnectBT.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_DisConnectBT.Location = new System.Drawing.Point(282, 428);
            this.Btn_DisConnectBT.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_DisConnectBT.Name = "Btn_DisConnectBT";
            this.Btn_DisConnectBT.RectColor = System.Drawing.Color.White;
            this.Btn_DisConnectBT.Size = new System.Drawing.Size(77, 33);
            this.Btn_DisConnectBT.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_DisConnectBT.StyleCustomMode = true;
            this.Btn_DisConnectBT.TabIndex = 242;
            this.Btn_DisConnectBT.Text = "断开";
            this.Btn_DisConnectBT.Click += new System.EventHandler(this.Btn_DisConnectBT_Click);
            // 
            // HYBluetoothView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_DisConnectBT);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.TB_Mac);
            this.Controls.Add(this.Btn_ConnectBT);
            this.Name = "HYBluetoothView";
            this.Size = new System.Drawing.Size(1023, 798);
            this.Controls.SetChildIndex(this.Btn_ConnectBT, 0);
            this.Controls.SetChildIndex(this.TB_Mac, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.Btn_DisConnectBT, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton Btn_ConnectBT;
        private Sunny.UI.UITextBox TB_Mac;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton Btn_DisConnectBT;
    }
}
