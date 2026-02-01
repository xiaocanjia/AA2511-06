using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Collections;
using FileHelper;

namespace BoardSDK
{
    public class CSCanIOBoard : BoardBase, IBoardIO
    {
        private string _filePath = "";

        private int inputCount = 0;

        private int outputCount = 0;

        private bool[][] _DIs;

        private bool[][] _DOs;

        private readonly ManualResetEvent TimeoutObject = new ManualResetEvent(false);

        protected Socket _socket = null;

        private readonly object _lock = new object();

        private IPEndPoint _remoteEndPoint;
        
        public override bool Connect(string filePath)
        {
            try
            {
                _filePath = filePath;
                string IP = GetCfgValue("DeviceConfig", "IP");
                int port = Convert.ToInt32(GetCfgValue("DeviceConfig", "Port"));
                inputCount = Convert.ToInt32(GetCfgValue("DeviceConfig", "InputCount"));
                outputCount = Convert.ToInt32(GetCfgValue("DeviceConfig", "OutputCount"));
                TimeoutObject.Reset();
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _remoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);
                _socket.ReceiveTimeout = 1000;
                _socket.BeginConnect(_remoteEndPoint, CallBackMethod, new object());
                _DIs = new bool[inputCount][];
                _DOs = new bool[outputCount][];
                for (int i = 0; i < inputCount; i++)
                    _DIs[i] = new bool[16];
                for (int i = 0; i < outputCount; i++)
                    _DOs[i] = new bool[16];
                if (!TimeoutObject.WaitOne(2000, false))
                    return false;
                new Task(RefreshIO).Start();
                _isConnected = true;
                return _isConnected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can总线IO卡连接失败" + ex);
                return false;
            }
        }

        private void RefreshIO()
        {
            while (_isConnected)
            {
                try
                {
                    for (int i = 0; i < inputCount; i++)
                        _DIs[i] = ReadInput(i);
                    for (int j = 0; j < outputCount; j++)
                        WriteOutput(j, _DOs[j]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can卡IO刷新刷新出错" + ex);
                    _isConnected = false;
                }
                Thread.Sleep(5);
            }
        }

        public override bool Disconnect()
        {
            try
            {
                _socket?.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool CheckConnect()
        {
            if (_socket == null) return false;
            return _socket.Connected;
        }

        public bool GetIn(int axisIdx, int IOIdx)
        {
            return _DIs[axisIdx][IOIdx];
        }

        public bool GetOut(int axisIdx, int IOIdx)
        {
            return _DOs[axisIdx][IOIdx];
        }

        public bool SetOut(int axisIdx, int IOIdx, bool value)
        {
            try
            {
                _DOs[axisIdx][IOIdx] = value;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string GetCfgValue(string section, string key)
        {
            return IniHelper.INIGetStringValue(_filePath, section, key, "");
        }

        private void CallBackMethod(IAsyncResult asyncresult)
        {
            TimeoutObject.Set();
        }

        private bool[] ReadInput(int address)
        {
            bool[] result = new bool[16];
            byte[] buffer = new byte[] { 0x48, 0x59, 0x07, 0x00, 0x11, 0X01, 0X09 };
            byte[] bidx = BitConverter.GetBytes(17 + address);
            buffer[3] = bidx[1];
            buffer[4] = bidx[0];
            byte[] receive = SendCmd(buffer);
            if (receive.Length == 11 && 0x48 == receive[0] && 0x59 == receive[1])
            {
                byte[] data = new byte[] { receive[10], receive[9] };
                result = GetBits(data);
            }
            else
            {
                result = _DIs[address];
            }
            return result;
        }

        private void WriteOutput(int address, bool[] bools)
        {
            bool[] result = new bool[16];
            byte[] buffer = new byte[] { 0x48, 0x59, 0x0C, 0x00, 0x21, 0X06, 0X49, 0x02, 0x00, 0x00, 0x00, 0x00 };
            byte[] bNo = BitConverter.GetBytes(33 + address);
            buffer[3] = bNo[1];
            buffer[4] = bNo[0];
            byte[] bData = GetBytes(_DOs[address]);
            buffer[10] = bData[1];
            buffer[11] = bData[0];
            SendCmd(buffer);
        }

        private bool[] GetBits(byte[] value)
        {
            var bits = new BitArray(value);
            bool[] bools = new bool[bits.Count];
            for (var i = 0; i < bits.Count; i++)
            {
                bools[i] = bits[i];
            }
            return bools;
        }

        //将bool[]转换成byte[]
        private byte[] GetBytes(bool[] value, int start = 0)
        {
            int length = value.Length - start;
            if (length <= 0) throw new ArgumentException("截取数组长度太小");
            int count = length / 8;
            int count1 = length % 8;
            if (count1 > 0) count++;

            byte[] result = new byte[count];
            for (int j = 0; j < count; j++)
            {
                result[j] = 0;
                for (int i = 0; i < 8; i++)//遍历当前字节的每个位赋值
                {
                    result[j] = SetBitValue(result[j], i, value[j * 8 + i + start]);
                }
            }
            return result;
        }

        private byte SetBitValue(byte value, int offset, bool bitValue)
        {
            if (offset > 7) throw new ArgumentException("偏移位offset大于7");
            return bitValue ? (byte)(value | (byte)Math.Pow(2, offset)) : (byte)(value & ~(byte)Math.Pow(2, offset));
        }

        private byte[] SendCmd(byte[] data)
        {
            lock (_lock)
            {
                try
                {
                    _socket.Send(data);
                    byte[] buffer = new byte[1024];
                    int length = _socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    byte[] res = new byte[length];
                    Array.Copy(buffer, res, length);
                    return res;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("sendCmd " + ex);
                    _isConnected = false;
                    return new byte[1];
                }
            }
        }
    }
}
