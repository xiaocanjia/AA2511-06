using System;
using System.Threading;
using System.Threading.Tasks;

namespace JSystem.Device
{
    public class TempController : SerialComm
    {
        public float CurrTemp = 20;
        private readonly object _lock = new object();
        public int Low = 0;
        public int High = 100;
        public int Temp = 10;
        private int idx = 10;

        public TempController()
        {
            new Task(GetTemp).Start();
        }

        public TempController(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new TempControllerView(this);
        }

        public void SetTemp()
        {
            byte[] blow = BitConverter.GetBytes(Low *100);
            byte[] bHigh = BitConverter.GetBytes(High * 100);

            byte[] bTemp = BitConverter.GetBytes(Temp * 100);
            byte[] TargetRange = new byte[] { 0x55, 0xAA, 0x0F, 0x00, 0x01, 0x00, 0x00, 0x0B, 0x03, 0x00, 0x01, 0x98, 0x3A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB4, 0xC6 };
            byte[] CurrentRange = new byte[] { 0x55, 0xAA, 0x0F, 0x00, 0x01, 0x01, 0x00, 0x0B, 0x04, 0x00, 0x01, 0x98, 0x3A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xAE, 0x73 };
            byte[] TargetTemp = new byte[] { 0x55, 0xAA, 0x0B, 0x00, 0x01, 0x03, 0x00, 0x0B, 0x05, 0x00, 0x01, 0xE8, 0x03, 0x00, 0x00, 0x18, 0x20 };
            TargetRange[11] = bHigh[0];
            TargetRange[12] = bHigh[1];
            TargetRange[13] = bHigh[2];
            TargetRange[14] = bHigh[3];
            TargetRange[15] = blow[0];
            TargetRange[16] = blow[1];
            TargetRange[17] = blow[2];
            TargetRange[18] = blow[3];
            //CurrentRange[11] = bHigh[0];
            //CurrentRange[12] = bHigh[1];
            //CurrentRange[13] = bHigh[2];
            //CurrentRange[14] = bHigh[3];
            //CurrentRange[15] = blow[0];
            //CurrentRange[16] = blow[1];
            //CurrentRange[17] = blow[2];
            //CurrentRange[18] = blow[3];
            TargetTemp[11] = bTemp[0];
            TargetTemp[12] = bTemp[1];
            TargetTemp[13] = bTemp[2];
            TargetTemp[14] = bTemp[3];
            SendDataByCrc16(TargetRange);
            SendDataByCrc16(CurrentRange);
            SendDataByCrc16(TargetTemp);
        }


        private void GetTemp()
        {
            while (true)
            {
                byte[] readTemp = new byte[] { 0x55, 0xAA, 0x07, 0x00, 0x01, 0x06, 0x00, 0x0B, 0x0B, 0x00, 0x01, 0xA2, 0x80 };
                SendDataByCrc16(readTemp);
                Thread.Sleep(200);
                byte[] buffer = _bufferList.ToArray();
                if (buffer.Length < 30) continue;
                for (int i = 0; i < buffer.Length-16; i++)
                {
                    if (buffer[i] == 0x55 && buffer[i + 1] == 0xAA&&buffer[i + 2] == 0x0C)
                    {
                        byte[] btemp = new byte[] { buffer[i + 12], buffer[i + 13], buffer[i + 14], buffer[i + 15] };
                        int currTemp = BitConverter.ToInt32(btemp, 0);
                        CurrTemp =Convert.ToSingle(currTemp) / 100;
                        ((TempControllerView)View).UpdateTemp();
                    }
                }
            }
        }

        public void Run(bool isOpen)
        {
            byte[] funOpen = new byte[] { 0x55, 0xAA, 0x07, 0x00, 0x01, 0x03, 0x00, 0x0B, 0x16, 0x01, 0x01, 0x33, 0x43 };
            byte[] funClose = new byte[] { 0x55, 0xAA, 0x07, 0x00, 0x01, 0x04, 0x00, 0x0B, 0x16, 0x01, 0x00, 0xF3, 0x34 };
            byte[] tempOpen = new byte[] { 0x55, 0xAA, 0x08, 0x00, 0x01, 0x05, 0x00, 0x0B, 0x06, 0x00, 0x01, 0x01, 0xF1, 0xD5 };
            byte[] tempClose = new byte[] { 0x55, 0xAA, 0x08, 0x00, 0x01, 0x06, 0x00, 0x0B, 0x06, 0x00, 0x01, 0x00, 0xF3, 0x15 };
            if (isOpen)
            {
                SendDataByCrc16(funOpen);
                SendDataByCrc16(tempOpen);
            }
            else
            {
                SendDataByCrc16(funClose);
                SendDataByCrc16(tempClose);
                SendDataByCrc16(funClose);
                SendDataByCrc16(tempClose);
            }

        }


        private void SendDataByCrc16(byte[] arry)
        {
            lock (_lock)
            {
                ClearBuffer();
                idx++;
                if (idx > 60000) idx = 10;
                byte[] bidx = BitConverter.GetBytes(idx);
                arry[5] = bidx[0];
                arry[6] = bidx[1];
                byte[] CheckCode = Crc16(arry, 4, arry[2]);
                arry[arry.Length - 2] = CheckCode[0];
                arry[arry.Length - 1] = CheckCode[1];
                WriteData(arry);
                Thread.Sleep(100);
            }
        }



        //CRC-16/IBM    x16+x15+x2+1
        private byte[] Crc16(byte[] buffer, int start = 0, int len = 0)
        {
            if (buffer == null || buffer.Length == 0) return null;
            if (start < 0) return null;
            int length = start + len;
            if (length > buffer.Length) return null;
            ushort crc = 0;// Initial value
            for (int i = start; i < length; i++)
            {
                crc ^= buffer[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 1) > 0)
                        crc = (ushort)((crc >> 1) ^ 0xA001);// 0xA001 = reverse 0x8005
                    else
                        crc = (ushort)(crc >> 1);
                }
            }
            byte[] ret = BitConverter.GetBytes(crc);
            return ret;
        }
    }
}

