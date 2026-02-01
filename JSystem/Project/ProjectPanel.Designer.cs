namespace JSystem.Project
{
    partial class ProjectPanel
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
            this.Button_DeletePro = new Sunny.UI.UISymbolButton();
            this.Button_SavePro = new Sunny.UI.UISymbolButton();
            this.CbB_Project_List = new Sunny.UI.UIComboBox();
            this.Label_Pdt = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // Button_DeletePro
            // 
            this.Button_DeletePro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_DeletePro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DeletePro.FillColor = System.Drawing.Color.Transparent;
            this.Button_DeletePro.FillDisableColor = System.Drawing.Color.Transparent;
            this.Button_DeletePro.FillHoverColor = System.Drawing.Color.Transparent;
            this.Button_DeletePro.FillPressColor = System.Drawing.Color.Transparent;
            this.Button_DeletePro.FillSelectedColor = System.Drawing.Color.Transparent;
            this.Button_DeletePro.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button_DeletePro.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_DeletePro.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_DeletePro.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_DeletePro.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_DeletePro.Location = new System.Drawing.Point(302, 5);
            this.Button_DeletePro.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button_DeletePro.Name = "Button_DeletePro";
            this.Button_DeletePro.RectColor = System.Drawing.Color.Transparent;
            this.Button_DeletePro.Size = new System.Drawing.Size(30, 30);
            this.Button_DeletePro.Style = Sunny.UI.UIStyle.Custom;
            this.Button_DeletePro.Symbol = 61944;
            this.Button_DeletePro.SymbolSize = 30;
            this.Button_DeletePro.TabIndex = 151;
            this.Button_DeletePro.TipsText = "删除";
            this.Button_DeletePro.Click += new System.EventHandler(this.Button_Delete_Pro_Click);
            // 
            // Button_SavePro
            // 
            this.Button_SavePro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SavePro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SavePro.FillColor = System.Drawing.Color.Transparent;
            this.Button_SavePro.FillDisableColor = System.Drawing.Color.Transparent;
            this.Button_SavePro.FillHoverColor = System.Drawing.Color.Transparent;
            this.Button_SavePro.FillPressColor = System.Drawing.Color.Transparent;
            this.Button_SavePro.FillSelectedColor = System.Drawing.Color.Transparent;
            this.Button_SavePro.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button_SavePro.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_SavePro.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_SavePro.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_SavePro.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Button_SavePro.Location = new System.Drawing.Point(270, 5);
            this.Button_SavePro.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button_SavePro.Name = "Button_SavePro";
            this.Button_SavePro.RectColor = System.Drawing.Color.Transparent;
            this.Button_SavePro.Size = new System.Drawing.Size(30, 30);
            this.Button_SavePro.Style = Sunny.UI.UIStyle.Custom;
            this.Button_SavePro.Symbol = 61639;
            this.Button_SavePro.SymbolSize = 30;
            this.Button_SavePro.TabIndex = 150;
            this.Button_SavePro.TipsText = "保存";
            this.Button_SavePro.Click += new System.EventHandler(this.Button_Save_Project_Click);
            // 
            // CbB_Project_List
            // 
            this.CbB_Project_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbB_Project_List.DataSource = null;
            this.CbB_Project_List.FillColor = System.Drawing.Color.White;
            this.CbB_Project_List.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CbB_Project_List.Location = new System.Drawing.Point(91, 5);
            this.CbB_Project_List.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbB_Project_List.MinimumSize = new System.Drawing.Size(63, 0);
            this.CbB_Project_List.Name = "CbB_Project_List";
            this.CbB_Project_List.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CbB_Project_List.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.CbB_Project_List.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.CbB_Project_List.Size = new System.Drawing.Size(172, 29);
            this.CbB_Project_List.Style = Sunny.UI.UIStyle.Custom;
            this.CbB_Project_List.TabIndex = 149;
            this.CbB_Project_List.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CbB_Project_List.DropDownClosed += new System.EventHandler(this.CbB_Project_List_DropDownClosed);
            // 
            // Label_Pdt
            // 
            this.Label_Pdt.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pdt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Pdt.ForeColor = System.Drawing.Color.White;
            this.Label_Pdt.Location = new System.Drawing.Point(4, 8);
            this.Label_Pdt.Name = "Label_Pdt";
            this.Label_Pdt.Size = new System.Drawing.Size(80, 23);
            this.Label_Pdt.Style = Sunny.UI.UIStyle.Custom;
            this.Label_Pdt.TabIndex = 153;
            this.Label_Pdt.Text = "当前产品:";
            this.Label_Pdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Label_Pdt);
            this.Controls.Add(this.Button_DeletePro);
            this.Controls.Add(this.Button_SavePro);
            this.Controls.Add(this.CbB_Project_List);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectPanel";
            this.Size = new System.Drawing.Size(335, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton Button_DeletePro;
        private Sunny.UI.UISymbolButton Button_SavePro;
        private Sunny.UI.UIComboBox CbB_Project_List;
        private Sunny.UI.UILabel Label_Pdt;
    }
}
