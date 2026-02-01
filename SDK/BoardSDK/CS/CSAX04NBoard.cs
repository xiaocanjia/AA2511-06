using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using JLogging;
using FileHelper;
using System.Collections;

namespace BoardSDK
{
    public class CSAX04NBoard : BoardBase, IBoardIO, IBoardAxis
    {
        protected Socket _socket = null;

        private string _filePath = "";

        private bool[] _isOn;

        private double[] _times;

        private bool[] _DIs = new bool[8];

        private bool[] _DOs = new bool[8];

        private readonly ManualResetEvent TimeoutObject = new ManualResetEvent(false);

        private readonly object _lock = new object();

        private IPEndPoint _remoteEndPoint;

        public override bool Connect(string filePath)
        {
            try
            {
                _filePath = filePath;
                string IP = GetCfgValue("DeviceConfig", "IP");
                int port = Convert.ToInt32(GetCfgValue("DeviceConfig", "Port"));
                int axesCount = Convert.ToInt32(GetCfgValue("DeviceConfig", "AxesCount"));
                TimeoutObject.Reset();
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _remoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);
                _socket.ReceiveTimeout = 1000;
                _socket.BeginConnect(_remoteEndPoint, CallBackMethod, new object());
                if (!TimeoutObject.WaitOne(2000, false))
                    return false;
                _isOn = new bool[axesCount];
                _times = new double[axesCount];
                for (int i = 0; i < axesCount; i++)
                {
                    SetAxisServoEnabled(i, true);
                    int iRange = Convert.ToInt32(GetCfgValue($"Axis{i}Config", "AxisRange"));
                    _times[i] = 8000000.0 / iRange;
                    byte[] range = IntToByte(iRange);
                    SendCmd(new byte[] { 0x01, (byte)Math.Pow(2, i), range[0], range[1], range[2], range[3] });
                    SendCmd(new byte[] { 0x06, (byte)Math.Pow(2, i) });
                    SendCmd(new byte[] { 0x17, (byte)Math.Pow(2, i), 0x01 });
                    SendCmd(new byte[] { 0x38, (byte)Math.Pow(2, i), 0x00, Convert.ToByte(GetCfgValue($"Axis{i}Config", "PLMTLogic")), Convert.ToByte(GetCfgValue($"Axis{i}Config", "NLMTLogic")) });
                    SendCmd(new byte[] { 0x2D, (byte)Math.Pow(2, i), Convert.ToByte(GetCfgValue($"Axis{i}Config", "AlarmLogic")) });
                }
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"轴卡连接失败{ex.Message}", LogLevels.Error);
                return false;
            }
        }

        private string GetCfgValue(string section, string key)
        {
            return IniHelper.INIGetStringValue(_filePath, section, key, "");
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

        public bool GoHome(int axis, double homeVelL, double homeVelH, double homeAcc, double homeDcc, uint homeMode, uint homeDir)
        {
            try
            {
                byte orgLogic = Convert.ToByte(GetCfgValue($"Axis{axis}Config", "OrgLogic"));
                byte[] bHomeVelL = UIntToByte((uint)(homeVelL / _times[axis]));
                byte[] bHomeVelH = UIntToByte((uint)(homeVelH / _times[axis]));
                byte[] bHomeAcc = UIntToByte((uint)(homeAcc / _times[axis] / 125.0));
                byte[] bHomeDcc = UIntToByte((uint)(homeDcc / _times[axis] / 125.0));
                byte[] buffer = null;
                byte bAxis = (byte)Math.Pow(2, axis);
                SetAxisServoEnabled(axis, true);
                SendCmd(new byte[] { 0x02, bAxis, bHomeVelL[0], bHomeVelL[1], bHomeVelH[0], bHomeVelH[1] });    //设置运行速度
                SendCmd(new byte[] { 0x03, bAxis, bHomeAcc[0], bHomeAcc[1], bHomeDcc[0], bHomeDcc[1] });        //设置加、减速度
                switch (homeMode)
                {
                    case 0: //Z相回原
                        SendCmd(new byte[] { 0x51, bAxis });
                        buffer = new byte[] { 0x56, bAxis, 0x01, orgLogic, 0x01, (byte)homeDir, bHomeVelH[0], bHomeVelH[1], 0x00, 0x00, 0x00, 0x00 };
                        break;
                    case 1: //撞到限位再回原点
                        buffer = new byte[] { 0x57, bAxis, orgLogic, (byte)homeDir, bHomeVelH[0], bHomeVelH[1], 0x00, 0x00, 0x00, 0x00 };
                        break;
                    case 2: //只用限位回原
                        SendCmd(new byte[] { 0x02, bAxis, bHomeVelL[0], bHomeVelL[1], bHomeVelH[0], bHomeVelH[1] });
                        buffer = new byte[] { 0x58, bAxis, orgLogic, (byte)homeDir, 0x00, 0x00, 0x00, 0x00 };
                        break;
                    case 3: //撞到原点就停
                        buffer = new byte[] { 0x59, bAxis, 0x01, orgLogic, (byte)homeDir, bHomeVelH[0], bHomeVelH[1], 0x00, 0x00, 0x00, 0x00 };
                        break;
                    default:
                        throw new Exception($"Homing mode has not way of {homeMode}");
                }
                SendCmd(buffer);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool JogMove(int axis, bool isPositive)
        {
            try
            {
                byte bAxis = (byte)Math.Pow(2, axis);
                SendCmd(new byte[] { (byte)(isPositive ? 0x0F : 0x10), bAxis });    //设置连续运动
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RelMove(int axis, double dist)
        {
            try
            {
                byte[] bDist = IntToByte((int)Math.Abs(dist));
                byte bAxis = (byte)Math.Pow(2, axis);
                SendCmd(new byte[] { (byte)(dist > 0 ? 0x0D : 0x0E), bAxis, bDist[0], bDist[1], bDist[2], bDist[3] });   //设置运动距离
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AbsMove(int axis, double pos)
        {
            try
            {
                byte[] bPos = IntToByte((int)pos);
                byte bAxis = (byte)Math.Pow(2, axis);
                SendCmd(new byte[] { 0x64, bAxis, bPos[0], bPos[1], bPos[2], bPos[3] });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CircularInterpolation(int axis1, int axis2, bool isPositive, double center1, double center2, double endPos1, double endPos2)
        {
            try
            {
                byte[] bCenter1 = IntToByte((int)Math.Abs(center1));
                byte[] bCenter2 = IntToByte((int)Math.Abs(center2));
                byte[] bEndPos1 = IntToByte((int)Math.Abs(endPos1));
                byte[] bEndPos2 = IntToByte((int)Math.Abs(endPos2));
                byte bAxis1 = (byte)Math.Pow(2, axis1);
                byte bAxis2 = (byte)Math.Pow(2, axis2);
                byte bPositive = (byte)(isPositive ? 0xDB : 0xDC);
                SendCmd(new byte[] { bPositive, bAxis1, bAxis2, bCenter1[0], bCenter1[1], bCenter1[2], bCenter1[3], bCenter2[0], bCenter2[1], bCenter2[2], bCenter2[3], bEndPos1[0], bEndPos1[1], bEndPos1[2], bEndPos1[3], bEndPos2[0], bEndPos2[1], bEndPos2[2], bEndPos2[3] });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckIsStop(int axis)
        {
            try
            {
                string ret = SendCmd(new byte[] { 0x39, (byte)Math.Pow(2, axis) });
                if (ret.Contains("Stopped"))
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ClearAlarm(int axis)
        {
            return true;
        }

        public double GetActPos(int axis)
        {
            try
            {
                string ret = SendCmd(new byte[] { 0x1b, (byte)Math.Pow(2, axis) });
                return Convert.ToDouble(ret.Split(':')[1]);
            }
            catch
            {
                return 0.0;
            }
        }

        public void SetActPos(int axis, double pos)
        {
            try
            {
                byte[] bPos = IntToByte((int)pos);
                SendCmd(new byte[] { 0x11, (byte)Math.Pow(2, axis), bPos[0], bPos[1], bPos[2], bPos[3] });
                Thread.Sleep(100);
                SendCmd(new byte[] { 0x12, (byte)Math.Pow(2, axis), bPos[0], bPos[1], bPos[2], bPos[3] });
            }
            catch { }
        }

        public double GetCmdPos(int axis)
        {
            try
            {
                string ret = SendCmd(new byte[] { 0x1a, (byte)Math.Pow(2, axis) });
                return Convert.ToDouble(ret.Split(':')[1]);
            }
            catch
            {
                return 0.0;
            }
        }

        public bool SetAxisServoEnabled(int axis, bool isOn)
        {
            try
            {
                _isOn[axis] = isOn;
                byte D2 = 0x01 << (7 - 4);
                byte D3 = (byte)(0x01 << axis);
                SendCmd(new byte[] { 0x3C, (byte)(isOn ? 0 : 1), D2, D3 });
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
                byte[] buffer = null;
                switch (axis)
                {
                    case 0:
                        buffer = new byte[] { 0xBB, 0x00, 0x02 };
                        break;
                    case 1:
                        buffer = new byte[] { 0xBB, 0x02, 0x00 };
                        break;
                    case 2:
                        buffer = new byte[] { 0xBB, 0xFF, 0xFD };
                        break;
                    case 3:
                        buffer = new byte[] { 0xBB, 0xFD, 0xFF };
                        break;
                }
                byte org = (byte)(Convert.ToByte(SendCmd(buffer).Split(':')[1]) == 1 ? 0 : 1);
                string ret = SendCmd(new byte[] { 0x4D, (byte)Math.Pow(2, axis) });
                if (ret.Contains("None Error!!!!"))
                    return (byte)(0 | (_isOn[axis] ? 32 : 0) | org << 3);
                int iRet = Convert.ToInt32(Regex.Split(ret, ": ")[1]); //bit2：硬件正限位 bit3：硬件负限位 bit4：伺服报警 bit5：急停
                return (byte)(((iRet & 4) >> 1) | ((iRet & 8) >> 1) | ((iRet & 16) >> 4) | ((iRet & 32) >> 1) | (_isOn[axis] ? 32 : 0) | (org << 3));
            }
            catch
            {
                return 1;
            }
        }

        public bool GetIn(int axisIdx, int IOIdx)
        {
            try
            {
                if (_socket == null) return false;
                if (IOIdx > 7) return false;
                string res = SendCmd(new byte[] { 0x60 });
                byte value = Convert.ToByte(res.Split(':')[1]);
                _DIs = GetBits(value);
                return _DIs[IOIdx];
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 将byte转换成bool[]
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool[] GetBits(byte value)
        {
            var bits = new BitArray(new byte[] { value });
            bool[] bools = new bool[bits.Count];
            for (var i = 0; i < bits.Count; i++)
            {
                bools[i] = bits[i];
            }
            return bools;
        }

        public bool GetOut(int axisIdx, int IOIdx)
        {
            return _DOs[IOIdx];
        }

        public bool SetOut(int axisIdx, int IOIdx, bool value)
        {
            try
            {
                _DOs[IOIdx] = value;
                SendCmd(new byte[] { 0x61, (byte)IOIdx, (byte)(value ? 1 : 0)});
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InstancyStop(int axis)
        {
            try
            {
                SendCmd(new byte[] { 0x20, (byte)Math.Pow(2, axis) });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Stop(int axis)
        {
            try
            {
                SendCmd(new byte[] { 0x1F, (byte)Math.Pow(2, axis) });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private byte[] IntToByte(int value)
        {
            byte[] buffer = new byte[4];
            buffer[0] = (byte)((value >> 24) & 0xFF);
            buffer[1] = (byte)((value >> 16) & 0xFF);
            buffer[2] = (byte)((value >> 8) & 0xFF);
            buffer[3] = (byte)((value >> 0) & 0xFF);
            return buffer;
        }

        private byte[] UIntToByte(uint value)
        {
            byte[] buffer = new byte[2];
            buffer[0] = (byte)((value >> 8) & 0xFF);
            buffer[1] = (byte)((value >> 0) & 0xFF);
            return buffer;
        }

        private void CallBackMethod(IAsyncResult asyncresult)
        {
            TimeoutObject.Set();
        }

        private string SendCmd(byte[] data)
        {
            lock (_lock)
            {
                try
                {
                    _socket.Send(data);
                    Thread.Sleep(1);
                    byte[] buffer = new byte[1024];
                    int length = _socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    string ret = Encoding.ASCII.GetString(buffer, 0, length);
                    return ret;
                }
                catch
                {
                    return "";
                }
            }
        }

        public bool SetSpeed(int axis, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            try
            {
                byte[] bMoveVelL = UIntToByte((uint)(moveVelL / _times[axis]));
                byte[] bMoveVelH = UIntToByte((uint)(moveVelH / _times[axis]));
                byte[] bMoveAcc = UIntToByte((uint)(moveAcc / _times[axis] / 125.0));
                byte[] bMoveDcc = UIntToByte((uint)(moveDcc / _times[axis] / 125.0));
                byte bAxis = (byte)Math.Pow(2, axis);
                SendCmd(new byte[] { 0x02, bAxis, bMoveVelL[0], bMoveVelL[1], bMoveVelH[0], bMoveVelH[1] });             //设置运行速度
                SendCmd(new byte[] { 0x03, bAxis, bMoveAcc[0], bMoveAcc[1], bMoveDcc[0], bMoveDcc[1] });                 //设置加、减速度
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
