using System;
using System.Windows.Forms;
using JSystem.User;
using Sunny.UI;

namespace JSystem.Project
{
    public partial class ProjectPanel : UserControl
    {
        ProjectManager _manager;

        public ProjectPanel()
        {
            InitializeComponent();
            ToolTip toolTipSave = new ToolTip();
            toolTipSave.ShowAlways = true;
            toolTipSave.SetToolTip(Button_SavePro, "保存");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.ShowAlways = true;
            toolTipDelete.SetToolTip(Button_DeletePro, "删除");
        }

        public void Init(ProjectManager manager)
        {
            if (manager == null)
                return;
            _manager = manager;
            CbB_Project_List.Items.Clear();
            foreach (string item in manager.Projects.ProjectsName)
                CbB_Project_List.Items.Add(item);
            CbB_Project_List.SelectedItem = manager.Projects.CurrProject;
        }

        public void SetEnabled(bool isEnabled)
        {
            Button_SavePro.Enabled = LoginForm.User == "操作员" ? false : true;
            Button_DeletePro.Enabled = LoginForm.User != "管理员" ? false : true;
        }

        private void Button_Save_Project_Click(object sender, EventArgs e)
        {
            if (CbB_Project_List.Text == "")
                return;
            if (!_manager.Projects.ProjectsName.Contains(CbB_Project_List.Text))
            {
                _manager.Projects.ProjectsName.Add(CbB_Project_List.Text);
                CbB_Project_List.Items.Add(CbB_Project_List.Text);
            }
            if (_manager.SaveProject(CbB_Project_List.Text))
                UIMessageTip.ShowOk("保存成功");
            else
                UIMessageTip.ShowError("保存失败");
        }

        private void Button_Delete_Pro_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm();
            form.ShowDialog();
            if (!form.IsRight)
                return;
            if (CbB_Project_List.Text == "")
                return;
            _manager.DeleteProject(CbB_Project_List.Text);
            CbB_Project_List.Items.Remove(CbB_Project_List.Text);
            CbB_Project_List.SelectedIndex = -1;
        }

        public bool LoadProject(string name)
        {
            if (InvokeRequired)
            {
                return (bool)Invoke(new Func<bool>(() => { return LoadProject(name); }));
            }
            else
            {
                CbB_Project_List.Text = name;
                if (!_manager.LoadProject(CbB_Project_List.Text))
                {
                    CbB_Project_List.SelectedItem = _manager.Projects.CurrProject;
                    return false;
                }
                return true;
            }
        }

        private void CbB_Project_List_DropDownClosed(object sender, EventArgs e)
        {
            if (CbB_Project_List.Text == "")
                return;
            if (!LoadProject(CbB_Project_List.Text))
            {
                CbB_Project_List.SelectedItem = _manager.Projects.CurrProject;
                UIMessageTip.ShowError("程序切换失败，请先停止运行");
            }
        }
    }
}
