using System;
using System.Threading;
using JSystem.Device;
using JSystem.Perform;

namespace JSystem.Station
{
    public class Track1Station : StationBase
    {
        public enum EStationStep
        {
            等待来料,
            扫码,
            出站
        }

        private string _track = "";

        public Track1Station(string track)
        {
            _track = track;
            Name = $"{track}1工站";
        }

        public override void Run()
        {
            try
            {
                bool isRequred = false;
                while (true)
                {
                    Thread.Sleep(10);
                    if (State == EStationState.END) return;
                    else if (State != EStationState.RUNNING) continue;
                    switch (Step)
                    {
                        case (int)EStationStep.等待来料:
                            if (!isRequred && !OnGetIn($"{_track}1感应有料1") && !OnGetIn($"{_track}1感应有料2"))
                            {
                                SetOut($"{_track}轨要料信号", true);
                                isRequred = true;
                                break;
                            }
                            if (OnGetIn($"{_track}轨上游OK进料信号"))
                            {
                                isRequred = false;
                                SetOut($"{_track}轨要料信号", false);
                                if (!MoveBelt("", $"{_track}1"))
                                    break;
                                break;
                            }
                            if (OnGetIn($"{_track}1感应有料1") &&  OnGetIn($"{_track}1感应有料2") &&
                               !OnGetIn($"{_track}2感应有料1") && !OnGetIn($"{_track}2感应有料2") &&
                               !OnGetIn($"{_track}2顶板有料1") && !OnGetIn($"{_track}2顶板有料2"))
                            {
                                JumpStep((int)EStationStep.扫码);
                            }
                            break;
                        case (int)EStationStep.扫码:
                            {
                                string _currSN = "";
                                SerialScanningGun gun = (SerialScanningGun)OnGetDevice("扫码枪");
                                if (gun.IsEnable)
                                    _currSN = gun.ReadSN();
                                AddLog($"当前产品SN为{_currSN}");
                                if (_currSN == "")
                                {
                                    OnShowPopup(EPopupType.WARNING, "2002", Name, $"请检查产品放置是否有误后点击重试", true);
                                    break;
                                }
                                OnGetStation($"{_track}2工站").SNQueue.Enqueue(_currSN);
                                bool ret = ((MesSys)OnGetDevice("Mes系统")).Arrival(_currSN, out string msg);
                                AddLog(msg);
                                if (!ret)
                                {
                                    OnShowPopup(EPopupType.EMERGENCY, "2003", Name, $"站别错误", true);
                                    break;
                                }
                                JumpStep((int)EStationStep.出站);
                            }
                            break;
                        case (int)EStationStep.出站:
                            if (OnGetIn($"{_track}2阻挡缸升到位1") && OnGetIn($"{_track}2阻挡缸升到位2"))
                            {
                                AddLog($"产品进站");
                                SetOut($"{_track}1阻挡缸上升", false);
                                SetOut($"{_track}1阻挡缸下降", true);
                                if (!GetIn($"{_track}1阻挡缸降到位1", true, 3000) || !GetIn($"{_track}1阻挡缸降到位2", true, 3000))
                                    break;
                                if (!MoveBelt($"{_track}1", $"{_track}2"))
                                    break;
                                if (OnGetIn($"{_track}1感应有料2"))
                                {
                                    AddLog("感应到连板，设备已停止");
                                    break;
                                }
                                SetOut($"{_track}1阻挡缸上升", true);
                                SetOut($"{_track}1阻挡缸下降", false);
                                if (!GetIn($"{_track}1阻挡缸升到位1", true, 3000) || !GetIn($"{_track}1阻挡缸升到位2", true, 3000))
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
                OnShowPopup(EPopupType.EMERGENCY, "2001", Name, $"主流程发生异常：{ex.Message}", true);
            }
        }

        public override void End()
        {
            SetOut($"{_track}1皮带启动", false);
            base.End();
        }

        public override void Pause()
        {
            SetOut($"{_track}1皮带启动", false);
            base.Pause();
        }

        public override bool Reset()
        {
            State = EStationState.RESETING;
            SetOut($"{_track}1阻挡缸下降", false);
            SetOut($"{_track}1阻挡缸上升", true);
            if (!GetIn($"{_track}1阻挡缸升到位1", true, 3000) || !GetIn($"{_track}1阻挡缸升到位2", true, 3000))
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
