using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using JSystem.Perform;
using JSystem.Device;
using JLogging;
using JSystem.Param;
using FileHelper;

namespace JSystem.IO
{
    public class IOManager
    {
        private bool _isStart = false;

        private bool _isInit = false;

        public Func<bool> OnInit;

        public Func<bool> OnStart;

        public Func<bool, bool> OnStop;

        public Func<bool, bool> OnPause;

        private bool _isMonitor = true;

        public Func<string, DeviceBase> OnGetDevice;

        public Func<List<DeviceBase>> OnGetBoards;

        public Action OnUpdateIOView;

        public Dictionary<string, IOParam> DictInput = new Dictionary<string, IOParam>();

        public Dictionary<string, IOParam> DictOutput = new Dictionary<string, IOParam>();

        public IOManager()
        {
            try
            {
                string cfgPath = AppDomain.CurrentDomain.BaseDirectory + "Config//参数.xlsx";
                using (Excel excel = new Excel(cfgPath))
                {
                    for (int i = 2; i <= excel["输入信号"].Rows; i++)
                    {
                        IOParam param = new IOParam()
                        {
                            Name = excel["输入信号"][i, 1].ToString(),
                            BoardName = excel["输入信号"][i, 2].ToString(),
                            AxisIndex = Convert.ToInt32(excel["输入信号"][i, 3]),
                            PointIndex = Convert.ToInt32(excel["输入信号"][i, 4])
                        };
                        DictInput.Add(excel["输入信号"][i, 1].ToString(), param);
                    }
                    for (int i = 2; i <= excel["输出信号"].Rows; i++)
                    {
                        IOParam param = new IOParam()
                        {
                            Name = excel["输出信号"][i, 1].ToString(),
                            BoardName = excel["输出信号"][i, 2].ToString(),
                            AxisIndex = Convert.ToInt32(excel["输出信号"][i, 3]),
                            PointIndex = Convert.ToInt32(excel["输出信号"][i, 4])
                        };
                        DictOutput.Add(excel["输出信号"][i, 1].ToString(), param);
                    }
                }
                new Task(MonitorIO).Start();
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("IO", $"序列化失败，请根据提示查看IO表的错误位置，{ex.Message}", LogLevels.Error);
            }
        }

        public bool Init()
        {
            try
            {
                foreach (var key in DictInput.Keys)
                    DictInput[key].State = GetIn(key);
                foreach (var key in DictOutput.Keys)
                    GetOut(key);
                _isInit = true;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("IO", $"{ex.Message}");
                _isInit = false;
            }
            return _isInit;
        }

        public void UnInit()
        {
            _isMonitor = false;
        }

        public void Start()
        {
            _isStart = true;
        }

        public void Stop()
        {
            _isStart = false;
        }

        public void Save()
        {
            string cfgPath = AppDomain.CurrentDomain.BaseDirectory + "Config//参数.xlsx";
            using (Excel excel = new Excel(cfgPath))
            {
                int intputIdx = 0;
                foreach (var key in DictInput.Keys)
                {
                    intputIdx++;
                    excel["输入信号"][intputIdx + 1, 1] = key.ToString();
                    excel["输入信号"][intputIdx + 1, 2] = DictInput[key].BoardName;
                    excel["输入信号"][intputIdx + 1, 3] = DictInput[key].AxisIndex;
                    excel["输入信号"][intputIdx + 1, 4] = DictInput[key].PointIndex;
                }
                int outputIdx = 0;
                foreach (var key in DictOutput.Keys)
                {
                    outputIdx++;
                    excel["输出信号"][outputIdx + 1, 1] = key.ToString();
                    excel["输出信号"][outputIdx + 1, 2] = DictOutput[key].BoardName;
                    excel["输出信号"][outputIdx + 1, 3] = DictOutput[key].AxisIndex;
                    excel["输出信号"][outputIdx + 1, 4] = DictOutput[key].PointIndex;
                }
                excel.Save();
            }
        }

        public void SetOut(string name, bool isOn)
        {
            try
            {
                if (OnGetDevice == null) return;
                IOParam doParam = DictOutput[name];
                Board board = (Board)OnGetDevice(doParam.BoardName);
                board.SetOut(doParam.AxisIndex, doParam.PointIndex, isOn);
            }
            catch
            {
                throw new Exception($"信号{name}配置异常");
            }
        }

        public bool GetOut(string name)
        {
            try
            {
                if (OnGetDevice == null) return false;
                IOParam doParam = DictOutput[name];
                Board board = (Board)OnGetDevice(doParam.BoardName);
                return board.GetOut(doParam.AxisIndex, doParam.PointIndex);
            }
            catch
            {
                throw new Exception($"信号{name}配置异常");
            }
        }

        public bool GetIn(string name)
        {
            try
            {
                if (OnGetDevice == null) return false;
                IOParam diParam = DictInput[name];
                Board board = (Board)OnGetDevice(diParam.BoardName);
                return board.GetIn(diParam.AxisIndex, diParam.PointIndex);
            }
            catch
            {
                throw new Exception($"信号{name}配置异常");
            }
        }

        public bool GetEdgeSignal(string name, bool isRising)
        {
            try
            {
                if (OnGetDevice == null) return false;
                IOParam diParam = DictInput[name];
                Board board = (Board)OnGetDevice(diParam.BoardName);
                bool di = board.GetIn(diParam.AxisIndex, diParam.PointIndex);
                bool ret = isRising ? (!diParam.State && di) : (diParam.State && !di);
                diParam.State = di;
                return ret;
            }
            catch
            {
                throw new Exception($"信号{name}配置异常");
            }
        }

        private void MonitorIO()
        {
            while (_isMonitor)
            {
                Thread.Sleep(50);
                if (OnGetDevice == null)
                    continue;
                OnUpdateIOView?.Invoke();
                if (GetEdgeSignal("启动按钮", true))
                    OnStart();
                if (GetEdgeSignal("复位按钮", true))
                    OnInit();
                if (GetEdgeSignal("暂停按钮", true))
                    OnPause(true);
                if (!_isStart) continue;
                if (!CheckIsSafe())
                    OnStop?.Invoke(false);
            }
        }

        public bool CheckIsSafe()
        {
            if (!ParamManager.GetBoolParam("禁用安全门"))
            {
                if (!CheckDI("前门禁", true) || !CheckDI("后门禁", true) || !CheckDI("左门禁", true) || !CheckDI("右门禁", true))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 复位之前需要检查以下IO是否安全，如不需要检测，直接返回true，不要删除该函数
        /// </summary>
        /// <returns></returns>
        public bool ResetSafeCheck()
        {
            return true;
        }

        public bool CheckDI(string input, bool value)
        {
            if (GetIn(input) != value)
            {
                LogManager.Instance.AddLog("IO", $"检查到{input}信号异常");
                return false;
            }
            return true;
        }
    }
}
