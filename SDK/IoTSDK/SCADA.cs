using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using JLogging;

namespace IOTSDK
{
    public class SCADA : IOT
    {
        private IOTParam _param;

        private string _currErrCode = "";

        private string _currErrMsg = "";

        private DateTime _start = DateTime.Now;

        public SCADA() { }

        public bool Connect(IOTParam param)
        {
            try
            {
                _param = param;
                JObject data = new JObject();
                data.Add("HEAD", GetHead("SCADA_Startup"));
                data.Add("MAIN", new JObject {
                    new JProperty("EQSN", _param.DeviceName),
                    new JProperty("OperatorName", _param.User),
                    new JProperty("SoftwareName", _param.SoftName),
                    new JProperty("SoftwareStartTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")),
                    new JProperty("HostName", Dns.GetHostName()),
                    new JProperty("IP", Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString()),
                });
                JObject response = Post(_param.URI, data.ToString(), _param.Token);
                if (response["HEAD"]["H_RET"].ToString() == "00001")
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"SCADA系统连接异常：{ex.Message}");
                return false;
            }
        }

        public bool DisConnect()
        {
            return true;
        }

        public bool Heartbeat(out string msg)
        {
            try
            {
                JObject data = new JObject();
                data.Add("HEAD", GetHead("SCADA_Heartbeat"));
                data.Add("MAIN", new JObject { new JProperty("EQSN", _param.DeviceName) });
                JObject response = Post(_param.URI, data.ToString(), _param.Token);
                msg = response.ToString();
                if (response["HEAD"]["H_RET"].ToString() == "00001")
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public bool UploadResults(string sn, double ct, List<MesResult> retList, out string msg)
        {
            msg = "";
            try
            {
                JObject data = new JObject();
                data.Add("HEAD", GetHead("SCADA_Common"));
                string failItem = "";
                foreach (MesResult ret in retList)
                {
                    if (ret.Decision == "FAIL")
                        failItem += ret.ID;
                }
                data.Add("MAIN", new JObject {
                    new JProperty("BU", _param.Business),
                    new JProperty("Dept", _param.Department),
                    new JProperty("Line",  _param.Line),
                    new JProperty("EQSN", _param.DeviceName),
                    new JProperty("OperatorName", _param.User),
                    new JProperty("SN", sn),
                    new JProperty("Station", _param.Station),
                    new JProperty("Amount", "1"),
                    new JProperty("CT", ct),
                    new JProperty("SetHeadPosition", "test"),
                    new JProperty("Result", failItem == "" ? "PASS" : "FAIL"),
                    new JProperty("FailItem", failItem),
                });
                JObject response = Post(_param.URI, data.ToString(), _param.Token);
                msg = "SCADA发送结果返回" + response.ToString();
                if (response["HEAD"]["H_RET"].ToString() == "00001")
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public bool UploadAlarm(string severity, string category, string code, string content, out string msg)
        {
            msg = "";
            _currErrCode = code;
            _currErrMsg = content;
            try
            {
                JObject data = new JObject();
                data.Add("HEAD", GetHead("SCADA_Warning"));
                data.Add("MAIN", new JObject
                {
                    new JProperty("EQSN", _param.DeviceName),
                    new JProperty("Type", "Produce"),
                    new JProperty("Code", _param.Station + code),
                    new JProperty("Descr", content),
                    new JProperty("OperatorName", _param.User),
                    new JProperty("HostName", Dns.GetHostName()),
                    new JProperty("IP", Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString()),
                });
                JObject response = Post(_param.URI, data.ToString(), _param.Token);
                msg = response.ToString();
                if (response["HEAD"]["H_RET"].ToString() == "00001")
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public bool ClearAlarm(out string msg)
        {
            try
            {
                msg = "";
                if (_currErrCode == "" || _currErrMsg == "")
                    return true;
                JObject data = new JObject();
                data.Add("HEAD", GetHead("SCADA_Warning"));
                data.Add("MAIN", new JObject
                {
                    new JProperty("EQSN", _param.DeviceName),
                    new JProperty("Type", "Eliminate"),
                    new JProperty("Code", _param.Station + _currErrCode),
                    new JProperty("Descr", _currErrMsg),
                    new JProperty("OperatorName", _param.User),
                    new JProperty("HostName", Dns.GetHostName()),
                    new JProperty("IP", Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString()),
                });
                JObject response = Post(_param.URI, data.ToString(), _param.Token);
                msg = response.ToString();
                _currErrCode = "";
                _currErrMsg = "";
                if (response["HEAD"]["H_RET"].ToString() == "00001")
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public bool UploadDeviceState(string state, out string msg)
        {
            msg = "SCADA未连接";
            try
            {
                JObject data = new JObject();
                data.Add("HEAD", GetHead("SCADA_StatusChange"));
                data.Add("MAIN", new JObject {
                    new JProperty("EQSN", _param.DeviceName),
                    new JProperty("Status", state),
                    new JProperty("OperatorName",  _param.User),
                    new JProperty("HostName", Dns.GetHostName()),
                    new JProperty("IP", Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString()),
                });
                JObject response = Post(_param.URI, data.ToString(), _param.Token);
                msg = response.ToString();
                if (response["HEAD"]["H_RET"].ToString() == "00001")
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public bool UploadProductState(string sn, string state, out string msg)
        {
            msg = "未实现UploadProductState";
            return true;
        }

        public bool UploadRecipeState(string recipe, string state, object content, out string msg)
        {
            msg = "未实现UploadRecipeState";
            return true;
        }

        public bool UploadCurrRight(string right, out string msg)
        {
            msg = "未实现UploadCurrRight";
            return true;
        }

        private JObject Post(string url, string json, string token = "")
        {
            string result = "";
            HttpWebRequest hwRequest = (HttpWebRequest)WebRequest.Create(url);
            hwRequest.Method = "POST";
            hwRequest.Headers.Add("token", token);
            hwRequest.Accept = "application/json;charset=UTF-8";
            hwRequest.ContentType = "application/json;charset=UTF-8";

            byte[] data = Encoding.UTF8.GetBytes(json);
            hwRequest.ContentLength = data.Length;

            using (Stream reqStream = hwRequest.GetRequestStream())
                reqStream.Write(data, 0, data.Length);

            //获取响应内容
            HttpWebResponse resp = (HttpWebResponse)hwRequest.GetResponse();
            Stream stream = resp.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                result = reader.ReadToEnd();
            return (JObject)JsonConvert.DeserializeObject(result);
        }

        private JObject GetHead(string op)
        {
            return new JObject()
            {
                new JProperty("H_GUID", Guid.NewGuid().ToString()),
                new JProperty("H_SRC_SYS", ""),
                new JProperty("H_OP", op),
                new JProperty("H_TOKEN", _param.Token),
            };
        }
    }
}
