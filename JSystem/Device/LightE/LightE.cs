using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace JSystem.Device
{
    public class LightE : DeviceBase
    {
        private int _hDevice;                       //控制器句柄

        private bool _isConnected = false;

        public string CurrSN = "";

        public string ConfigPath = "";

        public string CalibPath = "";

        public int mChnCount = 0;

        public int ReadCount = 10;

        public int TimeOut = 10000;

        private object m_CaptureObj = new object();
        
        [JsonIgnore]
        public Action<string> OnDispMsg;

        public LightE() { }

        public LightE(string name) : this()
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new LightEView(this);
        }

        public override bool Connect()
        {
            try
            {
                if (!IsEnable)
                    return true;
                LEConfocalDLL.LE_SelectDeviceType(2);                                                           //选择需使用的控制器类型接口，当前选择USB2代控制器
                LEConfocalDLL.LE_InitDLL();                                                                     //初始化传感器DLL 
                int iSta = LEConfocalDLL.LE_Open(CurrSN.ToCharArray(), ref _hDevice);
                iSta += LEConfocalDLL.LE_LoadDeviceConfigureFromFile(new StringBuilder(ConfigPath), _hDevice); //载入控制器配置文件，该文件必须路径正确且与当前使用控制器序号匹配
                iSta += LEConfocalDLL.LE_LoadLWCalibrationData(new StringBuilder(CalibPath), _hDevice);
                mChnCount = LEConfocalDLL.LE_GetChannels(_hDevice);
                _isConnected = iSta == 1;
                return _isConnected;
            }
            catch
            {
                return false;
            }
        }

        public override void DisConnect()
        {
            LEConfocalDLL.LE_Close(ref _hDevice);
            _isConnected = false;
        }

        public override bool CheckConnection()
        {
            OnUpdateStatus?.Invoke(_isConnected);
            return _isConnected;
        }

        public double[] ReadData()
        {
            if (Monitor.TryEnter(m_CaptureObj, 1000))
            {
                int iSta = 0;
                int currCount = 0;
                double[][] mMultiChnRst = new double[mChnCount][];
                //开始采集数据
                for (int i = 0; i < mChnCount; ++i)
                {
                    mMultiChnRst[i] = new double[ReadCount];
                    iSta = LEConfocalDLL.LE_SetChannelGetAllValues(mMultiChnRst[i], ReadCount, _hDevice, i + 1);
                }
                iSta = LEConfocalDLL.LE_StartGetChannelsValues(_hDevice);
                Stopwatch sw = new Stopwatch();
                sw.Restart();
                //检测当前采集任务是否采集完成循环,测试临时注释while循环
                while (currCount < ReadCount)
                {
                    iSta = LEConfocalDLL.LE_GetCapturedPoints(ref currCount, _hDevice);
                    Thread.Sleep(10);
                    if (sw.Elapsed.TotalMilliseconds > TimeOut)
                        break;
                }
                sw.Stop();
                int sta = LEConfocalDLL.LE_GetDeviceStatus(_hDevice);
                if (1 == sta)
                    LEConfocalDLL.LE_StopGetPoints(_hDevice);
                LEConfocalDLL.LE_StopGetPoints(_hDevice);     
                Monitor.Exit(m_CaptureObj);
                double[] avgHeight = new double[mChnCount];
                for (int i = 0; i < mChnCount; i++)
                    avgHeight[i] = mMultiChnRst[i].Average();
                return avgHeight;
            }
            return null;
        }
    }
}
