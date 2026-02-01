using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using JLogging;
using MeasResult;

namespace MesSDK
{
    public class Mektec : IMes
    {
        private MesParam _param;

        private string _MPN;

        public bool Connect(MesParam param)
        {
            try
            {
                _param = param;
                string URL = $"http://{_param.IP}:{_param.Port}/DataUpload/GetMPN";
                JObject msg = JObject.Parse(Get(URL));
                return msg["Result"].ToString() == "1";
            }
            catch (Exception ex)
            {
                LoggingIF.Log(ex.Message);
                return false;
            }
        }

        public bool DisConnect()
        {
            return true;
        }

        public bool Arrival(string sn, out string msg)
        {
            string URL = $"http://{_param.IP}:{_param.Port}/DataUpload/GetMPN/{_param.Lot}";
            msg = Get(URL);
            JObject jMsg = JObject.Parse(msg);
            if (jMsg["Msg"].ToString() != "OK")
                return false;
            _MPN = jMsg["MPN"].ToString();
            return true;
        }

        public bool Departure(string sn, List<MesResult> retList, out string msg)
        {
            string URL = $"http://{_param.IP}:{_param.Port}/DataUpload/Result";
            JObject key = new JObject
            {
                new JProperty("MPN", _MPN),
                new JProperty("LotNo", _param.Lot),
                new JProperty("UserID", _param.StaffID),
                new JProperty("RouteID", _param.StationID),
                new JProperty("LineID", _param.LineID),
                new JProperty("ProgramNo", _param.Version),
                new JProperty("ShtBarcode", sn)
            };
            JObject value = new JObject
            {
                new JProperty("PcsIndex", "0"),
                new JProperty("PCSBarcode", sn),
                new JProperty("Result", retList.Find((mRet) => mRet.Decision == "FAIL") == null ? "OK" : "NG")
            };
            JObject content = new JObject
            {
                new JProperty("DeviceID", _param.DeviceID),
                new JProperty("StateID", "Add"),
                new JProperty("Key", key),
                new JProperty("Value", value),
                new JProperty("Timestamp", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff+08:00"))
            };
            msg = Post(URL, content.ToString());
            JObject jMsg = JObject.Parse(msg);
            return jMsg["Value"].ToString() == "Success";
        }

        /// <summary>
        /// GET方式发送得结果
        /// </summary>
        /// <param name="url">请求的url</param>
        private string Get(string url)
        {
            try
            {
                HttpWebRequest hwRequest = (HttpWebRequest)WebRequest.Create(url);
                hwRequest.Method = "GET";
                HttpWebResponse hwResponse = (HttpWebResponse)hwRequest.GetResponse();
                StreamReader srReader = new StreamReader(hwResponse.GetResponseStream(), Encoding.ASCII);
                string strResult = srReader.ReadToEnd();
                srReader.Close();
                hwResponse.Close();
                return strResult;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// POST方式发送得结果
        /// </summary>
        /// <param name="url">请求的url</param>
        private string Post(string url, string send_data)
        {
            try
            {
                HttpWebRequest hwRequest = (HttpWebRequest)WebRequest.Create(url);
                hwRequest.Method = "POST";
                hwRequest.ContentType = "application/json";
                StreamWriter writer = new StreamWriter(hwRequest.GetRequestStream());
                writer.Write(send_data);
                writer.Flush();
                HttpWebResponse hwResponse = (HttpWebResponse)hwRequest.GetResponse();
                StreamReader reader = new StreamReader(hwResponse.GetResponseStream(), Encoding.ASCII);
                string strResult = reader.ReadToEnd();
                reader.Close();
                hwResponse.Close();
                return strResult;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool Departure(string sn, string passMsg, string failMsg, out string msg)
        {
            throw new NotImplementedException();
        }
    }
}
