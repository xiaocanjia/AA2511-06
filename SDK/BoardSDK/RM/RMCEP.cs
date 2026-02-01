using System;
using System.IO.Ports;
using JLogging;
using FileHelper;
using Modbus.Device;

namespace BoardSDK
{
    public class RMCEP : BoardBase, IBoardIO, IBoardAxis
    {
        private int _random = 0;

        private ModbusSerialMaster _master;

        private SerialPort _serialPort = new SerialPort();

        private ushort _speedAddr = 0;

        private ushort _posAddr = 0;

        private ushort _resetAddr = 0;

        private ushort _clearAddr = 0;

        private ushort _servoAddr = 0;

        private ushort _stopAddr = 0;

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
                _speedAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "通讯地址", "SpeedAddr", ""));
                _posAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "通讯地址", "PosAddr", ""));
                _resetAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "通讯地址", "ResetAddr", ""));
                _clearAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "通讯地址", "ClearAddr", ""));
                _servoAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "通讯地址", "ServoAddr", ""));
                _stopAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "通讯地址", "StopAddr", ""));
                _serialPort?.Close();
                _serialPort.Open();
                if (!_serialPort.IsOpen)
                    return false;
                _master = ModbusSerialMaster.CreateRtu(_serialPort);
                _master.ReadInputRegisters(1, 0, 2);
                _isConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"增广电缸连接失败，请检查串口是否被占用:{ex}", LogLevels.Error);
                return false;
            }
        }

        public override bool Disconnect()
        {
            _isConnected = false;
            _serialPort.Close();
            return true;
        }

        public override bool CheckConnect()
        {
            return _isConnected && _serialPort.IsOpen;
        }

        public bool ClearAlarm(int axis)
        {
            _master.WriteSingleCoil((byte)(axis + 1), _clearAddr, false);
            _master.WriteSingleCoil((byte)(axis + 1), _clearAddr, true);
            return true;
        }

        public byte GetAxisState(int axis)
        {
            try
            {
                bool[] status = _master.ReadCoils((byte)(axis + 1), _servoAddr, 1);
                return (byte)(status[0] ? 32 : 0);
            }
            catch
            {
                _isConnected = false;
                return 0;
            }
        }

        public double GetCmdPos(int axis)
        {
            try
            {
                ushort[] buffer = _master.ReadInputRegisters((byte)(axis + 1), 0, 2);
                byte[] bytes = new byte[4];
                float pos = 0;
                if (_posAddr == 4902)
                {
                    bytes[2] = (byte)(buffer[0] & 0xFF);
                    bytes[3] = (byte)(buffer[0] >> 8);
                    bytes[0] = (byte)(buffer[1] & 0xFF);
                    bytes[1] = (byte)(buffer[1] >> 8);
                    pos = BitConverter.ToUInt32(bytes, 0) / 1000.0f;
                }
                else
                {
                    bytes[0] = (byte)(buffer[0] & 0xFF);
                    bytes[1] = (byte)(buffer[0] >> 8);
                    bytes[2] = (byte)(buffer[1] & 0xFF);
                    bytes[3] = (byte)(buffer[1] >> 8);
                    pos = BitConverter.ToSingle(bytes, 0);
                }
                return pos > 10000 ? 0 : pos;
            }
            catch
            {
                _isConnected = false;
                return 0.0;
            }
        }

        public double GetActPos(int axis)
        {
            try
            {
                ushort[] buffer = _master.ReadInputRegisters((byte)(axis + 1), 0, 2);
                byte[] bytes = new byte[4];
                float pos = 0;
                if (_posAddr == 4902)
                {
                    bytes[2] = (byte)(buffer[0] & 0xFF);
                    bytes[3] = (byte)(buffer[0] >> 8);
                    bytes[0] = (byte)(buffer[1] & 0xFF);
                    bytes[1] = (byte)(buffer[1] >> 8);
                    pos = BitConverter.ToUInt32(bytes, 0) / 1000.0f;
                }
                else
                {
                    bytes[0] = (byte)(buffer[0] & 0xFF);
                    bytes[1] = (byte)(buffer[0] >> 8);
                    bytes[2] = (byte)(buffer[1] & 0xFF);
                    bytes[3] = (byte)(buffer[1] >> 8);
                    pos = BitConverter.ToSingle(bytes, 0);
                }
                return pos > 10000 ? 0 : pos;
            }
            catch
            {
                _isConnected = false;
                return 0;
            }
        }

        public bool GoHome(int axis, double homeVelL, double homeVelH, double homeAcc, double homeDcc, uint homeMode, uint homeDir)
        {
            _master.WriteMultipleRegisters((byte)(axis + 1), _speedAddr, ConvertToShortArr((float)homeVelH));
            _master.WriteMultipleRegisters((byte)(axis + 1), _posAddr, ConvertToShortArr(0));
            _master.WriteSingleCoil((byte)(axis + 1), _resetAddr, false);
            _master.WriteSingleCoil((byte)(axis + 1), _resetAddr, true);
            return true;
        }

        public bool AbsMove(int axis, double pos)
        {
            _master.WriteMultipleRegisters((byte)(axis + 1), _posAddr, _posAddr == 4902 ? ConvertToShortArr((uint)(pos * 1000 + (_random++) * 0.001)) : ConvertToShortArr((float)(pos + (_random++) * 0.001f)));
            if (_random == 10) _random = 0;
            return true;
        }

        public bool JogMove(int axis, bool isPositive)
        {
            AbsMove(axis, isPositive ? 1000 : 0);
            return true;
        }

        public bool RelMove(int axis, double dist)
        {
            double pos = GetActPos(axis) + dist;
            AbsMove(axis, pos);
            return true;
        }

        public bool SetAxisServoEnabled(int axis, bool isOn)
        {
            _master.WriteSingleCoil((byte)(axis + 1), _servoAddr, isOn);
            return true;
        }

        public bool Stop(int axis)
        {
            _master.WriteSingleCoil((byte)(axis + 1), _stopAddr, false);
            _master.WriteSingleCoil((byte)(axis + 1), _stopAddr, true);
            return true;
        }

        private ushort[] ConvertToShortArr(float data)
        {
            byte[] buffer = BitConverter.GetBytes(data);
            ushort[] arr = new ushort[2];
            arr[0] = BitConverter.ToUInt16(new byte[] { buffer[0], buffer[1] }, 0);
            arr[1] = BitConverter.ToUInt16(new byte[] { buffer[2], buffer[3] }, 0);
            return arr;
        }

        private ushort[] ConvertToShortArr(uint data)
        {
            byte[] buffer = BitConverter.GetBytes(data);
            ushort[] arr = new ushort[2];
            arr[0] = BitConverter.ToUInt16(new byte[] { buffer[2], buffer[3] }, 0);
            arr[1] = BitConverter.ToUInt16(new byte[] { buffer[0], buffer[1] }, 0);
            return arr;
        }

        public bool CheckIsStop(int axis)
        {
            throw new NotImplementedException();
        }

        public bool InstancyStop(int axis)
        {
            throw new NotImplementedException();
        }

        public bool GetIn(int axis, int IOIdx)
        {
            return _master.ReadCoils((byte)(axis + 1), (ushort)IOIdx, 1)[0];
        }

        public bool GetOut(int axis, int IOIdx)
        {
            throw new NotImplementedException();
        }

        public bool SetOut(int axis, int IOIdx, bool Value)
        {
            _master.WriteSingleCoil((byte)(axis + 1), (ushort)IOIdx, Value);
            return true;
        }

        public void SetActPos(int axis, double pos)
        {
            throw new NotImplementedException();
        }

        public bool CircularInterpolation(int axis1, int axis2, bool isPositive, double center1, double center2, double endPos1, double endPos2)
        {
            throw new NotImplementedException();
        }

        public bool SetSpeed(int axis, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            _master.WriteMultipleRegisters((byte)(axis + 1), _speedAddr, _posAddr == 4902 ? ConvertToShortArr((uint)moveVelH * 1000) : ConvertToShortArr((float)moveVelH));
            return true;
        }

        public bool OscillationMove(int axis, uint count, double freq, double amp, int acqInterval)
        {
            throw new NotImplementedException();
        }

        public bool EndOscillation(int axis, out int[] data)
        {
            throw new NotImplementedException();
        }

        public bool LineInterpolation(int[] axisArr, double[] posArr, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            throw new NotImplementedException();
        }
    }
}
