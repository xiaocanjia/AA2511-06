using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JSystem.Device
{
    public class SerialScanningGun : SerialComm                                                    
    {
        public string StartCommand = "start";

        public string EndCommand = "end";

        public int MaxLength = 27;

        public bool IsHex = false;

        public SerialScanningGun() { }

        public SerialScanningGun(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new SerialScanningGunView(this);
        }

        public string ReadSN(int timeOut = 1000)
        {
            ClearBuffer();
            if (IsHex)
            {
                string[] cmd = StartCommand.Split(' ');
                List<byte> dataBytes = new List<byte>();
                foreach (string c in cmd)
                    dataBytes.Add(Convert.ToByte("0x" + c, 16));
                WriteData(dataBytes.ToArray());
            }
            else
            {
                WriteData(StartCommand);
            }
            DateTime start = DateTime.Now;
            string sn = "";
            while (true)
            {
                Thread.Sleep(10);
                if (_bufferList.Count >= MaxLength)
                {
                    sn = Encoding.ASCII.GetString(_bufferList.ToArray());
                    sn = sn.Substring(0, MaxLength);
                    return sn;
                }
                if (DateTime.Now.Subtract(start).TotalMilliseconds > timeOut)
                {
                    WriteData(EndCommand);
                    return Encoding.ASCII.GetString(_bufferList.ToArray());
                }
            }
        }
    }
}

