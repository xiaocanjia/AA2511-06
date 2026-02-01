using System;
using System.Windows.Forms;
using JLogging;
using JSystem.Perform;
using Sunny.UI;

namespace JSystem.IO
{
    public partial class IOPage : UIPage
    {
        private IOManager _manager;

        private IOCfgForm _formDI = null;

        private IOCfgForm _formDO = null;

        private bool _isDisp = false;

        public IOPage()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public void Refresh(bool isOn)
        {
            _isDisp = isOn;
            if (!isOn) return;
            foreach (Control control in Panel_Out.Controls)
            {
                if (control is DOView doView)
                    doView.UpdateState();
            }
        }

        public void Init(IOManager manager)
        {
            try
            {
                if (manager == null)
                    return;
                _formDI = new IOCfgForm(manager);
                _formDO = new IOCfgForm(manager);
                _manager = manager;
                _manager.OnUpdateIOView = UpdateIOView;
                Panel_In.Controls.Clear();
                Panel_Out.Controls.Clear();
                foreach (var key in _manager.DictInput.Keys)
                {
                    DIView view = new DIView(key);
                    view.OnGetIn = _manager.GetIn;
                    view.OnShowParam = ShowDICfg;
                    Panel_In.Controls.Add(view);
                }
                foreach (var key in _manager.DictOutput.Keys)
                {
                    DOView view = new DOView(key);
                    view.OnSetOut = _manager.SetOut;
                    view.OnGetOut = _manager.GetOut;
                    view.OnShowParam = ShowDOCfg;
                    Panel_Out.Controls.Add(view);
                }
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"IO界面初始化失败, {ex.Message}", LogLevels.Error);
            }
        }

        public void ShowDICfg(string name)
        {
            _formDI.Show(_manager.OnGetBoards(), _manager.DictInput[name]);
        }

        public void ShowDOCfg(string name)
        {
            _formDI.Show(_manager.OnGetBoards(), _manager.DictOutput[name]);
        }

        public void SetEnabled(bool isEnabled)
        {
            foreach (Control control in Panel_Out.Controls)
            {
                if (control is DOView doView)
                    doView.SetEnabled(isEnabled);
            }
            foreach (Control control in Panel_In.Controls)
            {
                if (control is DIView diView)
                    diView.SetEnabled(isEnabled);
            }
        }

        private void UpdateIOView()
        {
            if (!_isDisp) return;
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateIOView()));
            }
            else
            {
                foreach (Control control in Panel_In.Controls)
                {
                    if (control is DIView diView)
                        diView.UpdateState();
                }
            }
        }
    }
}
