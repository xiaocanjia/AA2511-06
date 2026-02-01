using System;
using System.Threading;

namespace JSystem.Device
{
    public class BT600F : ModbusRtu
    {
        public float Speed = 100;

        public float Mill = 20;

        public BT600F()
        {
        }

        public BT600F(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new BT600FView(this);
        }

        public void Inject(byte addr, bool isOn)
        {
            WriteHoldingRegisters(addr, 4128, FloatToByteArray(Speed));
            Thread.Sleep(100);
            WriteHoldingRegisters(addr, 4130, FloatToByteArray(Mill));
            Thread.Sleep(100);
            WriteHoldingRegisters(addr, 4025, new byte[] { (byte)(isOn ? 1 : 0), 0 });
        }
        
        private byte[] FloatToByteArray(float data)
        {
            byte[] buffer = BitConverter.GetBytes(data);
            byte[] ByteArray = new byte[4];
            ByteArray[0] = buffer[2];
            ByteArray[1] = buffer[3];
            ByteArray[2] = buffer[0];
            ByteArray[3] = buffer[1];
            return ByteArray;
        }
    }
}
