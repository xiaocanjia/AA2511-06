using System;
using System.Collections.Generic;
using MeasResult;
using System.Xml;
using System.IO;

namespace MesSDK
{
    /// <summary>
    /// 峥嵘
    /// </summary>
    public class ZR : IMes
    {
        private MesParam _param;

        private MES_WebService.MES_WebService service = new MES_WebService.MES_WebService();

        private DateTime _start;

        private DateTime _end;

        private Dictionary<string, string> _snDict = new Dictionary<string, string>();

        public bool Connect(MesParam param)
        {
            _param = param;
            return true;
        }

        public bool DisConnect()
        {
            return true;
        }

        public bool Arrival(string sn, out string msg)
        {
            try
            {
                _start = DateTime.Now;
                string ret = service.Web_StartCheck(_param.StationID, sn, "JSystem", _param.StaffID);
                msg = $"产品{sn}入站信息：" + ret;
                if (!ret.Contains("检查通过，请开始测试"))
                    return false;
                _snDict.Add(sn, ret.Substring(ret.IndexOf("产品条码[") + 5, 13));
                return true;
            }
            catch (Exception ex)
            {
                msg = $"产品{sn}入站异常：" + ex.Message;
                return false;
            }
        }

        public bool Departure(string sn, List<MesResult> retList, out string msg)
        {
            try
            {
                if (!_snDict.ContainsKey(sn))
                {
                    msg = $"产品{sn}未入站";
                    return false;
                }
                _end = DateTime.Now;
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.CreateElement("NewDataSet");
                foreach (MesResult mRet in retList)
                {
                    XmlElement node = doc.CreateElement("name");
                    XmlElement nodeName = doc.CreateElement("TestItemName");
                    nodeName.InnerText = mRet.ID;
                    node.AppendChild(nodeName);
                    XmlElement nodeValue = doc.CreateElement("TestItemValues");
                    nodeValue.InnerText = mRet.Result;
                    node.AppendChild(nodeValue);
                    XmlElement nodeRet = doc.CreateElement("ItemResult");
                    nodeRet.InnerText = mRet.Decision;
                    node.AppendChild(nodeRet);
                    XmlElement nodeLog = doc.CreateElement("LogProcess");
                    node.AppendChild(nodeLog);
                    root.AppendChild(node);
                }
                StringWriter writer = new StringWriter();
                XmlTextWriter tx = new XmlTextWriter(writer);
                root.WriteTo(tx);
                string xmlStr = writer.ToString();
                string dec = retList.Find((mRet) => mRet.Decision == "FAIL") == null ? "PASS" : "FAIL";
                if (dec == "FAIL")
                {
                    _snDict.Remove(sn);
                    msg = $"产品{sn}结果为FAIL，无需出站";
                    return false;
                }
                string ret = service.Web_GetTestResult(_snDict[sn], sn, dec, _start.ToString("yyyy-MM-dd HH:mm:ss"), ((int)(_end - _start).TotalSeconds).ToString(), xmlStr, "1", "1");
                _snDict.Remove(sn);
                msg = $"产品{sn}出站信息：" + ret;
                if (!ret.Contains("PASS"))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                msg = $"产品{sn}出站异常：" + ex.Message;
                return false;
            }
        }

        public bool Departure(string sn, string passMsg, string failMsg, out string msg)
        {
            throw new NotImplementedException();
        }
    }
}
