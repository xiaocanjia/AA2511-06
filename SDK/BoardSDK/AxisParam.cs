namespace BoardSDK
{
    public class AxisParam
    {
        public int Index = 0;

        public string Name = "";

        public double MoveVelH = 20.0;

        public double MoveVelL = 2.0;

        public double MoveAcc = 20.0;

        public double MoveDcc = 20.0;

        public uint HomeMode = 0;

        public uint HomeDir = 0;

        public double HomeOffset = 1.0;

        public double HomeVelH = 20.0;

        public double HomeVelL = 20.0;

        public double HomeAcc = 3.0;

        public double HomeDcc = 3.0;

        public uint PlusePerMM = 1000;
    }
}
