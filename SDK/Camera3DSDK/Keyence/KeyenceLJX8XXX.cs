using System;
using System.IO;
using System.Runtime.InteropServices;
using JLogging;

namespace Camera3DSDK
{
    class KeyenceLJX8XXX : I3DCamera
    {
        [DllImport("kernel32.dll", SetLastError = false)]
        private static extern void CopyMemory(IntPtr destination, IntPtr source, UIntPtr length);

        private static int _deviceID = 0;

        private static bool _hasInit = false;

        private bool _isConnected = false;

        private float _triggerInterval = 0;

        private int _timeOut = 20000;

        private bool _receiveData = false;

        private int _profileCount = 0;

        private float _xSpacing = 0;

        private float[] _heightValues;

        private byte[] _intensityValues;

        private bool _isOn = false;

        private LJX8IF_ETHERNET_CONFIG _ethernetConfig = new LJX8IF_ETHERNET_CONFIG();

        private readonly int maxProfileCount = 3200;

        private readonly float minXPitch = 0;

        private readonly float coefficient = 0;

        private readonly object _syncObject = new object();

        private static HighSpeedDataCallBackForSimpleArray _callbackSimpleArray;

        public KeyenceLJX8XXX(ECamera3DType cameraType)
        {
            if (!_hasInit)
                KeyenceSDK.LJX8IF_Initialize();
            switch (cameraType)
            {
                case ECamera3DType.LJX8020:
                    minXPitch = 0.0025f;
                    coefficient = 0.0004f;
                    break;
                case ECamera3DType.LJX8060:
                    minXPitch = 0.005f;
                    coefficient = 0.0008f;
                    break;
                case ECamera3DType.LJX8080:
                    minXPitch = 0.0125f;
                    coefficient = 0.0016f;
                    break;
                case ECamera3DType.LJX8200:
                    minXPitch = 0.025f;
                    coefficient = 0.004f;
                    break;
                case ECamera3DType.LJX8400:
                    minXPitch = 0.075f;
                    coefficient = 0.008f;
                    break;
                case ECamera3DType.LJX8900:
                    minXPitch = 0.225f;
                    coefficient = 0.016f;
                    break;
            }
            _isConnected = false;
            _callbackSimpleArray = ReceiveHighSpeedSimpleArray;
        }

        public bool Connect(string IP, string port)
        {
            try
            {
                string[] strs = IP.Split('.');
                byte[] byteIP = new byte[strs.Length];
                for (int i = 0; i < strs.Length; i++)
                {
                    byteIP[i] = Convert.ToByte(strs[i]);
                }
                _ethernetConfig.abyIpAddress = byteIP;
                _ethernetConfig.wPortNo = 24691;    //固定不变的
                _deviceID++;
                int rc = KeyenceSDK.LJX8IF_EthernetOpen(_deviceID, ref _ethernetConfig);
                ClearBuffer();   //连接后清除内存，防止之前有缓存在里面导致第一次无法读取数据
                if (rc == 0)
                {
                    int result = UpdateSettting();
                    if (result == 0)
                        _isConnected = true;
                    else
                        _isConnected = false;
                }
                else
                {
                    _isConnected = false;
                }
                return rc == 0;
            }
            catch (Exception ex)
            {
                LoggingIF.Log("Fail to connect camera: " + ex.ToString(), LogLevels.Error);
                _isConnected = false;
                return false;
            }
        }

        public void Disconnect()
        {
            KeyenceSDK.LJX8IF_CommunicationClose(_deviceID);
        }

        public void SwitchLaser(bool isOn)
        {
            _isOn = isOn;
            if (_isOn)
            {
                KeyenceSDK.LJX8IF_StartMeasure(_deviceID);
                _heightValues = null;
                _intensityValues = null;
            }
            else
            {
                KeyenceSDK.LJX8IF_StopMeasure(_deviceID);
            }
        }

        public bool CheckConnection()
        {
            return _isConnected;
        }

        public void ClearBuffer()
        {
            KeyenceSDK.LJX8IF_ClearMemory(_deviceID);
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
                    return minXPitch / _xSpacing;
                case EParamNames.ProfileSize:
                    return (int)(maxProfileCount * _xSpacing);
                default:
                    return null;
            }
        }

