using System;
using System.Threading;

namespace JSystem.Device
{
    public class ZimmerGripper : ModbusTcp
    {
        private readonly int AddrWrite = 2049;  //端口1的写入起始地址

        private readonly int AddrRead = 2;      //端口1读取的起始地址

        private readonly int Interval = 16;     //两个端口之间的寄存器地址间隔

        public bool IsOn { get; private set; } = false;

        public bool IsOff { get; private set; } = true;

        public ZimmerGripper() { }

        public ZimmerGripper(string nameZh) : this()
        {
            Name = nameZh;
        }

        public override void InitView()
        {
            _view = new ZimmerGripperView(this);
        }

        public void SwitchGripper(int channel, bool isOn, ushort pos, byte tolerance = 0xff, byte force = 0x01)
        {
            if (!CheckConnection()) return;
            byte[] bPos = BitConverter.GetBytes(pos);
            WriteHoldingRegisters(1, (ushort)(AddrWrite + (channel - 1) * Interval), new byte[] { 0x00, 0x80, 0x00, 0x64, bPos[0], bPos[1], tolerance, force });
            Thread.Sleep(100);
            WriteHoldingRegisters(1, (ushort)(AddrWrite + (channel - 1) * Interval), new byte[] { 0x01, 0x00, 0x00, 0x64, bPos[0], bPos[1], tolerance, force });
            Thread.Sleep(100);
            WriteHoldingRegisters(1, (ushort)(AddrWrite + (channel - 1) * Interval), new byte[] { 0x00, (byte)(isOn ? 0x02 : 0x01) });
        }

        public byte[] GetStatus(int channel)
        {
            byte[] input = ReadHoldingRegisters(1, (ushort)(AddrRead + (channel - 1) * Interval), 3);
            if (input == null) return null;
            IsOn = ((input[1] >> 3) & 1) == 1;
            IsOff = ((input[1] >> 1) & 1) == 1;
            return input;
        }
    }
}
