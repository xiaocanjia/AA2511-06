using System;
using System.Windows.Forms;
using JLogging;
using JSystem.Device;
using JSystem.Perform;
using Sunny.UI;

namespace JSystem.Station
{
    public partial class AxisStatusPanel : UserControl
    {
        private StationManager _manager;

        private StationAxis _axis;

        private string _moveType = "Jog";

        public bool IsDisp = false;

        private byte _state = 255;

        public AxisStatusPanel() { }

        public AxisStatusPanel(StationManager manager, StationAxis axis)
        {
            InitializeComponent();
            _axis = axis;
            _manager = manager;
            Switch_Enable.Active = true;
            Switch_Enable.ValueChanged += new UISwitch.OnValueChanged(Switch_Enable_ValueChanged);
        }

        public override void Refresh()
        {
            base.Refresh();
            Lbl_Axis_Name.Text = _axis.Name;
        }

        public void SetEnable(bool isEnable)
        {
            Switch_Enable.Enabled = isEnable;
            foreach (Control control in Panel_Axis.Controls)
            {
                if (control is UIButton button)
                {
                    button.Enabled = isEnable;
                }
            }
        }

        public void SetMoveType(string type)
        {
            _moveType = type;
        }

        private void Switch_Enable_ValueChanged(object sender, bool value)
        {
            Board board = (Board)_manager.OnGetDevice(_axis.BoardName);
            board.SetAxisServoEnabled(_axis.AxisIndex, value);
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Board board = (Board)_manager.OnGetDevice(_axis.BoardName);
            board.GoHome(_axis.AxisIndex, _axis.HomeVelLPluse, _axis.HomeVelHPluse, _axis.HomeAccPluse, _axis.HomeDccPluse, _axis.HomeMode, _axis.HomeDir);
        }

        private void Btn_Move_Click(object sender, EventArgs e)
        {
            UISymbolButton btn = sender as UISymbolButton;
            if (_moveType == "Jog" || btn == null)
                return;
            string dir = btn.Symbol == 61544 ? "-" : "+";
            Board board = (Board)_manager.OnGetDevice(_axis.BoardName);
            board.SetSpeed(_axis.AxisIndex, _axis.MoveVelLPluse, _axis.ManulVel * _axis.PlusePerUnit, _axis.MoveAccPluse, _axis.MoveDccPluse);
            if (btn.Symbol == 61544)
                board.RelMove(_axis.AxisIndex, -Convert.ToDouble(_moveType));
            else if (btn.Symbol == 61543)
                board.RelMove(_axis.AxisIndex, Convert.ToDouble(_moveType));
            LogManager.Instance.AddLog("手动操作", $"点击{_axis.Name}轴相对运动{dir}{_moveType}", LogLevels.Debug);
        }

        private void Btn_Move_MouseDown(object sender, MouseEventArgs e)
        {
            UISymbolButton btn = sender as UISymbolButton;
            if (_moveType != "Jog" || btn == null)
                return;
            string dir = btn.Symbol == 61544 ? "负" : "正";
            Board board = (Board)_manager.OnGetDevice(_axis.BoardName);
            board.SetSpeed(_axis.AxisIndex, _axis.MoveVelLPluse, _axis.ManulVel * _axis.PlusePerUnit, _axis.MoveAccPluse, _axis.MoveDccPluse);
            board.JogMove(_axis.AxisIndex, btn.Symbol == 61543);
            LogManager.Instance.AddLog("手动操作", $"点击{_axis.Name}轴{dir}向连续运动", LogLevels.Debug);
        }

        private void Btn_Move_MouseUp(object sender, MouseEventArgs e)
        {
            UISymbolButton btn = sender as UISymbolButton;
            if (_moveType != "Jog" || btn == null)
                return;
            Board board = (Board)_manager.OnGetDevice(_axis.BoardName);
            board.Stop(_axis.AxisIndex);
        }

        private void Btn_Setup_Click(object sender, EventArgs e)
        {
            LogManager.Instance.AddLog("手动操作", $"打开{_axis.Name}轴配置按钮", LogLevels.Debug);
            AxisParamForm form = new AxisParamForm(_axis);
            form.ShowDialog();
        }

        public void UpdateStatus()
        {
            if (!Visible) return;
            Tb_CmdPos.Text = _axis.CmdPos.ToString("F3");
            Tb_ActPos.Text = _axis.ActPos.ToString("F3");
            if (_state != _axis.State)
            {
                _state = _axis.State;
                Light_PL.State = (_state & (0x01 << 1)) > 0 ? UILightState.On : UILightState.Off;
                Light_NL.State = (_state & (0x01 << 2)) > 0 ? UILightState.On : UILightState.Off;
                Light_Origin.State = (_state & (0x01 << 3)) > 0 ? UILightState.On : UILightState.Off;
                Light_Enabled.State = _axis.IsEnabled ? UILightState.On : UILightState.Off;
                Light_Alarm.State = _axis.IsAlarm ? UILightState.On : UILightState.Off;
                Light_Emg.State = _axis.IsEmergencyStop ? UILightState.On : UILightState.Off;
            }
            Application.DoEvents();
        }
    }
}
