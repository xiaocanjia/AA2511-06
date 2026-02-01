using System;
using System.Threading;
using JSystem.Param;
using JSystem.Perform;

namespace JSystem.Station
{
    public class Track2Station : StationBase
    {
        public enum EStationStep
        {
            等待来料,
            顶升,
            等待取料,
            移动治具到皮带3
        }

        private string _track = "";

        public Track2Station(string track)
        {
            _track = track;
            Name = $"{track}2工站";
        }

        public override void Run()
        {
            try
            {
                string currSN = "";
                while (true)
                {
                    Thread.Sleep(10);
                    if (State == EStationState.END) return;
                    else if (State != EStationState.RUNNING) continue;
                    switch (Step)
                    {
                        case (int)EStationStep.等待来料:
                            if (OnGetIn($"{_track}2感应有料1") && OnGetIn($"{_track}2感应有料2") &&
                                OnGetStation($"{_track}1工站").Step != (int)Track1Station.EStationStep.出站)
                            {
                                currSN = SNQueue.Dequeue();
                                JumpStep((int)EStationStep.顶升);
                            }
                            break;
                        case (int)EStationStep.顶升:
                            {
                                SetOut($"{_track}2顶升缸上升", true);
                                SetOut($"{_track}2顶升缸下降", false);
                                if (!GetIn($"{_track}2顶升缸升到位", true, 3000))
                                    break;
                                SetOut($"{_track}2侧推缸", true);
                                SetOut($"{_track}2定位缸", true);
                                if (!GetIn($"{_track}2侧推缸伸到位", true, 3000) || !GetIn($"{_track}2定位缸伸到位", true, 3000))
                                    break;
                                if (!GetIn($"{_track}2顶板有料1", true, 3000) || !GetIn($"{_track}2顶板有料2", true, 3000))
                                    break;
                                OnGetStation("搬运工站").SNQueue.Enqueue(currSN);
                                JumpStep((int)EStationStep.等待取料);
                            }
                            break;
                        case (int)EStationStep.等待取料:
                            if (OnGetStation($"搬运工站").Step != (int)TransferStation.EStationStep.等待测试完成 && 
                                !OnGetIn($"{_track}2感应有料1") && !OnGetIn($"{_track}2感应有料2") &&
                                !OnGetIn($"{_track}2顶板有料1") || !OnGetIn($"{_track}2顶板有料2"))
                            {
                                AddLog("产品已取走");
                                SetOut($"{_track}2侧推缸", false);
                                SetOut($"{_track}2定位缸", false);
                                if (!GetIn($"{_track}2侧推缸缩到位", true, 3000) || !GetIn($"{_track}2定位缸缩到位", true, 3000))
                                    break;
                                SetOut($"{_track}2顶升缸上升", false);
                                SetOut($"{_track}2顶升缸下降", true);
                                if (!GetIn($"{_track}2顶升缸降到位", true, 3000))
                                    break;
                                if (ParamManager.GetBoolParam("产品夹具分离"))
                                    JumpStep((int)EStationStep.移动治具到皮带3);
                                else
                                    JumpStep((int)EStationStep.等待来料);
                            }
                            break;
                        case (int)EStationStep.移动治具到皮带3:
                            if (OnGetStation($"{_track}3工站").Step == (int)Track3Station.EStationStep.等待来料)
                            {
                                if (!MoveBelt($"{_track}2", $"{_track}3"))
                                    break;
                                JumpStep((int)EStationStep.等待来料);
                            }
                            break;
                        default:
                            return;
                    }
                    AddLog("流程已退出");
                }
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "3001", Name, $"主流程发生异常：{ex.Message}", true);
            }
        }

        public override void End()
        {
            SetOut($"{_track}2皮带启动", false);
            base.End();
        }

        public override void Pause()
        {
            SetOut($"{_track}2皮带启动", false);
            base.Pause();
        }

        public override bool Reset()
        {
            State = EStationState.RESETING;
            SetOut($"{_track}2阻挡缸下降", false);
            SetOut($"{_track}2阻挡缸上升", true);
            SetOut($"{_track}2顶升缸下降", true);
            SetOut($"{_track}2顶升缸上升", false);
            SetOut($"{_track}2定位缸", false);
            SetOut($"{_track}2侧推缸", false);
            if (!GetIn($"{_track}2阻挡缸升到位1", true, 3000) || !GetIn($"{_track}2阻挡缸升到位2", true, 3000) ||
                !GetIn($"{_track}2顶升缸降到位", true, 3000) || !GetIn($"{_track}2定位缸缩到位", true, 3000) ||
                !GetIn($"{_track}2侧推缸缩到位", true, 3000))
                return false;
            JumpStep((int)EStationStep.等待来料);
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
