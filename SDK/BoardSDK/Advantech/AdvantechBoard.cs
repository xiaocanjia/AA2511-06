using System;
using Advantech.Motion;
using FileHelper;

namespace BoardSDK
{
    public class AdvantechBoard : BoardBase, IBoardIO, IBoardAxis
    {
        private IntPtr _devPtr = new IntPtr();

        private IntPtr[] _axisPtrs = null;
        
        private bool _isConnect = false;

        public override bool Connect(string filePath)
        {
            try
            {
                _isConnect = false;
                uint ID = Convert.ToUInt32("0x" + IniHelper.INIGetStringValue(filePath, "Device Config", "ID", ""), 16);
                uint ret = Motion.mAcm_DevOpen(ID, ref _devPtr);
                if (ret != (uint)ErrorCode.SUCCESS)
                    return false;
                uint axisCount = 0;
                ret = Motion.mAcm_GetU32Property(_devPtr, (uint)PropertyID.FT_DevAxesCount, ref axisCount);
                if (ret != (uint)ErrorCode.SUCCESS || axisCount <= 0)
                    return false;
                _axisPtrs = new IntPtr[axisCount];
                for (int i = 0; i < axisCount; i++)
                {
                    ret |= Motion.mAcm_AxOpen(_devPtr, (ushort)i, ref _axisPtrs[i]);
                    SetAxisServoEnabled(i, true);
                    ret |= Motion.mAcm_AxResetError(_axisPtrs[i]);
                    if (ret != (uint)ErrorCode.SUCCESS)
                        return false;
                }
                ret = Motion.mAcm_DevLoadConfig(_devPtr, filePath);
                if (ret != (uint)ErrorCode.SUCCESS)
                    return false;
                _isConnect = true;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool Disconnect()
        {
            try
            {
                uint Result = Motion.mAcm_DevClose(ref _devPtr);
                if (Result != (uint)ErrorCode.SUCCESS)
                    return false;
                _isConnect = false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool CheckConnect()
        {
            return _isConnect;
        }

        public bool ClearAlarm(int axis)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            uint res = Motion.mAcm_AxResetAlm(_axisPtrs[axis], 1);
            return (uint)ErrorCode.SUCCESS == res;
        }

        public double GetActPos(int axis)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return 0;
            double pos = 0;
            uint res = Motion.mAcm_AxGetActualPosition(_axisPtrs[axis], ref pos);
            return res == 0 ? pos : double.NaN;
        }

        public double GetCmdPos(int axis)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return 0;
            double pos = 0;
            uint res = Motion.mAcm_AxGetCmdPosition(_axisPtrs[axis], ref pos);
            return res == 0 ? pos : double.NaN;
        }

        public bool CheckIsStop(int axis)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            ushort state = 0;
            if (Motion.mAcm_AxGetState(_axisPtrs[axis], ref state) != 0)
                return false;
            if (state == (ushort)AxisState.STA_AX_READY || state == (ushort)AxisState.STA_AX_ERROR_STOP)
                return true;
            return false;
        }

