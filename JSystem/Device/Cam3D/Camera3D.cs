using System;
using System.IO;
using Newtonsoft.Json;
using Camera3DSDK;
using JSystem.Perform;
using BSLib;
using JLogging;

namespace JSystem.Device
{
    public class Camera3D : DeviceBase
    {
        private JMatrix3D _matrix3D;

        public int CamType = 0;

        public string IP = "192.168.0.10";

        public string Port = "8080";

        public float PointsInterval = 0.02f;

        public float TriggerInterval = 0.02f;

        private int _rows = 0;

        private int _columns = 0;

        public int TimeOut = 20000;

        [JsonIgnore]
        public bool ScanFinished { get; protected set; }

        public bool _isOn = false;

        public float ValidWidth = 30.0f;

        public string CfgName = "";

        public bool IsSaveImage = false;

        public bool IsSaveFailOnly = false;

        [JsonIgnore]
        private I3DCamera _camera;

        public Camera3D() { }

        public Camera3D(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new Cam3DView(this);
        }

        public override bool Connect()
        {
            if (!IsEnable) return true;
            try
            {
                _camera = Cam3DFactory.Create3DCamera((ECamera3DType)CamType);
                if (!_camera.Connect(IP, Port))
                    return false;
                _camera.SetParams(EParamNames.TimeOut, TimeOut);
                PointsInterval = (float)_camera.GetParams(EParamNames.PointInterval);
                if (ValidWidth > (int)_camera.GetParams(EParamNames.ProfileSize) * PointsInterval)
                    ValidWidth = (int)_camera.GetParams(EParamNames.ProfileSize) * PointsInterval;
                _columns = (int)(ValidWidth / PointsInterval);
                string CfgPath = AppDomain.CurrentDomain.BaseDirectory + "Config\\" + CfgName;
                if (CfgPath != "" && File.Exists(CfgPath))
                    _camera.LoadJob(CfgPath);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void DisConnect()
        {
            _camera?.Disconnect();
        }

        public override bool CheckConnection()
        {
            bool isConnect = _camera == null ? false : _camera.CheckConnection();
            OnUpdateStatus?.Invoke(isConnect);
            return isConnect;
        }

        public JMatrix3D GrabImage(double PCLLength, int jointCount)
        {
            try
            {
                if (CheckConnection() == false) return null;
                _rows = (int)(PCLLength / TriggerInterval);
                _camera.SetParams(EParamNames.ProfileCount, _rows);
                ScanFinished = false;
                int cols = _columns * jointCount;
                int rows = _rows;
                float[] hBuffer = new float[rows * cols];
                byte[] lBuffer = new byte[rows * cols];
                for (int i = 0; i < jointCount; i++)
                {
                    SwitchLaser(true);
                    LogManager.Instance.AddLog(Name, $"开始读取一次");
                    int ret = _camera.ReadBatchProfiles(out float[] hData, out byte[] lData);
                    if (hData == null || lData == null)
                    {
                        LogManager.Instance.AddLog(Name, $"数据读取失败");
                        return null;
                    }
                    int initCols = (int)_camera.GetParams(EParamNames.ProfileSize);
                    int startCols = (initCols - _columns) / 2;
                    for (int rowIndex = 0; rowIndex < _rows; rowIndex++)
                    {
                        int startIdx = rowIndex * initCols + startCols;
                        Array.Copy(hData, startIdx, hBuffer, _columns * rowIndex, _columns);
                        Array.Copy(lData, startIdx, lBuffer, _columns * rowIndex, _columns);
                    }
                    SwitchLaser(false);
                    LogManager.Instance.AddLog(Name, $"读取一次完成");
                }
                _matrix3D = new JMatrix3D();
                _matrix3D.Row = rows;
                _matrix3D.Column = cols;
                _matrix3D.HeightData = hBuffer;
                _matrix3D.LuminaceData = lBuffer;
                ScanFinished = true;
                return _matrix3D;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog(Name, $"读取数据失败，请检测参数是否设置正确：{ex.Message}", LogLevels.Error);
                return null;
            }
        }

        public void EndGrab()
        {
            if (_camera == null)
                return;
            _camera.ClearBuffer();
            SwitchLaser(false);
            ScanFinished = true;
        }

        public float GetValidWidth()
        {
            return PointsInterval * _columns;
        }

        public void SwitchLaser(bool isOn)
        {
            _camera?.SwitchLaser(isOn);
            _isOn = isOn;
        }

        public void SaveJob(string filePath)
        {
            _camera?.SaveJob(filePath);
        }

        public void LoadJob(string filePath)
        {
            _camera?.LoadJob(filePath);
        }

        public bool GetIsOn()
        {
            return _isOn;
        }
    }
}
