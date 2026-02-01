using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSystem.Device
{
    public class CSLumeter : SerialComm
    {
        [JsonIgnore]
        public double[] LuxList { private set; get; } = new double[6];

        [JsonIgnore]
        public Action OnUpdateDisp;

        public CSLumeter()
        {
            new Task(ReadLux).Start();
        }

        public CSLumeter(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new CSLumeterView(this);
        }

        private void ReadLux()
        {
            while (true)
            {
                Thread.Sleep(20);
                if (_bufferList.Count < 72)
                    continue;
                byte[] buffer = _bufferList.ToArray();
                _bufferList.Clear();
                string sData = Encoding.ASCII.GetString(buffer);
                if (!sData.Contains(";")) continue;
                string[] dataArr = sData.Split(';');
                foreach (var subData in dataArr)
                {
                    try
                    {
                        string[] subDataArr = subData.Split(',');
                        foreach (string item in subDataArr)
                        {
                            if (item.Contains("L") && item.Contains("=") && item.Length > 10)
                                LuxList[Convert.ToInt32(item[1].ToString()) - 1] = Convert.ToDouble(item.Split('=')[1]);
                        }
                    }
                    catch { }
                    OnUpdateDisp?.Invoke();
                }
            }
        }
    }
}

