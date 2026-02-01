using System;
using System.Threading;
using JSystem.Perform;

namespace JSystem.Station
{
    public class Track4Station : StationBase
    {
        public enum EStationStep
        {
            等待来料,
            出站
        }

        private string _track = "";

        public Track4Station(string track)
        {
            _track = track;
            Name = $"{track}4工站";
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
                            if (OnGetIn($"{_track}4感应有料1") && OnGetIn($"{_track}4感应有料2") &&
                                OnGetIn($"{_track}轨下游要料信号"))
                            {
                                JumpStep((int)EStationStep.出站);
                            }
                            break;
                        case (int)EStationStep.出站:
                            {
                                SetOut($"{_track}轨OK出料信号", true);
                                SetOut($"{_track}4皮带启动", true);
                                Thread.Sleep(5000);
                                SetOut($"{_track}4皮带启动", false);
                                SetOut($"{_track}轨OK出料信号", false);
                                if (!GetIn($"{_track}4感应有料1", false, 3000))
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
                OnShowPopup(EPopupType.EMERGENCY, "5001", Name, $"主流程发生异常：{ex.Message}", true);
            }
        }

        public override bool Reset()
        {
            State = EStationState.RESETING;
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
