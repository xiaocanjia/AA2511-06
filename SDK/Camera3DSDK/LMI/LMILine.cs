using System;
using System.Runtime.InteropServices;
using Lmi3d.GoSdk;
using Lmi3d.GoSdk.Messages;
using Lmi3d.Zen;
using Lmi3d.Zen.Io;

namespace Camera3DSDK
{
    class LMILine : I3DCamera
    {
        private GoSystem _system = null;        // Golocator system sensor management

        private GoSensor _sensor = null;        // Sensor management

        private GoSetup _setup = null;          // Sensor settings

        private float _triggerInterval = 0;

        private float _pointInterval;

        private int _profileCount = 0;

        private int _profileSize = 0;

        private int _timeOut = 20000;

        private static bool _hasInit = false;

        public LMILine()
        {
            if (!_hasInit)
            {
                KApiLib.Construct();
                GoSdkLib.Construct();
                _hasInit = true;
            }
        }

        public bool Connect(string IP, string port)
        {
            try
            {
                KIpAddress ip = KIpAddress.Parse(IP);
                _system = new GoSystem();
                _sensor = _system.FindSensorByIpAddress(ip);
                _sensor.Connect();
                _system.EnableData(true);
                _setup = _sensor.Setup;
                UpdateSettting();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Disconnect()
        {
            _sensor.Disconnect();
            _system.Disconnect();
        }

        public bool CheckConnection()
        {
            if (null == _sensor) return false;

            return _sensor.IsConnected();
        }

        public void SwitchLaser(bool isOn)
        {
            if (isOn)
            {
                // TODO Clear buffer
                _system.Start();
            }
            else
            {
                _system.Stop();
            }
        }

        public void SetParams(EParamNames name, object val)
        {
            switch (name)
            {
                case EParamNames.TriggerInterval:
                    _triggerInterval = Convert.ToSingle(val);
                    break;
                case EParamNames.TimeOut:
                    _timeOut = Convert.ToInt32(val);
                    break;
                case EParamNames.ProfileCount:
                    _profileCount = Convert.ToInt32(val);
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
            heightData = null;
            intensityData = null;
            GoDataSet dataSet = _system.ReceiveData(_timeOut);  // The buffer in sensor will be cleared automatically once read
            if (dataSet == null)
                return -1;
            int row = 0;
            int col = 0;
            float zOffset = 0;
            float zRes = 0;
            for (uint i = 0; i < dataSet.Count; i++)
            {
                GoDataMsg dataObj = (GoDataMsg)dataSet.Get(i);
                switch (dataObj.MessageType)
                {
                    case GoDataMessageType.Surface:
                        {
                            GoUniformSurfaceMsg surfaceMsg = (GoUniformSurfaceMsg)dataObj;
                            row = (int)surfaceMsg.Length;
                            col = (int)surfaceMsg.Width;
                            zOffset = (float)surfaceMsg.ZOffset / 1000;
                            zRes = (float)surfaceMsg.ZResolution / 1000000;
                            heightData = new float[row * col];

                            for (uint rowIdx = 0; rowIdx < row; rowIdx++)
                            {
                                IntPtr rowPtr = surfaceMsg.RowAt((int)rowIdx);
                                short[] rowBuffer = new short[_profileSize];
                                //LMI相机校准以后，得到的点云宽度可能会超过相机标准线宽，所以这里要取较小值
                                Marshal.Copy(rowPtr, rowBuffer, 0, _profileSize < col ? _profileSize : col);
                                for (uint colIdx = 0; colIdx < _profileSize; colIdx++)
                                {
                                    if (rowIdx < row)
                                    {
                                        heightData[rowIdx * _profileSize + colIdx] = rowBuffer[colIdx] != 0 && rowBuffer[colIdx].CompareTo(short.MinValue) != 0 ?
                                                                                        rowBuffer[colIdx] * zRes + zOffset : float.NaN;
                                    }
                                    else
                                        heightData[rowIdx * _profileSize + colIdx] = float.NaN;
                                }
                            }
                        }
                        break;
                    case GoDataMessageType.SurfaceIntensity:
                        {
                            GoSurfaceIntensityMsg intensifyMsg = (GoSurfaceIntensityMsg)dataObj;
                            row = (int)intensifyMsg.Length;
                            col = (int)intensifyMsg.Width;
                            intensityData = new byte[row * col];
                            IntPtr bufferPointeri = intensifyMsg.Data;
                            Marshal.Copy(bufferPointeri, intensityData, 0, intensityData.Length);
                        }
                        break;
                    default:
                        break;
                }
            }
            return 0;
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
            throw new NotImplementedException();
        }

        private void UpdateSettting()
        {
            double triggerLength = _setup.GetSurfaceGeneration().FixedLengthLength;
            double profileLength = _setup.GetActiveAreaWidth(_sensor.Role);
            _pointInterval = (float)_setup.XMedianWindowLimitMin;
            _triggerInterval = (float)_setup.YMedianWindowLimitMin;
            _profileCount = (int)(triggerLength / _triggerInterval);
            _profileSize = (int)(Math.Ceiling(profileLength / _pointInterval));
        }

        public void ClearBuffer()
        {
            throw new NotImplementedException();
        }
    }
}
