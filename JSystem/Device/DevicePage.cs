using System.Windows.Forms;
using JSystem.User;
using Sunny.UI;

namespace JSystem.Device
{
    public partial class DevicePage : UIPage
    {
        private DeviceManager _manager;
        
        public DevicePage()
        {
            InitializeComponent();
        }

        public void Init(DeviceManager manager)
        {
            _manager = manager;
            _manager.OnSetUserRight = SetUserRight;
            Tab_Devices.TabPages.Clear();
            foreach (DeviceBase device in manager.DeviceList)
            {
                TabPage page = new TabPage(device.Name);
                Tab_Devices.TabPages.Add(page);
                page.Controls.Add(device.View);
                device.View.Refresh();
                device.View.Dock = DockStyle.Fill;
                device.View.Show();
            }
        }

        public void SetUserRight(string right)
        {
            SetEnabled(right == "操作员");
        }

        public void SetEnabled(bool isEnabled)
        {
            bool enabled = isEnabled & (LoginForm.User == "管理员");
            foreach (DeviceBase device in _manager.DeviceList)
                device.View.Enabled = enabled;
        }
    }
}
