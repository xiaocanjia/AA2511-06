namespace JSystem.Station
{
    partial class AxisStatusPanel
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
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new System.Action(() => Dispose(disposing)));
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
            catch { }
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Axis = new Sunny.UI.UIPanel();
            this.Light_Enabled = new Sunny.UI.UILight();
            this.Tb_CmdPos = new Sunny.UI.UITextBox();
            this.Btn_Setup = new Sunny.UI.UISymbolButton();
            this.Switch_Enable = new Sunny.UI.UISwitch();
            this.Light_Emg = new Sunny.UI.UILight();
            this.Light_NL = new Sunny.UI.UILight();
            this.Light_Origin = new Sunny.UI.UILight();
            this.Light_PL = new Sunny.UI.UILight();
            this.Light_Alarm = new Sunny.UI.UILight();
            this.Tb_ActPos = new Sunny.UI.UITextBox();
            this.Btn_PMove = new Sunny.UI.UISymbolButton();
            this.Btn_NMove = new Sunny.UI.UISymbolButton();
            this.Btn_Home = new Sunny.UI.UISymbolButton();
            this.Lbl_Axis_Name = new Sunny.UI.UILabel();
            this.Panel_Axis.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Axis
            // 
            this.Panel_Axis.Controls.Add(this.Light_Enabled);
            this.Panel_Axis.Controls.Add(this.Tb_CmdPos);
            this.Panel_Axis.Controls.Add(this.Btn_Setup);
            this.Panel_Axis.Controls.Add(this.Switch_Enable);
            this.Panel_Axis.Controls.Add(this.Light_Emg);
            this.Panel_Axis.Controls.Add(this.Light_NL);
            this.Panel_Axis.Controls.Add(this.Light_Origin);
            this.Panel_Axis.Controls.Add(this.Light_PL);
            this.Panel_Axis.Controls.Add(this.Light_Alarm);
            this.Panel_Axis.Controls.Add(this.Tb_ActPos);
            this.Panel_Axis.Controls.Add(this.Btn_PMove);
            this.Panel_Axis.Controls.Add(this.Btn_NMove);
            this.Panel_Axis.Controls.Add(this.Btn_Home);
            this.Panel_Axis.Controls.Add(this.Lbl_Axis_Name);
            this.Panel_Axis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Axis.FillColor = System.Drawing.Color.GhostWhite;
            this.Panel_Axis.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_Axis.Location = new System.Drawing.Point(0, 0);
            this.Panel_Axis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Axis.MinimumSize = new System.Drawing.Size(1, 1);
            this.Panel_Axis.Name = "Panel_Axis";
            this.Panel_Axis.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Panel_Axis.Size = new System.Drawing.Size(1015, 38);
            this.Panel_Axis.Style = Sunny.UI.UIStyle.Custom;
            this.Panel_Axis.TabIndex = 84;
            this.Panel_Axis.Text = null;
            this.Panel_Axis.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Light_Enabled
            // 
            this.Light_Enabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Light_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.Light_Enabled.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Enabled.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Light_Enabled.Location = new System.Drawing.Point(503, 1);
            this.Light_Enabled.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_Enabled.Name = "Light_Enabled";
            this.Light_Enabled.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Enabled.OnColor = System.Drawing.Color.Lime;
            this.Light_Enabled.Radius = 35;
            this.Light_Enabled.Size = new System.Drawing.Size(35, 35);
            this.Light_Enabled.State = Sunny.UI.UILightState.Off;
            this.Light_Enabled.Style = Sunny.UI.UIStyle.Custom;
            this.Light_Enabled.StyleCustomMode = true;
            this.Light_Enabled.TabIndex = 179;
            this.Light_Enabled.Text = "uiLight1";
            // 
            // Tb_CmdPos
            // 
            this.Tb_CmdPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_CmdPos.ButtonSymbol = 61761;
            this.Tb_CmdPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tb_CmdPos.DecLength = 4;
            this.Tb_CmdPos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Tb_CmdPos.Location = new System.Drawing.Point(316, 5);
            this.Tb_CmdPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_CmdPos.Maximum = 2147483647D;
            this.Tb_CmdPos.Minimum = -2147483648D;
            this.Tb_CmdPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.Tb_CmdPos.Name = "Tb_CmdPos";
            this.Tb_CmdPos.Padding = new System.Windows.Forms.Padding(5);
            this.Tb_CmdPos.ReadOnly = true;
            this.Tb_CmdPos.Size = new System.Drawing.Size(75, 29);
            this.Tb_CmdPos.Style = Sunny.UI.UIStyle.Custom;
            this.Tb_CmdPos.TabIndex = 172;
            this.Tb_CmdPos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Setup
            // 
            this.Btn_Setup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Setup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Setup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Setup.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Setup.Location = new System.Drawing.Point(954, 4);
            this.Btn_Setup.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Setup.Name = "Btn_Setup";
            this.Btn_Setup.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Setup.Size = new System.Drawing.Size(50, 30);
            this.Btn_Setup.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Setup.StyleCustomMode = true;
            this.Btn_Setup.Symbol = 61459;
            this.Btn_Setup.TabIndex = 178;
            this.Btn_Setup.Click += new System.EventHandler(this.Btn_Setup_Click);
            // 
            // Switch_Enable
            // 
            this.Switch_Enable.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Switch_Enable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Switch_Enable.BackColor = System.Drawing.Color.Transparent;
            this.Switch_Enable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Switch_Enable.Location = new System.Drawing.Point(156, 5);
            this.Switch_Enable.MinimumSize = new System.Drawing.Size(1, 1);
            this.Switch_Enable.Name = "Switch_Enable";
            this.Switch_Enable.Size = new System.Drawing.Size(75, 29);
            this.Switch_Enable.Style = Sunny.UI.UIStyle.Custom;
            this.Switch_Enable.StyleCustomMode = true;
            this.Switch_Enable.TabIndex = 166;
            this.Switch_Enable.Text = "uiSwitch1";
            this.Switch_Enable.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.Switch_Enable_ValueChanged);
            // 
            // Light_Emg
            // 
            this.Light_Emg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Light_Emg.BackColor = System.Drawing.Color.Transparent;
            this.Light_Emg.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Emg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Light_Emg.Location = new System.Drawing.Point(764, 1);
            this.Light_Emg.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_Emg.Name = "Light_Emg";
            this.Light_Emg.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Emg.OnColor = System.Drawing.Color.Red;
            this.Light_Emg.Radius = 35;
            this.Light_Emg.Size = new System.Drawing.Size(35, 35);
            this.Light_Emg.State = Sunny.UI.UILightState.Off;
            this.Light_Emg.Style = Sunny.UI.UIStyle.Red;
            this.Light_Emg.StyleCustomMode = true;
            this.Light_Emg.TabIndex = 173;
            this.Light_Emg.Text = "uiLight1";
            // 
            // Light_NL
            // 
            this.Light_NL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Light_NL.BackColor = System.Drawing.Color.Transparent;
            this.Light_NL.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_NL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Light_NL.Location = new System.Drawing.Point(712, 1);
            this.Light_NL.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_NL.Name = "Light_NL";
            this.Light_NL.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_NL.OnColor = System.Drawing.Color.Lime;
            this.Light_NL.Radius = 35;
            this.Light_NL.Size = new System.Drawing.Size(35, 35);
            this.Light_NL.State = Sunny.UI.UILightState.Off;
            this.Light_NL.Style = Sunny.UI.UIStyle.Red;
            this.Light_NL.StyleCustomMode = true;
            this.Light_NL.TabIndex = 174;
            this.Light_NL.Text = "uiLight1";
            // 
            // Light_Origin
            // 
            this.Light_Origin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Light_Origin.BackColor = System.Drawing.Color.Transparent;
            this.Light_Origin.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Origin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Light_Origin.Location = new System.Drawing.Point(660, 1);
            this.Light_Origin.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_Origin.Name = "Light_Origin";
            this.Light_Origin.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Origin.OnColor = System.Drawing.Color.Lime;
            this.Light_Origin.Radius = 35;
            this.Light_Origin.Size = new System.Drawing.Size(35, 35);
            this.Light_Origin.State = Sunny.UI.UILightState.Off;
            this.Light_Origin.Style = Sunny.UI.UIStyle.Red;
            this.Light_Origin.StyleCustomMode = true;
            this.Light_Origin.TabIndex = 176;
            this.Light_Origin.Text = "uiLight1";
            // 
            // Light_PL
            // 
            this.Light_PL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Light_PL.BackColor = System.Drawing.Color.Transparent;
            this.Light_PL.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_PL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Light_PL.Location = new System.Drawing.Point(608, 1);
            this.Light_PL.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_PL.Name = "Light_PL";
            this.Light_PL.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_PL.OnColor = System.Drawing.Color.Lime;
            this.Light_PL.Radius = 35;
            this.Light_PL.Size = new System.Drawing.Size(35, 35);
            this.Light_PL.State = Sunny.UI.UILightState.Off;
            this.Light_PL.Style = Sunny.UI.UIStyle.Red;
            this.Light_PL.StyleCustomMode = true;
            this.Light_PL.TabIndex = 175;
            this.Light_PL.Text = "uiLight1";
            // 
            // Light_Alarm
            // 
            this.Light_Alarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Light_Alarm.BackColor = System.Drawing.Color.Transparent;
            this.Light_Alarm.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Alarm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Light_Alarm.Location = new System.Drawing.Point(556, 1);
            this.Light_Alarm.MinimumSize = new System.Drawing.Size(1, 1);
            this.Light_Alarm.Name = "Light_Alarm";
            this.Light_Alarm.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Light_Alarm.OnColor = System.Drawing.Color.Red;
            this.Light_Alarm.Radius = 35;
            this.Light_Alarm.Size = new System.Drawing.Size(35, 35);
            this.Light_Alarm.State = Sunny.UI.UILightState.Off;
            this.Light_Alarm.Style = Sunny.UI.UIStyle.Custom;
            this.Light_Alarm.StyleCustomMode = true;
            this.Light_Alarm.TabIndex = 177;
            this.Light_Alarm.Text = "uiLight1";
            // 
            // Tb_ActPos
            // 
            this.Tb_ActPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_ActPos.ButtonSymbol = 61761;
            this.Tb_ActPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tb_ActPos.DecLength = 4;
            this.Tb_ActPos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Tb_ActPos.Location = new System.Drawing.Point(406, 5);
            this.Tb_ActPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_ActPos.Maximum = 2147483647D;
            this.Tb_ActPos.Minimum = -2147483648D;
            this.Tb_ActPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.Tb_ActPos.Name = "Tb_ActPos";
            this.Tb_ActPos.Padding = new System.Windows.Forms.Padding(5);
            this.Tb_ActPos.ReadOnly = true;
            this.Tb_ActPos.Size = new System.Drawing.Size(75, 29);
            this.Tb_ActPos.Style = Sunny.UI.UIStyle.Custom;
            this.Tb_ActPos.TabIndex = 171;
            this.Tb_ActPos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_PMove
            // 
            this.Btn_PMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_PMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PMove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_PMove.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_PMove.Location = new System.Drawing.Point(824, 4);
            this.Btn_PMove.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_PMove.Name = "Btn_PMove";
            this.Btn_PMove.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_PMove.Size = new System.Drawing.Size(50, 30);
            this.Btn_PMove.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_PMove.StyleCustomMode = true;
            this.Btn_PMove.Symbol = 61543;
            this.Btn_PMove.TabIndex = 170;
            this.Btn_PMove.Click += new System.EventHandler(this.Btn_Move_Click);
            this.Btn_PMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Move_MouseDown);
            this.Btn_PMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Move_MouseUp);
            // 
            // Btn_NMove
            // 
            this.Btn_NMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_NMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NMove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_NMove.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_NMove.Location = new System.Drawing.Point(890, 4);
            this.Btn_NMove.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_NMove.Name = "Btn_NMove";
            this.Btn_NMove.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_NMove.Size = new System.Drawing.Size(50, 30);
            this.Btn_NMove.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_NMove.StyleCustomMode = true;
            this.Btn_NMove.Symbol = 61544;
            this.Btn_NMove.TabIndex = 169;
            this.Btn_NMove.Click += new System.EventHandler(this.Btn_Move_Click);
            this.Btn_NMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Move_MouseDown);
            this.Btn_NMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Move_MouseUp);
            // 
            // Btn_Home
            // 
            this.Btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Home.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Home.Location = new System.Drawing.Point(249, 4);
            this.Btn_Home.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(50, 30);
            this.Btn_Home.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Home.StyleCustomMode = true;
            this.Btn_Home.Symbol = 61470;
            this.Btn_Home.TabIndex = 168;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Lbl_Axis_Name
            // 
            this.Lbl_Axis_Name.AutoSize = true;
            this.Lbl_Axis_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Axis_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lbl_Axis_Name.Location = new System.Drawing.Point(5, 9);
            this.Lbl_Axis_Name.Name = "Lbl_Axis_Name";
            this.Lbl_Axis_Name.Size = new System.Drawing.Size(20, 21);
            this.Lbl_Axis_Name.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_Axis_Name.TabIndex = 167;
            this.Lbl_Axis_Name.Text = "X";
            this.Lbl_Axis_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AxisStatusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Axis);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 1, 2, 2);
            this.Name = "AxisStatusPanel";
            this.Size = new System.Drawing.Size(1015, 38);
            this.Panel_Axis.ResumeLayout(false);
            this.Panel_Axis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel Panel_Axis;
        private Sunny.UI.UISwitch Switch_Enable;
        private Sunny.UI.UILight Light_Emg;
        private Sunny.UI.UILight Light_NL;
        private Sunny.UI.UILight Light_Origin;
        private Sunny.UI.UILight Light_PL;
        private Sunny.UI.UILight Light_Alarm;
        private Sunny.UI.UITextBox Tb_ActPos;
        private Sunny.UI.UISymbolButton Btn_PMove;
        private Sunny.UI.UISymbolButton Btn_NMove;
        private Sunny.UI.UISymbolButton Btn_Home;
        private Sunny.UI.UILabel Lbl_Axis_Name;
        private Sunny.UI.UISymbolButton Btn_Setup;
        private Sunny.UI.UITextBox Tb_CmdPos;
        private Sunny.UI.UILight Light_Enabled;
    }
}
