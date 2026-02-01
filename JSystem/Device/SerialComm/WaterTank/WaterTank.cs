using System;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JSystem.Perform;

namespace JSystem.Device
{
    public class WaterTank : SerialComm
    {
        [JsonIgnore]
        public double TargetTemp = 37;

        [JsonIgnore]
        public double[] CurrTemp { get; private set; } = new double[5];

        [JsonIgnore]
        public bool[] CurrStage { get; private set; } = new bool[3];      //当前水位，共有三个感应器

        [JsonIgnore]
        public bool HasReach { get; private set; } = false;

        private bool _isOn = false;

        private bool _isAdding = false;

        private int _reachCount = 0;

        public WaterTank()
        {
            new Task(TempMonitor).Start();
        }

        public WaterTank(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new WaterTankView(this);
        }

        private void TempMonitor()
        {
            while (true)
            {
                Thread.Sleep(10);
                byte[] buffer = _bufferList.ToArray();
                _bufferList.Clear();
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (i >= buffer.Length - 11)
                        break;
                    if (buffer[i] == 0x48 && buffer[i + 11] == 0x0A)
                    {
                        if (buffer[i + 4] == 0x01)
                        {
                            CurrStage[0] = (buffer[i + 6] & 0x01) != 0x01;
                            CurrStage[1] = (buffer[i + 6] & 0x02) != 0x02;
                            CurrStage[2] = (buffer[i + 6] & 0x04) != 0x04;
                            if (_isOn && (!CurrStage[0] || CurrStage[2]))
                                SwitchTank(false);      //低于最低水位或者高于最高水位时不允许加热
                            if (!_isOn && CurrStage[0] && !CurrStage[2])
                            {
                                SetTemp(TargetTemp);
                                SwitchTank(true);       //高于最低水位时开始加热
                            }
                            if (!CurrStage[1])
                            {
                                if (!_isAdding)
                                {
                                    //BoardSysIF.Instance.SetOut(EOutput.抽水泵", true);
                                    //LogManager.Instance.AddLog("开始抽水");
                                    //_isAdding = true;
                                    //if (!BoardSysIF.Instance.GetIn(EInput.抽水桶有水"))
                                    //{
                                    //    BoardSysIF.Instance.SetOut(EOutput.蜂鸣器", true);
                                    //    LogManager.Instance.AddLog("抽水桶缺水，请及时加水");
                                    //}
                                }
                            }
                            else
                            {
                                if (_isAdding)
                                {
                                    //BoardSysIF.Instance.SetOut(EOutput.抽水泵", false);
                                    LogManager.Instance.AddLog(Name, "抽水完成");
                                    _isAdding = false;
                                }
                            }
                        }
                        else if (buffer[i + 4] == 0x02)
                        {
                            CurrTemp[buffer[i + 5] - 1] = BitConverter.ToInt32(new byte[] { buffer[i + 9], buffer[i + 8], buffer[i + 7], buffer[i + 6] }, 0) / 1000.0;
                        }
                        break;
                    }
                }
                double offset = 0.03;
                if (Math.Abs(CurrTemp[0] - TargetTemp) < 0.05 &&  Math.Abs(CurrTemp[1] - CurrTemp[0]) <= offset && 
                    Math.Abs(CurrTemp[2] - CurrTemp[0]) <= offset && Math.Abs(CurrTemp[3] - CurrTemp[0]) <= offset)
                {
                    _reachCount++;
                    if (_reachCount > 60000 / 10)
                        HasReach = true;
                }
                else
                {
                    _reachCount = 0;
                    HasReach = false;
                }
                ((WaterTankView)View).UpdateStatus();
            }
        }

        public void SwitchTank(bool isOn)
        {
            if (isOn)
            {
                WriteData(new byte[] { 0x48, 0x59, 0x0C, 0x01, 0x01, 0x03, 0x01, 0x00, 0x00, 0x00, 0x0d, 0x0a });
                Thread.Sleep(500);
                WriteData(new byte[] { 0x48, 0x59, 0x0C, 0x01, 0x01, 0x02, 0x01, 0x00, 0x00, 0x00, 0x0d, 0x0a });
                Thread.Sleep(500);
                WriteData(new byte[] { 0x48, 0x59, 0x0C, 0x01, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00, 0x0d, 0x0a });
                LogManager.Instance.AddLog(Name, "开始加热");
            }
            else
            {
                WriteData(new byte[] { 0x48, 0x59, 0x0C, 0x01, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00, 0x0d, 0x0a });
                Thread.Sleep(500);
                WriteData(new byte[] { 0x48, 0x59, 0x0C, 0x01, 0x01, 0x02, 0x01, 0x00, 0x00, 0x00, 0x0d, 0x0a });
                Thread.Sleep(500);
                WriteData(new byte[] { 0x48, 0x59, 0x0C, 0x01, 0x01, 0x03, 0x01, 0x00, 0x00, 0x00, 0x0d, 0x0a });
                LogManager.Instance.AddLog(Name, "停止加热");
            }
            _isOn = isOn;
        }

        public void SetTemp(double temp)
        {
            byte[] bTemp = BitConverter.GetBytes((ushort)(temp * 100));
            WriteData(new byte[] { 0x48, 0x59, 0x0C, 0x01, 0x02, 0x01, bTemp[0], bTemp[1], 0x00, 0x00, 0x0D, 0x0A });
        }
    }
}

