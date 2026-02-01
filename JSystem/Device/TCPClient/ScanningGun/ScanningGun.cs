using System;
using System.Text;
using System.Threading;

namespace JSystem.Device
{
    public class TCPScanningGun : TCPClient
    {
        public string StartCommand = "start";

        public string EndCommand = "end";

        public int Length = 27;

        public TCPScanningGun() { }

        public TCPScanningGun(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new TCPScanningGunView(this);
        }

        public string ReadSN(int timeOut = 1000)
        {
            ClearBuffer();
            WriteData(Encoding.Default.GetBytes(StartCommand));
            DateTime start = DateTime.Now;
            string sn = "";
            while (true)
            {
                Thread.Sleep(10);
                if (_bufferList.Count >= Length)
                {
                    sn = Encoding.ASCII.GetString(_bufferList.ToArray());
                    sn = sn.Substring(0, Length);
                    return sn;
                }
                if (DateTime.Now.Subtract(start).TotalMilliseconds > timeOut)
                    return "";
            }
        }
    }
}

