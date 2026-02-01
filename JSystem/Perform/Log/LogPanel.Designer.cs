using System;

namespace JSystem.Perform
{
    partial class LogPanel
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
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { Dispose(disposing); }));
            }
            else
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.DatePicker_Error = new Sunny.UI.UIDatePicker();
            this.Tab_Log = new Sunny.UI.UITabControl();
            this.TP_Running_Log = new System.Windows.Forms.TabPage();
            this.TB_Running_Log = new Sunny.UI.UITextBox();
            this.TP_Error_Log = new System.Windows.Forms.TabPage();
            this.TB_Error_Log = new Sunny.UI.UITextBox();
            this.Btn_Open_Dir = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            this.Tab_Log.SuspendLayout();
            this.TP_Running_Log.SuspendLayout();
            this.TP_Error_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.DatePicker_Error);
            this.uiPanel1.Controls.Add(this.Tab_Log);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.uiPanel1.Size = new System.Drawing.Size(558, 185);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatePicker_Error
            // 
            this.DatePicker_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker_Error.FillColor = System.Drawing.Color.White;
            this.DatePicker_Error.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DatePicker_Error.Location = new System.Drawing.Point(388, 4);
            this.DatePicker_Error.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePicker_Error.MaxLength = 10;
            this.DatePicker_Error.MinimumSize = new System.Drawing.Size(63, 0);
            this.DatePicker_Error.Name = "DatePicker_Error";
            this.DatePicker_Error.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DatePicker_Error.Size = new System.Drawing.Size(117, 29);
            this.DatePicker_Error.Style = Sunny.UI.UIStyle.Custom;
            this.DatePicker_Error.SymbolDropDown = 61555;
            this.DatePicker_Error.SymbolNormal = 61555;
            this.DatePicker_Error.TabIndex = 217;
            this.DatePicker_Error.Text = "2024-05-10";
            this.DatePicker_Error.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatePicker_Error.Value = new System.DateTime(2024, 5, 10, 0, 0, 0, 0);
            this.DatePicker_Error.Visible = false;
            this.DatePicker_Error.TextChanged += new System.EventHandler(this.DatePicker_Error_TextChanged);
            // 
            // Tab_Log
            // 
            this.Tab_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Log.Controls.Add(this.TP_Running_Log);
            this.Tab_Log.Controls.Add(this.TP_Error_Log);
            this.Tab_Log.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Tab_Log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tab_Log.ItemSize = new System.Drawing.Size(150, 33);
            this.Tab_Log.Location = new System.Drawing.Point(1, 1);
            this.Tab_Log.MainPage = "";
            this.Tab_Log.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Tab_Log.Name = "Tab_Log";
            this.Tab_Log.SelectedIndex = 0;
            this.Tab_Log.Size = new System.Drawing.Size(555, 184);
            this.Tab_Log.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tab_Log.Style = Sunny.UI.UIStyle.Custom;
            this.Tab_Log.StyleCustomMode = true;
            this.Tab_Log.TabBackColor = System.Drawing.Color.Gainsboro;
            this.Tab_Log.TabIndex = 1;
            this.Tab_Log.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Tab_Log.TabSelectedForeColor = System.Drawing.Color.White;
            this.Tab_Log.TabSelectedHighColorSize = 0;
            this.Tab_Log.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Tab_Log.SelectedIndexChanged += new System.EventHandler(this.Tab_Log_SelectedIndexChanged);
            // 
            // TP_Running_Log
            // 
            this.TP_Running_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TP_Running_Log.Controls.Add(this.TB_Running_Log);
            this.TP_Running_Log.Location = new System.Drawing.Point(0, 33);
            this.TP_Running_Log.Name = "TP_Running_Log";
            this.TP_Running_Log.Size = new System.Drawing.Size(555, 151);
            this.TP_Running_Log.TabIndex = 0;
            this.TP_Running_Log.Text = "运行日志";
            // 
            // TB_Running_Log
            // 
            this.TB_Running_Log.AutoScroll = true;
            this.TB_Running_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Running_Log.ButtonSymbol = 61761;
            this.TB_Running_Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Running_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Running_Log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Running_Log.Location = new System.Drawing.Point(0, 0);
            this.TB_Running_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Running_Log.Maximum = 10D;
            this.TB_Running_Log.MaxLength = 1;
            this.TB_Running_Log.Minimum = -2147483648D;
            this.TB_Running_Log.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Running_Log.Multiline = true;
            this.TB_Running_Log.Name = "TB_Running_Log";
            this.TB_Running_Log.ReadOnly = true;
            this.TB_Running_Log.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_Running_Log.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_Running_Log.ShowScrollBar = true;
            this.TB_Running_Log.Size = new System.Drawing.Size(555, 151);
            this.TB_Running_Log.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Running_Log.StyleCustomMode = true;
            this.TB_Running_Log.TabIndex = 3;
            this.TB_Running_Log.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TP_Error_Log
            // 
            this.TP_Error_Log.Controls.Add(this.TB_Error_Log);
            this.TP_Error_Log.Location = new System.Drawing.Point(0, 33);
            this.TP_Error_Log.Name = "TP_Error_Log";
            this.TP_Error_Log.Size = new System.Drawing.Size(555, 151);
            this.TP_Error_Log.TabIndex = 1;
            this.TP_Error_Log.Text = "错误日志";
            this.TP_Error_Log.UseVisualStyleBackColor = true;
            // 
            // TB_Error_Log
            // 
            this.TB_Error_Log.AutoScroll = true;
            this.TB_Error_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Error_Log.ButtonSymbol = 61761;
            this.TB_Error_Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Error_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Error_Log.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_Error_Log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Error_Log.Location = new System.Drawing.Point(0, 0);
            this.TB_Error_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Error_Log.Maximum = 10D;
            this.TB_Error_Log.MaxLength = 1;
            this.TB_Error_Log.Minimum = -2147483648D;
            this.TB_Error_Log.MinimumSize = new System.Drawing.Size(1, 16);
            this.TB_Error_Log.Multiline = true;
            this.TB_Error_Log.Name = "TB_Error_Log";
            this.TB_Error_Log.ReadOnly = true;
            this.TB_Error_Log.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_Error_Log.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TB_Error_Log.ShowScrollBar = true;
            this.TB_Error_Log.Size = new System.Drawing.Size(555, 151);
            this.TB_Error_Log.Style = Sunny.UI.UIStyle.Custom;
            this.TB_Error_Log.StyleCustomMode = true;
            this.TB_Error_Log.TabIndex = 4;
            this.TB_Error_Log.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Open_Dir
            // 
            this.Btn_Open_Dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Open_Dir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Open_Dir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
            this.Btn_Open_Dir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Open_Dir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Open_Dir.Location = new System.Drawing.Point(512, 3);
            this.Btn_Open_Dir.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Open_Dir.Name = "Btn_Open_Dir";
            this.Btn_Open_Dir.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Open_Dir.Size = new System.Drawing.Size(40, 30);
            this.Btn_Open_Dir.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Open_Dir.StyleCustomMode = true;
            this.Btn_Open_Dir.Symbol = 61564;
            this.Btn_Open_Dir.SymbolOffset = new System.Drawing.Point(1, 2);
            this.Btn_Open_Dir.SymbolSize = 30;
            this.Btn_Open_Dir.TabIndex = 4;
            this.Btn_Open_Dir.Click += new System.EventHandler(this.Btn_Open_Dir_Click);
            // 
            // LogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Btn_Open_Dir);
            this.Controls.Add(this.uiPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogPanel";
            this.Size = new System.Drawing.Size(558, 185);
            this.uiPanel1.ResumeLayout(false);
            this.Tab_Log.ResumeLayout(false);
            this.TP_Running_Log.ResumeLayout(false);
            this.TP_Error_Log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITabControl Tab_Log;
        private System.Windows.Forms.TabPage TP_Running_Log;
        private Sunny.UI.UITextBox TB_Running_Log;
        private Sunny.UI.UISymbolButton Btn_Open_Dir;
        private System.Windows.Forms.TabPage TP_Error_Log;
        private Sunny.UI.UITextBox TB_Error_Log;
        private Sunny.UI.UIDatePicker DatePicker_Error;
    }
}
