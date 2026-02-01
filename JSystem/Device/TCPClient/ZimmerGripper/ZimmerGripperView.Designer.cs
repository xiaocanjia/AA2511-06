namespace JSystem.Device
{
    partial class ZimmerGripperView
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
            this.TB_Force = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TB_Teach_Pos = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.TB_Tolerance = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.Btn_Tighten = new Sunny.UI.UIButton();
            this.Btn_Release = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.Lbl_Status = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.CbB_Channel = new Sunny.UI.UIComboBox();
            this.Label_Error = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.Lbl_Pos = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.Btn_Read = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // TB_Force
            // 
            this.TB_Force.ButtonSymbol = 61761;
            this.TB_Force.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Force.DoubleValue = 1D;
            this.TB_Force.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Force.IntValue = 1;
            this.TB_Force.Location = new System.Drawing.Point(114, 376);
            this.TB_Force.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Force.Maximum = 2147483647D;
            this.TB_Force.Minimum = -2147483648D;
            this.TB_Force.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Force.Name = "TB_Force";
            this.TB_Force.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Force.Size = new System.Drawing.Size(254, 29);
            this.TB_Force.TabIndex = 235;
            this.TB_Force.Text = "1";
            this.TB_Force.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(19, 378);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(87, 25);
            this.uiLabel1.TabIndex = 234;
            this.uiLabel1.Text = "加持力";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Teach_Pos
            // 
            this.TB_Teach_Pos.ButtonSymbol = 61761;
            this.TB_Teach_Pos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Teach_Pos.DoubleValue = 1500D;
            this.TB_Teach_Pos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Teach_Pos.IntValue = 1500;
            this.TB_Teach_Pos.Location = new System.Drawing.Point(114, 290);
            this.TB_Teach_Pos.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Teach_Pos.Maximum = 2147483647D;
            this.TB_Teach_Pos.Minimum = -2147483648D;
            this.TB_Teach_Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Teach_Pos.Name = "TB_Teach_Pos";
            this.TB_Teach_Pos.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Teach_Pos.Size = new System.Drawing.Size(254, 29);
            this.TB_Teach_Pos.TabIndex = 237;
            this.TB_Teach_Pos.Text = "1500";
            this.TB_Teach_Pos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(19, 292);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(87, 25);
            this.uiLabel2.TabIndex = 236;
            this.uiLabel2.Text = "示教位置";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_Tolerance
            // 
            this.TB_Tolerance.ButtonSymbol = 61761;
            this.TB_Tolerance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Tolerance.DoubleValue = 255D;
            this.TB_Tolerance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TB_Tolerance.IntValue = 255;
            this.TB_Tolerance.Location = new System.Drawing.Point(114, 333);
            this.TB_Tolerance.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TB_Tolerance.Maximum = 2147483647D;
            this.TB_Tolerance.Minimum = -2147483648D;
            this.TB_Tolerance.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Tolerance.Name = "TB_Tolerance";
            this.TB_Tolerance.Padding = new System.Windows.Forms.Padding(7);
            this.TB_Tolerance.Size = new System.Drawing.Size(254, 29);
            this.TB_Tolerance.TabIndex = 239;
            this.TB_Tolerance.Text = "255";
            this.TB_Tolerance.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(19, 335);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(87, 25);
            this.uiLabel3.TabIndex = 238;
            this.uiLabel3.Text = "允许偏差";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Tighten
            // 
            this.Btn_Tighten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Tighten.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Tighten.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Tighten.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Tighten.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Tighten.Location = new System.Drawing.Point(69, 576);
            this.Btn_Tighten.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Tighten.Name = "Btn_Tighten";
            this.Btn_Tighten.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Tighten.Size = new System.Drawing.Size(87, 35);
            this.Btn_Tighten.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Tighten.StyleCustomMode = true;
            this.Btn_Tighten.TabIndex = 240;
            this.Btn_Tighten.Text = "夹紧";
            this.Btn_Tighten.Click += new System.EventHandler(this.Btn_Tighten_Click);
            // 
            // Btn_Release
            // 
            this.Btn_Release.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Release.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Release.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Release.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Release.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Release.Location = new System.Drawing.Point(222, 576);
            this.Btn_Release.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Release.Name = "Btn_Release";
            this.Btn_Release.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Release.Size = new System.Drawing.Size(87, 35);
            this.Btn_Release.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Release.StyleCustomMode = true;
            this.Btn_Release.TabIndex = 241;
            this.Btn_Release.Text = "松开";
            this.Btn_Release.Click += new System.EventHandler(this.Btn_Release_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(19, 428);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(87, 25);
            this.uiLabel4.TabIndex = 242;
            this.uiLabel4.Text = "状态";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Status.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Status.Location = new System.Drawing.Point(112, 428);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(87, 25);
            this.Lbl_Status.TabIndex = 243;
            this.Lbl_Status.Text = "0";
            this.Lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(19, 255);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(78, 23);
            this.uiLabel8.TabIndex = 245;
            this.uiLabel8.Text = "端口号";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbB_Channel
            // 
            this.CbB_Channel.DataSource = null;
            this.CbB_Channel.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CbB_Channel.FillColor = System.Drawing.Color.White;
            this.CbB_Channel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Channel.Items.AddRange(new object[] {
            "静置工站上传送夹爪",
            "备用1",
            "备用2",
            "备用3",
            "上下料转移夹爪",
            "传送轴1夹爪",
            "传送轴2夹爪",
            "抛料夹爪"});
            this.CbB_Channel.Location = new System.Drawing.Point(114, 249);
            this.CbB_Channel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Channel.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Channel.Name = "CbB_Channel";
            this.CbB_Channel.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.CbB_Channel.Size = new System.Drawing.Size(254, 29);
            this.CbB_Channel.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Channel.StyleCustomMode = true;
            this.CbB_Channel.TabIndex = 244;
            this.CbB_Channel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_Error
            // 
            this.Label_Error.BackColor = System.Drawing.Color.Transparent;
            this.Label_Error.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Label_Error.Location = new System.Drawing.Point(112, 469);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(87, 25);
            this.Label_Error.TabIndex = 247;
            this.Label_Error.Text = "0";
            this.Label_Error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(19, 469);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(87, 25);
            this.uiLabel9.TabIndex = 246;
            this.uiLabel9.Text = "错误";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Pos
            // 
            this.Lbl_Pos.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Pos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Pos.Location = new System.Drawing.Point(112, 512);
            this.Lbl_Pos.Name = "Lbl_Pos";
            this.Lbl_Pos.Size = new System.Drawing.Size(87, 25);
            this.Lbl_Pos.TabIndex = 249;
            this.Lbl_Pos.Text = "0";
            this.Lbl_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(19, 512);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(87, 25);
            this.uiLabel11.TabIndex = 248;
            this.uiLabel11.Text = "当前位置";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Read
            // 
            this.Btn_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Read.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Btn_Read.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Read.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Read.Location = new System.Drawing.Point(281, 459);
            this.Btn_Read.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Read.Size = new System.Drawing.Size(87, 35);
            this.Btn_Read.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Read.StyleCustomMode = true;
            this.Btn_Read.TabIndex = 250;
            this.Btn_Read.Text = "读取";
            this.Btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // ZimmerGripperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Read);
            this.Controls.Add(this.Lbl_Pos);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.CbB_Channel);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.Btn_Release);
            this.Controls.Add(this.Btn_Tighten);
            this.Controls.Add(this.TB_Tolerance);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.TB_Teach_Pos);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.TB_Force);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ZimmerGripperView";
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.TB_Force, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.TB_Teach_Pos, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.TB_Tolerance, 0);
            this.Controls.SetChildIndex(this.Btn_Tighten, 0);
            this.Controls.SetChildIndex(this.Btn_Release, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.Lbl_Status, 0);
            this.Controls.SetChildIndex(this.CbB_Channel, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.uiLabel9, 0);
            this.Controls.SetChildIndex(this.Label_Error, 0);
            this.Controls.SetChildIndex(this.uiLabel11, 0);
            this.Controls.SetChildIndex(this.Lbl_Pos, 0);
            this.Controls.SetChildIndex(this.Btn_Read, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox TB_Force;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TB_Teach_Pos;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox TB_Tolerance;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton Btn_Tighten;
        private Sunny.UI.UIButton Btn_Release;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel Lbl_Status;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboBox CbB_Channel;
        private Sunny.UI.UILabel Label_Error;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel Lbl_Pos;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIButton Btn_Read;
    }
}
