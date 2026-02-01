using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using JSystem.Perform;
using JSystem.Param;
using JSystem.Device;
using Meas2D;
using HalconDotNet;
using Meas2D.Tool;

namespace JSystem.Station
{
    public class TestStation : StationBase
    {
        public enum EStationStep
        {
            等待测试,
            拍照定位,
            滚压,
            按压,
            测试完成,
            等待出站,
        }
        
        public Action<int, string, List<double>[]> OnSendPressDada;

        public Action<TimeSpan> OnSendCT;

        public Meas2DManager Meas2DMgr = new Meas2DManager();

        private string _cave = "";

        private string _currSN = "";

        public TestStation(string cave)
        {
            _cave = cave;
            Name = $"{_cave}测试工站";
        }

        public override void Run()
        {
            try
            {
                MesSys mes = (MesSys)OnGetDevice("Mes系统");
                DateTime start = DateTime.Now;
                double[] offset = null;
                string dec = "";
                while (State != EStationState.END)
                {
                    Thread.Sleep(10);
                    if (State != EStationState.RUNNING) continue;
                    switch (Step)
                    {
                        case (int)EStationStep.等待测试:
                            if (OnGetStation("搬运工站").Step == (int)TransferStation.EStationStep.放生料完成 && SNQueue.Count != 0)
                            {
                                _currSN = SNQueue.Dequeue();
                                AddLog($"产品{_currSN}进站");
                                if (ParamManager.GetStringParam("设备类型") == "滚压")
                                    JumpStep((int)EStationStep.拍照定位);
                                else
                                    JumpStep((int)EStationStep.按压);
                            }
                            break;
                        case (int)EStationStep.拍照定位:
                            {
                                if (!GrabImage(_currSN, out offset)) break;
                                JumpStep((int)EStationStep.滚压);
                            }
                            break;
                        case (int)EStationStep.滚压:
                            {
                                dec = RollPressing() ? "PASS" : "FAIL";
                                start = DateTime.Now;
                                AddLog($"产品{_currSN}检测结果为{dec}");
                                if (!GoHome($"{_cave}测试Z轴")) break;
                                JumpStep((int)EStationStep.测试完成);
                            }
                            break;
                        case (int)EStationStep.按压:
                            {
                                dec = DirectPressing() ? "PASS" : "FAIL";
                                start = DateTime.Now;
                                AddLog($"产品{_currSN}检测结果为{dec}");
                                if (!GoHome($"{_cave}测试Z轴")) break;
                                JumpStep((int)EStationStep.测试完成);
                            }
                            break;
                        case (int)EStationStep.测试完成:
                            {
                                PointPos point = OnGetPoint($"取{_cave}穴熟料位");
                                if (!MoveToPos(point[$"{_cave}测试Y轴"]))
                                    break;
                                JumpStep((int)EStationStep.等待出站);
                            }
                            break;
                        case (int)EStationStep.等待出站:
                            if (OnGetStation("搬运工站").Step == (int)TransferStation.EStationStep.取熟料完成)
                            {
                                AddLog($"产品{_currSN}已被取走");
                                _currSN = "";
                                OnGetStation("搬运工站").DecQueue.Enqueue(dec);
                                Delay(200);
                                JumpStep((int)EStationStep.等待测试);
                            }
                            break;
                        default:
                            return;
                    }
                }
                AddLog("退出主线程");
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "4001", Name, $"主流程发生异常：{ex.Message}", true);
            }
        }
        
        public override void JumpStep(int step)
        {
            AddLog($"跳转到步骤：{(EStationStep)step}");
            base.JumpStep(step);
        }

        public bool RollPressing()
        {
            StationAxis axis = OnGetAxis("下压轴");
            Board board = (Board)OnGetDevice(axis.BoardName);
            PointPos point = OnGetPoint($"{_cave}穴下压极限位");
            point["下压轴"].Enabled = false;
            if (!MoveToPoint(point)) return false;
            AxisCoord coord = point["下压轴"];
            RollPressSensor sensor = (RollPressSensor)OnGetDevice("压力传感器");
            List<double>[] weightList = new List<double>[1];
            weightList[0] = new List<double>();
            bool isReach = false;
            DateTime holdStart = DateTime.Now;
            DateTime start = DateTime.Now;
        MOVE:
            while (State == EStationState.PAUSE)
                Thread.Sleep(10);
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
            while (true)
            {
                Thread.Sleep(5);
                if (State == EStationState.PAUSE) goto MOVE;
                if (State == EStationState.END) return false;
                if (!isReach && !board.CheckIsStop(axis.AxisIndex))
                {
                    AddLog($"已到达设定的下压极限位，但仍未到达压力下限");
                    return false;
                }
                double weight = sensor.ReadPressure();
                weightList[0].Add(weight);
                if (!isReach && weight > ParamManager.GetDoubleParam("压力设定值"))
                {
                    holdStart = DateTime.Now;
                    isReach = true;
                    board.Stop(axis.AxisIndex);
                    AddLog("到达设定压力值");
                    break;
                }
            }
            bool endMove = false;
            new Task(() =>
            {
                while (!endMove)
                {
                    Thread.Sleep(5);
                    if (State == EStationState.PAUSE) continue;
                    if (State == EStationState.END) return;
                    double weight = sensor.ReadPressure();
                    weightList[0].Add(weight);
                }
            }).Start();
            for (int i = 0; i < ParamManager.GetIntParam("滚压次数"); i++)
            {
                if (!MoveToPoint(OnGetPoint($"{_cave}穴滚压起始位")))
                    return false;
                if (!MoveToPoint(OnGetPoint($"{_cave}穴滚压终止位")))
                    return false;
            }
            endMove = true;
            OnSendPressDada(_cave == "左" ? 0 : 1, _currSN, weightList);
            return true;
        }

