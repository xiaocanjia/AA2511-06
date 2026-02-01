using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MeasResult;

namespace MesSDK
{
    public class HQ : IMes
    {
        [DllImport("HQMES.dll", CharSet = CharSet.Ansi)]
        public static extern int MesInit(ref int hMes, StringBuilder sInfo, ref int InfoLen);

        [DllImport("HQMES.dll", CharSet = CharSet.Ansi)]
        public static extern int MesStart(int hMes, string SN, string ActionName, string Tools, StringBuilder sInfo, ref int InfoLen);

        [DllImport("HQMES.dll")]
        public static extern int MesStart2(int hMes, string SN, string SNType, string ActionName, string Tools, StringBuilder sInfo, ref int InfoLen);

        [DllImport("HQMES.dll")]
        public static extern int MesEnd(int hMes, string SN, string ActionName, string Tools, string ErrorCode, StringBuilder sInfo, ref int InfoLen);

        [DllImport("HQMES.dll")]
        public static extern int MesEnd2(int hMes, string SN, string SNType, string ActionName, string Tools, string ErrorCode, string AllData, StringBuilder sInfo, ref int InfoLen);

        [DllImport("HQMES.dll")]
        private static extern int MesSaveAndGetExtraInfo(int hMes, string G_TYPE, string G_POSITION, string G_KEY, string G_VALUE, string G_EXTINFO, StringBuilder sInfo, ref int InfoLen);

        [DllImport("HQMES.dll")]
        public static extern int MesUnInit(int hMes);

        private int hMes = 0;

        private MesParam _param;

        public bool Connect(MesParam param)
        {
            int len = 102400;
            _param = param;
            StringBuilder strdata = new StringBuilder(len);
            return 0 == MesInit(ref hMes, strdata, ref len);
        }

        public bool Arrival(string sn, out string msg)
        {
            int len = 102400;
            StringBuilder strdata = new StringBuilder(len);
            string data = "";
            string needload = "";
            int ret = MesStart(hMes, sn, _param.StationID, _param.DeviceID, strdata, ref len);
            msg = "MES入站信息" + strdata.ToString();
            if (0 != ret) return false;
            JObject jo = (JObject)JsonConvert.DeserializeObject(strdata.ToString());
            data = jo.GetValue("DATA") == null ? "" : jo.GetValue("DATA").ToString();
            //data是一个json字符串，其中包含mes返回的主要字段，按照这个参考继续解析出来 例如获取CSN
            JObject jb = (JObject)JsonConvert.DeserializeObject(data);
            needload = jo.GetValue("NeedLoad") == null ? "" : jo.GetValue("NeedLoad").ToString();//标记工具是否需要重启
            if (needload == "Y")
            {
                msg += "配置文件发生改变，需要重新载入配置文件";
                return false;
            }
            return true;
        }

        public bool Departure(string sn, List<MesResult> retList, out string msg)
        {
            int len = 102400;
            StringBuilder strdata = new StringBuilder(len);
            string err = "";
            int ret = 0;
            JObject data = new JObject();
            foreach (MesResult mRet in retList)
            {
                if (mRet.Decision == "FAIL")
                    err += mRet.ID + ",";
                else
                    data.Add(mRet.ID, mRet.Result);
            }
            if (err != "")
                err.Remove(err.Length - 1);
            if (err.Length > 100)
                err.Substring(0, 100);
            if (retList == null || retList.Count == 0)
                ret = MesEnd(hMes, sn, _param.StationID, _param.DeviceID, err, strdata, ref len);
            else
                ret = MesEnd2(hMes, sn, "1", _param.StationID, _param.DeviceID, err, data.ToString(), strdata, ref len);
            msg = strdata.ToString();
            return ret == 0;
        }

        public bool DisConnect()
        {
            return true;
            //try
            //{
            //    return 0 == MesUnInit(hMes);
            //}
            //catch
            //{
            //    return false;
            //}
        }

        public bool Departure(string sn, string passMsg, string failMsg, out string msg)
        {
            int len = 102400;
            int ret = 0;
            StringBuilder strdata = new StringBuilder(len);
            if (passMsg == "")
                ret = MesEnd(hMes, sn, _param.StationID, _param.DeviceID, failMsg, strdata, ref len);
            else
                ret = MesEnd2(hMes, sn, "1", _param.StationID, _param.DeviceID, failMsg, passMsg, strdata, ref len);
            msg = strdata.ToString();
            return ret == 0;
        }
    }
}
