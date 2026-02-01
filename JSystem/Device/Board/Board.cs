using System;
using Newtonsoft.Json;
using BoardSDK;

namespace JSystem.Device
{
    public class Board : DeviceBase
    {
        public int BoardType = 0;

        [JsonIgnore]
        private BoardBase _board;

        private bool _isConnected = false;

        public Board() { }

        public Board(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new BoardView(this);
        }

        public override bool Connect()
        {
            _board = BoardFactory.CreateBoard((EBoardType)BoardType);
            return _board.Connect(AppDomain.CurrentDomain.BaseDirectory + $"Config\\{Name}.cfg");
        }

        public override void DisConnect()
        {
            _board?.Disconnect();
        }

        public override bool CheckConnection()
        {
            _isConnected = _board == null ? false : _board.CheckConnect();
            OnUpdateStatus?.Invoke(_isConnected);
            return _isConnected;
        }
        
        public bool SetOut(int axisIdx, int IOIdx, bool Value)
        {
            if (!_isConnected) return false;
            return ((IBoardIO)_board).SetOut(axisIdx, IOIdx, Value);
        }
        
        public bool GetOut(int axisIdx, int IOIdx)
        {
            if (!_isConnected) return false;
            return ((IBoardIO)_board).GetOut(axisIdx, IOIdx);
        }
        
        public bool GetIn(int axisIdx, int IOIdx)
        {
            if (!_isConnected) return false;
            return ((IBoardIO)_board).GetIn(axisIdx, IOIdx);
        }
        
        public bool ClearAlarm(int axis)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).ClearAlarm(axis);
        }

        public bool SetAxisServoEnabled(int axis, bool isOn)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).SetAxisServoEnabled(axis, isOn);
        }

        public bool GoHome(int axis, double homeVelL, double homeVelH, double homeAcc, double homeDcc, uint homeMode, uint homeDir)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).GoHome(axis, homeVelL, homeVelH, homeAcc, homeDcc, homeMode, homeDir);
        }

        public bool CheckIsStop(int axis)
        {
            if (!_isConnected) return true;
            return ((IBoardAxis)_board).CheckIsStop(axis);
        }

        public byte GetAxisState(int axis)
        {
            if (!_isConnected) return 0;
            return ((IBoardAxis)_board).GetAxisState(axis);
        }

        public double GetActPos(int axis)
        {
            if (!_isConnected) return 0.0;
            return ((IBoardAxis)_board).GetActPos(axis);
        }

        public void SetActPos(int axis, double pos)
        {
            if (!_isConnected) return;
            ((IBoardAxis)_board).SetActPos(axis, pos);
        }

        public double GetCmdPos(int axis)
        {
            if (!_isConnected) return 0.0;
            return ((IBoardAxis)_board).GetCmdPos(axis);
        }

        public bool SetSpeed(int axis, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).SetSpeed(axis, moveVelL, moveVelH, moveAcc, moveDcc);
        }

        public bool AbsMove(int axis, double pos)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).AbsMove(axis, pos);
        }

        public bool RelMove(int axis, double dist)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).RelMove(axis, dist);
        }

        public bool CircleMove(int axis1, int axis2, double moveVelL, double moveVelH, double moveAcc, double moveDcc, bool isPositive, double center1, double center2, double endPos1, double endPos2)
        {
            if (!_isConnected) return false;
            ((IBoardAxis)_board).SetSpeed(axis1, moveVelL, moveVelH, moveAcc, moveDcc);
            return ((IBoardAxis)_board).CircularInterpolation(axis1, axis2, isPositive, center1, center2, endPos1, endPos2);
        }

        public bool LineInterpolation(int[] axisArr, double[] posArr, double moveVelL, double moveVelH, double moveAcc, double moveDcc)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).LineInterpolation(axisArr, posArr, moveVelL, moveVelH, moveAcc, moveDcc);
        }

        public bool JogMove(int axis, bool isPositive)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).JogMove(axis, isPositive);
        }

        public bool OscillationMove(int axis, uint count, double freq, double amp, int acqInterval)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).OscillationMove(axis, count, freq, amp, acqInterval);
        }

        public bool EndOscillation(int axis, out int[] data)
        {
            data = null;
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).EndOscillation(axis, out data);
        }

        public bool Stop(int axis)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).Stop(axis);
        }

        public bool InstancyStop(int axis)
        {
            if (!_isConnected) return false;
            return ((IBoardAxis)_board).InstancyStop(axis);
        }
    }
}