        public byte GetAxisState(int axis)
        {
            byte ret = 0;
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return ret;
            uint IOStatus = 0;
            Motion.mAcm_AxGetMotionIO(_axisPtrs[axis], ref IOStatus);
            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_ALM) > 0)   //ALM
                ret |= (0x01 << 0);
            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_LMTP) > 0)  //+EL
                ret |= (0x01 << 1);
            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_LMTN) > 0)  //-EL
                ret |= (0x01 << 2);
            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_ORG) > 0 || //ORG
                (IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_EZ) > 0)    //EZ
                ret |= (0x01 << 3);
            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_EMG) > 0)   //EMG
                ret |= (0x01 << 4);
            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_SVON) > 0)  //Servo
                ret |= (0x01 << 5);
            return ret;
        }

        public bool GetIn(int axisIdx, int IOIdx)
        {
            if (!_isConnect)
                return false;
            int axis = (IOIdx & 0xff00) >> 8;
            int channel = IOIdx & 0x00ff;
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            byte bitData = 0;
            uint Result = Motion.mAcm_AxDiGetBit(_axisPtrs[axis], (ushort)channel, ref bitData);
            if (Result != (uint)ErrorCode.SUCCESS)
                return false;
            if (bitData == 0)
                return false;
            else
                return true;
        }

        public bool GetOut(int axisIdx, int IOIdx)
        {
            if (!_isConnect)
                return false;
            int axis = (IOIdx & 0xff00) >> 8;
            int channel = IOIdx & 0x00ff;
            byte bitData = 0;
            Motion.mAcm_AxDoGetBit(_axisPtrs[axis], (ushort)channel, ref bitData);
            if (bitData == 0)
                return false;
            else
                return true;
        }

        public bool SetOut(int axisIdx, int IOIdx, bool Value)
        {
            if (!_isConnect)
                return false;
            int axis = (IOIdx & 0xff00) >> 8;
            int channel = IOIdx & 0xff;
            byte byteWrite = Value ? (byte)1 : (byte)0;
            return 0 == Motion.mAcm_AxDoSetBit(_axisPtrs[axis], (ushort)channel, byteWrite);
        }

        public bool GoHome(int axis, double homeVelL, double homeVelH, double homeAcc, double homeDcc, uint homeMode, uint homeDir)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;

            uint res = 0;
            res |= Motion.mAcm_AxResetError(_axisPtrs[axis]);
            res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxVelLow, homeVelL);
            res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxVelHigh, homeVelH);
            res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxAcc, homeAcc);
            res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxDec, homeDcc);
            res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxHomeCrossDistance, 10);
            res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxJerk, 0);
            res |= Motion.mAcm_AxHome(_axisPtrs[axis], homeMode, homeDir);

            return res == (uint)ErrorCode.SUCCESS;
        }

        public bool InstancyStop(int axis)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            uint res = Motion.mAcm_AxStopEmg(_axisPtrs[axis]);
            return (uint)ErrorCode.SUCCESS == res;
        }

        public bool JogMove(int axis, bool isPositive)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            uint res = 0;
            res |= Motion.mAcm_AxResetError(_axisPtrs[axis]);
            res |= Motion.mAcm_AxMoveVel(_axisPtrs[axis], isPositive ? (ushort)0 : (ushort)1);

            return res == (uint)ErrorCode.SUCCESS;
        }

        public bool AbsMove(int axis, double pos)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            uint res = 0;
            res |= Motion.mAcm_AxResetError(_axisPtrs[axis]);
            res |= Motion.mAcm_AxMoveAbs(_axisPtrs[axis], pos);
            return res == (uint)ErrorCode.SUCCESS;
        }

        public bool RelMove(int axis, double dist)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            uint res = 0;
            res |= Motion.mAcm_AxResetError(_axisPtrs[axis]);
            res |= Motion.mAcm_AxMoveRel(_axisPtrs[axis], dist);
            return res == (uint)ErrorCode.SUCCESS;
        }

        public bool SetSpeed(int axis, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            try
            {
                if (_axisPtrs == null || _axisPtrs[axis] == null)
                    return false;
                uint res = 0;
                res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxVelLow, moveVelL);
                res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxVelHigh, moveVelH);
                res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxAcc, moveAcc);
                res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxDec, moveDcc);
                res |= Motion.mAcm_SetF64Property(_axisPtrs[axis], (uint)PropertyID.PAR_AxJerk, 0);
                return res == (uint)ErrorCode.SUCCESS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SetAxisServoEnabled(int axis, bool isOn)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            uint res = Motion.mAcm_AxSetSvOn(_axisPtrs[axis], (uint)(isOn ? 1 : 0));
            return (uint)ErrorCode.SUCCESS == res;
        }
        
        public bool Stop(int axis)
        {
            if (_axisPtrs == null || _axisPtrs[axis] == null)
                return false;
            uint res = Motion.mAcm_AxStopDec(_axisPtrs[axis]);
            return (uint)ErrorCode.SUCCESS == res;
        }

        public void SetActPos(int axis, double pos)
        {
            throw new NotImplementedException();
        }

        public bool CircularInterpolation(int axis1, int axis2, bool isPositive, double center1, double center2, double endPos1, double endPos2)
        {
            throw new NotImplementedException();
        }

        public bool SetSpeed(double moveVelL, double moveVelH, double moveAcc, double moveDcc)
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
