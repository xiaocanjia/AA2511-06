using System;
using System.Threading;
using Newtonsoft.Json;
using HalconDotNet;
using Camera2DSDK;

namespace JSystem.Device
{
    public class Camera2D : DeviceBase
    {
        public int CamType = 0;
        
        [JsonIgnore]
        private I2DCamera _camera;

        public float Gain = 1.0f;

        public Camera2D() { }

        public Camera2D(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new Cam2DView(this);
        }

        public override bool Connect()
        {
            _camera = Cam2DFactory.Create2DCamera((ECam2DType)CamType);
            bool ret = _camera.Connect(Name);
            _camera?.SetParams(EParamNames.Gain, Gain);
            return ret;
        }

        public override void DisConnect()
        {
            _camera?.Disconnect();
        }

        public override bool CheckConnection()
        {
            bool isConnected = _camera == null ? false : _camera.CheckConnection();
            OnUpdateStatus?.Invoke(isConnected);
            return isConnected;
        }

        public void Open()
        {
            _camera?.Open();
        }

        public void Close()
        {
            _camera?.Close();
        }

        public int GrabImage(out HImage image)
        {
            IntPtr pData;
            int width;
            int height;
            image = null;
            for (int i = 0; i < 10; i++)
            {
                _camera.GrabImage(out pData, out width, out height);
                if (width == 0 || height == 0)
                {
                    _camera.Disconnect();
                    Thread.Sleep(100);
                    _camera.Connect(Name);
                    _camera.Open();
                    Thread.Sleep(100);
                    continue;
                }
                image = new HImage("byte", width, height, pData);
                break;
            }
            return 0;
        }

        public int GrabImageRGB(out HImage image)
        {
            IntPtr pData;
            int width;
            int height;
            image = null;
            for (int i = 0; i < 10; i++)
            {
                _camera.GrabImageRGB(out pData, out width, out height);
                if (width == 0 || height == 0)
                {
                    _camera.Disconnect();
                    _camera.Connect(Name);
                    _camera.Open();
                    Thread.Sleep(100);
                    continue;
                }
                image = new HImage();
                image.GenImageInterleaved(pData, "rgb", width, height, -1, "byte", 0, 0, 0, 0, -1, 0);
                break;
            }
            return 0;
        }

        public void SetExposure(double exposure)
        {
            _camera?.SetParams(EParamNames.Exposure, exposure);
        }
    }
}
