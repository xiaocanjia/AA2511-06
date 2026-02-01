using System;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;
using JSystem.Perform;
using JSystem.Station;
using JSystem.Device;
using JSystem.IO;
using JSystem.User;
using JSystem.Param;
using JLogging;
using System.Diagnostics;

namespace JSystem
{
    public partial class MainWindow : UIHeaderMainFrame
    {
        private SysController _controller;

        private PerformPage _performPage;

        private IOPage _IOPage;

        private StationsPage _stationPage;

        private DevicePage _devicePage;

        private ParamPage _paramsPage;

        private VisionPage _visionPage;

        private LoginForm _loginForm;

        private IOTSys _IOS;

        public MainWindow()
        {
            InitializeComponent();
            _loginForm = new LoginForm();
            Application.AddMessageFilter(_loginForm);
            Header.TabControl = MainTabControl;
            _performPage = new PerformPage();
            _IOPage = new IOPage();
            _stationPage = new StationsPage();
            _devicePage = new DevicePage();
            _paramsPage = new ParamPage();
            _visionPage = new VisionPage();
            AddPage(_performPage, 1001, 0, 61461);
            AddPage(_IOPage, 1002, 1, 61729);
            AddPage(_stationPage, 1003, 2, 61505);
            AddPage(_devicePage, 1004, 3, 61573);
            AddPage(_paramsPage, 1005, 4, 61643);
            AddPage(_visionPage, 1006, 5, 61488);
            Load += MainWindow_Load;
            Shown += MainWindow_Shown;
            FormClosed += MainWindow_FormClosed;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            TopMost = true;
            Thread.Sleep(100);
            TopMost = false;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            TopMost = false;
            RBtn_Auto.Checked = true;
            _loginForm.Display();
        }



        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _IOS?.ClearAlarm(out string msg);
            _controller.UnInit();
            Thread.Sleep(100);
            LogManager.Instance.AddLog("手动", "软件关闭", LogLevels.Debug);
            Process.GetCurrentProcess().Kill();
        }

        public void Init(SysController controller)
        {
            _controller = controller;
            _controller.OnUpdateUI = UpdateUI;
            _controller.OnSetEnable = SetEnable;
            _loginForm.OnChangeUserRight += SetUserRight;
            _performPage.Init(_controller);
            _projectPanel.Init(_controller.ProjectMgr);
            _devicePage.Init(_controller.DeviceMgr);
            _performPage.StatusPanel.Init(_controller.DeviceMgr);
            _IOPage.Init(_controller.IOMgr);
            _stationPage.Init(_controller.StationMgr);
            _paramsPage.Init(_controller.ParamMgr);
            _visionPage.Init(_controller.StationMgr);
            _IOS = ((IOTSys)_controller.DeviceMgr.GetDevice("物联系统"));
            if (_controller.ProjectMgr.Projects.CurrProject == "")
                UpdateUI();
        }

        private void AddPage(UIPage page, int pageIdx, int nodeIdx, int symbol)
        {
            AddPage(page, pageIdx);
            Header.SetNodePageIndex(Header.Nodes[nodeIdx], pageIdx);
            Header.SetNodeSymbol(Header.Nodes[nodeIdx], symbol, 35);
        }

        private void UpdateUI()
        {
            try
            {
                if (_controller == null) return;
                _stationPage.UpdateUI();
                _paramsPage.UpdateUI();
                _visionPage.UpdateUI();
            }
            catch (Exception ex)
            {
                _controller.Stop(false);
                LogManager.Instance.AddLog("主流程", $"界面初始化失败，请检查配置文件是否有误，{ex.Message}详情请查看错误日志；", LogLevels.Error);
            }
        }

        private void SetUserRight()
        {
            Lb_User.Text = LoginForm.User;
            RBtn_Manual.Enabled = (LoginForm.User != "操作员") && (_controller.CurrState == EDeviceState.UNINIT || _controller.CurrState == EDeviceState.EMERGENCY || _controller.CurrState == EDeviceState.INITED);
            RBtn_Auto.Enabled = RBtn_Manual.Enabled;
            _paramsPage.SetEnabled(RBtn_Manual.Checked);
            if (LoginForm.User == "操作员")
            {
                if (!RBtn_Auto.Checked)
                    RBtn_Auto.Checked = true;
            }
            else
            {
                SetEnabled();
            }
            if (_IOS != null)
            {
                _IOS.UploadCurrRight(LoginForm.User, out string rec);
                LogManager.Instance.AddLog("权限", rec, LogLevels.Debug);
            }
        }

        private void SetEnable(bool isEnabled)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { SetEnable(isEnabled); }));
            }
            else
            {
                //_projectPanel.Enabled = isEnabled;
                bool enabled = isEnabled & (LoginForm.User != "操作员");
                RBtn_Manual.Enabled = enabled;
                RBtn_Auto.Enabled = enabled;
            }
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            _loginForm.Display();
        }

        private void RBtn_Mode_CheckedChanged(object sender, EventArgs e)
        {
            UIRadioButton rb = sender as UIRadioButton;
            if (rb == null || !rb.Checked) return;
            LogManager.Instance.AddLog("手动", $"切换为{rb.Text}模式", LogLevels.Debug);
            if (RBtn_Auto.Checked)
                _controller.OnUpdateState(EDeviceState.UNINIT);
            SetEnabled();
        }

        private void SetEnabled()
        {
            _stationPage.SetEnabled(RBtn_Manual.Checked);
            _IOPage.SetEnabled(RBtn_Manual.Checked);
            _paramsPage.SetEnabled(RBtn_Manual.Checked);
            _devicePage.SetEnabled(RBtn_Manual.Checked);
            _performPage.SetEnabled(RBtn_Manual.Checked);
            _projectPanel.SetEnabled(RBtn_Manual.Checked);
        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            _IOPage.Refresh(itemText == "I/O");
            _stationPage.Refresh(itemText == "点位");
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("是否关闭软件", "提示", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
