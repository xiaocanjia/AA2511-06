using FileHelper;
using JLogging;
using Modbus.Device;
using System;
using System.IO.Ports;

namespace BoardSDK
{
    public class ELS : BoardBase, IBoardAxis
    {
        private ModbusSerialMaster _master;

        private SerialPort _serialPort = new SerialPort();

        private readonly ushort DirAddr = 1000;

        private readonly ushort PosAddr = 1001;

        private readonly ushort SpeedAddr = 1002;

        private readonly ushort AccAddr = 1003;

        private readonly ushort PressMM = 1004;

        private readonly ushort PressAddr = 1005;

        private ushort Dir = 1;

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
                _serialPort?.Close();
                _serialPort.Open();
                if (!_serialPort.IsOpen)
                    return false;
                _master = ModbusSerialMaster.CreateRtu(_serialPort);
                _isConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"钧舵电缸连接失败，请检查串口是否被占用:{ex}", LogLevels.Error);
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
            bool ret = _isConnected && _serialPort.IsOpen;
            return _isConnected && _serialPort.IsOpen;
        }

        public bool GoHome(int axis, double homeVelL, double homeVelH, double homeAcc, double homeDcc, uint homeMode, uint homeDir)
        {
            Dir = (ushort)(homeDir == 0 ? 1 : 3);
            _master.WriteSingleRegister((byte)(axis + 1), AccAddr, GetUshort(homeAcc));
            _master.WriteSingleRegister((byte)(axis + 1), SpeedAddr, GetUshort(homeVelH));
            _master.WriteSingleRegister((byte)(axis + 1), PosAddr, 0);
            _master.WriteSingleRegister((byte)(axis + 1), PressMM, 500);
            _master.WriteSingleRegister((byte)(axis + 1), PressAddr, 100);
            _master.WriteSingleRegister((byte)(axis + 1), DirAddr, 0);
            _master.WriteSingleRegister((byte)(axis + 1), DirAddr, (ushort)(homeDir == 0 ? 1 : 3));
            return true;
        }

        public bool AbsMove(int axis, double pos)
        {
            _master.WriteSingleRegister((byte)(axis + 1), PosAddr, GetUshort(pos));
            _master.WriteSingleRegister((byte)(axis + 1), PressMM, 500);
            _master.WriteSingleRegister((byte)(axis + 1), PressAddr, 100);
            _master.WriteSingleRegister((byte)(axis + 1), DirAddr, GetUshort(Dir));
            return true;
        }

        public bool RelMove(int axis, double dist)
        {
            double ActPos = GetActPos(axis);
            double pos = ActPos + dist;
            _master.WriteSingleRegister((byte)(axis + 1), PosAddr, GetUshort(pos));
            _master.WriteSingleRegister((byte)(axis + 1), PressMM, 500);
            _master.WriteSingleRegister((byte)(axis + 1), PressAddr, 100);
            _master.WriteSingleRegister((byte)(axis + 1), DirAddr, GetUshort(Dir));
            return true;
        }

        public bool JogMove(int axis, bool isPositive)
        {
            double dist = isPositive ? 1000 : 0;
            RelMove(axis, dist);
            return true;
        }

        public bool SetSpeed(int axis, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            try
            {
                _master.WriteSingleRegister((byte)(axis + 1), AccAddr, GetUshort(moveAcc / 100));
                _master.WriteSingleRegister((byte)(axis + 1), SpeedAddr, GetUshort(moveVelH / 100));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte GetAxisState(int axis)
        {
            try
            {
                //0：ALM，1：EL +，2：EL -，3：ORG， 4：EMG，5：Enable
                ushort[] ALM = _master.ReadInputRegisters((byte)(axis + 1), 0x07D1, 1);
                byte res = (byte)(((ALM[0] == 0 || ALM[0] == 4) ? 0 : 1) | 32);
                return res;

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool SetAxisServoEnabled(int axis, bool isOn)
        {
            return true;
        }

        public double GetActPos(int axis)
        {
            try
            {
                ushort[] res = _master.ReadInputRegisters((byte)(axis + 1), 2002, 1);
                double ActPos = Convert.ToDouble(res[0]);
                return ActPos;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double GetCmdPos(int axis)
        {
            try
            {
                ushort[] res = _master.ReadHoldingRegisters((byte)(axis + 1), 1001, 1);
                double CmdPos = Convert.ToDouble(res[0]);
                return CmdPos;

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool CheckIsStop(int axis)
        {
            ushort[] res = _master.ReadInputRegisters((byte)(axis + 1), 0x07D0, 1);
            bool statu = !GetBit(res[0], 3);
            return statu;
        }

        public bool ClearAlarm(int axis)
        {
            throw new NotImplementedException();
        }

        public bool Stop(int axis)
        {
            _master.WriteSingleRegister((byte)(axis + 1), 0x03EF, 0);
            _master.WriteSingleRegister((byte)(axis + 1), DirAddr, 17);
            return true;
        }

        public bool InstancyStop(int axis)
        {
            throw new NotImplementedException();
        }


        private ushort GetUshort(double data)
        {
            if (data < 0) return 0;
            ushort value = Convert.ToUInt16(data);
            byte[] buffer = BitConverter.GetBytes(value);
            ushort result = BitConverter.ToUInt16(new byte[] { buffer[0], buffer[1] }, 0);
            return result;
        }

        /// <summary>
        ///  获取ushort指定位的值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public bool GetBit(ushort value, int offset)
        {
            if (offset > 15) throw new ArgumentException("offset大于数组长度");
            return (value & (1 << offset)) != 0;
        }

        public void SetActPos(int axis, double pos)
        {
            throw new NotImplementedException();
        }

        public bool CircularInterpolation(int axis1, int axis2, bool isPositive, double center1, double center2, double endPos1, double endPos2)
        {
            throw new NotImplementedException();
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
