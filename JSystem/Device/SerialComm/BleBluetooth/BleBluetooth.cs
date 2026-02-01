using System.Threading;

namespace JSystem.Device
{
    public class BleBluetooth : SerialComm
    {
        public string GuidTx = "";

        public string GuidRx = "";

        public BleBluetooth() { }

        public BleBluetooth(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new BleBluetoothView(this);
        }

        public override bool Connect()
        {
            try
            {
                bool ret = base.Connect();
                WriteData($"AT+CHTX{GuidTx}");
                Thread.Sleep(100);
                WriteData($"AT+CHRX{GuidRx}");
                Thread.Sleep(100);
                return ret;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// BT-Bluetooth
        /// </summary>
        /// <param name="mac"></param>
        public void ConnectBT(string mac)
        {
            WriteData($"AT+CON{mac}");
        }

        public void DisConnectBT()
        {
            WriteData($"AT+DISCON");
            Thread.Sleep(100);
            WriteData($"AT+RESET");
            Thread.Sleep(100);
        }
    }
}

