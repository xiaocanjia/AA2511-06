using System;
using System.Linq;
using FileHelper;
using JSystem.Perform;
using JLogging;
using System.Collections.Generic;

namespace JSystem.Param
{
    public class ParamManager
    {
        private static BasicParam[] _paramsArray;

        public BasicParam[] ParamsArray
        {
            get
            {
                return _paramsArray;
            }
            set
            {
                for (int i = 0; i < _paramsArray.Length; i++)
                {
                    _paramsArray[i].Value = value.FirstOrDefault((p) => p.Name == _paramsArray[i].Name)?.Value ?? _paramsArray[i].Value;
                    _paramsArray[i].Right = value.FirstOrDefault((p) => p.Name == _paramsArray[i].Name)?.Right ?? _paramsArray[i].Right;
                }
            }
        }

        public static Dictionary<string, List<MesResult>> RetDict;

        public string CurrRight;

        public ParamManager()
        {
            RetDict = new Dictionary<string, List<MesResult>>();
            using (Excel excel = new Excel(AppDomain.CurrentDomain.BaseDirectory + "Config//参数.xlsx"))
            {
                foreach (ExcelSheet sheet in excel.Sheets)
                {
                    if (!sheet.Name.Contains("门限"))
                        continue;
                    List<MesResult> retList = new List<MesResult>();
                    RetDict.Add(sheet.Name, retList);
                    for (int i = 2; i <= sheet.Rows; i++)
                    {
                        MesResult ret = new MesResult();
                        ret.ID = sheet[i, 1].ToString();

                        if (sheet[i, 2].ToString() == "/" && sheet[i, 3].ToString() == "/" && sheet[i, 4].ToString() == "/")
                        {
                            ret.RefValue = "";
                            ret.IsNumerical = false;
                        }
                        else if (sheet[i, 2].ToString() != "/")
                        {
                            ret.RefValue = sheet[i, 2].ToString();
                            ret.IsNumerical = false;
                        }
                        else
                        {
                            ret.UpperLimit = Convert.ToDouble(sheet[i, 3]);
                            ret.LowerLimit = Convert.ToDouble(sheet[i, 4]);
                            ret.IsNumerical = true;
                        }
                        ret.IsOutput = sheet[i, 5].ToString() == "是";
                        retList.Add(ret);
                    }
                }
                _paramsArray = new BasicParam[excel["变量"].Rows - 1];
                for (int i = 2; i <= excel["变量"].Rows; i++)
                {
                    _paramsArray[i - 2] = new BasicParam();
                    _paramsArray[i - 2].Name = excel["变量"][i, 1].ToString();
                    _paramsArray[i - 2].Type = excel["变量"][i, 2].ToString();
                    _paramsArray[i - 2].Value = excel["变量"][i, 3].ToString();
                    _paramsArray[i - 2].Right = excel["变量"][i, 4].ToString();
                    _paramsArray[i - 2].IsDisplay = excel["变量"][i, 5].ToString() == "是";
                }
            }
        }

        public static bool GetBoolParam(string name)
        {
            BasicParam param = _paramsArray.FirstOrDefault((p) => { return p.Name == name; });
            if (param == null)
            {
                LogManager.Instance.AddLog("参数", $"列表中没有{name}", LogLevels.Error);
                throw new Exception($"参数列表中没有{name}");
            }
            return param.Value == "是";
        }

        public static string GetStringParam(string name)
        {
            BasicParam param = _paramsArray.FirstOrDefault((p) => { return p.Name == name; });
            if (param == null)
            {
                LogManager.Instance.AddLog("参数", $"列表中没有{name}", LogLevels.Error);
                throw new Exception($"参数列表中没有{name}");
            }
            return param.Value;
        }

        public static int GetIntParam(string name)
        {
            BasicParam param = _paramsArray.FirstOrDefault((p) => { return p.Name == name; });
            if (param == null)
            {
                LogManager.Instance.AddLog("参数", $"列表中没有{name}", LogLevels.Error);
                throw new Exception($"参数列表中没有{name}");
            }
            return Convert.ToInt32(param.Value);
        }

        public static double GetDoubleParam(string name)
        {
            BasicParam param = _paramsArray.FirstOrDefault((p) => { return p.Name == name; });
            if (param == null)
            {
                LogManager.Instance.AddLog("参数", $"列表中没有{name}", LogLevels.Error);
                throw new Exception($"参数列表中没有{name}");
            }
            return Convert.ToDouble(param.Value);
        }

        public static void SetParam(string name, object value)
        {
            BasicParam param = _paramsArray.FirstOrDefault((p) => { return p.Name == name; });
            if (param == null)
            {
                LogManager.Instance.AddLog("参数", $"列表中没有{name}", LogLevels.Error);
                throw new Exception($"参数列表中没有{name}");
            }
            param.Value = value.ToString();
        }

        public static List<MesResult> GetMesResults(string sheetName)
        {
            List<MesResult> retList = new List<MesResult>();
            for (int i = 0; i < RetDict[sheetName].Count; i++)
                retList.Add(RetDict[sheetName][i].Clone());
            return retList;
        }

        public void Save()
        {
            using (Excel excel = new Excel(AppDomain.CurrentDomain.BaseDirectory + "Config//参数.xlsx"))
            {
                for (int i = 0; i < _paramsArray.Length; i++)
                {
                    excel["变量"][i + 2, 1] = _paramsArray[i].Name;
                    excel["变量"][i + 2, 3] = _paramsArray[i].Value;
                    excel["变量"][i + 2, 4] = _paramsArray[i].Right;
                }
                foreach (string sheetName in RetDict.Keys)
                {
                    for (int i = 0; i < RetDict[sheetName].Count; i++)
                    {
                        excel[sheetName][i + 2, 1] = RetDict[sheetName][i].ID;
                        excel[sheetName][i + 2, 2] = RetDict[sheetName][i].IsNumerical ? "/" : (RetDict[sheetName][i].RefValue == "" ? "/" : RetDict[sheetName][i].RefValue);
                        excel[sheetName][i + 2, 3] = RetDict[sheetName][i].IsNumerical ? RetDict[sheetName][i].UpperLimit.ToString() : "/";
                        excel[sheetName][i + 2, 4] = RetDict[sheetName][i].IsNumerical ? RetDict[sheetName][i].LowerLimit.ToString() : "/";
                        excel[sheetName][i + 2, 5] = RetDict[sheetName][i].IsOutput ? "是" : "否";
                    }
                }
                excel.Save();
            }
        }
    }
}
