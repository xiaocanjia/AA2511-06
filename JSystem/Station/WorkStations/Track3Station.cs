using JSystem.IO;
using JSystem.Perform;
using System;
using System.Threading;

namespace JSystem.Station
{
    public class Track3Station : StationBase
    {
        public enum EStationStep
        {
            等待来料,
            复位气缸,
            出站,
        }

        private string _track = "";

        public Track3Station(string track)
        {
            _track = track;
            Name = $"{track}3工站";
        }

        public override void Run()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(10);
                    if (State == EStationState.END) return;
                    else if (State != EStationState.RUNNING) continue;
                    switch (Step)
                    {
                        case (int)EStationStep.等待来料:
                            if (OnGetStation($"搬运工站").Step == (int)TransferStation.EStationStep.放熟料完成)
                            {
                                if (!OnGetIn($"{_track}3感应有料1") || !OnGetIn($"{_track}3感应有料2") ||
                                    !OnGetIn($"{_track}3顶板有料1") || !OnGetIn($"{_track}3顶板有料2"))
                                {
                                    OnShowPopup(EPopupType.ALARM, "6006", Name, $"{_track}3有料感应状态异常", true);
                                    break;
                                }
                                AddLog("产品进站");
                                JumpStep((int)EStationStep.复位气缸);
                            }
                            break;
                        case (int)EStationStep.复位气缸:
                            {
                                Delay(500);
                                SetOut($"{_track}3侧推缸", false);
                                SetOut($"{_track}3定位缸", false);
                                if (!GetIn($"{_track}3侧推缸缩到位", true, 3000) || !GetIn($"{_track}3定位缸缩到位", true, 3000))
                                    break;
                                SetOut($"{_track}3顶升缸上升", false);
                                SetOut($"{_track}3顶升缸下降", true);
                                if (!GetIn($"{_track}3顶升缸降到位", true, 3000))
                                    break;
                                JumpStep((int)EStationStep.出站);
                            }
                            break;
                        case (int)EStationStep.出站:
                            if (!OnGetIn($"{_track}4感应有料1") && !OnGetIn($"{_track}4感应有料2") &&
                                OnGetStation($"{_track}4工站").Step != (int)Track1Station.EStationStep.出站)
                            {
                                SetOut($"{_track}3阻挡缸上升", false);
                                SetOut($"{_track}3阻挡缸下降", true);
                                if (!GetIn($"{_track}3阻挡缸降到位1", true, 3000) || !GetIn($"{_track}3阻挡缸降到位2", true, 3000))
                                    break;
                                if (!MoveBelt($"{_track}3", $"{_track}4"))
                                    break;
                                SetOut($"{_track}3阻挡缸上升", true);
                                SetOut($"{_track}3阻挡缸下降", false);
                                if (!GetIn($"{_track}3阻挡缸升到位1", true, 3000) || !GetIn($"{_track}3阻挡缸升到位2", true, 3000))
                                    break;
                                JumpStep((int)EStationStep.等待来料);
                            }
                            break;
                        default:
                            return;
                    }
                }
            }
            catch (Exception ex)
            {
                OnShowPopup(EPopupType.EMERGENCY, "4001", Name, $"主流程发生异常：{ex.Message}", true);
            }
        }

        public override void End()
        {
            SetOut($"{_track}3皮带启动", false);
            base.End();
        }

        public override void Pause()
        {
            SetOut($"{_track}3皮带启动", false);
            base.Pause();
        }

        public override bool Reset()
        {
            State = EStationState.RESETING;
            SetOut($"{_track}3阻挡缸下降", false);
            SetOut($"{_track}3阻挡缸上升", true);
            SetOut($"{_track}3顶升缸下降", true);
            SetOut($"{_track}3顶升缸上升", false);
            SetOut($"{_track}3定位缸", false);
            SetOut($"{_track}3侧推缸", false);
            if (!GetIn($"{_track}3阻挡缸升到位1", true, 3000) || !GetIn($"{_track}3阻挡缸升到位2", true, 3000) ||
                !GetIn($"{_track}3顶升缸降到位", true, 3000) || !GetIn($"{_track}3定位缸缩到位", true, 3000) ||
                !GetIn($"{_track}3侧推缸缩到位", true, 3000))
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
