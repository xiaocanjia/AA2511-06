using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using Modbus.Device;
using FileHelper;
using JLogging;

namespace BoardSDK
{
    public class CS485IOBoard : BoardBase, IBoardIO
    {
        private ModbusSerialMaster _master;
        
        private SerialPort _serialPort = new SerialPort();

        private int _axexCount = 0;

        private bool[][] DIs;

        private bool[][] DOs;

        private ushort _IOCount = 16;

        public override bool Connect(string filePath)
        {
            try
            {
                _serialPort.PortName = IniHelper.INIGetStringValue(filePath, "串口设置", "PortName", "");
                _serialPort.BaudRate = Convert.ToInt32(IniHelper.INIGetStringValue(filePath, "串口设置", "BaudRate", ""));
                _serialPort.Parity = (Parity)Convert.ToInt32(IniHelper.INIGetStringValue(filePath, "串口设置", "Parity", ""));
                _serialPort.DataBits = Convert.ToInt32(IniHelper.INIGetStringValue(filePath, "串口设置", "DataBits", ""));
                _serialPort.StopBits = (StopBits)Convert.ToInt32(IniHelper.INIGetStringValue(filePath, "串口设置", "StopBits", ""));
                _serialPort.ReadTimeout = Convert.ToInt32(IniHelper.INIGetStringValue(filePath, "串口设置", "ReadTimeout", ""));
                _axexCount = Convert.ToInt32(IniHelper.INIGetStringValue(filePath, "板卡数量", "AxesCount", ""));
                _IOCount = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "板卡数量", "IOCount", ""));
                DIs = new bool[_axexCount][];
                DOs = new bool[_axexCount][];
                for (int i = 0; i < _axexCount; i++)
                {
                    DIs[i] = new bool[_IOCount];
                    DOs[i] = new bool[_IOCount];
                }
                _serialPort.Open();
                if (!_serialPort.IsOpen)
                    return false;
                //Thread.Sleep(2000);
                //_serialPort.Close();
                //_serialPort.Open();
                _master = ModbusSerialMaster.CreateRtu(_serialPort);
                _master.ReadCoils(1, 16, _IOCount);
                new Task(RefreshIO).Start();
                _isConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"IO卡连接失败，请检查是否拨码，AB向是否接反{ex}", LogLevels.Error);
                return false;
            }
        }

        private void RefreshIO()
        {
            while (_isConnected)
            {
                Thread.Sleep(5);
                for (int i = 0; i < _axexCount; i++)
                {
                    try
                    {
                        _master.WriteMultipleCoils((byte)(i + 1), 80, DOs[i]);
                        DIs[i] = _master.ReadCoils((byte)(i + 1), 16, _IOCount);
                    }
                    catch { }
                }
            }
        }

        public override bool Disconnect()
        {
            try
            {
                _serialPort?.Close();
                _master?.Dispose();
                _isConnected = false;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool CheckConnect()
        {
            return _serialPort.IsOpen && _isConnected;
        }

        public bool GetIn(int axisIdx, int IOIdx)
        {
            return DIs[axisIdx][IOIdx];
        }

        public bool GetOut(int axisIdx, int IOIdx)
        {
            return DOs[axisIdx][IOIdx];
        }

        public bool SetOut(int axisIdx, int IOIdx, bool value)
        {
            try
            {
                DOs[axisIdx][IOIdx] = value;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
