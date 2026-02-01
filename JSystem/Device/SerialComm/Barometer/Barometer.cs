using System;

namespace JSystem.Device
{
    public class Barometer : ModbusRtu
    {
        public Barometer() { }

        public Barometer(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new BarometerView(this);
        }

        public void SetPressure(ushort data)
        {
            byte[] bData = BitConverter.GetBytes((ushort)(data * 10));
            WriteHoldingRegister(1, 0, bData);
        }

        public ushort ReadPressure()
        {
            byte[] ret = ReadHoldingRegisters(1, 0, 1);
            if (ret == null) return 0;
            return (ushort)(BitConverter.ToUInt16(ret, 0) / 10);
        }
    }
}