        public int ReadBatchProfiles(out float[] heightData, out byte[] intensityData)
        {
            try
            {
                int count = _timeOut / 10;
                while (count > 0)
                {
                    if (_isOn == false)
                    {
                        heightData = null;
                        intensityData = null;
                        _receiveData = false;
                        return -2;
                    }
                    count--;
                    System.Threading.Thread.Sleep(10);
                    if (_receiveData)
                    {
                        heightData = _heightValues;
                        intensityData = _intensityValues;
                        _receiveData = false;
                        return 0;
                    }
                }
                heightData = null;
                intensityData = null;
                _receiveData = false;
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

        public int ReadSingleProfile(out float[] heightData, out byte[] intensityData)
        {
            heightData = null;
            intensityData = null;
            return 0;
        }

        /// <summary>
		/// Method that is called from the DLL as a callback function
		/// </summary>
		/// <param name="headBuffer">A pointer to the buffer that stores the header data array</param>
		/// <param name="profileBuffer">A pointer to the buffer that stores the profile data array</param>
		/// <param name="luminanceBuffer">A pointer to the buffer that stores the luminance profile data array</param>
		/// <param name="isLuminanceEnable">The value indicating whether luminance data output is enable or not</param>
		/// <param name="profileSize">The data count of one profile</param>
		/// <param name="count">Number of profiles</param>
		/// <param name="notify">Completion flag</param>
		/// <param name="user">Thread ID (value passed during initialization)</param>
		private void ReceiveHighSpeedSimpleArray(IntPtr headBuffer, IntPtr profileBuffer, IntPtr luminanceBuffer, uint isLuminanceEnable, uint profileSize, uint count, uint notify, uint user)
        {
            try
            {
                if (count != _profileCount) return;
                int bufferSize = Convert.ToInt32(profileSize * count);
                ushort[] buffer = new ushort[bufferSize];
                _heightValues = new float[count * profileSize];
                CopyUshort(profileBuffer, buffer, bufferSize);
                for (int i = 0; i < bufferSize; i++)
                {
                    _heightValues[i] = buffer[i] != 0 ? (buffer[i] + short.MinValue) * coefficient : float.NaN;
                }
                if (isLuminanceEnable == 1)
                {
                    DateTime start = DateTime.Now;
                    _intensityValues = new byte[count * profileSize];
                    CopyUshort(luminanceBuffer, buffer, bufferSize);
                    for (int i = 0; i < bufferSize; i++)
                        _intensityValues[i] = (byte)(buffer[i] / 4);
                    DateTime end = DateTime.Now;
                    double span = (end - start).Milliseconds;
                }
                _receiveData = true;
            }
            catch (Exception ex)
            {
                LoggingIF.Log("Fail to receive data: " + ex.ToString(), LogLevels.Error);
            }
        }

        private int UpdateSettting()
        {
            //修改设置时要先结束连接
            KeyenceSDK.LJX8IF_StopHighSpeedDataCommunication(_deviceID);
            KeyenceSDK.LJX8IF_FinalizeHighSpeedDataCommunication(_deviceID);
            LJX8IF_HIGH_SPEED_PRE_START_REQUEST request = new LJX8IF_HIGH_SPEED_PRE_START_REQUEST();
            LJX8IF_PROFILE_INFO profileInfo = new LJX8IF_PROFILE_INFO();
            request.bySendPosition = 2;
            ushort highSpeedPort = 24692;
            _profileCount = GetProfileCount();
            _xSpacing = GetXSpacing();
            _triggerInterval = GetTriggerInterval();
            //第三个参数是高速通道的端口，不是连接相机时的端口；_profileCount是指接受到多少条轮廓就触发一次回调函数
            int a = KeyenceSDK.LJX8IF_InitializeHighSpeedDataCommunicationSimpleArray(_deviceID, ref _ethernetConfig,
                    highSpeedPort, _callbackSimpleArray, (uint)_profileCount, (uint)_deviceID);
            int b = KeyenceSDK.LJX8IF_PreStartHighSpeedDataCommunication(_deviceID, ref request, ref  profileInfo);
            int c = KeyenceSDK.LJX8IF_StartHighSpeedDataCommunication(_deviceID);
            if (a != 0 || b != 0 || c != 0)
                return -1;
            return 0;
        }

        public void SaveJob(string filePath)
        {
            uint dataSize = KeyenceSDK.ProgramSettingSize;
            byte[] receiveBuffer = new byte[dataSize];
            
            using (PinnedObject pin = new PinnedObject(receiveBuffer))
            {
                //Parameter
                LJX8IF_TARGET_SETTING target = GetSelectedProgramTargetSetting();
                // Download
                Rc rc = (Rc)KeyenceSDK.LJX8IF_GetSetting(_deviceID, (byte)LJX8IF_SETTING_DEPTH.LJX8IF_SETTING_DEPTH_SAVE, target, pin.Pointer, dataSize);
                if (rc != (int)Rc.Ok)
                    return;
            }
            // Save program data
            using (FileStream filestream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(filestream))
            {
                writer.Write(receiveBuffer);
            }
        }

        public void LoadJob(string filePath)
        {
            uint dataSize = KeyenceSDK.ProgramSettingSize;

            // Allocate buffer
            byte[] receiveBuffer = new byte[(int)dataSize];
            // Load program data
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                //Validate file
                if (fileStream.Length != dataSize)
                    return;
                using (BinaryReader reader = new BinaryReader(fileStream))
                {
                    reader.Read(receiveBuffer, 0, (int)dataSize);
                }
            }

            using (PinnedObject pin = new PinnedObject(receiveBuffer))
            {
                // Upload
                uint error = 0;
                // Parameter
                LJX8IF_TARGET_SETTING target = GetSelectedProgramTargetSetting();

                Rc rc = (Rc)KeyenceSDK.LJX8IF_SetSetting(_deviceID, (byte)LJX8IF_SETTING_DEPTH.LJX8IF_SETTING_DEPTH_SAVE, target, pin.Pointer, dataSize, ref error);
            }
            UpdateSettting();
        }

        /// <summary>
		/// Create program download/upload parameters depends on combobox selection.
		/// </summary>
		/// <returns>Setting item structure</returns>
		private LJX8IF_TARGET_SETTING GetSelectedProgramTargetSetting()
        {
            LJX8IF_TARGET_SETTING setting;
            setting.byCategory = 0xFF;    // means all parameter
            setting.byItem = 0x00;
            setting.reserve = 0;
            setting.byTarget1 = 0;        // This is used when you want to set a setting item in greater detail
            setting.byTarget2 = 0;
            setting.byTarget3 = 0;
            setting.byTarget4 = 0;
            setting.byType = (byte)(SettingType.Program00);
            return setting;
        }

        private void CopyUshort(IntPtr source, ushort[] destination, int length)
        {
            // @Point
            // Copy array using kernel32's method manually because System.Runtime.InteropServices.Marshal.Copy method 
            // does not support ushort array.
            using (PinnedObject pin = new PinnedObject(destination))
            {
                int copyLength = Marshal.SizeOf(typeof(ushort)) * length;
                CopyMemory(pin.Pointer, source, (UIntPtr)copyLength);
            }
        }

        /// <summary>
        /// 获取轮廓的数量
        /// </summary>
        /// <returns></returns>
        private int GetProfileCount()
        {
            LJX8IF_TARGET_SETTING setting = new LJX8IF_TARGET_SETTING
            {
                byType = 0x10,
                byCategory = 0x00,
                byItem = 0x0A,
                byTarget1 = 0x00,
                byTarget2 = 0x00,
                byTarget3 = 0x00,
                byTarget4 = 0x00
            };
            byte depth = 0x02;
            uint dataLength = 4;
            byte[] data = new byte[dataLength];
            using (PinnedObject pin = new PinnedObject(data))
            {
                KeyenceSDK.LJX8IF_GetSetting(_deviceID, depth, setting, pin.Pointer, dataLength);
            }
            string sData = string.Format("{0:x2}", data[3]) + string.Format("{0:x2}", data[2]) +
                            string.Format("{0:x2}", data[1]) + string.Format("{0:x2}", data[0]);
            return int.Parse(sData, System.Globalization.NumberStyles.AllowHexSpecifier);
        }

        /// <summary>
        /// 获取触发间隔，就是Y分辨率
        /// </summary>
        /// <returns></returns>
        private float GetTriggerInterval()
        {
            byte depth = 0x02;
            LJX8IF_TARGET_SETTING setting = new LJX8IF_TARGET_SETTING
            {
                byType = 0x10,
                byCategory = 0x00,
                byItem = 0x05,
                byTarget1 = 0x00,
                byTarget2 = 0x00,
                byTarget3 = 0x00,
                byTarget4 = 0x00
            };
            uint dataLength = 4;
            byte[] data = new byte[dataLength];
            using (PinnedObject pin = new PinnedObject(data))
            {
                KeyenceSDK.LJX8IF_GetSetting(_deviceID, depth, setting, pin.Pointer, dataLength);
            }
            string sData = string.Format("{0:x2}", data[3]) + string.Format("{0:x2}", data[2]) +
                            string.Format("{0:x2}", data[1]) + string.Format("{0:x2}", data[0]);
            return uint.Parse(sData, System.Globalization.NumberStyles.AllowHexSpecifier) / 10000.0f;
        }

        /// <summary>
        /// 获取X步进，将X方向分辨率修改为1/2或1/4
        /// </summary>
        /// <returns></returns>
        private float GetXSpacing()
        {
            byte depth = 0x02;
            LJX8IF_TARGET_SETTING setting = new LJX8IF_TARGET_SETTING
            {
                byType = 0x10,
                byCategory = 0x02,
                byItem = 0x02,
                byTarget1 = 0x00,
                byTarget2 = 0x00,
                byTarget3 = 0x00,
                byTarget4 = 0x00
            };
            uint dataLength = 4;
            byte[] data = new byte[dataLength];
            using (PinnedObject pin = new PinnedObject(data))
            {
                KeyenceSDK.LJX8IF_GetSetting(_deviceID, depth, setting, pin.Pointer, dataLength);
            }
            if (data[0] == 1)
                return 0.5f;
            else if (data[0] == 2)
                return 0.25f;
            else
                return 1.0f;
        }
    }
}
