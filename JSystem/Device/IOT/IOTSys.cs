using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IOTSDK;

namespace JSystem.Device
{
    public class IOTSys : DeviceBase
    {
        public int Type;

        public IOTParam Param = new IOTParam();

        private bool _isConnect = false;

        private DateTime _start = DateTime.Now;

        [JsonIgnore]
        private IOT _IOT;

        public IOTSys() { }

        public IOTSys(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new IOTSysView(this);
        }

        public override bool Connect()
        {
            if (!IsEnable) return true;
            _IOT = IOTFactory.CreateIOT((EIOTType)Type);
            if (!_IOT.Connect(Param))
                return false;
            _isConnect = true;
            new Task(CheckHeartbeat).Start();
            return _isConnect;
        }

        public override void DisConnect()
        {
            if (!IsEnable || !_isConnect)
                return;
            _IOT.DisConnect();
            _isConnect = false;
        }

        public override bool CheckConnection()
        {
            OnUpdateStatus?.Invoke(_isConnect);
            return _isConnect;
        }

        private void CheckHeartbeat()
        {
            while (_isConnect)
            {
                Thread.Sleep(1000);
                if (DateTime.Now.Subtract(_start).TotalSeconds > Param.HeartBeatInterval)
                {
                    _IOT.Heartbeat(out string msg);
                    _start = DateTime.Now;
                }
            }
        }

        public bool UploadResults(string sn, double ct, List<MesResult> retList, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "物联系统未启用";
                return true;
            }
            if (_IOT == null)
            {
                msg = "物联系统未连接";
                return false;
            }
            return _IOT.UploadResults(sn, ct, retList, out msg);
        }

        public bool UploadDeviceState(string state, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "物联系统未启用";
                return true;
            }
            if (_IOT == null)
            {
                msg = "物联系统未连接";
                return false;
            }
            return _IOT.UploadDeviceState(state, out msg);
        }

        public bool UploadProductState(string sn, string state, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "物联系统未启用";
                return true;
            }
            if (_IOT == null)
            {
                msg = "物联系统未连接";
                return false;
            }
            return _IOT.UploadProductState(sn, state, out msg);
        }

        public bool UploadAlarm(string severity, string category, string id, string content, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "物联系统未启用";
                return true;
            }
            if (_IOT == null)
            {
                msg = "物联系统未连接";
                return false;
            }
            return _IOT.UploadAlarm(severity, category, id, content, out msg);
        }

        public bool ClearAlarm(out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "物联系统未启用";
                return true;
            }
            if (_IOT == null)
            {
                msg = "物联系统未连接";
                return false;
            }
            return _IOT.ClearAlarm(out msg);
        }

        public bool UploadRecipeState(string recipe, string state, object content, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "物联系统未启用";
                return true;
            }
            if (_IOT == null)
            {
                msg = "物联系统未连接";
                return false;
            }
            return _IOT.UploadRecipeState(recipe, state, content, out msg);
        }

        public bool UploadCurrRight(string right, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "物联系统未启用";
                return true;
            }
            if (_IOT == null)
            {
                msg = "物联系统未连接";
                return false;
            }
            return _IOT.UploadCurrRight(right, out msg);
        }
    }
}
