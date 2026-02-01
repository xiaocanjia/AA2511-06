using System;

namespace JSystem.Device
{
    public class RollPressSensor : ModbusTcp
    {
        public RollPressSensor() { }

        public RollPressSensor(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new RollPressSensorView(this);
        }

        public double ReadPressure()
        {
            byte[] rec = ReadHoldingRegisters(1, 0x60, 2);
            if (rec == null || rec.Length == 0)
                return double.NaN;
            else
                return BitConverter.ToUInt32(rec, 0) / 1000.0;
        }
    }
}

