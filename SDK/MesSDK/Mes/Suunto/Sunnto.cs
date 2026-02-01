using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MeasResult;

namespace MesSDK
{
    public class Sunnto : IMes
    {
        private MesParam _param=null;

        private HttpHelper helper = null;
        
        public bool Connect(MesParam param)
        {
            _param = param;
            helper = new HttpHelper(param.IP);
            if (param.IP == "https://cloud-api.suunto.cn/")
                helper.Tokenkey = "Man@Su%!unto&23";
            else
                helper.Tokenkey = "fwor32#L$ho23";
            if (helper.Post("").Contains("未能解析此远程名称"))
                return false;
            return true;
        }

        public bool DisConnect()
        {
            return true;
        }

        public bool Arrival(string sn, out string msg)
        {
            JObject obj = new JObject();
            obj.Add("pcbaSerial", sn);
            obj.Add("agTestStatus", "none");
            obj.Add("workstationType", 3);
            string response = helper.Post(obj.ToString());
            //解析返回数值 
            HttpResponseModel<WatchData> responseobj = JsonConvert.DeserializeObject<HttpResponseModel<WatchData>>(response);
            if (responseobj.code == 200 && responseobj.data.agTestStatus == "none")
            {
                msg = $"产品{sn}入站成功";
                return true;
            }
            else
            {
                msg = $"产品{sn}入站异常：" + responseobj.code;
                return false;
            }
        }
        
        public bool Departure(string sn, List<MesResult> retList, out string msg)
        {
            JObject obj = new JObject();
            obj.Add("pcbaSerial", sn);
            obj.Add("agTestStatus", "true");//A+G
            obj.Add("workstationType", 3);  //A+G
            string response = helper.Post(obj.ToString());
            //解析返回数值 
            HttpResponseModel<WatchData> responseobj = JsonConvert.DeserializeObject<HttpResponseModel<WatchData>>(response);
            if (responseobj.code == 200 && responseobj.data.agTestStatus == "true")
            {
                msg = $"产品{sn}_M成功";
                return true;
            }
            else
            {
                msg = $"产品{sn}出站异常：" + responseobj.code+ responseobj.message;
                return false;
            }
        }

        public bool Departure(string sn, string passMsg, string failMsg, out string msg)
        {
            throw new System.NotImplementedException();
        }
    }
}
