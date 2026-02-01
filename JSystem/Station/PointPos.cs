using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSystem.Station
{
    public class PointPos
    {
        public string Name = "";

        public List<AxisCoord> AxesCoord = new List<AxisCoord>();

        public PointPos() { }

        public PointPos(string name)
        {
            Name = name;
        }

        [JsonIgnore]
        public AxisCoord this[string name]
        {
            get { return AxesCoord.Find((axis) => axis.Name == name); }
        }

        public PointPos Clone()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.DeserializeObject<PointPos>(JsonConvert.SerializeObject(this, settings), settings);
        }
    }

    public class AxisCoord
    {
        public string Name;

        public double Pos = 0;

        //-1表示使用统一设置的速度
        public double Speed = -1;

        public int TimeOut = 10000;

        public bool Enabled = true;
    }
}
