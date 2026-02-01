using System;
using System.Drawing;
using System.Windows.Forms;
using JSystem.User;
using Sunny.UI;

namespace JSystem.IO
{
    public partial class DIView : UserControl
    {
        private string _diName;

        private bool _isOn = false;

        private bool _isError = false;

        public Func<string, bool> OnGetIn;

        public Action<string> OnShowParam;

        public DIView(string name)
        {
            InitializeComponent();
            _diName = name;
            Lbl_Name.Text = name.ToString();
            DoubleBuffered = true;
        }

        public void SetEnabled(bool isEnabled)
        {
            Lbl_Name.Enabled = isEnabled & (LoginForm.User == "管理员");
        }

        public void UpdateState()
        {
            try
            {
                if (_isError) return;
                if (OnGetIn == null || _isOn == OnGetIn(_diName))
                    return;
                _isOn = !_isOn;
                _isError = false;
                UpdateUI(Color.Black);
            }
            catch
            {
                _isError = true;
                UpdateUI(Color.Red);
            }
        }

        private void UpdateUI(Color color)
        {
            if (InvokeRequired)
                Invoke(new Action(() => { UpdateUI(color); }));
            else
            {
                Lbl_Name.ForeColor = color;
                if (color == Color.Black)
                    Light_IsOn.State = _isOn ? UILightState.On : UILightState.Off;
            }
        }

        private void Lbl_Name_Click(object sender, EventArgs e)
        {
            OnShowParam(_diName);
            try
            {
                _isOn = OnGetIn(_diName);
                Light_IsOn.State = _isOn ? UILightState.On : UILightState.Off;
                _isError = false;
                Lbl_Name.ForeColor = Color.Black;
            }
            catch
            {
                _isError = true;
                Lbl_Name.ForeColor = Color.Red;
            }
        }
    }
}
