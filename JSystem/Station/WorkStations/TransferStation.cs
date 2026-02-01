using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using HalconDotNet;
using JSystem.Device;
using JSystem.Perform;
using Meas2D;
using Meas2D.Tool;
using JSystem.Param;

namespace JSystem.Station
{
    public class TransferStation : StationBase
    {
        public enum EStationStep
        {
            等待进料,
            移动到取料安全位,
            拍照,
            取生料,
            等待测试完成,
            取熟料,
            取熟料完成,
            移动到放料安全位,
            放生料,
            放生料完成,
            放熟料,
            放熟料完成,
        }

        public Action<int, HImage> OnDispImage;

        public Meas2DManager Meas2DMgrA = new Meas2DManager();

        public Meas2DManager Meas2DMgrB = new Meas2DManager();

        private Dictionary<string, Meas2DManager> MeasDict = new Dictionary<string, Meas2DManager>();

        private Camera2D _cam;

        public TransferStation()
        {
            Name = "搬运工站";
        }

        public override void Run()
        {
            try
            {
                string currSN = "";
                string track = "";
                string cave = "";
                while (true)
                {
                    Thread.Sleep(10);
                    if (State == EStationState.END) return;
                    else if (State != EStationState.RUNNING) continue;
                    switch (Step)
                    {
                        case (int)EStationStep.等待进料:
                            if (OnGetStation("A2工站").Step == (int)Track2Station.EStationStep.等待取料)
                            {
                                AddLog("A轨产品进站");
                                track = "A";
                                JumpStep((int)EStationStep.移动到取料安全位);
                                break;
                            }
                            if (OnGetStation("B2工站").Step == (int)Track2Station.EStationStep.等待取料)
                            {
                                AddLog("B轨产品进站");
                                track = "B";
                                JumpStep((int)EStationStep.移动到取料安全位);
                                break;
                            }
                            if (OnGetStation("左测试工站").Step == (int)TestStation.EStationStep.等待出站)
                            {
                                cave = "左";
                                AddLog("取料位没料，先取左测试位熟料");
                                JumpStep((int)EStationStep.取熟料);
                                break;
                            }
                            if (OnGetStation("右测试工站").Step == (int)TestStation.EStationStep.等待出站)
                            {
                                cave = "右";
                                AddLog("取料位没料，先取右测试位熟料");
                                JumpStep((int)EStationStep.取熟料);
                                break;
                            }
                            break;
                        case (int)EStationStep.移动到取料安全位:
                            {
                                PointPos point = OnGetPoint("取料安全位");
                                if (!MoveToPos(point["搬运Z轴"])) break;
                                point["搬运R轴"].Enabled = false;
                                if (!MoveToPoint(point)) break;
                                if (!MoveToPos(point["搬运R轴"])) break;
                                JumpStep((int)EStationStep.拍照);
                            }
                            break;
                        case (int)EStationStep.拍照:
                            {
                                currSN = SNQueue.Dequeue();
                                if (!GrabImage(currSN, track)) break;
                                JumpStep((int)EStationStep.取生料);
                            }
                            break;
                        case (int)EStationStep.取生料:
                            {
                                PointPos point = OnGetPoint($"取{track}轨生料位");
                                point["搬运Z轴"].Enabled = false;
                                if (!MoveToPoint(point)) break;
                                if (!MoveToPos(point["搬运Z轴"])) break;
                                if (!SwitchGripper("生料", true)) break;
                                if (!MoveToPoint(OnGetPoint("安全高度"))) break;
                                JumpStep((int)EStationStep.等待测试完成);
                            }
                            break;
                        case (int)EStationStep.等待测试完成:
                            if (OnGetStation("左测试工站").Step == (int)TestStation.EStationStep.等待测试)
                            {
                                cave = "左";
                                JumpStep((int)EStationStep.移动到放料安全位);
                                break;
                            }
                            if (OnGetStation("左测试工站").Step == (int)TestStation.EStationStep.等待出站)
                            {
                                cave = "左";
                                JumpStep((int)EStationStep.取熟料);
                                break;
                            }
                            if (OnGetStation("右测试工站").Step == (int)TestStation.EStationStep.等待测试)
                            {
                                cave = "右";
                                JumpStep((int)EStationStep.移动到放料安全位);
                                break;
                            }
                            if (OnGetStation("右测试工站").Step == (int)TestStation.EStationStep.等待出站)
                            {
                                cave = "右";
                                JumpStep((int)EStationStep.取熟料);
                                break;
                            }
                            break;
                        case (int)EStationStep.取熟料:
                            {
                                if (!MoveToPoint(OnGetPoint("安全高度"))) break;
                                PointPos point = OnGetPoint($"取{cave}穴熟料位");
                                point["搬运Z轴"].Enabled = false;
                                if (!MoveToPoint(point)) break;
                                if (!MoveToPos(point["搬运Z轴"])) break;
                                if (!SwitchGripper("熟料", true)) break;
                                if (!MoveToPoint(OnGetPoint("安全高度"))) break;
                                JumpStep((int)EStationStep.移动到放料安全位);
                            }
                            break;
                        case (int)EStationStep.移动到放料安全位:
                            {
                                PointPos point = OnGetPoint("放料安全位");
                                if (!MoveToPos(point["搬运Z轴"])) break;
                                point["搬运R轴"].Enabled = false;
                                if (!MoveToPoint(point)) break;
                                if (!MoveToPos(point["搬运R轴"])) break;
                                JumpStep((int)EStationStep.取熟料完成);
                            }
                            break;
                        case (int)EStationStep.取熟料完成:
                            {
                                Delay(100);
                                if (OnGetIn("生料夹爪夹到位"))
                                    JumpStep((int)EStationStep.放生料);
                                else
                                    JumpStep((int)EStationStep.放熟料);
                            }
                            break;
                        case (int)EStationStep.放生料:
                            {
                                PointPos point = OnGetPoint($"放{cave}穴生料位");
                                point["搬运Z轴"].Enabled = false;
                                if (!MoveToPoint(point)) break;
                                if (!MoveToPos(point["搬运Z轴"])) break;
                                if (!SwitchGripper("生料", false)) break;
                                if (!MoveToPoint(OnGetPoint("安全高度"))) break;
                                OnGetStation($"{cave}测试工站").SNQueue.Enqueue(currSN);
                                JumpStep((int)EStationStep.放生料完成);
                            }
                            break;
                        case (int)EStationStep.放生料完成:
                            {
                                AddLog($"产品{currSN}出站");
                                if (OnGetIn("熟料夹爪夹到位"))
                                    JumpStep((int)EStationStep.放熟料);
                                else
                                    JumpStep((int)EStationStep.等待进料);
                            }
                            break;
                        case (int)EStationStep.放熟料:
                            {
                                if (OnGetStation("A3工站").Step == (int)Track3Station.EStationStep.等待来料)
                                    track = "A";
                                else if (OnGetStation("B3工站").Step == (int)Track3Station.EStationStep.等待来料)
                                    track = "B";
                                else
                                    break;
                                if (OnGetIn($"{track}3顶板有料1") || OnGetIn($"{track}3顶板有料2") ||
                                    OnGetIn($"{track}3阻挡缸降到位1") || OnGetIn($"{track}3阻挡缸降到位2"))
                                {
                                    OnShowPopup(EPopupType.ALARM, "6006", Name, $"{track}3有料感应或者阻挡缸状态异常", true);
                                    break;
                                }
                                PointPos point = OnGetPoint($"放{track}轨熟料位");
                                point["搬运Z轴"].Enabled = false;
                                if (!MoveToPoint(point)) break;
                                if (!MoveToPos(point["搬运Z轴"])) break;
                                if (!SwitchGripper("熟料", false)) break;
                                if (!MoveToPos(OnGetPoint("取料安全位")["搬运Z轴"])) break;
                                string dec = DecQueue.Dequeue();
                                if (dec == "FAIL")
                                {
                                    OnShowPopup(EPopupType.CONFIRM, "6010", Name, $"当前产品测试结果FAIL", true);
                                    JumpStep((int)EStationStep.等待进料);
                                    break;
                                }
                                JumpStep((int)EStationStep.放熟料完成);
                            }
                            break;
                        case (int)EStationStep.放熟料完成:
                            {
                                Thread.Sleep(100);
                                JumpStep((int)EStationStep.等待进料);
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "6001", Name, $"主流程发生异常：{ex.Message}", true);
            }
        }

        public bool SwitchGripper(string gripper, bool isOn)
        {
            SetOut($"{gripper}升降缸下降", true);
            SetOut($"{gripper}升降缸上升", false);
            if (!GetIn($"{gripper}升降缸降到位", true, 2000))
                return false;
            Thread.Sleep(100);
            SetOut($"{gripper}夹爪夹紧", isOn ? true : false);
            SetOut($"{gripper}夹爪松开", isOn ? false : true);
            if (!GetIn($"{gripper}夹爪夹到位", isOn, 2000) && !GetIn($"{gripper}夹爪松到位", !isOn, 2000))
                return false;
            Thread.Sleep(100);
            SetOut($"{gripper}升降缸下降", false);
            SetOut($"{gripper}升降缸上升", true);
            if (!GetIn($"{gripper}升降缸升到位", true, 2000))
                return false;
            return true;
        }

        public bool GrabImage(string sn, string track)
        {
            try
            {
                MeasDict.Clear();
                MeasDict.Add("A", Meas2DMgrA);
                MeasDict.Add("B", Meas2DMgrB);
                LightController controller = (LightController)OnGetDevice("上料光源");
                controller.SetLightness(1, 255);
                PointPos pointShot = OnGetPoint($"{track}轨拍照位");
                if (!MoveToPos(pointShot["搬运Z轴"]))
                    return false;
                if (!MoveToPos(pointShot["搬运X轴"]))
                    return false;
                if (!MoveToPos(pointShot["搬运Y轴"]))
                    return false;
                Thread.Sleep(500);
                _cam = (Camera2D)OnGetDevice($"上料相机");
            GRAB:
                if (State == EStationState.END)
                    return false;
                _cam.GrabImageRGB(out HImage img);
                if (img == null)
                {
                    OnShowPopup(EPopupType.EMERGENCY, "6004", Name, $"拍照发生异常，图像为空，可以尝试重启相机", true);
                    return false;
                }
                MeasDict[track].SaveImage(img, sn);
                OnDispImage(0, img);
                MeasDict[track].UpdateImage(img);
                Thread.Sleep(300);
                double[] pos = ((PointPosTool2DModel)MeasDict[track].ToolMgr.GetTools().Find((t) => t.Name.Contains("点点中心"))).Pos;
                if (pos == null || Math.Abs(pos[0]) > 8 || Math.Abs(pos[1]) > 8)
                {
                    DialogResult ret = OnShowPopup(EPopupType.ALARM, "6006", Name, $"视觉定位偏差过大，请将产品摆放正确以后点击重试", true);
                    if (ret == DialogResult.Retry)
                        goto GRAB;
                    else
                        return false;
                }
                AddLog($"产品{sn}偏移量为{pos[0]}, {pos[1]}");
                controller.SetLightness(1, 0);
                return true;
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "6004", Name, $"拍照发生异常：{ex.Message}", true);
                return false;
            }
        }

        public override bool Reset()
        {
            State = EStationState.RESETING;
            if (ParamManager.GetStringParam("设备类型") == "直压")
            {
                ((Barometer)OnGetDevice($"左气压比例阀")).SetPressure(0);
                ((Barometer)OnGetDevice($"右气压比例阀")).SetPressure(0);
                SetOut($"左穴压合气缸上升", true);
                SetOut($"左穴压合气缸下降", false);
                if (!GetIn($"左穴压合气缸升到位", true, 3000))
                    return false;
                SetOut($"右穴压合气缸上升", true);
                SetOut($"右穴压合气缸下降", false);
                if (!GetIn($"右穴压合气缸升到位", true, 3000))
                    return false;
            }
            if (!GoHome(new string[] { "搬运Z轴", "左测试Z轴", "右测试Z轴" }))
                return false;
            if (!GoHome(new string[] { "搬运X轴", "左测试X轴", "左测试Y轴", "右测试X轴", "右测试Y轴" }))
                return false;
            if (!GoHome(new string[] { "搬运Y轴" }))
                return false;
            if (!GoHome(new string[] { "搬运R轴" }))
                return false;
            JumpStep((int)EStationStep.等待进料);
            State = EStationState.RESETED;
            return base.Reset();
        }

        public override void JumpStep(int step)
        {
            AddLog($"跳转到步骤：{(EStationStep)step}");
            base.JumpStep(step);
        }
    }
}
