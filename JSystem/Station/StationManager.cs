using System;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSystem.Perform;
using JSystem.Device;
using JSystem.IO;
using JLogging;
using System.Linq;
using FileHelper;
using System.Text;

namespace JSystem.Station
{
    public class StationManager
    {
        private EStationState _state = EStationState.END;

        public EStationState State
        {
            get { return _state; }
            set
            {
                _state = value;
                foreach (StationBase station in StationList)
                    station.State = value;
            }
        }

        private bool _isMonitor = true;

        private static readonly object _lock = new object();

        public List<StationBase> StationList { private set; get; } = new List<StationBase>();

        private static string CfgPath = AppDomain.CurrentDomain.BaseDirectory + "Config//参数.xlsx";

        public StationAxis[] Axes { get; protected set; } = new StationAxis[0];

        public Func<string, DeviceBase> OnGetDevice;

        public Action<string, bool> OnSetOut;

        public Func<string, bool> OnGetIn;

        public Func<string, bool, bool> OnGetEdgeSignal;

        public Func<EPopupType, string, string, string, bool, DialogResult> OnShowPopup;

        public Action OnHidePopup;

        private Task[] _tasksRun = null;

        private List<PointPos> _pointsList = new List<PointPos>();

        public Action OnUpdateState;

        public List<PointPos> PointsList
        {
            set
            {
                try
                {
                    string[] pointsName;
                    using (Excel excel = new Excel(CfgPath))
                    {
                        pointsName = new string[excel["点位"].Rows - 1];
                        for (int i = 2; i <= excel["点位"].Rows; i++)
                            pointsName[i - 2] = excel["点位"][i, 1].ToString();
                    }
                    _pointsList.Clear();
                    foreach (string pointName in pointsName)
                    {
                        if (value == null || value.Find((p) => p.Name == pointName) == null)
                            _pointsList.Add(new PointPos(pointName));
                        else
                            _pointsList.Add(value.Find((p) => p.Name == pointName));
                    }
                }
                catch (Exception ex)
                {
                    LogManager.Instance.AddLog("点位初始化", $"文件读取异常：{ex.Message}", LogLevels.Error);
                }
            }
            get
            {
                return _pointsList;
            }
        }

        public StationManager()
        {
            try
            {
                StationList.Add(new Track1Station("A"));
                StationList.Add(new Track1Station("B"));
                StationList.Add(new Track2Station("A"));
                StationList.Add(new Track2Station("B"));
                StationList.Add(new Track3Station("A"));
                StationList.Add(new Track3Station("B"));
                StationList.Add(new Track4Station("A"));
                StationList.Add(new Track4Station("B"));
                StationList.Add(new TransferStation());
                StationList.Add(new TestStation("左"));
                StationList.Add(new TestStation("右"));
                PointsList = null;
                using (Excel excel = new Excel(CfgPath))
                {
                    Axes = new StationAxis[excel["轴"].Rows - 1];
                    for (int i = 2; i <= excel["轴"].Rows; i++)
                    {
                        Axes[i - 2] = new StationAxis()
                        {
                            Name = excel["轴"][i, 1].ToString(),
                            BoardName = excel["轴"][i, 2].ToString(),
                            AxisIndex = Convert.ToInt32(excel["轴"][i, 3]),
                            PlusePerUnit = Convert.ToUInt32(excel["轴"][i, 4]),
                            Unit = excel["轴"][i, 5].ToString(),
                            MoveVelL = Convert.ToDouble(excel["轴"][i, 6]),
                            MoveVelH = Convert.ToDouble(excel["轴"][i, 7]),
                            ManulVel = Convert.ToDouble(excel["轴"][i, 8]),
                            MoveAcc = Convert.ToDouble(excel["轴"][i, 9]),
                            MoveDcc = Convert.ToDouble(excel["轴"][i, 10]),
                            HomeMode = Convert.ToUInt32(excel["轴"][i, 11]),
                            HomeDir = Convert.ToUInt32(excel["轴"][i, 12]),
                            HomeVelL = Convert.ToDouble(excel["轴"][i, 13]),
                            HomeVelH = Convert.ToDouble(excel["轴"][i, 14]),
                            HomeAcc = Convert.ToDouble(excel["轴"][i, 15]),
                            HomeDcc = Convert.ToDouble(excel["轴"][i, 16]),
                            Accuracy = Convert.ToDouble(excel["轴"][i, 17]),
                        };
                    }
                }
                new Task(AxisStateMonitor).Start();
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"请检查配置文件的类型是否存在：{ex.Message}");
            }
        }

