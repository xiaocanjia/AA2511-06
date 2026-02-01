using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using JSystem.Perform;
using JSystem.Device;
using JSystem.IO;
using JLogging;

namespace JSystem.Station
{
    public class StationBase
    {
        public EStationState State = EStationState.END;
        
        public string Name;

        public int Step { get; protected set; } = 0;

        public Control View;

        public Func<string, StationBase> OnGetStation;

        public Queue<string> SNQueue = new Queue<string>();

        public Queue<string> DecQueue = new Queue<string>();

        public Queue<List<MesResult>> RetQueue = new Queue<List<MesResult>>();

        public Func<string, DeviceBase> OnGetDevice;

        public Action<string, bool> OnSetOut;

        public Func<string, bool> OnGetIn;

        public Func<string, bool, bool> OnGetEdgeSignal;

        public Func<EPopupType, string, string, string, bool, DialogResult> OnShowPopup;

        public Action OnHidePopup;

        public Func<string, PointPos> OnGetPoint;

        public Func<string, StationAxis> OnGetAxis;

        public virtual void Run() { }

        public virtual void JumpStep(int step) { Step = step; }

        public virtual void Start()
        {
            if (State != EStationState.PAUSE && State != EStationState.RESETED)
                return;
            State = EStationState.RUNNING;
        }

        public virtual void End()
        {
            State = EStationState.END;
        }

        public virtual void Pause()
        {
            State = EStationState.PAUSE;
        }

        public virtual bool Reset()
        {
            DecQueue.Clear();
            SNQueue.Clear();
            RetQueue.Clear();
            return true;
        }

        /// <summary>
        /// 多轴回原
        /// </summary>
        /// <param name="isHome">true是回原，false是不回原</param>
        /// <param name="isAsyn"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        protected bool GoHome(string[] Axes, bool isAsyn = false, int timeOut = 20000)
        {
            bool ret = true;
            int idx = 0;
            Task[] taskPool = new Task[Axes.Count()];
            for (int i = 0; i < Axes.Length; i++)
            {
                taskPool[idx] = new Task((j) =>
                {
                    if (!GoHome(Axes[(int)j], isAsyn, timeOut))
                        ret = false;
                }, i);
                taskPool[idx].Start();
                idx++;
            }
            Task.WaitAll(taskPool);
            return ret;
        }

