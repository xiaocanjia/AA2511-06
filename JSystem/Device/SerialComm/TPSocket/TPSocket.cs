using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using JSystem.Param;
using JSystem.Perform;

namespace JSystem.Device
{
    public class TPSocket : SerialComm
    {
        public TPSocket() { }

        public TPSocket(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new TPSocketView(this);
        }

        public bool GetIn(int idx)
        {
            if (!CheckConnection())
                return false;
            byte[] rec = SendCommand(new byte[] { 0x48, 0x59, 0x08, 0x01, 0x0C, 0x01, 0x0D, 0x0A });
            if (rec == null)
            {
                LogManager.Instance.AddLog("TPSocket", "获取输入失败");
                return false;
            }
            return ((rec[5] >> idx) & 1) == 1;
        }

        private byte[] SendCommand(byte[] data)
        {
            ClearBuffer();
            WriteData(data);
            DateTime start = DateTime.Now;
            while (true)
            {
                Thread.Sleep(10);
                if (_bufferList.Count >= 3 && _bufferList.Count == _bufferList[2])
                    return _bufferList.ToArray();
                if (DateTime.Now.Subtract(start).TotalMilliseconds > 2000)
                    return null;
            }
        }

        public bool SendCommand(string pdtLog, string cmd, byte[] send, out byte[] rec)
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
                byte[] sendTotal = new byte[] { 0x48, 0x59, (byte)(5 + send.Length) };
                WriteData(sendTotal.Concat(send).Concat(new byte[] { 0x0D, 0x0A }).ToArray());
                string msg = "";
                foreach (byte b in sendTotal)
                    msg += b.ToString("X2") + " ";
                LogManager.Instance.AddPdtLog(pdtLog, $"发送：{msg}");
                DateTime start = DateTime.Now;
                retryCount++;
                List<byte> recData = new List<byte>();
                msg = "";
                while (true)
                {
                    Thread.Sleep(50);
                    if (DateTime.Now.Subtract(start).TotalSeconds > 10)
                    {
                        msg = "";
                        foreach (byte b in recData)
                            msg += b.ToString("X2") + " ";
                        LogManager.Instance.AddPdtLog(pdtLog, $"读取指令超时\t接收：{msg}");
                        goto SEND;
                    }
                    recData.AddRange(_bufferList);
                    if (recData.Count < 3 || recData.Count < recData[2])
                        continue;
                    msg = "";
                    foreach (byte b in recData)
                        msg += b.ToString("X2") + " ";
                    rec = recData.ToArray();
                    LogManager.Instance.AddPdtLog(pdtLog, $"接收：{msg}");
                    Thread.Sleep(100);
                    ClearBuffer();
                }
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddPdtLog(pdtLog, $"接收数据异常：{ex.Message}");
                return false;
            }
        }
    }
}

