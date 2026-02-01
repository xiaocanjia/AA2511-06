namespace JSystem.Device
{
    partial class BleBluetoothView
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
            this.TB_Guid_Tx = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_Guid_Rx = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // TB_Guid_Tx
            // 
            this.TB_Guid_Tx.ButtonSymbol = 61761;
            this.TB_Guid_Tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Guid_Tx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Guid_Tx.Location = new System.Drawing.Point(118, 286);
            this.TB_Guid_Tx.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Guid_Tx.Maximum = 2147483647D;
            this.TB_Guid_Tx.Minimum = -2147483648D;
            this.TB_Guid_Tx.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Guid_Tx.Name = "TB_Guid_Tx";
            this.TB_Guid_Tx.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Guid_Tx.Size = new System.Drawing.Size(260, 29);
            this.TB_Guid_Tx.TabIndex = 210;
            this.TB_Guid_Tx.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Guid_Tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Guid_Tx.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(17, 288);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(85, 25);
            this.uiLabel5.TabIndex = 209;
            this.uiLabel5.Text = "GuidTx";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Guid_Rx
            // 
            this.TB_Guid_Rx.ButtonSymbol = 61761;
            this.TB_Guid_Rx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Guid_Rx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Guid_Rx.Location = new System.Drawing.Point(118, 329);
            this.TB_Guid_Rx.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Guid_Rx.Maximum = 2147483647D;
            this.TB_Guid_Rx.Minimum = -2147483648D;
            this.TB_Guid_Rx.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Guid_Rx.Name = "TB_Guid_Rx";
            this.TB_Guid_Rx.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Guid_Rx.Size = new System.Drawing.Size(260, 29);
            this.TB_Guid_Rx.TabIndex = 212;
            this.TB_Guid_Rx.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Guid_Rx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Guid_Rx.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(17, 331);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(85, 25);
            this.uiLabel6.TabIndex = 211;
            this.uiLabel6.Text = "GuidRx";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BleBluetoothView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.TB_Guid_Rx);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.TB_Guid_Tx);
            this.Controls.Add(this.uiLabel5);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "BleBluetoothView";
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.TB_Guid_Tx, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.TB_Guid_Rx, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox TB_Guid_Tx;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TB_Guid_Rx;
        private Sunny.UI.UILabel uiLabel6;
    }
}
