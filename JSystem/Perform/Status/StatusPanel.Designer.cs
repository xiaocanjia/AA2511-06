namespace JSystem.Perform
{
    partial class StatusPanel
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
            this.Btn_Status_Title = new Sunny.UI.UIButton();
            this.Panel_State = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.Lb_UnInit = new Sunny.UI.UILabel();
            this.Lb_Run = new Sunny.UI.UILabel();
            this.Lb_Alarm = new Sunny.UI.UILabel();
            this.Lb_PauseAlarm = new Sunny.UI.UILabel();
            this.Lb_Pause = new Sunny.UI.UILabel();
            this.Lb_Initing = new Sunny.UI.UILabel();
            this.Lb_Inited = new Sunny.UI.UILabel();
            this.Lbl_CurrState = new Sunny.UI.UILabel();
            this.Panel_State.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Status_Title
            // 
            this.Btn_Status_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Status_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Status_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Status_Title.Enabled = false;
            this.Btn_Status_Title.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Status_Title.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Status_Title.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Status_Title.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Status_Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_Status_Title.ForeDisableColor = System.Drawing.Color.White;
            this.Btn_Status_Title.Location = new System.Drawing.Point(0, 0);
            this.Btn_Status_Title.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Status_Title.Name = "Btn_Status_Title";
            this.Btn_Status_Title.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Status_Title.Size = new System.Drawing.Size(542, 35);
            this.Btn_Status_Title.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_Status_Title.StyleCustomMode = true;
            this.Btn_Status_Title.TabIndex = 177;
            this.Btn_Status_Title.Text = "设备状态";
            // 
            // Panel_State
            // 
            this.Panel_State.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_State.AutoScroll = true;
            this.Panel_State.BackColor = System.Drawing.Color.White;
            this.Panel_State.Controls.Add(this.uiPanel2);
            this.Panel_State.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_State.Location = new System.Drawing.Point(2, 36);
            this.Panel_State.Name = "Panel_State";
            this.Panel_State.Size = new System.Drawing.Size(538, 185);
            this.Panel_State.TabIndex = 179;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.Lb_UnInit);
            this.uiPanel2.Controls.Add(this.Lb_Run);
            this.uiPanel2.Controls.Add(this.Lb_Alarm);
            this.uiPanel2.Controls.Add(this.Lb_PauseAlarm);
            this.uiPanel2.Controls.Add(this.Lb_Pause);
            this.uiPanel2.Controls.Add(this.Lb_Initing);
            this.uiPanel2.Controls.Add(this.Lb_Inited);
            this.uiPanel2.Controls.Add(this.Lbl_CurrState);
            this.uiPanel2.FillColor = System.Drawing.Color.Gainsboro;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(4, 4);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.uiPanel2.Size = new System.Drawing.Size(260, 40);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 15;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_UnInit
            // 
            this.Lb_UnInit.BackColor = System.Drawing.Color.Transparent;
            this.Lb_UnInit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_UnInit.ForeColor = System.Drawing.Color.Blue;
            this.Lb_UnInit.Location = new System.Drawing.Point(175, 9);
            this.Lb_UnInit.Name = "Lb_UnInit";
            this.Lb_UnInit.Size = new System.Drawing.Size(76, 23);
            this.Lb_UnInit.StyleCustomMode = true;
            this.Lb_UnInit.TabIndex = 8;
            this.Lb_UnInit.Text = "未初始化";
            this.Lb_UnInit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Run
            // 
            this.Lb_Run.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Run.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_Run.ForeColor = System.Drawing.Color.Green;
            this.Lb_Run.Location = new System.Drawing.Point(175, 9);
            this.Lb_Run.Name = "Lb_Run";
            this.Lb_Run.Size = new System.Drawing.Size(76, 23);
            this.Lb_Run.StyleCustomMode = true;
            this.Lb_Run.TabIndex = 9;
            this.Lb_Run.Text = "运行中";
            this.Lb_Run.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Alarm
            // 
            this.Lb_Alarm.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Alarm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_Alarm.ForeColor = System.Drawing.Color.Red;
            this.Lb_Alarm.Location = new System.Drawing.Point(175, 9);
            this.Lb_Alarm.Name = "Lb_Alarm";
            this.Lb_Alarm.Size = new System.Drawing.Size(76, 23);
            this.Lb_Alarm.StyleCustomMode = true;
            this.Lb_Alarm.TabIndex = 14;
            this.Lb_Alarm.Text = "报警";
            this.Lb_Alarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_PauseAlarm
            // 
            this.Lb_PauseAlarm.BackColor = System.Drawing.Color.Transparent;
            this.Lb_PauseAlarm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_PauseAlarm.ForeColor = System.Drawing.Color.Orange;
            this.Lb_PauseAlarm.Location = new System.Drawing.Point(175, 9);
            this.Lb_PauseAlarm.Name = "Lb_PauseAlarm";
            this.Lb_PauseAlarm.Size = new System.Drawing.Size(76, 23);
            this.Lb_PauseAlarm.StyleCustomMode = true;
            this.Lb_PauseAlarm.TabIndex = 13;
            this.Lb_PauseAlarm.Text = "报警暂停";
            this.Lb_PauseAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Pause
            // 
            this.Lb_Pause.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Pause.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_Pause.ForeColor = System.Drawing.Color.Green;
            this.Lb_Pause.Location = new System.Drawing.Point(175, 9);
            this.Lb_Pause.Name = "Lb_Pause";
            this.Lb_Pause.Size = new System.Drawing.Size(76, 23);
            this.Lb_Pause.StyleCustomMode = true;
            this.Lb_Pause.TabIndex = 12;
            this.Lb_Pause.Text = "暂停";
            this.Lb_Pause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Initing
            // 
            this.Lb_Initing.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Initing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_Initing.ForeColor = System.Drawing.Color.Green;
            this.Lb_Initing.Location = new System.Drawing.Point(175, 9);
            this.Lb_Initing.Name = "Lb_Initing";
            this.Lb_Initing.Size = new System.Drawing.Size(76, 23);
            this.Lb_Initing.StyleCustomMode = true;
            this.Lb_Initing.TabIndex = 11;
            this.Lb_Initing.Text = "初始化中";
            this.Lb_Initing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Inited
            // 
            this.Lb_Inited.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Inited.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_Inited.ForeColor = System.Drawing.Color.Blue;
            this.Lb_Inited.Location = new System.Drawing.Point(175, 9);
            this.Lb_Inited.Name = "Lb_Inited";
            this.Lb_Inited.Size = new System.Drawing.Size(76, 23);
            this.Lb_Inited.StyleCustomMode = true;
            this.Lb_Inited.TabIndex = 10;
            this.Lb_Inited.Text = "空闲";
            this.Lb_Inited.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_CurrState
            // 
            this.Lbl_CurrState.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CurrState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_CurrState.Location = new System.Drawing.Point(3, 9);
            this.Lbl_CurrState.Name = "Lbl_CurrState";
            this.Lbl_CurrState.Size = new System.Drawing.Size(100, 23);
            this.Lbl_CurrState.Style = Sunny.UI.UIStyle.Custom;
            this.Lbl_CurrState.TabIndex = 0;
            this.Lbl_CurrState.Text = "当前状态";
            this.Lbl_CurrState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.Panel_State);
            this.Controls.Add(this.Btn_Status_Title);
            this.Name = "StatusPanel";
            this.Size = new System.Drawing.Size(542, 222);
            this.Panel_State.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton Btn_Status_Title;
        private System.Windows.Forms.FlowLayoutPanel Panel_State;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel Lbl_CurrState;
        private Sunny.UI.UILabel Lb_UnInit;
        private Sunny.UI.UILabel Lb_Run;
        private Sunny.UI.UILabel Lb_Alarm;
        private Sunny.UI.UILabel Lb_PauseAlarm;
        private Sunny.UI.UILabel Lb_Pause;
        private Sunny.UI.UILabel Lb_Initing;
        private Sunny.UI.UILabel Lb_Inited;
    }
}
