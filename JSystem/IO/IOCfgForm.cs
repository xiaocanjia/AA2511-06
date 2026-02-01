using System;
using Sunny.UI;
using System.Collections.Generic;
using JSystem.Device;

namespace JSystem.IO
{
    public partial class IOCfgForm : UIForm
    {
        private IOManager _manager;

        private IOParam _param;

        public IOCfgForm()
        {
            InitializeComponent();
            ControlBox = false; //隐藏关闭按钮
            MaximizeBox = false; //隐藏最大化按钮
            MinimizeBox = false; //隐藏最小化按钮
        }

        public IOCfgForm(IOManager manager) : this()
        {
            _manager = manager;
        }

        public void Show(List<DeviceBase> boards, IOParam param)
        {
            _param = param;
            CbB_Board_Name.Items.Clear();
            foreach (DeviceBase b in boards)
                CbB_Board_Name.Items.Add(b.Name);
            if (CbB_Board_Name.Items.Contains(_param.BoardName))
                CbB_Board_Name.SelectedItem = _param.BoardName;
            else
                CbB_Board_Name.SelectedIndex = 0;
            Text = _param.Name;
            TB_Axis_Idx.Text = _param.AxisIndex.ToString();
            TB_Point_Idx.Text = _param.PointIndex.ToString();
            ShowDialog();
        }

        private void Btn_Apply_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TB_Axis_Idx.Text, out int axisIdx) ||
                !int.TryParse(TB_Point_Idx.Text, out int pointIdx))
            {
                UIMessageTip.ShowError($"请填入整型数据");
                return;
            }
            _param.BoardName = CbB_Board_Name.SelectedText;
            _param.AxisIndex = Convert.ToInt32(TB_Axis_Idx.Text);
            _param.PointIndex = Convert.ToInt32(TB_Point_Idx.Text);
            Hide();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
