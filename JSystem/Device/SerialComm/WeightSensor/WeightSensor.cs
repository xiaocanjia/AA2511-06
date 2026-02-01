using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace JSystem.Device
{
    public class WeightSensor : SerialComm
    {
        public double[] WeightList { private set; get; } = new double[2];

        [JsonIgnore]
        public Action OnUpdateDisp;

        public WeightSensor()
        {
            new Task(CalcWeight).Start();
        }

        public WeightSensor(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new WeightSensorView(this);
        }

        private void CalcWeight()
        {
            while (true)
            {
                Thread.Sleep(5);
                if (_bufferList.Count < 12)
                    continue;
                byte[] buffer = _bufferList.ToArray();
                _bufferList.Clear();
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (i >= buffer.Length - 12)
                        break;
                    if (buffer[i] == 0x48 && buffer[i + 12] == 0x0A)
                    {
                        WeightList[0] = BitConverter.ToSingle(new byte[] { buffer[i + 6],  buffer[i + 5], buffer[i + 4], buffer[i + 3] }, 0);
                        WeightList[1] = BitConverter.ToSingle(new byte[] { buffer[i + 10], buffer[i + 9], buffer[i + 8], buffer[i + 7] }, 0);
                        i += 12;
                        OnUpdateDisp();
                        break;
                    }
                }
            }
        }
    }
}

