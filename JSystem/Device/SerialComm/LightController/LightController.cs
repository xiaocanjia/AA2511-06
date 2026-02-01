using System;
using System.Threading;

namespace JSystem.Device
{
    public class LightController : SerialComm
    {
        private static readonly object _lock = new object();

        public LightController() { }

        public LightController(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new LightControllerView(this);
        }

        public void SetLightness(int channel, int lightness)
        {
            lock(_lock)
            {
                byte[] bLightness = BitConverter.GetBytes((ushort)lightness);
                WriteData(new byte[] { 0x48, 0x59, 0x01, (byte)channel, bLightness[1], bLightness[0], 0x00, 0x00, 0x0d, 0x0a });
                Thread.Sleep(500);
            }
        }
    }
}

