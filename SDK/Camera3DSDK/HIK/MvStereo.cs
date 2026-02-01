using System;
using System.Runtime.InteropServices;
using MvStereoAppSDKNet;

using STC_Object = System.IntPtr;
using STC_DataSet = System.IntPtr;

namespace Camera3DSDK
{
    class MvStereo : I3DCamera
    {
        private readonly object Lock = new object();

        private readonly uint MaxImageSize = 1024 * 1024 * 30;

        private MvStereoApp _camera = new MvStereoApp();

        private MvStereoApp.STC_PROFILE_COORDSCALE _scale = new MvStereoApp.STC_PROFILE_COORDSCALE();

        private bool _isConnected = false;

        private int _profileCount = 0;

        private int _profileSize = 0;

        private int _timeOut = 20000;

        public bool Connect(string IP, string port)
        {
            MvStereoApp.MV_STEREOCAM_NET_INFO_LIST deviceList = new MvStereoApp.MV_STEREOCAM_NET_INFO_LIST();
            GC.Collect();
            deviceList.nDeviceNum = 0;
            int result = MvStereoApp.MV_STA_EnumStereoCam_NET(ref deviceList);
            if (0 != result)
            {
                _isConnected = false;
                return false;
            }
            for (int i = 0; i < deviceList.nDeviceNum; i++)
            {
                MvStereoApp.MV_STEREOCAM_NET_INFO device = (MvStereoApp.MV_STEREOCAM_NET_INFO)Marshal.PtrToStructure(deviceList.pDeviceInfo[i], typeof(MvStereoApp.MV_STEREOCAM_NET_INFO));
                if (IP == device.nCurrentIp.ToString())
                {
                    if (null == _camera)
                        _camera = new MvStereoApp();
                    result = _camera.MV_STA_CreateHandleByCameraInfo_NET(ref device);
                    if (MvStereoApp.MV_STA_OK != result)
                    {
                        _isConnected = false;
                        return false;
                    }
                    result = _camera.MV_STA_OpenDevice_NET();
                    if (MvStereoApp.MV_STA_OK != result)
                    {
                        _isConnected = false;
                        return false;
                    }
                    _isConnected = true;
                }
            }
            return true;
        }

        public void Disconnect()
        {
            _camera?.MV_STA_DestroyHandle_NET();
        }

        public bool CheckConnection()
        {
            return _isConnected;
        }

        public void ClearBuffer()
        {
            return;
        }

        public void SwitchLaser(bool isOn)
        {
            if (isOn)
                _camera.MV_STA_Start_NET();
            else
                _camera.MV_STA_Stop_NET();
        }

        public int ReadBatchProfiles(out float[] heightData, out byte[] intensityData)
        {
            int result = MvStereoApp.MV_STA_OK;
            byte[] m_pcDataBuf = new byte[MaxImageSize];
            STC_DataSet pDataSet = STC_DataSet.Zero;
            int nResultCount = 0;
            uint nMsgType = 0;
            STC_Object DataObj = STC_Object.Zero;
            heightData = null;
            intensityData = null;
            result = _camera.MV_STA_ReceiveDataTimeout_NET(ref pDataSet, (uint)_timeOut);

            if (result != MvStereoApp.MV_STA_OK)
                return -1;

            nResultCount = _camera.MV_STA_DataSetCount_NET(pDataSet);
            for (int index = 0; index < nResultCount; index++)
            {
                DataObj = _camera.MV_STA_DataSetAt_NET(pDataSet, index);
                nMsgType = _camera.MV_STA_DataMsgType_NET(DataObj);

                switch (nMsgType)
                {
                    case MvStereoApp.STC_DATA_MSG_TYPE_IMG_RAW:
                        {
                            GC.Collect();   //强制释放下资源；
                            MvStereoApp.STC_DATA_IMAGE stImg = new MvStereoApp.STC_DATA_IMAGE();
                            result = _camera.MV_STA_GetImage_NET(DataObj, ref stImg);
                            if (0 != result)
                            {
                                _camera.MV_STA_DestroyData_NET(pDataSet);
                                continue;
                            }
                            _profileCount = stImg.nHeight;
                            _profileSize = stImg.nWidth;
                            Marshal.Copy(stImg.pData, m_pcDataBuf, 0, (int)stImg.nFrameLen);
                            break;
                        }
                    case MvStereoApp.STC_3D_Profile_Intensity:
                        {
                            GC.Collect();   //强制释放下资源；
                            MvStereoApp.STC_PROFILE_INTENSITY stImg = new MvStereoApp.STC_PROFILE_INTENSITY();
                            result = _camera.MV_STA_GetProfileIntensity_NET(DataObj, ref stImg);
                            if (0 != result)
                            {
                                _camera.MV_STA_DestroyData_NET(pDataSet);
                                continue;
                            }
                            Marshal.Copy(stImg.pData, m_pcDataBuf, 0, (int)stImg.nDataLen);
                            break;
                        }
                    case MvStereoApp.STC_3D_Profile_Count:
                        {
                            STC_Object pnProfileCount = new STC_Object(0);
                            result = _camera.MV_STA_GetProfileCount_NET(DataObj, ref pnProfileCount);
                            if (0 != result)
                            {
                                _camera.MV_STA_DestroyData_NET(pDataSet);
                                continue;
                            }
                            break;
                        }
                    case MvStereoApp.STC_3D_Profile_CoordScale:
                        {
                            result = _camera.MV_STA_GetProfileCoordScale_NET(DataObj, ref _scale);
                            break;
                        }
                    default:
                        break;
                }
            }
            _camera.MV_STA_DestroyData_NET(pDataSet);

            return 0;
        }

        public int ReadSingleProfile(out float[] heightData, out byte[] intensityData)
        {
            heightData = null;
            intensityData = null;
            return 0;
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
                    break;
                default:
                    break;
            }
        }

        public object GetParams(EParamNames name)
        {
            MvStereoApp.MV_STA_FLOATVALUE stParam = new MvStereoApp.MV_STA_FLOATVALUE();
            switch (name)
            {
                case EParamNames.TriggerInterval:
                    _camera.MV_STA_GetFloatValue_NET("YScale", ref stParam);
                    return stParam.fCurValue;
                case EParamNames.ProfileCount:
                    return _profileCount;
                case EParamNames.PointInterval:
                    _camera.MV_STA_GetFloatValue_NET("XScale", ref stParam);
                    return stParam.fCurValue;
                case EParamNames.ProfileSize:
                    return _profileSize;
                default:
                    return null;
            }
        }

        public void LoadJob(string filePath)
        {
            _camera?.MV_STA_FeatureLoad_NET(filePath);
        }

        public void SaveJob(string filePath)
        {
            _camera?.MV_STA_FeatureSave_NET(filePath);
        }
    }
}
