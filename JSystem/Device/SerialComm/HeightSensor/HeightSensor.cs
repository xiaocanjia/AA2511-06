using System;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSystem.Device
{
    public class HeightSensor : ModbusRtu
    {
        public double CurrHeight { get; protected set; }

        private bool _isOn = true;

        [JsonIgnore]
        public Action OnUpdateDisp;

        public HeightSensor() { }

        public HeightSensor(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new HeightSensorView(this);
        }

        public override bool Connect()
        {
            if (!base.Connect())
                return false;
            _isOn = true;
            new Task(Monitor).Start();
            return true;
        }

        public override void DisConnect()
        {
            _isOn = false;
            base.DisConnect();
        }

        private void Monitor()
        {
            while (_isOn)
            {
                try
                {
                    _bufferList.Clear();
                    byte[] rec = ReadHoldingRegisters(01, 0, 2);
                    if (rec == null || rec.Length == 0) continue;
                    CurrHeight = BitConverter.ToUInt32(rec, 0) / 1000.0;
                    OnUpdateDisp?.Invoke();
                    CurrHeight = 0.0;
                }
                catch
                {
                    OnUpdateDisp?.Invoke();
                }
            }
        }
    }
}