        protected bool GoHome(string axisName, bool isAsyn = false, int timeOut = 20000)
        {
            try
            {
                DateTime start = DateTime.Now;
                StationAxis axis = OnGetAxis(axisName);
                if (axis == null) return false;
                AddLog($"{axisName}开始回原", LogLevels.Debug);
                Board board = (Board)OnGetDevice(axis.BoardName);
                bool ret = board.GoHome(axis.AxisIndex, axis.HomeVelLPluse, axis.HomeVelHPluse, axis.HomeAccPluse, axis.HomeDccPluse, axis.HomeMode, axis.HomeDir);
                if (!ret) return false;
                if (isAsyn) return true;
                while (true)
                {
                    Thread.Sleep(100);
                    if (axis.IsEmergencyStop || axis.IsAlarm || State == EStationState.END)
                    {
                        AddLog($"{axisName}回原失败，请检查急停按钮开关是否按下以及驱动器是否报警", LogLevels.Error);
                        return false;
                    }
                    if (board.CheckIsStop(axis.AxisIndex))
                    {
                        if (Math.Abs(board.GetCmdPos(axis.AxisIndex)) < axis.Accuracy)
                        {
                            //axis.SetActPos(0.0);
                            axis.NeedGoHome = false;
                            AddLog($"{axisName}回原完成");
                            return true;
                        }
                        else
                        {
                            AddLog($"{axisName}回原失败");
                            return false;
                        }
                    }
                    if (DateTime.Now.Subtract(start).TotalMilliseconds > timeOut)
                    {
                        AddLog($"{axisName}回原超时，请重新尝试，并联系工程师解决");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "001", Name, $"{axisName}回原发生异常：{ex.Message}", true);
                return false;
            }
        }

        public void EndMove(string axisName)
        {
            StationAxis axis = OnGetAxis(axisName);
            if (axis == null) return;
            ((Board)OnGetDevice(axis.BoardName)).Stop(axis.AxisIndex);
        }

        public void JogMove(string axixName, bool isPositive)
        {
            StationAxis axis = OnGetAxis(axixName);
            Board board = (Board)OnGetDevice(axis.BoardName);
            board.SetSpeed(axis.AxisIndex, axis.MoveVelLPluse, axis.MoveVelHPluse, axis.MoveAccPluse, axis.MoveDccPluse);
            board.JogMove(axis.AxisIndex, isPositive);
        }

        /// <summary>
        /// 移动到固定点位（默认同步）
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="speed"></param>
        /// <param name="isAsyn">false：同步，true：异步</param>
        /// <param name="timeOut">超时，单位：毫秒</param>
        /// <returns>false表示移动失败</returns>
        public bool MoveToPoint(PointPos point)
        {
            AddLog($"移动到{point.Name}");
            StationAxis axis = OnGetAxis(point.AxesCoord[0].Name);
            Board board = (Board)OnGetDevice(axis.BoardName);
            bool ret = true;
            Task[] taskPool = new Task[point.AxesCoord.Count];
            for (int i = 0; i < point.AxesCoord.Count; i++)
            {
                taskPool[i] = new Task((idx) =>
                {
                    if (!point.AxesCoord[(int)idx].Enabled)
                        return;
                    if (!MoveToPos(point.AxesCoord[(int)idx]))
                        ret = false;
                }, i);
                taskPool[i].Start();
            }
            Task.WaitAll(taskPool);
            return ret;
        }

        public bool LineInterpolation(PointPos point)
        {
            AddLog($"移动到{point.Name}");
            StationAxis axis1 = OnGetAxis(point.AxesCoord[0].Name);
            Board board = (Board)OnGetDevice(axis1.BoardName);
            List<int> axisIdxList = new List<int>();
            List<double> posList = new List<double>();
            foreach (AxisCoord coord in point.AxesCoord)
            {
                if (!coord.Enabled)
                    continue;
                StationAxis axis = OnGetAxis(coord.Name);
                axisIdxList.Add(axis.AxisIndex);
                posList.Add(coord.Pos * axis.PlusePerUnit);
            }
        MOVE:
            while (State == EStationState.PAUSE)
                Thread.Sleep(100);
            if (!board.LineInterpolation(axisIdxList.ToArray(), posList.ToArray(), axis1.MoveVelLPluse, point.AxesCoord[0].Speed * axis1.PlusePerUnit, axis1.MoveAccPluse, axis1.MoveDccPluse))
            {
                DialogResult ret = OnShowPopup(EPopupType.ALARM, "002", Name, $"直线插补到{point.Name}运动失败，请检查轴卡是否断连", true);
                if (ret == DialogResult.Retry)
                    goto MOVE;
                else if (ret == DialogResult.Abort)
                    return false;
            }
            DateTime start = DateTime.Now;
            while (true)
            {
                Thread.Sleep(10);
                if (State == EStationState.PAUSE) goto MOVE;
                if (State == EStationState.END) return false;
                if (CheckIsInPos(point))
                    return true;
                if (DateTime.Now.Subtract(start).TotalMilliseconds > point.AxesCoord[0].TimeOut)
                {
                    DialogResult ret = OnShowPopup(EPopupType.ALARM, "003", Name, $"直线插补到{point.Name}超时，请检查是否设置的超时时间过短", true);
                    if (ret == DialogResult.Retry)
                        goto MOVE;
                    else if (ret == DialogResult.Abort)
                        return false;
                }
            }
        }

        public bool MoveToPos(AxisCoord coord)
        {
            try
            {
                StationAxis axis = OnGetAxis(coord.Name);
                Board board = (Board)OnGetDevice(axis.BoardName);
                if (Math.Abs(coord.Pos - board.GetCmdPos(axis.AxisIndex)) < axis.Accuracy)
                    return true;
                AddLog($"{coord.Name}移动到{coord.Pos}", LogLevels.Debug);
            MOVE:
                while (State == EStationState.PAUSE)
                    Thread.Sleep(100);
                if (State == EStationState.END) return false;
                board.SetSpeed(axis.AxisIndex, axis.MoveVelLPluse, coord.Speed * axis.PlusePerUnit, axis.MoveAccPluse, axis.MoveDccPluse);
                if (!board.AbsMove(axis.AxisIndex, coord.Pos * axis.PlusePerUnit))
                {
                    DialogResult ret = OnShowPopup(EPopupType.ALARM, "002", Name, $"{coord.Name}运动失败，请检查轴卡是否断连", true);
                    if (ret == DialogResult.Retry)
                        goto MOVE;
                    else if (ret == DialogResult.Abort)
                        return false;
                }
                DateTime start = DateTime.Now;
                while (!board.CheckIsStop(axis.AxisIndex))
                {
                    Thread.Sleep(10);
                    if (State == EStationState.PAUSE) goto MOVE;
                    if (State == EStationState.END) return false;
                    if (DateTime.Now.Subtract(start).TotalMilliseconds > coord.TimeOut)
                    {
                        DialogResult ret = OnShowPopup(EPopupType.ALARM, "003", Name, $"{coord.Name}运动超时，请检查是否设置的超时时间过短", true);
                        if (ret == DialogResult.Retry)
                            goto MOVE;
                        else if (ret == DialogResult.Abort)
                            return false;
                    }
                }
                if (Math.Abs(coord.Pos - board.GetCmdPos(axis.AxisIndex)) > axis.Accuracy)
                {
                    DialogResult ret = OnShowPopup(EPopupType.ALARM, "004", Name, $"{coord.Name}运动位置偏差过大，请检查是否到达限位", true);
                    if (ret == DialogResult.Retry)
                        goto MOVE;
                    else if (ret == DialogResult.Abort)
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "004", Name, $"{coord.Name}移动到{coord.Pos}出现异常：{ex.Message}", true);
                return false;
            }
        }
        
        public bool CheckIsInPos(PointPos point)
        {
            if (point == null)
                return false;
            for (int i = 0; i < point.AxesCoord.Count; i++)
            {
                StationAxis axis = OnGetAxis(point.AxesCoord[i].Name);
                if (!point.AxesCoord[i].Enabled) continue;
                Board board = (Board)OnGetDevice(axis.BoardName);
                if (Math.Abs(point.AxesCoord[i].Pos * axis.PlusePerUnit - board.GetCmdPos(axis.AxisIndex)) > axis.Accuracy)
                    return false;
            }
            return true;
        }

        public bool MoveBelt(string belt1, string belt2)
        {
        RETRY:
            while (State == EStationState.PAUSE)
                Thread.Sleep(100);
            if (State == EStationState.END) return false;
            if (belt1 != "")
                SetOut($"{belt1}皮带启动", true);
            SetOut($"{belt2}皮带启动", true);
            DateTime start = DateTime.Now;
            while (true)
            {
                if (State == EStationState.PAUSE)
                {
                    start = DateTime.Now;
                    if (belt1 != "")
                        SetOut($"{belt1}皮带启动", false);
                    SetOut($"{belt2}皮带启动", false);
                    goto RETRY;
                }
                if (State == EStationState.END)
                {
                    if (belt1 != "")
                        SetOut($"{belt1}皮带启动", false);
                    SetOut($"{belt2}皮带启动", false);
                    return false;
                }
                if (OnGetIn($"{belt2}感应有料1") && OnGetIn($"{belt2}感应有料2"))
                    break;
                if (DateTime.Now.Subtract(start).TotalMilliseconds > 8000)
                {
                    DialogResult ret = OnShowPopup(EPopupType.ALARM, "006", Name, $"{belt2}信号检测超时，请检查产品位置是否异常", true);
                    if (ret == DialogResult.Retry)
                        goto RETRY;
                    return false;
                }
                Thread.Sleep(10);
            }
            Thread.Sleep(500);
            if (belt1 != "")
                SetOut($"{belt1}皮带启动", false);
            SetOut($"{belt2}皮带启动", false);
            return true;
        }

        /// <summary>
        /// 检查是否停止
        /// </summary>
        /// <param name="axisName"></param>
        /// <returns></returns>
        protected bool CheckIsStop(string axisName)
        {
            if (OnGetAxis == null) return false;
            StationAxis axis = OnGetAxis(axisName);
            Board board = (Board)OnGetDevice(axis.BoardName);
            if (axis == null) return false;
            return board.CheckIsStop(axis.AxisIndex);
        }

        protected bool GetIn(string name, bool isOn, int timeout = 0)
        {
            try
            {
            RETRY:
                if (timeout == 0) return OnGetIn(name) == isOn;
                DateTime start = DateTime.Now;
                while (true)
                {
                    if (State == EStationState.PAUSE)
                    {
                        start = DateTime.Now;
                        continue;
                    }
                    if (State == EStationState.END)
                        return false;
                    if (OnGetIn(name) == isOn)
                        return true;
                    if (DateTime.Now.Subtract(start).TotalMilliseconds > timeout)
                    {
                        DialogResult ret = OnShowPopup(EPopupType.ALARM, "006", Name, $"{name}信号检测超时，请检查感应器是否有异常", true);
                        if (ret == DialogResult.Retry)
                            goto RETRY;
                        return false;
                    }
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "006", Name, $"{name}信号获取失败：{ex.Message}", true);
                return false;
            }
        }


        protected void SetOut(string name, bool value)
        {
            try
            {
                OnSetOut(name, value);
                AddLog($"信号{name}设置为{value}", LogLevels.Debug);
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "007", Name, $"信号{name}设置失败：{ex.Message}", true);
            }
        }

        protected bool Delay(int timeOut)
        {
            AddLog($"延迟{timeOut}毫秒", LogLevels.Debug);
            DateTime start = DateTime.Now;
            while (true)
            {
                Thread.Sleep(5);
                if (State == EStationState.PAUSE)
                {
                    start = DateTime.Now;
                    continue;
                }
                else if (State == EStationState.END)
                    return false;
                if (DateTime.Now.Subtract(start).TotalMilliseconds > timeOut)
                    return true;
            }
        }

        public void AddLog(string log, LogLevels level = LogLevels.Info, [CallerFilePath] string filePath = "",
            [CallerMemberName] string caller = "", [CallerLineNumber] int lineNum = 0)
        {
            LogManager.Instance.AddLog(Name, log, level, filePath, caller, lineNum);
        }
    }
}
