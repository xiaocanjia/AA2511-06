using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JSystem.Device;
using JSystem.Param;
using JSystem.User;
using Sunny.UI;

namespace JSystem.Station
{
    public partial class StationsPage : UIPage
    {
        private StationManager _manager;

        private List<AxisStatusPanel> _panelList = new List<AxisStatusPanel>();

        public StationsPage()
        {
            InitializeComponent();
        }

        public void Init(StationManager manager)
        {
            if (manager == null)
                return;
            _manager = manager;
            _manager.OnUpdateState = DispState;
            foreach (PointPos pos in _manager.PointsList)
                LBx_Points.Items.Add(pos.Name);
            foreach (StationAxis axis in _manager.Axes)
            {
                AxisStatusPanel panel = new AxisStatusPanel(manager, axis);
                panel.Refresh();
                Panel_Axes.Controls.Add(panel);
                _panelList.Add(panel);
            }
        }

        public void Refresh(bool isOn)
        {
            foreach (AxisStatusPanel panel in _panelList)
            {
                panel.IsDisp = isOn;
            }
        }

        public void UpdateUI()
        {
            LBx_Points.SelectedIndex = -1;
            Panel_Point_Axes.Controls.Clear();
        }

        public void SetEnabled(bool isEnabled)
        {
            bool enabled = isEnabled & (LoginForm.User != "操作员");
            Panel_Point_Axes.Enabled = enabled;
            Panel_Axes.Enabled = enabled;
            foreach (Control control in Controls)
            {
                if (control is UIButton)
                    control.Enabled = enabled;
            }
            if (enabled)
                _manager.State = EStationState.MANUAL;
        }

        private void Btn_Add_Axis_Click(object sender, EventArgs e)
        {
            if (LBx_Points.SelectedItem == null) return;
            AxisCoord pos = new AxisCoord();
            _manager.PointsList.Find((p) => p.Name == LBx_Points.SelectedItem.ToString()).AxesCoord.Add(pos);
            AxisCoordPanel panel = new AxisCoordPanel(pos, _manager);
            Panel_Point_Axes.Controls.Add(panel);
        }

        private void Btn_Remove_Axis_Click(object sender, EventArgs e)
        {
            if (LBx_Points.SelectedItem == null) return;
            List<AxisCoord> axesPos = _manager.PointsList.Find((p) => p.Name == LBx_Points.SelectedItem.ToString()).AxesCoord;
            if (axesPos.Count == 0) return;
            Panel_Point_Axes.Controls.RemoveAt(axesPos.Count - 1);
            axesPos.RemoveAt(axesPos.Count - 1);
        }

        private void Btn_Record_Click(object sender, EventArgs e)
        {
            if (LBx_Points.SelectedItem.ToString() == "") return;
            foreach (Control ctl in Panel_Point_Axes.Controls)
            {
                AxisCoordPanel panel = ctl as AxisCoordPanel;
                panel.TeachPos();
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            foreach (StationAxis axis in _manager.Axes)
                ((Board)_manager.OnGetDevice(axis.BoardName)).Stop(axis.AxisIndex);
        }

        private void CbB_MoveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbB_MoveType.Text != "Jog" && !double.TryParse(CbB_MoveType.Text, out double dist))
                CbB_MoveType.Text = "Jog";
            foreach (Control c in Panel_Axes.Controls)
            {
                AxisStatusPanel panel = c as AxisStatusPanel;
                if (panel == null) continue;
                panel.SetMoveType(CbB_MoveType.Text);
            }
        }

        private void LBx_Points_ItemClick(object sender, EventArgs e)
        {
            Panel_Point_Axes.Controls.Clear();
            foreach (AxisCoord coord in _manager.PointsList.Find((p) => p.Name == LBx_Points.SelectedItem.ToString()).AxesCoord)
            {
                AxisCoordPanel panel = new AxisCoordPanel(coord, _manager);
                Panel_Point_Axes.Controls.Add(panel);
            }
        }

        private void CbB_MoveType_TextChanged(object sender, EventArgs e)
        {
            if (CbB_MoveType.Text != "Jog" && !double.TryParse(CbB_MoveType.Text, out double dist))
                CbB_MoveType.Text = "Jog";
            foreach (Control c in Panel_Axes.Controls)
            {
                AxisStatusPanel panel = c as AxisStatusPanel;
                if (panel == null) continue;
                panel.SetMoveType(CbB_MoveType.Text);
            }
        }

        private void DispState()
        {
            if (InvokeRequired)
                BeginInvoke(new Action(() => { DispState(); }));
            else
            {
                if (!Visible)
                    return;
                foreach (AxisStatusPanel panel in _panelList)
                    panel.UpdateStatus();
            }
        }

        private void Btn_TestL_Click(object sender, EventArgs e)
        {
            TestStation testStnL = (TestStation)_manager.GetStation("左测试工站");
            if (ParamManager.GetStringParam("设备类型") == "滚压")
                testStnL.RollPressing();
            else
                testStnL.DirectPressing();
        }
    }
}
