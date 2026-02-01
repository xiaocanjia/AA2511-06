using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace JSystem.Device
{
    public class DeviceBase
    {
        public string Name;

        public bool IsEnable = true;

        protected UserControl _view;

        [JsonIgnore]
        public UserControl View
        {
            get
            {
                if (_view == null)
                    InitView();
                return _view;
            }
        }

        private DevStatusPanel _statusPanel;

        [JsonIgnore]
        public DevStatusPanel StatusPanel
        {
            get
            {
                if (_statusPanel == null)
                    _statusPanel = new DevStatusPanel(this);
                return _statusPanel;
            }
        }

        [JsonIgnore]
        public Action<bool> OnUpdateStatus;

        public virtual void SetUserRight(string right) { View.Enabled = (right != "操作员"); }

        public virtual bool Connect() { return true; }

        public virtual void DisConnect() { }

        public virtual bool CheckConnection() { return true; }

        public virtual void InitView() { }
    }
}
