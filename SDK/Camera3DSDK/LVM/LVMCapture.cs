using System;
using System.Threading;
using System.Runtime.InteropServices;
using JLogging;
using NvtLvmSdk;
using static NvtLvmSdk.CameraModel;

namespace Camera3DSDK
{
    public class LVMCapture : I3DCamera
    {
        private CameraApi _camera;//相机对象

        private string _id = "";

        private float _pointInterval = 0.02f;

        private int _profileSize = 1920;

        private int _timeOut = 20000;

        private bool _isOn = false;

        private bool _receiveData = false;

        private lvm_depth_map_t _depthMap;

        private lvm_point_cloud_t _pointCloud;

        private int _profileCount = 1000;

        private bool _isConnected = false;

        public LVMCapture()
        {
            _camera = new CameraApi();
        }

        public bool Connect(string IP, string port)
        {
            int ret = _camera.Cam_Connect(IP, ref _id, -1);
            CameraApi.GetPcldMapDataEvent += new GetPcldMapDataEventHandler(OnGrabPcldMapData);
            _isConnected = true;
            return ret == 0;
        }

        public void Disconnect()
        {
            int ret = _camera.Cam_Disconnect(_id);
            _isConnected = false;
        }

        public void ClearBuffer()
        {
            _camera.Cam_FreeBuffer(_id);    //必须释放，否则依旧会读取数据
            Thread.Sleep(100);
        }

        public bool CheckConnection()
        {
            if (_id == "")
                return false;
            int link = 0;
            for (int i = 0; i < 3; i++)
            {
                _camera.FlashDevPara(_id);
                link += _camera.Dev_State_List_T[_id].link_health;
                Thread.Sleep(100);
            }
            return (link != 0) && _isConnected;
        }

        public void SwitchLaser(bool isOn)
        {
            _isOn = isOn;
            if (isOn)
                _camera.Cam_GrabStart(_id);
            else
                _camera.Cam_GrabStop(_id);
        }

        public void SetParams(EParamNames name, object val)
        {
            switch (name)
            {
                case EParamNames.TimeOut:
                    _timeOut = Convert.ToInt32(val);
                    break;
                case EParamNames.ProfileCount:
                    _profileCount = Convert.ToInt32(val);
                    _camera.Cam_AllocBuffer(_id, grab_mode_t.POINT_CLOUD_AND_DEPTH_MAP, _profileCount, 2);
                    _camera.Cam_BindBuffer(_id);
                    _camera.Cam_EnableAsyncMode(_id, grab_mode_t.POINT_CLOUD_AND_DEPTH_MAP, 0);
                    Thread.Sleep(300);
                    break;
                default:
                    break;
            }
        }

        public object GetParams(EParamNames name)
        {
            switch (name)
            {
                case EParamNames.PointInterval:
                    return _pointInterval;
                case EParamNames.ProfileSize:
                    return _profileSize;
                case EParamNames.ProfileCount:
                    return _profileCount;
                default:
                    return null;
            }
        }

        public int ReadBatchProfiles(out float[] heightData, out byte[] intensityData)
        {
            heightData = null;
            intensityData = null;
            try
            {
                int count = _timeOut / 10;
                while (count > 0)
                {
                    if (_isOn == false)
                    {
                        _receiveData = false;
                        return -2;
                    }
                    count--;
                    Thread.Sleep(10);
                    if (_receiveData)
                    {
                        int size = (int)(_pointCloud.head.height * _pointCloud.head.width);
                        lvm_image_t instensity_img = Marshal.PtrToStructure<lvm_image_t>(_pointCloud.instensity_img);
                        lvm_depth_map_t height_img = Marshal.PtrToStructure<lvm_depth_map_t>(_pointCloud.dm);
                        ushort[] usHeightData = new ushort[size];
                        ushort[] usIntensityData = new ushort[size];
                        heightData = new float[size];
                        intensityData = new byte[size];
                        CameraApi.MyCopy(height_img.data, usHeightData, 0, size);
                        CameraApi.MyCopy(instensity_img.data, usIntensityData, 0, size);
                        double zScale = _camera.DepthMap_Param_List_T[_id].z_scale;
                        for (int i = 0; i < size; i++)
                        {
                            heightData[i] = (float)(usHeightData[i] * zScale);
                            intensityData[i] = usHeightData[i] == 0 ? (byte)0 : (byte)(usIntensityData[i] / 256);
                        }
                        _receiveData = false;
                        return 0;
                    }
                }
                ClearBuffer();
                _receiveData = false;
                return -1;
            }
            catch (Exception ex)
            {
                LoggingIF.Log("Fail to read data: " + ex.ToString(), LogLevels.Error);
                return -1;
            }
        }

        private int OnGrabPcldMapData(string id, lvm_point_cloud_t pointCloudData, lvm_point_t[] data, int lines)
        {
            if (id == _id)
            {
                _receiveData = true;
                _pointCloud = pointCloudData;
            }
            return 0;
        }

        private int OnGrabDepthMapData(string id, lvm_depth_map_t depthMap, ushort[] data, int lines)
        {
            if (id == _id)
            {
                _receiveData = true;
                _depthMap = depthMap;
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
            _camera?.Cam_SaveDevParam(_id, filePath);
        }

        public void LoadJob(string filePath)
        {
            _camera?.Cam_LoadDeviceParam(_id, filePath);
        }
    }
}
