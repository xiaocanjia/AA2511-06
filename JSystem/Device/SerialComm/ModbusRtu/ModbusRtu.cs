using System;
using System.Linq;
using System.Threading;

namespace JSystem.Device
{
    public class ModbusRtu : SerialComm
    {
        private readonly int TimeOut = 2000;
        
        private byte[] _header = { 0x00, 0x00, 0x00, 0x00 };

        private readonly object _lock = new object();

        public ModbusRtu() { }

        public ModbusRtu(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new ModbusRtuView(this);
        }

        public byte[] ReadCoils(byte slaveAddr, ushort addr, ushort count)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(count);
            byte[] buffer = new byte[] { slaveAddr, 0x01, bAddr[1], bAddr[0], bLength[1], bLength[0] };
            byte[] crc = GetCrcValue(buffer);
            byte[] ret = SendCommand(buffer.Concat(crc).ToArray(), 5 + count / 8 + 1);
            if (ret == null) return null;
            return ret.Take(3 + ret[2]).Skip(3).ToArray();
        }

        public bool WriteCoil(byte slaveAddr, ushort addr, bool data)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] buffer = new byte[] { slaveAddr, 0x05, bAddr[1], bAddr[0], (byte)(data ? 0xff : 0x00), 0x00 };
            byte[] crc = GetCrcValue(buffer);
            if (SendCommand(buffer.Concat(crc).ToArray(), 8) != null)
                return true;
            return false;
        }

        public bool WriteCoils(byte slaveAddr, ushort addr, byte[] data)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(data.Length * 8);
            byte[] buffer = (new byte[] { slaveAddr, 0x0F, bAddr[1], bAddr[0], bLength[1], bLength[0], (byte)data.Length }).Concat(data).ToArray();
            byte[] crc = GetCrcValue(buffer);
            if (SendCommand(buffer.Concat(crc).ToArray(), 8) != null)
                return true;
            return false;
        }
        
        /// <summary>
         /// 保持寄存器可以读和写，每个寄存器是16位
         /// </summary>
         /// <param name="addr"></param>
         /// <param name="count"></param>
         /// <returns></returns>
        public bool WriteHoldingRegister(byte slaveAddr, ushort addr, byte[] data)
        {
            byte[] newData = new byte[data.Length];
            for (int i = 0; i < data.Length / 2; i++)
            {
                newData[i * 2] = data[i * 2 + 1];
                newData[i * 2 + 1] = data[i * 2];
            }
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] buffer = (new byte[] { slaveAddr, 0x06, bAddr[1], bAddr[0] }).Concat(newData).ToArray();
            byte[] crc = GetCrcValue(buffer);
            if (SendCommand(buffer.Concat(crc).ToArray(), 8) != null)
                return true;
            return false;
        }

        /// <summary>
        /// 保持寄存器可以读和写，每个寄存器是16位，输入寄存器是只允许读的
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public bool WriteHoldingRegisters(byte slaveAddr, ushort addr, byte[] data)
        {
            byte[] newData = new byte[data.Length];
            for (int i = 0; i < data.Length / 2; i++)
            {
                newData[i * 2] = data[i * 2 + 1];
                newData[i * 2 + 1] = data[i * 2];
            }
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(data.Length / 2);
            byte[] buffer = (new byte[] { slaveAddr, 0x10, bAddr[1], bAddr[0], bLength[1], bLength[0], (byte)data.Length }).Concat(newData).ToArray();
            byte[] crc = GetCrcValue(buffer);
            if (SendCommand(buffer.Concat(crc).ToArray(), 8) != null)
                return true;
            return false;
        }

        /// <summary>
        /// 一个寄存器是两个字节
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="count">输入的是寄存器的数量，由于返回的是字节，所以返回的是寄存器数量的两倍</param>
        /// <returns></returns>
        public byte[] ReadHoldingRegisters(byte slaveAddr, ushort addr, ushort count)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(count);
            byte[] buffer = new byte[] { slaveAddr, 0x03, bAddr[1], bAddr[0], bLength[1], bLength[0] };
            byte[] crc = GetCrcValue(buffer);
            byte[] ret = SendCommand(buffer.Concat(crc).ToArray(), 7);
            if (ret == null) return null;
            byte[] temp = new byte[count * 2];
            for (int i = 0; i < count; i++)
            {
                temp[i * 2] = ret[3 + i * 2 + 1];
                temp[i * 2 + 1] = ret[3 + i * 2];
            }
            return temp;
        }

        /// <summary>
        /// 一个寄存器是两个字节
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="count">输入的是寄存器的数量，由于返回的是字节，所以返回的是寄存器数量的两倍</param>
        /// <returns></returns>
        public byte[] ReadInputRegisters(byte slaveAddr, ushort addr, ushort count)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(count);
            byte[] buffer = new byte[] { slaveAddr, 0x04, bAddr[1], bAddr[0], bLength[1], bLength[0] };
            byte[] crc = GetCrcValue(buffer);
            byte[] ret = SendCommand(buffer.Concat(crc).ToArray(), 5 + count * 2);
            if (ret == null) return null;
            byte[] temp = new byte[count * 2];
            for (int i = 0; i < count; i++)
            {
                temp[i * 2] = ret[3 + i * 2 + 1];
                temp[i * 2 + 1] = ret[3 + i * 2];
            }
            return temp;
        }

        private byte[] SendCommand(byte[] data, int retCount)
        {
            if (!IsEnable || !CheckConnection()) return null;
            lock (_lock)
            {
                Thread.Sleep(10);
                WriteData(data);
                DateTime start = DateTime.Now;
                while (true)
                {
                    if (ReadData().Count >= retCount)
                    {
                        byte[] ret = ReadData().ToArray();
                        ClearBuffer();
                        Thread.Sleep(10);
                        return ret;
                    }
                    if (DateTime.Now.Subtract(start).TotalMilliseconds > TimeOut)
                    {
                        ClearBuffer();
                        return null;
                    }
                }
            }
        }

        private byte[] GetCrcValue(params byte[] data)
        {
            ushort crc = 0xFFFF;
            ushort XorValue = 0xA001;
            byte[] CrcValue;
            for (int i = 0; i < data.Length; i++)
            {
                crc = (ushort)(crc ^ data[i]);
                for (int j = 0; j < 8; j++)
                {
                    if ((ushort)(crc % 2) == 1)
                    {
                        crc = (ushort)(crc >> 1);
                        crc = (ushort)(crc ^ XorValue);
                    }
                    else
                    {
                        crc = (ushort)(crc >> 1);
                    }
                }
            }
            CrcValue = new byte[] { (byte)(crc & 0xff), (byte)(crc >> 8) };
            return CrcValue;
        }
    }
}