        public void RegisterEvents()
        {
            foreach (StationBase station in StationList)
            {
                station.OnGetStation = GetStation;
                station.OnGetDevice = OnGetDevice;
                station.OnGetIn = OnGetIn;
                station.OnSetOut = OnSetOut;
                station.OnGetEdgeSignal = OnGetEdgeSignal;
                station.OnGetPoint = GetPointPos;
                station.OnGetAxis = GetAxis;
                station.OnShowPopup = ShowPopup;
                station.OnHidePopup = () => { OnHidePopup?.Invoke(); };
            }
        }

        public bool Reset()
        {
            try
            {
                if (StationList == null || StationList.Count == 0)
                    return false;
                foreach (StationAxis axis in Axes)
                {
                    if (axis.IsAlarm)
                    {
                        LogManager.Instance.AddLog("复位", $"{axis.Name}轴报警，无法复位");
                        return false;
                    }
                    if (axis.IsEmergencyStop)
                    {
                        LogManager.Instance.AddLog("复位", $"急停被按下，无法复位");
                        return false;
                    }
                }
                if (!End()) return false;
                if (_tasksRun != null)
                {
                    Task.WaitAll(_tasksRun);
                    LogManager.Instance.AddLog("复位", $"线程已全部停止");
                }
                LogManager.Instance.AddLog("复位", $"开始复位");
                _state = EStationState.RESETING;
                bool ret = true;
                Task[] tasksReset = new Task[StationList.Count];
                for (int i = 0; i < StationList.Count; i++)
                {
                    tasksReset[i] = new Task((idx) =>
                    {
                        if (!StationList[(int)idx].Reset())
                        {
                            LogManager.Instance.AddLog("复位", $"{StationList[(int)idx].Name}复位失败");
                            ret = false;
                            return;
                        }
                    }, i);
                    tasksReset[i].Start();
                }
                Task.WaitAll(tasksReset);
                if (!ret) return false;
                _tasksRun = new Task[StationList.Count];
                for (int i = 0; i < StationList.Count; i++)
                {
                    _tasksRun[i] = new Task(StationList[i].Run);
                    _tasksRun[i].Start();
                }
                _state = ret ? EStationState.RESETED : EStationState.END;
                LogManager.Instance.AddLog("复位", $"复位结束");
                return ret;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("复位", $"工站复位异常：{ex.Message}");
                return false;
            }
        }

