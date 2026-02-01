namespace JSystem.Station
{
    partial class AxisCoordPanel
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
            this.Tb_Pos = new Sunny.UI.UITextBox();
            this.TB_Speed = new Sunny.UI.UITextBox();
            this.lblAxName = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.CbB_Axes = new Sunny.UI.UIComboBox();
            this.Btn_MoveToPos = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.TB_TimeOut = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // Tb_Pos
            // 
            this.Tb_Pos.ButtonSymbol = 61761;
            this.Tb_Pos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tb_Pos.DecLength = 4;
            this.Tb_Pos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Tb_Pos.Location = new System.Drawing.Point(220, 5);
            this.Tb_Pos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_Pos.Maximum = 2147483647D;
            this.Tb_Pos.Minimum = -2147483648D;
            this.Tb_Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.Tb_Pos.Name = "Tb_Pos";
            this.Tb_Pos.Padding = new System.Windows.Forms.Padding(5);
            this.Tb_Pos.Size = new System.Drawing.Size(75, 29);
            this.Tb_Pos.Style = Sunny.UI.UIStyle.Custom;
            this.Tb_Pos.TabIndex = 173;
            this.Tb_Pos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_Pos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.Tb_Pos.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TB_Speed
            // 
            this.TB_Speed.ButtonSymbol = 61761;
            this.TB_Speed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Speed.DecLength = 4;
            this.TB_Speed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Speed.Location = new System.Drawing.Point(346, 5);
            this.TB_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Speed.Maximum = 2147483647D;
            this.TB_Speed.Minimum = -2147483648D;
            this.TB_Speed.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Speed.Name = "TB_Speed";
            this.TB_Speed.Padding = new System.Windows.Forms.Padding(5);
            this.TB_Speed.Size = new System.Drawing.Size(75, 29);
            this.TB_Speed.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Speed.TabIndex = 173;
            this.TB_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TB_Speed.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // lblAxName
            // 
            this.lblAxName.AutoSize = true;
            this.lblAxName.BackColor = System.Drawing.Color.Transparent;
            this.lblAxName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblAxName.Location = new System.Drawing.Point(174, 9);
            this.lblAxName.Name = "lblAxName";
            this.lblAxName.Size = new System.Drawing.Size(42, 21);
            this.lblAxName.Style = Sunny.UI.UIStyle.Custom;
            this.lblAxName.TabIndex = 175;
            this.lblAxName.Text = "坐标";
            this.lblAxName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(302, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(42, 21);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 176;
            this.uiLabel1.Text = "速度";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Axes
            // 
            this.CbB_Axes.DataSource = null;
            this.CbB_Axes.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Axes.FillColor = System.Drawing.Color.White;
            this.CbB_Axes.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Axes.Location = new System.Drawing.Point(9, 5);
            this.CbB_Axes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Axes.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Axes.Name = "CbB_Axes";
            this.CbB_Axes.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Axes.Size = new System.Drawing.Size(155, 29);
            this.CbB_Axes.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Axes.StyleCustomMode = true;
            this.CbB_Axes.TabIndex = 177;
            this.CbB_Axes.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.CbB_Axes.SelectedIndexChanged += new System.EventHandler(this.CbB_Axes_SelectedIndexChanged);
            // 
            // Btn_MoveToPos
            // 
            this.Btn_MoveToPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MoveToPos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_MoveToPos.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_MoveToPos.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_MoveToPos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_MoveToPos.Location = new System.Drawing.Point(560, 4);
            this.Btn_MoveToPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_MoveToPos.Name = "Btn_MoveToPos";
            this.Btn_MoveToPos.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_MoveToPos.Size = new System.Drawing.Size(56, 30);
            this.Btn_MoveToPos.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_MoveToPos.StyleCustomMode = true;
            this.Btn_MoveToPos.TabIndex = 178;
            this.Btn_MoveToPos.Text = "Go";
            this.Btn_MoveToPos.Click += new System.EventHandler(this.Btn_MoveToPos_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(429, 9);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(42, 21);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 180;
            this.uiLabel2.Text = "超时";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_TimeOut
            // 
            this.TB_TimeOut.ButtonSymbol = 61761;
            this.TB_TimeOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_TimeOut.DecLength = 4;
            this.TB_TimeOut.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_TimeOut.Location = new System.Drawing.Point(473, 5);
            this.TB_TimeOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TimeOut.Maximum = 2147483647D;
            this.TB_TimeOut.Minimum = -2147483648D;
            this.TB_TimeOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_TimeOut.Name = "TB_TimeOut";
            this.TB_TimeOut.Padding = new System.Windows.Forms.Padding(5);
            this.TB_TimeOut.Size = new System.Drawing.Size(75, 29);
            this.TB_TimeOut.Style = Sunny.UI.UIStyle.Custom;
            this.TB_TimeOut.TabIndex = 179;
            this.TB_TimeOut.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AxisCoordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.TB_TimeOut);
            this.Controls.Add(this.Btn_MoveToPos);
            this.Controls.Add(this.CbB_Axes);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.lblAxName);
            this.Controls.Add(this.TB_Speed);
            this.Controls.Add(this.Tb_Pos);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Name = "AxisCoordPanel";
            this.Size = new System.Drawing.Size(623, 37);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.Leave += new System.EventHandler(this.TextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox Tb_Pos;
        private Sunny.UI.UITextBox TB_Speed;
        private Sunny.UI.UILabel lblAxName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox CbB_Axes;
        private Sunny.UI.UIButton Btn_MoveToPos;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox TB_TimeOut;
    }
}
