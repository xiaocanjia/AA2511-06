using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSystem.Device;
using JSystem.IO;
using JSystem.Param;
using Sunny.UI;

namespace JSystem.Perform
{
    public partial class StatusPanel : UserControl
    {
        private DeviceManager _manager;

        private bool _isTwinkle = false;

        private UILabel[] _lbs = null;

        public StatusPanel()
        {
            InitializeComponent();
            _lbs = new UILabel[] { Lb_UnInit, Lb_Initing, Lb_Inited, Lb_Run, Lb_Pause, Lb_PauseAlarm, Lb_Alarm };
        }

        public void Init(DeviceManager manager)
        {
            _manager = manager;
            for (int i = 0; i < manager.DeviceList.Count; i++)
            {
                DevStatusPanel panel = manager.DeviceList[i].StatusPanel;
                panel.Name = manager.DeviceList[i].Name;
                Panel_State.Controls.Add(panel);
            }
        }

        public void UpdateState(EDeviceState state, int red, int yellow, int green, int buzzer)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { UpdateState(state, red, yellow, green, buzzer); }));
            }
            else
            {
                _lbs[(int)state].BringToFront();
                if (_isTwinkle == true)
                {
                    _isTwinkle = false;
                    Thread.Sleep(100);
                }
                new Task(() =>
                {
                    try
                    {
                        SwitchLed("红灯", red);
                        SwitchLed("黄灯", yellow);
                        SwitchLed("绿灯", green);
                        if (!ParamManager.GetBoolParam("禁用蜂鸣器"))
                            SwitchLed("蜂鸣器", buzzer);
                    }
                    catch { }
                }).Start();
            }
        }

        private void SwitchLed(string name, int state)
        {
            switch (state)
            {
                case 0:
                    _manager.OnSetOut(name, false);
                    Thread.Sleep(50);
                    break;
                case 1:
                    _manager.OnSetOut(name, true);
                    Thread.Sleep(50);
                    break;
                case 2:
                    _isTwinkle = true;
                    bool flag = true;
                    DateTime start = DateTime.Now;
                    _manager.OnSetOut(name, flag);
                    new Task(() =>
                    {
                        while (true)
                        {
                            Thread.Sleep(50);
                            if (!_isTwinkle)
                                return;
                            if (DateTime.Now.Subtract(start).TotalMilliseconds > 500)
                            {
                                start = DateTime.Now;
                                flag = !flag;
                                _manager.OnSetOut(name, flag);
                            }
                        }
                    }).Start();
                    break;
            }
        }
    }
}
