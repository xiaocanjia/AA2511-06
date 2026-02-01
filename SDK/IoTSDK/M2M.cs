using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HW.AutoIOTSdk.Common;
using HW.AutoIOTSdk.Config;
using HW.AutoIOTSdk.Message;
using HW.AutoIOTSdk.Message.Property;
using HW.AutoIOTSdk.Service;
using JLogging;
using Newtonsoft.Json;

namespace IOTSDK
{
    [StructLayout(LayoutKind.Sequential)]
    public class SystemTime
    {
        public ushort Year;

        public ushort Month;

        public ushort DayOfWeek;

        public ushort Day;

        public ushort Hour;

        public ushort Minute;

        public ushort Second;
    }

    public class M2M : IOT
    {
        [DllImport("Kernel32.dll")]
        public static extern void SetLocalTime(SystemTime st);
        
        private IOTParam _param;

        private M2MClient _client;

        private ProcessState _preDeviceState;

        private AlarmReport _currAlarm;

        private Recipe _currRecipe;

        private string _currRight;

        public M2M()
        {
            _preDeviceState = new ProcessState()
            {
                state = "IDLE",
                subState = "Starved"
            };
        }

        public bool Connect(IOTParam param)
        {
            try
            {
                _param = param;
                M2MClientConfig conf = new M2MClientConfig
                {
                    logPath = _param.LogPath,
                    logName = _param.LogName,
                    machineSn = _param.DeviceName,
                    siteId = Convert.ToInt32(_param.Station),
                    uri = _param.URI
                };
                _client = M2MClient.getInstance(conf);
                ServiceAddr addr = new ServiceAddr()
                {
                    ip = _param.IP,
                    port = _param.Port
                };
                EquipmentCommunicationStateChanged commState = new EquipmentCommunicationStateChanged("COMMUNICATING", addr, "NOTIFY")
                {
                    equipmentModelName = _param.SoftName,
                    softwareVersion = _param.SoftVer
                };
                ReturnVo ret = _client.equipmentCommunicationStateChanged(commState);
                if (!ret.replyMessage.Contains("success")) return false;
                ret = _client.equipmentControlStateChanged(new EquipmentControlStateChanged("OFFLINE", "LOCAL", "NOTIFY"));
                if (!ret.replyMessage.Contains("success")) return false;
                ret = _client.dateAndTimeRequest(new DateAndTimeRequest());
                DateTime date = DateTime.ParseExact(((DateAndTimeReply)ret).time, "yyyyMMddHHmmssfff", null);
                SystemTime time = new SystemTime()
                {
                    Year = (ushort)date.Year,
                    Month = (ushort)date.Month,
                    Day = (ushort)date.Day,
                    DayOfWeek = (ushort)date.DayOfWeek,
                    Hour = (ushort)date.Hour,
                    Minute = (ushort)date.Minute,
                    Second = (ushort)date.Second
                };
                SetLocalTime(time);
                if (!ret.replyMessage.Contains("success")) return false;
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统连接异常：{ex.Message}");
                return false;
            }
        }

        public bool DisConnect()
        {
            try
            {
                ReturnVo ret = _client.equipmentControlStateChanged(new EquipmentControlStateChanged("LOCAL", "OFFLINE", "NOTIFY"));
                ServiceAddr addr = new ServiceAddr()
                {
                    ip = _param.IP,
                    port = _param.Port
                };
                EquipmentCommunicationStateChanged commState = new EquipmentCommunicationStateChanged("NOT_COMMUNICATING", addr, "NOTIFY")
                {
                    equipmentModelName = _param.SoftName,
                    softwareVersion = _param.SoftVer
                };
                ret = _client.equipmentCommunicationStateChanged(commState);
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统断开连接异常：{ex.Message}");
                return false;
            }
        }

        public bool Heartbeat(out string msg)
        {
            msg = "";
            try
            {
                var ret = _client.heartbeatRequest(new HeartbeatRequest());
                msg = $"heartbeatRequest: {JsonConvert.SerializeObject(ret, Formatting. Indented)}";
                return true;
            }
            catch (Exception ex)
            {
                msg = $"华为物联系统心跳异常：{ex.Message}";
                return false;
            }
        }