        public bool Start()
        {
            try
            {
                if (_state != EStationState.PAUSE && _state != EStationState.RESETED)
                {
                    LogManager.Instance.AddLog("主流程", $"机台未复位");
                    return false;
                }
                if (StationList == null || StationList.Count == 0)
                    return false;
                if (StationList.Find((s) => s.State != EStationState.RESETED && s.State != EStationState.PAUSE) != null)
                {
                    LogManager.Instance.AddLog("主流程", $"工站状态改变");
                    return false;
                }
                foreach (StationBase station in StationList)
                    station.Start();
                _state = EStationState.RUNNING;
                return true;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"工站启动异常：{ex.Message}");
                return false;
            }
        }

        public bool Pause()
        {
            try
            {
                if (StationList == null || StationList.Count == 0)
                    return false;
                foreach (StationBase station in StationList)
                    station.Pause();
                Thread.Sleep(100);  //确保所有工站已经进入了暂停状态
                foreach (StationAxis axis in Axes)
                {
                    ((Board)OnGetDevice(axis.BoardName)).Stop(axis.AxisIndex);
                }
                _state = EStationState.PAUSE;
                return true;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"工站暂停异常：{ex.Message}");
                return false;
            }
        }

        public bool End()
        {
            try
            {
                if (StationList == null || StationList.Count == 0)
                    return true;
                foreach (StationAxis axis in Axes)
                    ((Board)OnGetDevice(axis.BoardName)).Stop(axis.AxisIndex);
                foreach (StationBase station in StationList)
                    station.End();
                _state = EStationState.END;
                LogManager.Instance.AddLog("主流程", $"已停止运行");
                return true;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"工站停止异常：{ex.Message}");
                return false;
            }
        }

        public void UnInit()
        {
            _isMonitor = false;
        }

        public void AxisStateMonitor()
        {
            while (_isMonitor)
            {
                try
                {
                    if (OnGetDevice == null) continue;
                    foreach (StationAxis axis in Axes)
                    {
                        Thread.Sleep(5);    //不加延迟会卡
                        Board board = (Board)OnGetDevice(axis.BoardName);
                        axis.State = board.GetAxisState(axis.AxisIndex);
                        axis.IsAlarm = (axis.State & (0x01 << 0)) > 0 ? true : false;
                        axis.IsEmergencyStop = (axis.State & (0x01 << 4)) > 0 ? true : false;
                        axis.IsEnabled = (axis.State & (0x01 << 5)) > 0 ? true : false;
                        axis.CmdPos = board.GetCmdPos(axis.AxisIndex) / axis.PlusePerUnit;
                        axis.ActPos = board.GetActPos(axis.AxisIndex) / axis.PlusePerUnit;
                        if (!axis.IsAlarm && !axis.IsEmergencyStop && axis.IsEnabled)
                            continue;
                        axis.NeedGoHome = true;
                        if (_state == EStationState.END || _state == EStationState.MANUAL)
                            continue;
                        if (axis.IsAlarm)
                            OnShowPopup(EPopupType.EMERGENCY, "1001", "主流程", $"{axis.Name}轴报警，已停止", true);
                        else if (axis.IsEmergencyStop)
                            OnShowPopup(EPopupType.EMERGENCY, "1002", "主流程", $"急停被按下，已停止", true);
                        else if (!axis.IsEnabled)
                            OnShowPopup(EPopupType.EMERGENCY, "1003", "主流程", $"{axis.Name}轴没有使能，已停止", true);
                    }
                    OnUpdateState?.Invoke();
                }
                catch (Exception ex)
                {
                    LogManager.Instance.AddLog("AxisStateMonitor", ex.Message, LogLevels.Error);
                    return;
                }
            }
        }

        public StationBase GetStation(string stationName)
        {
            StationBase station = StationList.Find((s) => s.Name == stationName);
            if (station == null)
            {
                OnShowPopup(EPopupType.EMERGENCY, "1004", "主流程", $"不存在{stationName}", true);
                return null;
            }
            return station;
        }

        public DialogResult ShowPopup(EPopupType type, string code, string name, string msg, bool isBlock = true)
        {
            lock (_lock)
            {
                return OnShowPopup(type, code, name, msg, isBlock);
            }
        }

        private PointPos GetPointPos(string pointName)
        {
            if (PointsList.Find((p) => p.Name == pointName) == null)
            {
                OnShowPopup(EPopupType.EMERGENCY, "1005", "主流程", $"不存在点位{pointName}", true);
                return null;
            }
            return PointsList.Find((p) => p.Name == pointName).Clone();
        }

        public StationAxis GetAxis(string axisName)
        {
            return Axes.FirstOrDefault((axis) => axis.Name == axisName);
        }

        public void Save()
        {
            using (Excel excel = new Excel(CfgPath))
            {
                for (int i = 2; i <= excel["轴"].Rows; i++)
                {
                    excel["轴"][i, 1] = Axes[i - 2].Name;
                    excel["轴"][i, 2] = Axes[i - 2].BoardName;
                    excel["轴"][i, 3] = Axes[i - 2].AxisIndex;
                    excel["轴"][i, 4] = Axes[i - 2].PlusePerUnit;
                    excel["轴"][i, 5] = Axes[i - 2].Unit;
                    excel["轴"][i, 6] = Axes[i - 2].MoveVelL;
                    excel["轴"][i, 7] = Axes[i - 2].MoveVelH;
                    excel["轴"][i, 8] = Axes[i - 2].ManulVel;
                    excel["轴"][i, 9] = Axes[i - 2].MoveAcc;
                    excel["轴"][i, 10] = Axes[i - 2].MoveDcc;
                    excel["轴"][i, 11] = Axes[i - 2].HomeMode;
                    excel["轴"][i, 12] = Axes[i - 2].HomeDir;
                    excel["轴"][i, 13] = Axes[i - 2].HomeVelL;
                    excel["轴"][i, 14] = Axes[i - 2].HomeVelH;
                    excel["轴"][i, 15] = Axes[i - 2].HomeAcc;
                    excel["轴"][i, 16] = Axes[i - 2].HomeDcc;
                    excel["轴"][i, 17] = Axes[i - 2].Accuracy;
                }
                for (int i = 2; i <= excel["点位"].Rows; i++)
                    excel["点位"][i, 1] = _pointsList[i - 2].Name;
                excel.Save();
            }
        }
    }
}
