using System;
using System.Linq;
using System.Threading;

namespace JSystem.Device
{
    public class ModbusTcp : TCPClient
    {
        private readonly int TimeOut = 2000;
        
        private byte[] _header = { 0x00, 0x00, 0x00, 0x00 };

        private readonly object _lock = new object();

        public ModbusTcp() { }
        
        public ModbusTcp(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new ModbusTcpView(this);
        }

        public byte[] ReadCoils(byte slaveAddr, ushort addr, ushort count)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(count);
            byte[] ret = SendCommand(_header.Concat(new byte[] { 0x00, 0x06, slaveAddr, 0x01, bAddr[1], bAddr[0], bLength[1], bLength[0] }).ToArray());
            if (ret == null) return null;
            return ret.Skip(9).ToArray();
        }

        public bool WriteCoils(byte slaveAddr, ushort addr, byte[] data)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            int len = data.Length;
            byte[] bLength = BitConverter.GetBytes(len);
            byte[] buffer = _header.Concat(new byte[] { 0x00, (byte)(7 + len * 2), slaveAddr, 0x0F, bAddr[1], bAddr[0], bLength[1], bLength[0] }).ToArray();
            buffer.Concat(data);
            if (SendCommand(buffer) != null)
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
            byte[] buffer = _header.Concat(new byte[] { 0x00, (byte)(7 + data.Length), slaveAddr, 0x10, bAddr[1], bAddr[0], bLength[1], bLength[0], (byte)data.Length }).Concat(newData).ToArray();
            if (SendCommand(buffer) != null)
                return true;
            return false;
        }

        /// <summary>
        /// 一个寄存器是两个字节
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public byte[] ReadHoldingRegisters(byte slaveAddr, ushort addr, ushort count)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(count);
            byte[] ret = SendCommand(_header.Concat(new byte[] { 0x00, 0x06, slaveAddr, 0x03, bAddr[1], bAddr[0], bLength[1], bLength[0] }).ToArray());
            if (ret == null) return null;
            byte[] temp = new byte[count * 2];
            for (int i = 0; i < count; i++)
            {
                temp[i * 2] = ret[9 + i * 2 + 1];
                temp[i * 2 + 1] = ret[9 + i * 2];
            }
            return temp;
        }

        /// <summary>
        /// 一个寄存器是两个字节
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public byte[] ReadInputRegisters(byte slaveAddr, ushort addr, ushort count)
        {
            byte[] bAddr = BitConverter.GetBytes(addr);
            byte[] bLength = BitConverter.GetBytes(count);
            byte[] ret = SendCommand(_header.Concat(new byte[] { 0x00, 0x06, slaveAddr, 0x04, bAddr[1], bAddr[0], bLength[1], bLength[0] }).ToArray());
            if (ret == null) return null;
            byte[] temp = new byte[count * 2];
            for (int i = 0; i < count; i++)
            {
                temp[i * 2] = ret[9 + i * 2 + 1];
                temp[i * 2 + 1] = ret[9 + i * 2];
            }
            return temp;
        }

        private byte[] SendCommand(byte[] data)
        {
            lock(_lock)
            {
                WriteData(data);
                DateTime start = DateTime.Now;
                byte retLength = 0;
                while (true)
                {
                    Thread.Sleep(10);
                    if (retLength == 0 && _bufferList.Count >= 6)
                        retLength = _bufferList[5];
                    if (_bufferList.Count >= 6 + retLength)
                    {
                        byte[] ret = _bufferList.ToArray();
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
    }
}
