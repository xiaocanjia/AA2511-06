using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using JSystem.User;
using Sunny.UI;
using System.Collections.Generic;

namespace JSystem.Param
{
    public partial class ParamPage : UIPage
    {
        private ParamManager _manager;

        private BasicParam[] _paramsArray;

        public ParamPage()
        {
            InitializeComponent();
        }

        public void Init(ParamManager manager)
        {
            foreach (string key in ParamManager.RetDict.Keys)
                CbB_Threshold.Items.Add(key);
            CbB_Threshold.SelectedIndex = 0;
            if (manager == null)
                return;
            _manager = manager;
            DGV_Param.Columns[0].DataPropertyName = "Name";
            DGV_Param.Columns[0].ReadOnly = true;
            DGV_Param.Columns[1].DataPropertyName = "Type";
            DGV_Param.Columns[1].Visible = false;
            DGV_Param.Columns[2].DataPropertyName = "Value";
            DGV_Param.Columns[3].DataPropertyName = "Right";
            DGV_Param.AllowUserToAddRows = false;
        }

        public void UpdateUI()
        {
            _paramsArray = _manager.ParamsArray.Where((p) => p.IsDisplay).ToArray();
            DGV_Param.DataSource = new BindingList<BasicParam>(_paramsArray);
        }

        public void SetEnabled(bool isEnabled)
        {
            for (int i = 0; i < _paramsArray.Length; i++)
            {
                if (LoginForm.User == "操作员")
                {
                    if (_paramsArray[i].Right == "操作员")
                    {
                        DGV_Results.ReadOnly = false;
                        DGV_Param.Rows[i].ReadOnly = false;
                    }
                    else
                    {
                        DGV_Results.ReadOnly = true;
                        DGV_Param.Rows[i].ReadOnly = true;
                    }
                }
                else if (LoginForm.User == "工程师")
                {
                    if (_paramsArray[i].Right == "操作员" || _paramsArray[i].Right == "工程师")
                    {
                        DGV_Results.ReadOnly = false;
                        DGV_Param.Rows[i].ReadOnly = false;
                    }
                    else
                    {
                        DGV_Results.ReadOnly = true;
                        DGV_Param.Rows[i].ReadOnly = true;
                    }
                }
                else if (LoginForm.User == "管理员")
                {
                    DGV_Param.Rows[i].ReadOnly = false;
                    DGV_Param.Columns[2].ReadOnly = false;
                    DGV_Results.ReadOnly = false;
                }
            }
        }

        private void DGV_Param_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _paramsArray.Length)
                return;
            BasicParam param = _paramsArray[e.RowIndex];
            if (param.Type == "DOUBLE" && !double.TryParse(param.Value, out double dResult))
            {
                param.Value = "0.0";
                if (e.ColumnIndex == 1)
                    return;
                MessageBox.Show($"参数 {param.Name} 输入格式不是double型");
            }
            else if (param.Type == "INT" && !int.TryParse(param.Value, out int iResult))
            {
                param.Value = "0";
                if (e.ColumnIndex == 1)
                    return;
                MessageBox.Show($"参数 {param.Name} 输入格式不是int型");
            }
        }

        private void DGV_Param_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _paramsArray.Length || !DGV_Param.Enabled)
                return;
            BasicParam param = _paramsArray[e.RowIndex];
            if (e.ColumnIndex != 2 || param.Right != LoginForm.User) return;
            if (param.Type == "BOOL")
            {
                DGV_Param.Rows[e.RowIndex].ReadOnly = true;
                param.Value = param.Value == "是" ? "否" : "是";
            }
            else if (param.Name.Contains("路径"))
            {
                DGV_Param.Rows[e.RowIndex].ReadOnly = true;
                FolderSelectDialog dialog = new FolderSelectDialog();
                if (dialog.ShowDialog(Handle))
                {
                    DGV_Param.Rows[e.RowIndex].Cells[2].Value = dialog.FileName;
                }
            }
        }

        private void DGV_Results_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<MesResult> retList = ParamManager.RetDict[CbB_Threshold.Text];
            if (e.RowIndex >= retList.Count)
                return;
            MesResult ret = retList[e.RowIndex];
            ret.ID = DGV_Results.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (ret.IsNumerical)
            {
                ret.UpperLimit = Convert.ToDouble(DGV_Results.Rows[e.RowIndex].Cells[2].Value.ToString());
                ret.LowerLimit = Convert.ToDouble(DGV_Results.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            else
            {
                ret.RefValue = DGV_Results.Rows[e.RowIndex].Cells[1].Value.ToString() == "/" ? "" : DGV_Results.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            ret.IsOutput = Convert.ToBoolean(DGV_Results.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void CbB_Threshold_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGV_Results.Rows.Clear();
            List<MesResult> retList = ParamManager.RetDict[CbB_Threshold.Text];
            for (int i = 0; i < retList.Count; i++)
            {
                if (retList[i].IsNumerical)
                    DGV_Results.AddRow(new object[] { retList[i].ID, "/", retList[i].UpperLimit, retList[i].LowerLimit, retList[i].IsOutput });
                else
                    DGV_Results.AddRow(new object[] { retList[i].ID, retList[i].RefValue == "" ? "/" : retList[i].RefValue, "/", "/", retList[i].IsOutput });
            }
        }
    }
}
