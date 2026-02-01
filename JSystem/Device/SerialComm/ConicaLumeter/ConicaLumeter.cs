using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSystem.Device
{
    public class ConicaLumeter : SerialComm
    {
        public double CurrLux { get; protected set; }

        private bool _isOn = true;

        [JsonIgnore]
        public Action OnUpdateDisp;

        public double Offset = 0.0;

        public ConicaLumeter() { }

        public ConicaLumeter(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new ConicaLumeterView(this);
        }

        public override bool Connect()
        {
            if (!base.Connect())
                return false;
            _isOn = true;
            WriteData(new byte[] { 0x02, 0x30, 0x30, 0x35, 0x34, 0x31, 0x20, 0x20, 0x20, 0x03, 0x31, 0x33, 0x0D, 0x0A });
            Thread.Sleep(200);
            new Task(Monitor).Start();
            return true;
        }

        public override void DisConnect()
        {
            _isOn = false;
            WriteData(new byte[] { 0x02, 0x30, 0x30, 0x35, 0x34, 0x30, 0x20, 0x20, 0x20, 0x03, 0x31, 0x32, 0x0D, 0x0A });
            base.DisConnect();
        }

        private void Monitor()
        {
            while (_isOn)
            {
                try
                {
                    _bufferList.Clear();
                    WriteData(new byte[] { 0x02, 0x30, 0x30, 0x31, 0x30, 0x30, 0x30, 0x30, 0x30, 0x03, 0x30, 0x32, 0x0D, 0x0A });
                    Thread.Sleep(100);
                    byte[] buffer = _bufferList.ToArray();
                    if (buffer.Length != 32) continue;
                    if (buffer[0] == 0x02 && buffer[1] == 0x30)
                    {
                        int internum = Convert.ToInt16(Encoding.ASCII.GetString(new byte[] { buffer[7] }));
                        CurrLux = Convert.ToDouble(Encoding.ASCII.GetString(new byte[] { buffer[10], buffer[11], buffer[12], buffer[13], buffer[14] })) / 10000.0 * Math.Pow(10, internum) + Offset;
                        if (CurrLux < 0)
                            CurrLux = 0;
                        OnUpdateDisp?.Invoke();
                    }
                    else
                    {
                        CurrLux = 0.0;
                    }
                }
                catch
                {
                    OnUpdateDisp?.Invoke();
                }
            }
        }
    }
}

