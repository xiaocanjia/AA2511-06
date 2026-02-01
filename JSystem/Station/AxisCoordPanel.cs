using System;
using System.Linq;
using System.Windows.Forms;
using JSystem.Device;
using Sunny.UI;

namespace JSystem.Station
{
    public partial class AxisCoordPanel : UserControl
    {
        private AxisCoord _coord = new AxisCoord();

        private StationManager _mgr;

        public AxisCoordPanel(AxisCoord coord, StationManager mgr)
        {
            _coord = coord;
            _mgr = mgr;
            InitializeComponent();
            foreach (StationAxis axis in mgr.Axes)
                CbB_Axes.Items.Add(axis.Name);
            CbB_Axes.Text = coord.Name;
            Tb_Pos.Text = coord.Pos.ToString();
            TB_Speed.Text = coord.Speed.ToString();
            TB_TimeOut.Text = coord.TimeOut.ToString();
        }

        public void TeachPos()
        {
            if (_mgr == null || _coord.Name == "" || _coord.Name == null) return;
            StationAxis axis = _mgr.Axes.First((a) => a.Name == _coord.Name);
            if (axis == null) return;
            Board board = (Board)_mgr.OnGetDevice(axis.BoardName);
            double pos = board.GetCmdPos(axis.AxisIndex) / axis.PlusePerUnit;
            Tb_Pos.Text = pos.ToString("F3");
            _coord.Pos = pos;
        }

        private void CbB_Axes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _coord.Name = CbB_Axes.Text;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                UpdateValue();
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            UITextBox tb = sender as UITextBox;
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
                _coord.Pos = Convert.ToDouble(Tb_Pos.Text);
                _coord.Speed = Convert.ToDouble(TB_Speed.Text);
                _coord.TimeOut = Convert.ToInt32(TB_TimeOut.Text);
            }
            catch
            {
                UIMessageBox.Show("参数格式填写错误，请检查！");
                return;
            }
        }

        private void Btn_MoveToPos_Click(object sender, EventArgs e)
        {
            if (_mgr.Axes == null || _coord.Name == "") return;
            StationAxis axis = _mgr.Axes.First((a) => a.Name == _coord.Name);
            if (axis == null) return;
            Board board = (Board)_mgr.OnGetDevice(axis.BoardName);
            board.SetSpeed(axis.AxisIndex, axis.MoveVelLPluse, axis.ManulVel * axis.PlusePerUnit, axis.MoveAccPluse, axis.MoveDccPluse);
            board.AbsMove(axis.AxisIndex, _coord.Pos * axis.PlusePerUnit);
        }
    }
}
