using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using JSystem.Perform;
using JSystem.Param;
using System.Linq;

namespace JSystem.Device
{
    public class HYBluetooth : SerialComm
    {
        public HYBluetooth() { }

        public HYBluetooth(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new HYBluetoothView(this);
        }

        /// <summary>
        /// BT-Bluetooth
        /// </summary>
        /// <param name="mac"></param>
        public bool ConnectBT(string pdtLog, string mac)
        {
            return SendCommand(pdtLog, $"连接{mac}", GetCommand(0x03, Encoding.Default.GetBytes(mac.Replace(":", ""))), "connected");
        }

        public void DisConnectBT(string pdtLog)
        {
            SendCommand(pdtLog, $"{Name}断开连接", GetCommand(0x04, new byte[0]), "connect");
            Thread.Sleep(300);
            SendCommand(pdtLog, $"{Name}复位", GetCommand(0x07, new byte[0]), "Succeed");
        }

        public bool SendCommand(string pdtLog, string cmd, byte[] data, string required)
        {
            if (!CheckConnection())
            {
                LogManager.Instance.AddPdtLog(pdtLog, $"{Name}未连接");
                return false;
            }
            ClearBuffer();
            int maxRetryCount = ParamManager.GetIntParam("失败重测次数");
            int retryCount = 0;
            LogManager.Instance.AddPdtLog(pdtLog, $"{cmd}");
            try
            {
            SEND:
                if (retryCount >= maxRetryCount)
                {
                    LogManager.Instance.AddPdtLog(pdtLog, $"超过{maxRetryCount}次重试次数，结束测试");
                    return false;
                }
                ClearBuffer();
                WriteData(data);
                string msg = "";
                foreach (byte b in data)
                    msg += b.ToString("X2") + " ";
                LogManager.Instance.AddPdtLog(pdtLog, $"发送：{msg}");
                DateTime start = DateTime.Now;
                retryCount++;
                while (true)
                {
                    Thread.Sleep(50);
                    if (DateTime.Now.Subtract(start).TotalSeconds > 8)
                    {
                        msg = "";
                        if (_bufferList.Count > 0)
                            msg = Encoding.Default.GetString(_bufferList.ToArray());
                        LogManager.Instance.AddPdtLog(pdtLog, $"{Name}{cmd}超时\t接收：{msg}");
                        goto SEND;
                    }
                    if (_bufferList.Count == 0)
                        continue;
                    msg = Encoding.Default.GetString(_bufferList.ToArray());
                    if (!msg.Contains(required))
                        continue;
                    LogManager.Instance.AddPdtLog(pdtLog, $"{Name}接收：{msg}");
                    Thread.Sleep(100);
                    ClearBuffer();
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddPdtLog(pdtLog, $"{Name}接收数据异常：{ex.Message}");
                return false;
            }
        }

        public bool SendPdtCommand(string pdtLog, string cmd, byte[] data, int requireCount, out byte[] rec)
        {
            rec = null;
            if (!CheckConnection())
            {
                LogManager.Instance.AddPdtLog(pdtLog, $"{Name}未连接");
                return false;
            }
            ClearBuffer();
            int maxRetryCount = ParamManager.GetIntParam("失败重测次数");
            int retryCount = 0;
            LogManager.Instance.AddPdtLog(pdtLog, $"{cmd}");
            try
            {
            SEND:
                if (retryCount >= maxRetryCount)
                {
                    LogManager.Instance.AddPdtLog(pdtLog, $"超过{maxRetryCount}次重试次数，结束测试");
                    return false;
                }
                ClearBuffer();
                byte[] bData = GetCommand(0x05, data);
                WriteData(bData);
                string msg = "";
                foreach (byte b in bData)
                    msg += b.ToString("X2") + " ";
                LogManager.Instance.AddPdtLog(pdtLog, $"{Name}发送：{msg}");
                DateTime start = DateTime.Now;
                retryCount++;
                while (true)
                {
                    Thread.Sleep(50);
                    if (DateTime.Now.Subtract(start).TotalSeconds > 5)
                    {
                        msg = "";
                        foreach (byte b in _bufferList)
                            msg += b.ToString("X2") + " ";
                        LogManager.Instance.AddPdtLog(pdtLog, $"读取指令超时\t接收：{msg}");
                        goto SEND;
                    }
                    if (_bufferList.Count < requireCount)
                        continue;
                    msg = "";
                    foreach (byte b in _bufferList)
                        msg += b.ToString("X2") + " ";
                    rec = _bufferList.ToArray();
                    LogManager.Instance.AddPdtLog(pdtLog, $"接收：{msg}");
                    Thread.Sleep(100);
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddPdtLog(pdtLog, $"接收数据异常：{ex.Message}");
                return false;
            }
        }

        private byte[] GetCommand(byte type, byte[] data)
        {
            List<byte> cmd = new List<byte>();
            cmd.Add(Convert.ToByte(ParamManager.GetStringParam("指令1"), 16));
            cmd.Add(Convert.ToByte(ParamManager.GetStringParam("指令2"), 16));
            cmd.AddRange(BitConverter.GetBytes((short)(data.Length + 7)).Reverse());
            cmd.Add(type);
            cmd.AddRange(data);
            cmd.Add(0x0D);
            cmd.Add(0x0A);
            return cmd.ToArray();
        }
    }
}

