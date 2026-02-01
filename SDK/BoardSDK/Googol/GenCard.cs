using System;
using System.Threading;
using FileHelper;
using GTN;
using JLogging;

namespace BoardSDK
{
    public class GenCard : BoardBase, IBoardIO, IBoardAxis
    {
        private ushort _doAddr = 0;

        private ushort _diAddr = 0;

        private int[] _mode = null;

        public override bool Connect(string filePath)
        {
            try
            {
                short sRtn = mc.GTN_Open(5, 2);
                if (sRtn < 0) return false;
                sRtn += mc.GTN_TerminateEcatComm(1);
                sRtn += mc.GTN_InitEcatComm(1);
                if (sRtn < 0)
                {
                    LoggingIF.Log("请将Gecat.xml文件放到运行目录下");
                    return false;
                }
                int count = 0;
                while (true)
                {
                    Thread.Sleep(100);
                    if (mc.GTN_IsEcatReady(1, out short sEcatSts) == -10)
                        return false;
                    count++;
                    if (sEcatSts == 1)
                        break;
                    else if (count > 100)
                        break;
                }
                sRtn += mc.GTN_StartEcatComm(1);
                sRtn += mc.GTN_Reset(1);
                sRtn += mc.GTN_LoadConfig(1, filePath);
                sRtn += mc.GTN_ClrSts(1, 1, 32);

                Thread.Sleep(1000);
                if (sRtn < 0) return false;
                _doAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "轴卡信息", "DOAddr", ""));
                _diAddr = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "轴卡信息", "DIAddr", ""));
                uint axisCount = Convert.ToUInt16(IniHelper.INIGetStringValue(filePath, "轴卡信息", "AxisCount", ""));
                _mode = new int[axisCount];
                for (int i = 0; i < axisCount; i++)
                {
                    short nCore = (short)(i / 32 + 1);
                    short nAxis = (short)(i % 32 + 1);
                    SetAxisServoEnabled(i, true);
                    mc.GTN_GetEcatEncPos(nCore, nAxis, out int EcatEncPos);
                    mc.GTN_SetPrfPos(nCore, nAxis, EcatEncPos);
                    _mode[i] = 8;
                }
                _isConnected = true;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool Disconnect()
        {
            short sRtn = mc.GTN_TerminateEcatComm(1);
            sRtn += mc.GTN_Close();
            _isConnected = false;
            return sRtn == 0;
        }

        public override bool CheckConnect()
        {
            mc.TEcatErrInfo info = new mc.TEcatErrInfo();
            mc.GTN_GetEcatDcErrorEx(1, ref info);
            return info.offlineFlag == 0 && _isConnected;
        }
        
        public bool Stop(int axis)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            if (_mode[axis] == 6)
            {
                mc.GTN_SetHomingMode(nCore, nAxis, 8);// 切换到位置控制模式
                _mode[axis] = 8;
            }
            return mc.GTN_Stop(nCore, 1 << (nAxis - 1), 0) == 0;
        }

        public bool InstancyStop(int axis)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            return mc.GTN_Stop(nCore, 1 << (nAxis - 1), 1) == 0;
        }
        
        public bool CheckIsStop(int axis)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            short sRtn = mc.GTN_GetSts(nCore, nAxis, out int axisStatus, 1, out uint pClk);
            return (axisStatus & (1 << 10)) == 0;
        }

        public bool ClearAlarm(int axis)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            return mc.GTN_ClrSts(nCore, nAxis, 1) == 0; 
        }

        public double GetActPos(int axis)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            mc.GTN_GetEcatEncPos(nCore, nAxis, out int EcatEncPos);//读取 EtherCAT 轴的编码器位置, 驱动器的寄存器
            return EcatEncPos;
        }

        public double GetCmdPos(int axis)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            mc.GTN_GetPrfPos(nCore, nAxis, out double EncPos, 1, out uint pClock);
            return EncPos;
        }

        public byte GetAxisState(int axis)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            byte ret = 0;
            short sRtn = 0;
            sRtn = mc.GTN_ClrSts(nCore, nAxis, 1);//清除驱动器报警标志、跟随误差越限标志、限位触发标志
            sRtn = mc.GTN_GetSts(nCore, nAxis, out int IOStatus, 1, out uint pClk);
            if ((IOStatus & 0x02) != 0)      //ALM
                ret |= (0x01 << 0);
            if ((IOStatus & 0x20) != 0)      //+EL
                ret |= (0x01 << 1);
            if ((IOStatus & 0x40) != 0)      //-EL
                ret |= (0x01 << 2);
            if ((IOStatus & 0x100) != 0)     //EMG
                ret |= (0x01 << 4);
            if ((IOStatus & 0x200) != 0)     //Servo
                ret |= (0x01 << 5);
            sRtn = mc.GTN_GetDi(nCore, mc.MC_HOME, out int value);
            if ((value & (1 << nAxis - 1)) != 0)     //ORG
                ret |= (0x01 << 3);
            if (_mode[axis] == 6 && Math.Abs(GetActPos(axis) - 0.0) < 1e-2)
            {
                mc.GTN_SetHomingMode(nCore, nAxis, 8);// 切换到位置控制模式
                _mode[axis] = 8;
            }
            return ret;
        }
        
        public bool SetAxisServoEnabled(int axis, bool isOn)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            short ret = 0;
            if (isOn == true)
                ret = mc.GTN_AxisOn(nCore, nAxis);
            else
                ret = mc.GTN_AxisOff(nCore, nAxis);
            return ret == 0;
        }
        
        public bool GoHome(int axis, double homeVelL, double homeVelH, double homeAcc, double homeDcc, uint homeMode, uint homeDir)
        {
            short sRtn = 0;
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            sRtn += mc.GTN_ClrSts(nCore, nAxis, 1);         //清除驱动器报警标志、跟随误差越限标志、限位触发标志
            sRtn += mc.GTN_SetHomingMode(nCore, nAxis, 6);  //切换到回零模式
            sRtn += mc.GTN_ZeroPos(nCore, nAxis, 1);
            sRtn += mc.GTN_SetEcatHomingPrm(nCore, nAxis, (short)homeMode, homeVelH, homeVelL, homeAcc, 0, 0);
            sRtn += mc.GTN_StartEcatHoming(nCore, nAxis);
            _mode[axis] = 6;
            return sRtn == 0;
        }
        
        public bool AbsMove(int axis, double pos)
        {
            short sRtn = 0;
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            sRtn += mc.GTN_ClrSts(nCore, nAxis, 1);//清除驱动器报警标志、跟随误差越限标志、限位触发标志
            sRtn += mc.GTN_PrfTrap(nCore, nAxis);
            if (_mode[axis] == 6)
            {
                mc.GTN_SetHomingMode(nCore, nAxis, 8);// 切换到位置控制模式
                _mode[axis] = 8;
            }
            sRtn += mc.GTN_SetPos(nCore, nAxis, (int)pos);//设置目标位置
            sRtn += mc.GTN_Update(nCore, 1 << (nAxis - 1));//更新轴运动
            return sRtn == 0;
        }

        public bool JogMove(int axis, bool isPositive)
        {
            try
            {
                short sRtn = 0;
                short nCore = (short)(axis / 32 + 1);
                short nAxis = (short)(axis % 32 + 1);
                sRtn += mc.GTN_ClrSts(nCore, nAxis, 1);//清除驱动器报警标志、跟随误差越限标志、限位触发标志
                sRtn += mc.GTN_PrfJog(nCore, nAxis);
                sRtn += mc.GTN_GetJogPrm(nCore, nAxis, out mc.TJogPrm Jog);
                Jog.acc = 1000 / 1000;
                Jog.dec = 1000 / 1000;
                Jog.smooth = 0.5;
                sRtn += mc.GTN_SetJogPrm(nCore, nAxis, ref Jog);
                sRtn += mc.GTN_SetVel(nCore, nAxis, isPositive ? 1000 / 1000 : - 1000 / 1000);//设置速度 
                sRtn += mc.GTN_Update(nCore, 1 << (nAxis - 1));
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool RelMove(int axis, double dist)
        {
            short sRtn = 0;
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            sRtn += mc.GTN_ClrSts(nCore, nAxis, 1);//清除驱动器报警标志、跟随误差越限标志、限位触发标志
            sRtn += mc.GTN_PrfTrap(nCore, nAxis);
            sRtn += mc.GTN_GetPrfPos(nCore, nAxis, out double prfpos, 1, out uint clk); //获取目标位置
            sRtn += mc.GTN_SetPos(nCore, nAxis, (int)(prfpos + dist));                  //设置目标位置
            sRtn += mc.GTN_Update(nCore, 1 << (nAxis - 1));                             //更新轴运动
            return sRtn == 0;
        }

        public bool SetSpeed(int axis, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            try
            {
                short sRtn = 0;
                short nCore = (short)(axis / 32 + 1);
                short nAxis = (short)(axis % 32 + 1);
                sRtn += mc.GTN_GetTrapPrm(nCore, nAxis, out mc.TTrapPrm trap);
                trap.acc = moveAcc / 1000;
                trap.dec = moveDcc / 1000;
                trap.smoothTime = 10;
                trap.velStart = 0;
                sRtn += mc.GTN_SetTrapPrm(nCore, nAxis, ref trap);//设置点位运动参数
                sRtn += mc.GTN_SetVel(nCore, nAxis, moveVelH / 1000);//设置目标速度
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool GetIn(int axis, int IOIdx)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            int ret = mc.GTN_GetEcatRawData(nCore, (ushort)(_diAddr + IOIdx / 8), 1, out byte pValue);
            return (pValue & (1 << (IOIdx % 8))) != 0;
        }

        public bool GetOut(int axis, int IOIdx)
        {
            short nCore = (short)(axis / 32 + 1);
            short nAxis = (short)(axis % 32 + 1);
            int ret = mc.GTN_GetEcatRawData(nCore, (ushort)(_doAddr + IOIdx / 8), 1, out byte pValue);
            return (pValue & (1 << (IOIdx % 8))) != 0;
        }

        public bool SetOut(int axis, int IOIdx, bool isOn)
        {
            short nCore = (short)(axis / 32 + 1);
            ushort offset = (ushort)(_doAddr + IOIdx / 8);
            short ret = mc.GTN_GetEcatRawData(nCore, offset, 1, out byte currValue);
            byte value = isOn ? (byte)(currValue | (byte)Math.Pow(2, IOIdx % 8)) : (byte)(currValue & ~(byte)Math.Pow(2, IOIdx % 8));
            ret += mc.GTN_SetEcatRawData(nCore, offset, 1, ref value);
            return ret == 0;
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
