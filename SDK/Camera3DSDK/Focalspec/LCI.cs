using System;
using FocalSpec.FsApiNet.Model;
using System.Collections.Generic;
using JLogging;

namespace Camera3DSDK
{
    class LCI : I3DCamera
    {
        public FsApi _camera;

        private readonly SensorParameterStore _parameters = SensorParameterStore.GetInstance();

        private float _triggerInterval = 0;

        private float _pointInterval;

        private int _profileCount = 0;

        private int _profileSize = 0;

        private float _encoderRes = 0.001f;

        private int _timeOut = 20000;

        private float[] _heightValues;

        private byte[] _intensityValues;

        private string _ID = "";

        private bool _isOn = false;

        private int _idx = 0;

        private bool _isConnected = false;

        public LCI(ECamera3DType type)
        {
            switch (type)
            {
                case ECamera3DType.LCI1220:
                    _profileSize = 1728;
                    _pointInterval = 0.0067f;
                    break;
            }
        }

        public bool Connect(string ID, string port)
        {
            try
            {
                _isConnected = false;
                _ID = ID;
                int cameraCount = 0;
                if (_camera == null)
                    _camera = new FsApi();
                var cameraStatus = _camera.Open(ref cameraCount, out List<string> cameraIds, 2000);
                if (cameraStatus != CameraStatusCode.Ok)
                    return false;
                if (cameraCount == 0)
                {
                    _camera.Close();
                    return false;
                }
                //根据相机Id连接相机，把IP当作相机ID
                cameraStatus = _camera.Connect(ID, null);
                if (cameraStatus != CameraStatusCode.Ok)
                    return false;
                // Set maximum number of points per frame 
                _camera.SetParameter(ID, SensorParameter.MaxPointCount, 20000);
                //加载标定文件
                cameraStatus = _camera.GetParameter(ID, SensorParameter.SensorDataInFlash, out int calibrationsInCamera);
                if (cameraStatus != CameraStatusCode.Ok)
                    return false;

                var zCalibStatus = CameraStatusCode.CameraErrorSensorCalibrationFileNotSet;
                var xCalibStatus = CameraStatusCode.CameraErrorSensorCalibrationFileNotSet;

                if (calibrationsInCamera == 1)
                {
                    //设置标定dat文件
                    zCalibStatus = _camera.SetParameter(ID, SensorParameter.ZCalibrationFile, null);
                    if (zCalibStatus != CameraStatusCode.Ok)
                        return false;
                    xCalibStatus = _camera.SetParameter(ID, SensorParameter.XCalibrationFile, null);
                    if (zCalibStatus != CameraStatusCode.Ok)
                        return false;
                }
                
                //这两个函数很重要，通过加载Recipe 是设置不了的，需要用SDK函数设置，目的是设置单位
                //0是PX，1是um
                if (_camera.SetParameter(ID, SensorParameter.PeakYUnit, 1) != CameraStatusCode.Ok) return false;
                if (_camera.SetParameter(ID, SensorParameter.PeakXUnit, 1) != CameraStatusCode.Ok) return false;
                _camera.SetLineCallback(ID, 0, LineCallback);
                _isConnected = true;
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public void Disconnect()
        {
            _isConnected = false;
            //_camera.Close();
        }

        public bool CheckConnection()
        {
            if (_camera == null) return false;
            return _isConnected;
        }

        public void SwitchLaser(bool isOn)
        {
            if (isOn)
                _camera.StartGrabbing(_ID);
            else
                _camera.StopGrabbing(_ID);
            _isOn = isOn;
        }

        public void SetParams(EParamNames name, object val)
        {
            switch (name)
            {
                case EParamNames.TriggerInterval:
                    _triggerInterval = Convert.ToSingle(val);
                    _camera.SetParameter(_ID, SensorParameter.PulseDivider, _triggerInterval / _encoderRes);
                    break;
                case EParamNames.TimeOut:
                    _timeOut = Convert.ToInt32(val);
                    break;
                case EParamNames.ProfileCount:
                    _profileCount = Convert.ToInt32(val);
                    _camera.SetParameter(_ID, SensorParameter.BatchLength, (float)_profileCount);
                    break;
                case EParamNames.Exposure:
                    _camera.SetParameter(_ID, SensorParameter.Exposure, Convert.ToSingle(val));
                    break;
                case EParamNames.EncoderResolution:
                    _encoderRes = Convert.ToSingle(val);
                    break;
                default:
                    break;
            }
        }

        public object GetParams(EParamNames name)
        {
            switch (name)
            {
                case EParamNames.TriggerInterval:
                    return _triggerInterval;
                case EParamNames.ProfileCount:
                    return _profileCount;
                case EParamNames.PointInterval:
                    return _pointInterval;
                case EParamNames.ProfileSize:
                    return _profileSize;
                default:
                    return null;
            }
        }

        public int ReadBatchProfiles(out float[] heightData, out byte[] intensityData)
        {
            try
            {
                _idx = 0;
                int count = _timeOut / 10;
                while (count > 0)
                {
                    if (_isOn == false)
                    {
                        heightData = null;
                        intensityData = null;
                        return -2;
                    }
                    count--;
                    System.Threading.Thread.Sleep(10);
                    if (_idx >= _profileCount)
                    {
                        heightData = _heightValues;
                        intensityData = _intensityValues;
                        return 0;
                    }
                }
                heightData = null;
                intensityData = null;
                return -1;
            }
            catch (Exception ex)
            {
                LoggingIF.Log("Fail to read data: " + ex.ToString(), LogLevels.Error);
                heightData = null;
                intensityData = null;
                return -1;
            }
        }

        private void LineCallback(int layerId, float[] zValues, float[] intensityValues, int lineLength, double xStep, FsApi.Header header)
        {
            if (_heightValues == null || _heightValues.Length != _profileCount * _profileSize)
            {
                _profileSize = lineLength;
                _intensityValues = new byte[_profileCount * _profileSize];
                _heightValues = new float[_profileCount * _profileSize];
            }
            _idx++;
            if (_idx == 0 || _idx > _profileCount)
                return;
            for (int i = 0; i < lineLength; i++)
            {
                _heightValues[(_idx - 1) * _profileSize + i] = zValues[i] == 9999999 ? float.NaN : zValues[i] * 10.0f + 30000.0f;
                _intensityValues[(_idx - 1) * _profileSize + i] = (byte)(intensityValues[i] == 9999999 ? 0 : intensityValues[i]);
            }
        }

        public int ReadSingleProfile(out float[] heightData, out byte[] intensityData)
        {
            heightData = null;
            intensityData = null;
            return 0;
        }

        public void SaveJob(string filePath)
        {
            throw new NotImplementedException();
        }

        public void LoadJob(string filePath)
        {
            var cameraStatus = _camera.SetParameter(_ID, SensorParameter.LoadRecipe, filePath);
        }


        public void ClearBuffer()
        {
            _heightValues = null;
            _intensityValues = null;
        }
    }
}