        public bool DirectPressing()
        {
            SetOut($"{_cave}穴压合气缸上升", false);
            SetOut($"{_cave}穴压合气缸下降", true);
            Barometer barometer = (Barometer)OnGetDevice($"{_cave}气压比例阀");
            DirectPressSensor sensor = (DirectPressSensor)OnGetDevice($"{_cave}直压压力传感器");
            ushort currBarometer = 60;
            barometer.SetPressure(currBarometer);
            if (!GetIn($"{_cave}穴压合气缸降到位", true, 10000))
                return false;
            List<double>[] weightList = new List<double>[6];
            for (int i = 0; i < 6; i++)
                weightList[i] = new List<double>();
            bool isReach = false;
            DateTime holdStart = DateTime.Now;
            DateTime start = DateTime.Now;
        MOVE:
            while (State == EStationState.PAUSE)
                Thread.Sleep(10);
            if (State == EStationState.END) return false;
            while (true)
            {
                if (State == EStationState.PAUSE) goto MOVE;
                if (State == EStationState.END) return false;
                if (!isReach && currBarometer >= ParamManager.GetDoubleParam("气压比例阀允许最大值"))
                {
                    AddLog($"{_cave}气压比例阀已到达允许最大值，但仍未到达压力下限");
                    return false;
                }
                double[] pressure = sensor.ReadPressure();
                for (int i = 0; i < 6; i++)
                    weightList[i].Add(pressure[i]);
                if (!isReach)
                {
                    if (pressure[2] < ParamManager.GetDoubleParam("设定压力值"))
                    {
                        holdStart = DateTime.Now;
                        isReach = true;
                        AddLog("到达设定压力值");
                    }
                    else
                    {
                        currBarometer += 10;
                        barometer.SetPressure(currBarometer);
                        Thread.Sleep(200);
                    }
                }
                if (isReach && DateTime.Now.Subtract(holdStart).TotalSeconds > ParamManager.GetIntParam("保压时间(s)"))
                {
                    OnSendPressDada(_cave == "左" ? 0 : 1, _currSN, weightList);
                    AddLog("保压完成");
                    barometer.SetPressure(0);
                    SetOut($"{_cave}穴压合气缸上升", true);
                    SetOut($"{_cave}穴压合气缸下降", false);
                    if (!GetIn($"{_cave}穴压合气缸升到位", true, 6000))
                        return false;
                    return true;
                }
            }
        }

        public bool GrabImage(string sn, out double[] pos)
        {
            pos = null;
            try
            {
                LightController light = (LightController)OnGetDevice($"{_cave}工位光源");
                light.SetLightness(1, 255);
                if (!MoveToPoint(OnGetPoint($"{_cave}穴拍照位")))
                    return false;
                Thread.Sleep(500);
                Camera2D cam = (Camera2D)OnGetDevice($"{_cave}工位相机");
            GRAB:
                if (State == EStationState.END)
                    return false;
                cam.GrabImageRGB(out HImage img);
                if (img == null)
                {
                    OnShowPopup(EPopupType.EMERGENCY, "6004", Name, $"拍照发生异常，图像为空，可以尝试重启相机", true);
                    return false;
                }
                Meas2DMgr.SaveImage(img, sn);
                Meas2DMgr.UpdateImage(img);
                Thread.Sleep(300);
                pos = ((PointPosTool2DModel)Meas2DMgr.ToolMgr.GetTools().Find((t) => t.Name.Contains("点点中心"))).Pos;
                if (pos == null || Math.Abs(pos[0]) > 8 || Math.Abs(pos[1]) > 8)
                {
                    DialogResult ret = OnShowPopup(EPopupType.ALARM, "6006", Name, $"视觉定位偏差过大，请将产品摆放正确以后点击重试", true);
                    if (ret == DialogResult.Retry)
                        goto GRAB;
                    else
                        return false;
                }
                AddLog($"产品{sn}偏移量为{pos[0]}, {pos[1]}");
                light.SetLightness(1, 0);
                return true;
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "6004", Name, $"拍照发生异常：{ex.Message}", true);
                return false;
            }
        }

        public void Calib()
        {
            try
            {
                Camera2D cam = (Camera2D)OnGetDevice($"{_cave}工位相机");
                SetOut("工位2光源", true);
                if (!cam.CheckConnection())
                {
                    OnShowPopup(EPopupType.ALARM, "", Name, "相机未连接", true);
                    return;
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        PointPos pointShot = OnGetPoint("拍照位");
                        if (!MoveToPos(pointShot["工位2Z轴"])) return;
                        pointShot["工位2X轴"].Pos -= (1 - j) * 1;
                        pointShot["工位2Y轴"].Pos -= (1 - i) * 1;
                        if (!MoveToPoint(pointShot))
                            return;
                        Thread.Sleep(1000);
                        ((Camera2D)OnGetDevice("Camera")).GrabImage(out HImage image);
                        Meas2DMgr.UpdateImage(image);
                        Meas2DMgr.SaveImage(image);
                    }
                }
                SetOut("工位2光源", false);
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.ALARM, "3006", Name, $"拍照发生异常：{ex.Message}", true);
            }
        }
    }
}
