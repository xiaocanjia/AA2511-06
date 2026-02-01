using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MeasResult;
using System.Net;
using System.IO;
using System;

namespace MesSDK
{
    /// <summary>
    /// 华勤南昌一厂
    /// </summary>
    public class HQ1 : IMes
    {
        private MesParam _param;

        public bool Connect(MesParam param)
        {
            _param = param;
            return true;
        }

        public bool Arrival(string sn, out string msg)
        {
            try
            {
                string Request = "{\"HEAD\":{\"H_GUID\":\"ActGUID\",\"H_SRC_SYS\":\"\",\"H_OP\":\"Request\",\"H_TOKEN\":\"\",\"H_ACTION\":\"Mura_Test\"}," +
                "\"MAIN\":{\"H_OP\":\"Request\",\"H_ACTION\":\"Mura_Test\",\"G_OP_LINE\":\"F02\",\"G_WS\":\"Mura_Test\",\"G_USER\":\"ActUserID\",\"G_OP_PC\":\"ActFixtureID\",\"G_SN\":\"2RPBB23C20800083\",\"G_Language\":\"\",\"G_HostName\":\"ActHostName\",\"G_IP\":\"\"}}";
                JObject jo = (JObject)JsonConvert.DeserializeObject(Request);
                jo["MAIN"]["H_OP"] = _param.ProductID;
                jo["HEAD"]["H_OP"] = _param.ProductID;
                jo["HEAD"]["H_ACTION"] = _param.StationID;
                jo["MAIN"]["H_ACTION"] = _param.StationID;
                jo["MAIN"]["G_OP_LINE"] = _param.LineID;
                jo["MAIN"]["G_WS"] = _param.StationID;
                jo["MAIN"]["G_USER"] = _param.StaffID;
                jo["MAIN"]["G_OP_PC"] = _param.DeviceID;
                jo["MAIN"]["G_SN"] = sn;
                Request = JsonConvert.SerializeObject(jo);
                string re = DoPostRequestSendData(_param.IP, Request);
                JObject rec = (JObject)JsonConvert.DeserializeObject(re);
                string GetIsMes = Convert.ToString(rec["HEAD"]["H_RET"]);
                msg = "MES发送信息:" + jo + "MES接收信息:" + rec;
                if (GetIsMes == "00001")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public bool Departure(string sn, List<MesResult> retList, out string msg)
        {
            try
            {
                string content = "{\"HEAD\":{\"H_GUID\":\"ActGUID\",\"H_SRC_SYS\":\"\",\"H_OP\":\"ATUpdateFlow\",\"H_TOKEN\":\"\",\"H_ACTION\":\"ActStation\"}," +
                "\"MAIN\":{\"H_OP\":\"ATUpdateFlow\",\"H_ACTION\":\"ActStation\",\"G_OP_LINE\":\"F20\",\"G_WS\":\"ActStation\",\"G_USER\":\"ActUserID\",\"G_OP_PC\":\"ActFixtureID\",\"G_SN\":\"YX0089T8\",\"G_ErrCode\":\"PASS\",\"G_HostName\":\"ActHostName\",\"G_IP\":\"ActIP\"}}";
                JObject jo = (JObject)JsonConvert.DeserializeObject(content);
                jo["HEAD"]["H_OP"] = "ATUpdateFlowFootPad";
                jo["MAIN"]["H_OP"] = "ATUpdateFlowFootPad";
                jo["HEAD"]["H_ACTION"] = _param.StationID;  //实际的站别名，无数据可传示例的值(不传API会报错)
                jo["MAIN"]["H_ACTION"] = _param.StationID;  //实际的站别名，无数据可传示例的值(不传API会报错)
                jo["MAIN"]["G_WS"] = _param.StationID;      //实际的站别名，无数据可传示例的值(不传API会报错)
                jo["MAIN"]["G_OP_LINE"] = _param.LineID;    //实际的线别名，无数据可放空
                jo["MAIN"]["G_USER"] = _param.StaffID;      //实际的操作人员工号
                jo["MAIN"]["G_OP_PC"] = _param.StaffID;     //设备的治具编号，请工厂提供
                jo["MAIN"]["G_SN"] = sn;                    //SN号
                int ngCount = 0;
                foreach (MesResult ret in retList)
                {
                    jo["MAIN"][ret.ID] = ret.Result;
                    if (ret.IsOutput && ret.Decision == "FAIL")
                        ngCount++;
                }
                jo["MAIN"]["G_ErrCode"] = ngCount == 0 ? "PASS" : "FAIL";
                content = JsonConvert.SerializeObject(jo);
                string re = DoPostRequestSendData(_param.IP, content);//Url按照车间定义MBD2的是http://172.24.248.15/FA_APINCBD/HQAPI/MES/
                JObject rec = (JObject)JsonConvert.DeserializeObject(re);
                string GetIsMes = Convert.ToString(rec["HEAD"]["H_RET"]);
                msg = "MES发送信息:" + jo + "MES接收信息:" + rec;
                if (GetIsMes == "00001")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public bool DisConnect()
        {
            return true;
        }

        private string DoPostRequestSendData(string url, string data)
        {
            try
            {
                string str = "";
                //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                Encoding encoding = Encoding.UTF8;

                //构造一个Web请求的对象
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                //使用文件流发送指令
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(data);
                writer.Flush();
                //获取web请求的响应的内容
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    str = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                }
                return str;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool Departure(string sn, string passMsg, string failMsg, out string msg)
        {
            throw new NotImplementedException();
        }
    }
}
