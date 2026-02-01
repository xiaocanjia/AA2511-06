using Newtonsoft.Json;

namespace JSystem.Station
{
    /// <summary>
    /// 由于该类是通过板卡ID和轴名称来确定的，所以放到工站里面
    /// </summary>
    public class StationAxis
    {
        public string Name;

        public string BoardName;

        public int AxisIndex;

        public double MoveVelH = 20.0;

        public byte SecurityLevel = 1;

        public double SecurityPos = 0.0;

        [JsonIgnore]
        public bool NeedGoHome = true;

        [JsonIgnore]
        public double MoveVelHPluse
        {
            get { return MoveVelH * PlusePerUnit; }
        }

        public double MoveVelL = 2.0;

        [JsonIgnore]
        public double MoveVelLPluse
        {
            get { return MoveVelL * PlusePerUnit; }
        }

        public double ManulVel = 20.0;

        [JsonIgnore]
        public double ManulVelPluse
        {
            get { return ManulVel * PlusePerUnit; }
        }

        public double MoveAcc = 50.0;

        [JsonIgnore]
        public double MoveAccPluse
        {
            get { return MoveAcc * PlusePerUnit; }
        }

        public double MoveDcc = 50.0;

        [JsonIgnore]
        public double MoveDccPluse
        {
            get { return MoveDcc * PlusePerUnit; }
        }

        public string Unit = "mm";

        public uint HomeMode = 0;

        public uint HomeDir = 0;

        public double HomeOffset = 0.0;

        public double HomeVelH = 20.0;

        [JsonIgnore]
        public double HomeVelHPluse
        {
            get { return HomeVelH * PlusePerUnit; }
        }

        public double HomeVelL = 20.0;

        [JsonIgnore]
        public double HomeVelLPluse
        {
            get { return HomeVelL * PlusePerUnit; }
        }

        public double HomeAcc = 50.0;

        [JsonIgnore]
        public double HomeAccPluse
        {
            get { return HomeAcc * PlusePerUnit; }
        }

        public double HomeDcc = 50.0;

        [JsonIgnore]
        public double HomeDccPluse
        {
            get { return HomeDcc * PlusePerUnit; }
        }

        public uint PlusePerUnit = 1000;

        public double Accuracy = 0.01;

        [JsonIgnore]
        public bool IsAlarm;

        [JsonIgnore]
        public bool IsEnabled;

        [JsonIgnore]
        public bool IsEmergencyStop;

        [JsonIgnore]
        public byte State;

        [JsonIgnore]
        public double CmdPos;

        [JsonIgnore]
        public double ActPos;

        public StationAxis() { }
    }
}