        public bool UploadResults(string sn, double ct, List<MesResult> retList, out string msg)
        {
            msg = "";
            try
            {
                Dictionary<string, object> retDict = new Dictionary<string, object>();
                if (retList == null)
                    retDict.Add("Data", "test");
                var productSN = new ProductSn()
                {
                    type = "PRODUCT_SN",
                    value = sn
                };
                var ret = _client.processDataReport(new ProcessDataReport(new ProductSn() { type = "PRODUCT_SN", value = sn }, _currRecipe, retDict));
                msg += $"processDataReport: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                string currTime = DateTime.Now.ToString("yyyyMMddHHmmssff");
                ret = _client.equipmentDataReport(new EquipmentDataReport(1, 1, currTime, retDict));
                msg += $"equipmentDataReport: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统上传结果异常：{ex.Message}");
                return false;
            }
        }

        public bool UploadDeviceState(string state, out string msg)
        {
            msg = "";
            try
            {
                ProcessState deviceState = new ProcessState() { state = state.Substring(0, state.IndexOf(":")), subState = state.Substring(state.IndexOf(":") + 1)};
                ReturnVo ret = _client.equipmentProcessStateChanged(new EquipmentProcessStateChanged("NOTIFY", _preDeviceState, deviceState));
                msg = $"equipmentProcessStateChanged: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                _preDeviceState = deviceState;
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统上传设备状态异常：{ex.Message}");
                return false;
            }
        }

        public bool UploadProductState(string sn, string state, out string msg)
        {
            msg = "";
            try
            {
                var productState = new ProductProcessStateChanged()
                {
                    productSn = new ProductSn() { type = "PRODUCT_SN", value = sn },
                    messageId = Guid.NewGuid().ToString("N"),
                    monitorMode = "NOTIFY",
                    productState = state,
                    recipe = _currRecipe
                };
                ReturnVo ret = _client.productProcessStateChanged(productState);
                msg = $"productProcessStateChanged: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统上传产品状态异常：{ex.Message}");
                return false;
            }
        }

        public bool UploadAlarm(string severity, string category, string id, string content, out string msg)
        {
            msg = "";
            try
            {
                _currAlarm = new AlarmReport()
                {
                    alarmId = id,
                    alarmState = "SET",
                    alarmSeverity = severity[0].ToString(),
                    alarmCategory = category,
                    alarmText = content,
                    alarmInstanceId = Guid.NewGuid().ToString("N")
                };
                ReturnVo ret = _client.alarmReport(_currAlarm);
                msg = $"alarmReport: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统上传报警信息异常：{ex.Message}");
                return false;
            }
        }

        public bool ClearAlarm(out string msg)
        {
            msg = "";
            if (_currAlarm == null)
                return true;
            try
            {
                _currAlarm.alarmState = "CLEAR";
                ReturnVo ret = _client.alarmReport(_currAlarm);
                _currAlarm = null;
                msg = $"alarmReport: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统清除报警异常：{ex.Message}");
                return false;
            }
        }

        public bool UploadRecipeState(string recipe, string state, object content, out string msg)
        {
            msg = "";
            try
            {
                _currRecipe = new Recipe() { name = recipe, version = "V1.0" };
                var body = new RecipeBody() { formattedBody = (Dictionary<string, object>)content };
                var ret = _client.recipeStateChanged(new RecipeStateChanged(_currRecipe, state, body, "NOTIFY"));
                msg = $"recipeStateChanged: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统上传当前工单信息异常：{ex.Message}");
                return false;
            }
        }

        public bool UploadCurrRight(string right, out string msg)
        {
            msg = "";
            try
            {
                if (_currRight != "")
                    _client.operatorLoginStateChanged(new OperatorLoginStateChanged("NOTIFY", _currRight, "LOGOUT"));
                var ret = _client.operatorLoginStateChanged(new OperatorLoginStateChanged("NOTIFY", right, "LOGIN"));
                _currRight = right;
                msg = $"operatorLoginStateChanged: {JsonConvert.SerializeObject(ret, Formatting.Indented)}";
                return true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log($"华为物联系统上传当前权限异常：{ex.Message}");
                return false;
            }
        }
    }
}
