using System;
using System.Drawing;
using System.Windows.Forms;
using JSystem.User;
using JSystem.Perform;
using JLogging;

namespace JSystem.IO
{
    public partial class DOView : UserControl
    {
        private string _doName;

        public Action<string> OnShowParam;

        public Action<string, bool> OnSetOut;

        public Func<string, bool> OnGetOut;

        public DOView(string name)
        {
            InitializeComponent();
            _doName = name;
            Lbl_Name.Text = name.ToString();
            Switch_IsOn.ValueChanged += Switch_IsOn_ValueChanged;
            DoubleBuffered = true;
        }

        private void Switch_IsOn_ValueChanged(object sender, bool value)
        {
            string isOn = value ? "打开" : "关闭";
            LogManager.Instance.AddLog("手动", $"{isOn}{_doName}信号", LogLevels.Debug);
            OnSetOut?.Invoke(_doName, value);
        }

        public void SetEnabled(bool isEnabled)
        {
            Lbl_Name.Enabled = isEnabled & (LoginForm.User == "管理员");
            Switch_IsOn.Enabled = isEnabled & (LoginForm.User != "操作员");
        }

        public void UpdateState()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateState()));
            }
            else
            {
                try
                {
                    Switch_IsOn.Active = OnGetOut(_doName);
                    Lbl_Name.ForeColor = Color.Black;
                }
                catch
                {
                    Lbl_Name.ForeColor = Color.Red;
                }
            }
        }

        private void Lbl_Name_Click(object sender, EventArgs e)
        {
            OnShowParam(_doName);
            UpdateState();
        }
    }
}
