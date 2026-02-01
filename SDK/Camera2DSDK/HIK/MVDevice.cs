using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Camera2DSDK
{
    public class MVDevice : I2DCamera
    {
        private MyCamera _camera = new MyCamera();

        private MyCamera.MV_CC_DEVICE_INFO device;

        //注册图像回调函数
        public MyCamera.cbOutputExdelegate ImageCallback;

        private IntPtr pImageBuf = IntPtr.Zero;

        private int _width;

        private int _height;

        private bool _isConnected = false;

        MyCamera.MV_FRAME_OUT _imageOut = new MyCamera.MV_FRAME_OUT();

        public bool Connect(string name)
        {
            MyCamera.MV_CC_Initialize_NET();
            MyCamera.MV_CC_DEVICE_INFO_LIST m_pDeviceList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
            int ret = MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE, ref m_pDeviceList);
            for (int i = 0; i < m_pDeviceList.nDeviceNum; i++)
            {
                device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));
                string deviceName = "";
                if (device.nTLayerType == MyCamera.MV_GIGE_DEVICE)
                {
                    MyCamera.MV_GIGE_DEVICE_INFO_EX stGigEDeviceInfo = (MyCamera.MV_GIGE_DEVICE_INFO_EX)MyCamera.ByteToStruct(device.SpecialInfo.stGigEInfo, typeof(MyCamera.MV_GIGE_DEVICE_INFO_EX));
                    deviceName = Encoding.Default.GetString(stGigEDeviceInfo.chUserDefinedName).Trim('\0');
                }
                else if (device.nTLayerType == MyCamera.MV_USB_DEVICE)
                {
                    MyCamera.MV_USB3_DEVICE_INFO_EX stGigEDeviceInfo = (MyCamera.MV_USB3_DEVICE_INFO_EX)MyCamera.ByteToStruct(device.SpecialInfo.stGigEInfo, typeof(MyCamera.MV_USB3_DEVICE_INFO_EX));
                    deviceName = Encoding.Default.GetString(stGigEDeviceInfo.chUserDefinedName).Trim('\0');
                }
                if (deviceName == name)
                {
                    ret += _camera.MV_CC_CreateDevice_NET(ref device);
                    ret += _camera.MV_CC_OpenDevice_NET();
                    ret += _camera.MV_CC_SetEnumValue_NET("AcquisitionMode", (uint)MyCamera.MV_CAM_ACQUISITION_MODE.MV_ACQ_MODE_CONTINUOUS);
                    ret += _camera.MV_CC_SetEnumValue_NET("TriggerMode", (uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_OFF);
                    _camera.MV_CC_StartGrabbing_NET();
                    _isConnected = ret == 0;
                    return _isConnected;
                }
            }
            _isConnected = false;
            return _isConnected;
        }

        public void Disconnect()
        {
            _camera?.MV_CC_CloseDevice_NET();
            _camera?.MV_CC_DestroyDevice_NET();
            _isConnected = false;
        }

        public bool CheckConnection()
        {
            return _isConnected;
        }

        public void GrabImage(out IntPtr pData, out int width, out int height)
        {
            if (_imageOut.pBufAddr != IntPtr.Zero)
                _camera.MV_CC_FreeImageBuffer_NET(ref _imageOut);
            int nRet = _camera.MV_CC_GetImageBuffer_NET(ref _imageOut, 1000);
            width = _imageOut.stFrameInfo.nWidth;
            height = _imageOut.stFrameInfo.nHeight;
            pData = _imageOut.pBufAddr;
        }

        public void GrabImageRGB(out IntPtr pData, out int width, out int height)
        {
            if (_imageOut.pBufAddr != IntPtr.Zero)
            {
                _camera.MV_CC_FreeImageBuffer_NET(ref _imageOut);
                Marshal.FreeHGlobal(pImageBuf);
                pImageBuf = IntPtr.Zero;
            }
            int nRet = _camera.MV_CC_GetImageBuffer_NET(ref _imageOut, 1000);
            width = _imageOut.stFrameInfo.nWidth;
            height = _imageOut.stFrameInfo.nHeight;
            pImageBuf = Marshal.AllocHGlobal((int)_imageOut.stFrameInfo.nWidth * _imageOut.stFrameInfo.nHeight * 3);
            int nImageBufSize = _imageOut.stFrameInfo.nWidth * _imageOut.stFrameInfo.nHeight * 3;
            MyCamera.MV_PIXEL_CONVERT_PARAM stPixelConvertParam = new MyCamera.MV_PIXEL_CONVERT_PARAM();

            stPixelConvertParam.pSrcData = _imageOut.pBufAddr;//源数据
            stPixelConvertParam.nWidth = _imageOut.stFrameInfo.nWidth;//图像宽度
            stPixelConvertParam.nHeight = _imageOut.stFrameInfo.nHeight;//图像高度
            stPixelConvertParam.enSrcPixelType = _imageOut.stFrameInfo.enPixelType;//源数据的格式
            stPixelConvertParam.nSrcDataLen = _imageOut.stFrameInfo.nFrameLen;

            stPixelConvertParam.nDstBufferSize = (uint)nImageBufSize;
            stPixelConvertParam.pDstBuffer = pImageBuf;//转换后的数据
            stPixelConvertParam.enDstPixelType = MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed;
            nRet = _camera.MV_CC_ConvertPixelType_NET(ref stPixelConvertParam);//格式转换
            pData = pImageBuf;
        }

        private int GetIntValue(string strKey, out uint value)
        {
            var strParam = new MyCamera.MVCC_INTVALUE();
            int ret = _camera.MV_CC_GetIntValue_NET(strKey, ref strParam);
            value = ret == 0 ? strParam.nCurValue : 0;
            return ret;
        }

        public void SwitchSoftTrigger(bool isOn)
        {
            //if (isOn)
            //    _camera.MV_CC_SetTriggerMode_NET((uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_ON);
            //else
            //    _camera.MV_CC_SetTriggerMode_NET((uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_OFF);
        }

        public void Open()
        {
            _camera?.MV_CC_StartGrabbing_NET();
        }

        public void Close()
        {
            _camera?.MV_CC_StopGrabbing_NET();
        }

        public void TriggerOnce()
        {
            _camera?.MV_CC_TriggerSoftwareExecute_NET();
        }

        public object GetParams(EParamNames name)
        {
            throw new NotImplementedException();
        }

        public void SetParams(EParamNames name, object val)
        {
            switch (name)
            {
                case EParamNames.Exposure:
                    _camera?.MV_CC_SetExposureTime_NET(Convert.ToSingle(val));
                    break;
                case EParamNames.Gain:
                    _camera?.MV_CC_SetGain_NET(Convert.ToSingle(val));
                    break;
            }
        }
    }
}
