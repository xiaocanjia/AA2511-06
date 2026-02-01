using System;
using System.Threading;
using Ivi.Visa;
using NationalInstruments.Visa;
using JLogging;

namespace JSystem.Device
{
    /// <summary>
    /// 程控电源
    /// </summary>
    public class ProgramPower : DeviceBase
    {
        private readonly object _lock = new object();

        public string PortName;

        private bool _isConnected = false;

        private IMessageBasedFormattedIO _IO;

        public ProgramPower() { }

        public ProgramPower(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new ProgramPowerView(this);
        }

        public override bool Connect()
        {
            try
            {
                var rmSession = new ResourceManager();
                MessageBasedSession mbSession = (MessageBasedSession)rmSession.Open(PortName);
                _IO = mbSession.FormattedIO;
                _isConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                _isConnected = false;
                LoggingIF.Log(ex.Message);
                return false;
            }
        }

        public override void DisConnect()
        {
            _isConnected = false;
        }

        public override bool CheckConnection()
        {
            OnUpdateStatus?.Invoke(_isConnected);
            return _isConnected;
        }

        public void SetVolt(int channel, double volt)
        {
            _IO.WriteLine("*CLS");
            _IO.WriteLine($"OUTP{channel} ON");
            _IO.WriteLine($"SOUR{channel}:VOLT {volt}");
        }

        public void SetCurr(int channel, double curr)
        {
            _IO.WriteLine("*CLS");
            _IO.WriteLine($"OUTP{channel} ON");
            _IO.WriteLine($"SOUR{channel}:CURR {curr}");
        }

        public double GetCurr(int channel, int interval, int readCount, double max = 10000)
        {
            double sum = 0;
            int idx = 0;
            DateTime start = DateTime.Now;
            for (int i = 0; i < readCount; i++)
            {
                Thread.Sleep(interval);
                start = DateTime.Now;
                double curr = Convert.ToDouble(SendCommand($"MEAS{channel}:CURR?"));
                LoggingIF.Log($"工位{channel}电流值{curr}，耗时{DateTime.Now.Subtract(start).TotalMilliseconds}");
                if (double.IsNaN(curr) || curr > max) continue;
                idx++;
                sum += curr;
            }
            return idx == 0 ? 0 : sum / idx;
        }

        private string SendCommand(string cmd)
        {
            lock (_lock)
            {
                _IO.WriteLine(cmd);
                return _IO.ReadString();
            }
        }
    }
}
