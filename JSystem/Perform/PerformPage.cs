using System;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows.Forms;
using Sunny.UI;
using JSystem.Station;
using JLogging;
using JSystem.Device;
using FileHelper;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace JSystem.Perform
{
    public partial class PerformPage : UIPage
    {
        private SysController _controller;

        private Popup _window = new Popup();

        private DispatcherFrame _dispatcherFrame = null;

        private int _totalCount = 0;

        private int _passCount = 0;

        private int _failCount = 0;

        private string _filePath = AppDomain.CurrentDomain.BaseDirectory + "user.ini";

        private IOTSys _IOT = null;

        private TestStation _stationL;

        private TestStation _stationR;

        private UILineChart[] _charts = null;

        private UILabel[] _lbSNs = null;

        private string[] _serialNames = new string[6];

        public PerformPage()
        {
            InitializeComponent();
            _charts = new UILineChart[] { ChartL, ChartR };
            _lbSNs = new UILabel[] { LB_SNL, LB_SNR };
            _window.OnHide = HidePopup;
            _serialNames = new string[] { "Fx", "Fy", "Fz", "Mx", "My", "Mz" };
            for (int i = 0; i < _charts.Length; i++)
            {
                UILineOption option = new UILineOption();
                option.ToolTip.Visible = true;
                option.Title = new UITitle();
                option.Title.Top = UITopAlignment.Center;
                option.Title.SubText = "";
                option.Grid.Top = 30;
                option.Grid.Bottom = 30;
                option.Grid.Left = 50;
                option.Grid.Right = 20;
                option.AddSeries(new UILineSeries("Fx", Color.Green) { Smooth = true });
                option.AddSeries(new UILineSeries("Fy", Color.Yellow) { Smooth = true });
                option.AddSeries(new UILineSeries("Fz", Color.Red) { Smooth = true });
                option.AddSeries(new UILineSeries("Mx", Color.Blue) { Smooth = true });
                option.AddSeries(new UILineSeries("My", Color.Gray) { Smooth = true });
                option.AddSeries(new UILineSeries("Mz", Color.Black) { Smooth = true });
                option.Legend = new UILegend();
                option.Legend.Orient = UIOrient.Horizontal;
                option.Legend.Top = UITopAlignment.Top;
                option.Legend.Left = UILeftAlignment.Right;
                option.YAxis.Name = "压力";
                _charts[i].SetOption(option);
            }
        }

        public void Init(SysController controller)
        {
            try
            {
                _controller = controller;
                _IOT = (IOTSys)controller.DeviceMgr.GetDevice("SCADA系统");
                _controller.StationMgr.OnShowPopup = ShowPopup;
                _controller.StationMgr.OnHidePopup = HidePopup;
                _controller.OnUpdateState = UpdateState;
                _stationL = (TestStation)_controller.StationMgr.GetStation("左测试工站");
                _stationR = (TestStation)_controller.StationMgr.GetStation("右测试工站");
                _stationL.OnSendPressDada = DispWave;
                _stationR.OnSendPressDada = DispWave;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主页", $"主页初始化失败：{ex.Message}");
            }
        }

        private void DispWave(int idx, string sn, List<double>[] dataList)
        {
            if (InvokeRequired)
                Invoke(new Action(() => { DispWave(idx, sn, dataList); }));
            else
            {
                _lbSNs[idx].Text = sn;
                _charts[idx].Option.Series["Fx"].Clear();
                _charts[idx].Option.Series["Fy"].Clear();
                _charts[idx].Option.Series["Fz"].Clear();
                _charts[idx].Option.Series["Mx"].Clear();
                _charts[idx].Option.Series["My"].Clear();
                _charts[idx].Option.Series["Mz"].Clear();
                for (int i = 0; i < dataList.Length; i++)
                {
                    _charts[idx].Option.Series[_serialNames[i]].Clear();
                    for (int j = 0; j < dataList[i].Count; j++)
                        _charts[idx].Option.AddData(_serialNames[i], j, dataList[i][j]);
                }
                _charts[idx].Refresh();
            }
        }

        public void SetEnabled(bool isEnabled)
        {
            Btn_Start.Enabled = !isEnabled;
            Btn_Pause.Enabled = !isEnabled;
            Btn_Reset.Enabled = !isEnabled;
            Btn_End.Enabled = !isEnabled;
        }

        private void UpdateState(EDeviceState state)
        {
            if (InvokeRequired)
                BeginInvoke(new Action(() => { UpdateState(state); }));
            else
            {
                _controller.CurrState = state;
                switch (state)
                {
                    case EDeviceState.UNINIT:
                        StatusPanel.UpdateState(state, 0, 0, 0, 0);
                        Btn_Reset.Enabled = true;
                        Btn_Start.BringToFront();
                        HidePopup();
                        if (_IOT != null)
                        {
                            _IOT.UploadDeviceState("Stop", out string msg);
                            LogManager.Instance.AddLog("主流程", "发送Stop获取返回值:" + msg, LogLevels.Debug);
                        }
                        break;
                    case EDeviceState.INITING:
                        StatusPanel.UpdateState(state, 0, 0, 2, 0);
                        Btn_Reset.Enabled = false;
                        HidePopup();
                        break;
                    case EDeviceState.INITED:
                        StatusPanel.UpdateState(state, 0, 1, 0, 0);
                        _IOT?.ClearAlarm(out string ret);
                        Btn_Start.BringToFront();
                        Btn_Reset.Enabled = true;
                        break;
                    case EDeviceState.RUN:
                        StatusPanel.UpdateState(state, 0, 0, 1, 0);
                        Btn_Reset.Enabled = false;
                        Btn_Pause.BringToFront();
                        HidePopup();
                        if (_IOT != null)
                        {
                            _IOT.UploadDeviceState("Runing", out string msg);
                            LogManager.Instance.AddLog("主流程", "发送Runing获取返回值:" + msg, LogLevels.Debug);
                        }
                        break;
                    case EDeviceState.PAUSE:
                        StatusPanel.UpdateState(state, 0, 0, 2, 0);
                        Btn_Start.BringToFront();
                        break;
                    case EDeviceState.PAUSEALARM:
                        StatusPanel.UpdateState(state, 0, 2, 0, 1);
                        Btn_Start.BringToFront();
                        Btn_Reset.Enabled = false;
                        break;
                    case EDeviceState.EMERGENCY:
                        StatusPanel.UpdateState(state, 2, 0, 0, 1);
                        Btn_Reset.Enabled = true;
                        Btn_Start.BringToFront();
                        break;
                }
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            new Task(() =>
            {
                Invoke(new Action(() => { Btn_Reset.Enabled = false; }));
                Btn_Reset.Enabled = false;
                Btn_Start.Symbol = 61515;
                _controller.Init();
                Invoke(new Action(() => { Btn_Reset.Enabled = true; }));
            }).Start();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (!_controller.Start())
                UIMessageTip.ShowError("启动失败");
        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            if (!_controller.Pause(true))
                UIMessageTip.ShowError("暂停失败");
        }

        private void Btn_End_Click(object sender, EventArgs e)
        {
            LogManager.Instance.AddLog("主页", $"手动点击中止按钮", LogLevels.Debug);
            _controller.Stop(true);
        }

        private void Btn_Mute_Click(object sender, EventArgs e)
        {
            _controller.IOMgr.SetOut("蜂鸣器", false);
        }

        private DialogResult ShowPopup(EPopupType type, string code, string title, string msg, bool isBlock)
        {
            if (InvokeRequired)
            {
                return (DialogResult)Invoke(new Func<DialogResult>(() => { return ShowPopup(type, code, title, msg, isBlock); }));
            }
            else
            {
                _dispatcherFrame = new DispatcherFrame();
                LogManager.Instance.AddLog(title, msg, LogLevels.Error);
                if (_IOT != null)
                {
                    _IOT.UploadAlarm(type.ToString(), "", code, msg, out string ret);
                    LogManager.Instance.AddLog(title, ret, LogLevels.Debug);
                }
                if (_controller.CurrState == EDeviceState.RUN && isBlock)
                {
                    if (type == EPopupType.EMERGENCY)
                        _controller.Stop(false);
                    if (type == EPopupType.ALARM || type == EPopupType.CONFIRM)
                        _controller.Pause(false);
                }
                _window.Show(type, title, msg);
                if (!isBlock) return DialogResult.None;
                Dispatcher.PushFrame(_dispatcherFrame);
                if (_controller.CurrState != EDeviceState.PAUSEALARM && _controller.CurrState != EDeviceState.EMERGENCY)
                {
                    _controller.IOMgr.SetOut("蜂鸣器", false);
                    return _window.CurrRet;
                }
                if (_window.CurrRet == DialogResult.Abort)
                    _controller.Stop(true);
                if (_window.CurrRet == DialogResult.Retry || _window.CurrRet == DialogResult.OK)
                    _controller.Start();
                return _window.CurrRet;
            }
        }

        private void HidePopup()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => HidePopup()));
            }
            else
            {
                if (_dispatcherFrame == null)
                    return;
                _dispatcherFrame.Continue = false;
                _dispatcherFrame = null;
                _window?.Hide();
                if (_IOT != null)
                {
                    _IOT.ClearAlarm(out string msg);
                    LogManager.Instance.AddLog(_window.Text, msg, LogLevels.Debug);
                }
            }
        }

        private void DispCT(double CT)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => DispCT(CT)));
            }
            else
            {
                Lb_CT.Text = CT.ToString();
                Lb_UPH.Text = (3600.0 / CT * 2).ToString();
            }
        }

        private void DispCount()
        {
            Lb_OK_Pct.Text = ((_passCount / Convert.ToDouble(_totalCount)) * 100).ToString("F1") + "%";
            Lb_Total.Text = _totalCount.ToString();
            Lb_Pass.Text = _passCount.ToString();
            Lb_Fail.Text = _failCount.ToString();
            IniHelper.INIWriteValue(_filePath, "统计", "TotalCount", Lb_Total.Text);
            IniHelper.INIWriteValue(_filePath, "统计", "PassCount", Lb_Pass.Text);
            IniHelper.INIWriteValue(_filePath, "统计", "FailCount", Lb_Fail.Text);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            _totalCount = 0;
            _passCount = 0;
            _failCount = 0;
            DispCount();
        }

        private void TimerIO_Tick(object sender, EventArgs e)
        {

        }
    }
}
