using System;

namespace JSystem.Device
{
    public class DirectPressSensor : ModbusTcp
    {
        public DirectPressSensor() { }

        public DirectPressSensor(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new DirectPressSensorView(this);
        }

        public double[] ReadPressure()
        {
            byte[] rec = ReadInputRegisters(1, 0, 12);
            if (rec == null || rec.Length == 0)
                return null;
            double[] pressureArr = new double[6];
            for (int i = 0; i < 6; i++)
                pressureArr[i] = BitConverter.ToSingle(new byte[] { rec[2 + i * 4], rec[3 + i * 4], rec[0 + i * 4], rec[1 + i * 4] }, 0);
            return pressureArr;
        }
    }
}

