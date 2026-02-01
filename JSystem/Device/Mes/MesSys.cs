using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using MesSDK;
using MeasResult;

namespace JSystem.Device
{
    public class MesSys : DeviceBase
    {
        public int Type;

        public MesParam Param = new MesParam();

        private bool _isConnect = false;

        [JsonIgnore]
        private IMes _mes;

        public MesSys() { }

        public MesSys(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new MesSysView(this);
        }

        public override bool Connect()
        {
            try
            {
                if (!IsEnable) return true;
                _mes = MesFactory.CreateMes((EMesType)Type);
                if (!_mes.Connect(Param))
                    return false;
                _isConnect = true;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void DisConnect()
        {
            _isConnect = false;
            _mes?.DisConnect();
        }

        public override bool CheckConnection()
        {
            OnUpdateStatus?.Invoke(_isConnect);
            return _isConnect;
        }

        public bool Arrival(string sn, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "mes未启用";
                return true;
            }
            if (_mes == null)
            {
                msg = "mes未连接";
                return false;
            }
            return _mes.Arrival(sn, out msg);
        }

        public bool Departure(string sn, List<MesResult> retList, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "mes未启用";
                return true;
            }
            if (_mes == null)
            {
                msg = "mes未连接";
                return false;
            }
            return _mes.Departure(sn, retList, out msg);
        }

        public bool Departure(string sn, string passMsg, string failMsg, out string msg)
        {
            if (!IsEnable || !_isConnect)
            {
                msg = "mes未启用";
                return true;
            }
            if (_mes == null)
            {
                msg = "mes未连接";
                return false;
            }
            return _mes.Departure(sn, passMsg, failMsg, out msg);
        }
    }
}
