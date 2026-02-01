using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using JLogging;

namespace Camera3DSDK
{
    class SSZNSR7000 : I3DCamera
    {
        private int _ID = 0;

        private readonly float _pointInterval = 0;

        private int _profileSize = 0;       //每一行的轮廓点数
        
        private int _timeOut = 20000;

        private int _profileCount = 1000;

        private bool _isOn = false;

        public SSZNSR7000(ECamera3DType type)
        {
            switch (type)
            {
                case ECamera3DType.SR7020:
                    _pointInterval = 0.003f;
                    break;
                case ECamera3DType.SR7050:
                    _pointInterval = 0.01f;
                    break;
                case ECamera3DType.SR7060:
                    _pointInterval = 0.015f;
                    break;
                case ECamera3DType.SR7080:
                    _pointInterval = 0.02f;
                    break;
                case ECamera3DType.SR8060:
                    _pointInterval = 0.012f;
                    break;
            }
        }

        public bool Connect(string IP, string port)
        {
            SR7IF_ETHERNET_CONFIG cfg;

            string[] ipTmp = IP.Split('.');
            if (ipTmp.Length != 4)
            {
                return false;
            }

            cfg.abyIpAddress = new byte[]
            {
                    Convert.ToByte(ipTmp[0]),
                    Convert.ToByte(ipTmp[1]),
                    Convert.ToByte(ipTmp[2]),
                    Convert.ToByte(ipTmp[3])
            };
            _ID = Convert.ToInt32(ipTmp[3].Substring(1));
            int errO = SR7LinkFunc.SR7IF_EthernetOpen(_ID, ref cfg);
            if (errO != 0)
            {
                return false;
            }
            _profileSize = SR7LinkFunc.SR7IF_ProfileDataWidth(_ID, new IntPtr());
            return true;
        }

        public void Disconnect()
        {
            //建立连接 SR7IF_CommClose 断开连接
            int errC = SR7LinkFunc.SR7IF_CommClose(_ID);
        }

        public bool CheckConnection()
        {
            int err = SR7LinkFunc.SR7IF_GetError(_ID, new IntPtr(), new IntPtr());
            if (err == 0) return true;
            return false;
        }

        public void SwitchLaser(bool isOn)
        {
            _isOn = isOn;
            if (isOn)
                SR7LinkFunc.SR7IF_StartMeasure(_ID, _timeOut);
            else
                SR7LinkFunc.SR7IF_StopMeasure(_ID);
        }

        public void ClearBuffer()
        {

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
            switch (name)
            {
                case EParamNames.ProfileSize:
                    return _profileSize;
                case EParamNames.PointInterval:
                    return _pointInterval;
                default:
                    return null;
            }
        }

        public int ReadBatchProfiles(out float[] heightData, out byte[] intensityData)
        {
            int size = _profileSize * _profileCount;
            heightData = new float[size];
            intensityData = new byte[size];       
            int[] tHeightData = new int[size];      //当前批次高度数据缓存
            byte[] tIntensityData = new byte[size];  //当前批次亮度数据缓存  
            uint[] FrameLoss = new uint[_profileCount];                       //批处理过快掉帧数量数据缓存
            long[] FrameId = new long[_profileCount];                         //帧编号数据缓存
            uint[] Encoder = new uint[_profileCount];                         //编码器数据缓存
            DateTime start = DateTime.Now;
            int currCount = 0;
            while (true)
            {
                using (PinnedObject pin_height = new PinnedObject(tHeightData))       //内存自动释放接
                {
                    using (PinnedObject pin_gray = new PinnedObject(tIntensityData))
                    {
                        using (PinnedObject pin_encoder = new PinnedObject(Encoder))
                        {
                            using (PinnedObject pin_frameloss = new PinnedObject(FrameLoss))
                            {
                                using (PinnedObject pin_frameid = new PinnedObject(FrameId))
                                {
                                    int curBPt = SR7LinkFunc.SR7IF_GetBatchRollData(_ID,
                                        new IntPtr(),
                                        pin_height.Pointer,
                                        pin_gray.Pointer,
                                        pin_encoder.Pointer,
                                        pin_frameid.Pointer,
                                        pin_frameloss.Pointer,
                                        256);
                                    if (curBPt < 0 || _isOn == false || DateTime.Now.Subtract(start).TotalSeconds > 30)
                                    {
                                        SR7LinkFunc.SR7IF_StopMeasure(_ID);
                                        return -1;
                                    }
                                    if (curBPt == 0)
                                    {
                                        Thread.Sleep(50);
                                        continue;
                                    }

                                    #region Err Proc 
                                    if (curBPt < 0)
                                    {
                                        if (curBPt == (int)SR7IF_ERROR.SR7IF_ERROR_MODE)
                                        {
                                            SR7LinkFunc.SR7IF_StopMeasure(_ID);
                                            heightData = null;
                                            intensityData = null;
                                            return -1;
                                        }
                                        else if (curBPt == (int)SR7IF_ERROR.SR7IF_NORMAL_STOP)
                                        {
                                            SR7LinkFunc.SR7IF_StopMeasure(_ID);
                                            heightData = null;
                                            intensityData = null;
                                            return -2;
                                        }
                                        else
                                        {
                                            //获取错误码
                                            int[] EthErrCnt = new int[1];
                                            int[] UserErrCnt = new int[1];
                                            using (PinnedObject pin_EthErrCnt = new PinnedObject(EthErrCnt))
                                            {
                                                using (PinnedObject pin_UserErrCnt = new PinnedObject(UserErrCnt))
                                                {
                                                    SR7LinkFunc.SR7IF_GetBatchRollError(_ID, pin_EthErrCnt.Pointer, pin_UserErrCnt.Pointer);
                                                }
                                            }

                                            if (curBPt == (int)SR7IF_ERROR.SR7IF_ERROR_ROLL_DATA_OVERFLOW)
                                            {
                                                heightData = null;
                                                intensityData = null;
                                                return -3;

                                            }
                                            else if (curBPt == (int)SR7IF_ERROR.SR7IF_ERROR_ROLL_BUSY)
                                            {
                                                heightData = null;
                                                intensityData = null;
                                                return -4;
                                            }

                                            EthErrCnt = null;
                                            UserErrCnt = null;
                                            GC.Collect();
                                            return -5;
                                        }
                                    }
                                    #endregion Err Proc
                                    
                                    int currSize = (currCount + curBPt <= _profileCount ? curBPt : (_profileCount - currCount)) * _profileSize;
                                    int bufferSize = currCount * _profileSize;  //已经扫描的点数
                                    for (int i = 0; i < currSize; i++)
                                    {
                                        if (tHeightData[i] < -10000000)
                                        {
                                            heightData[i + bufferSize] = float.NaN;
                                            intensityData[i + bufferSize] = 0;
                                        }
                                        else
                                        {
                                            heightData[i + bufferSize] = tHeightData[i] * 0.00001f;
                                            intensityData[i + bufferSize] = tIntensityData[i];
                                        }
                                    }
                                    currCount += curBPt;
                                    if (currCount >= _profileCount)
                                    {
                                        Thread.Sleep(100);
                                        tHeightData = null;
                                        tIntensityData = null;
                                        FrameLoss = null;
                                        Encoder = null;
                                        FrameId = null;
                                        GC.Collect();
                                        return 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int ReadSingleProfile(out float[] heightData, out byte[] intensityData)
        {
            uint[] EncoderData = new uint[1];
            int[] ProfData = new int[_profileSize];
            heightData = new float[_profileSize];
            intensityData = null;
            using (PinnedObject pin_Profile = new PinnedObject(ProfData))
            {
                using (PinnedObject pin_Encoder = new PinnedObject(EncoderData))
                {
                    int Rc = SR7LinkFunc.SR7IF_GetSingleProfile((uint)_ID, pin_Profile.Pointer, pin_Encoder.Pointer);
                    for (int i = 0; i < _profileSize; i++)
                    {
                        if (ProfData[i] < -10000000)
                        {
                            heightData[i] = -10.0f;
                        }
                        else
                        {
                            heightData[i] = ProfData[i] * 0.00001f;
                        }
                    }
                }
            }
            return 0;
        }

        public void SaveJob(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            BinaryWriter binWriter = new BinaryWriter(fs);
            UInt32[] pSize = new UInt32[1];
            using (PinnedObject pin_size = new PinnedObject(pSize))       //内存自动释放接
            {
                IntPtr str_Setting = SR7LinkFunc.SR7IF_ExportParameters(0, pin_size.Pointer);
                byte[] str_SettingByte = new byte[pSize[0]];
                Marshal.Copy(str_Setting, str_SettingByte, 0, (int)pSize[0]);
                if (str_Setting == null)
                {
                    LoggingIF.Log("参数保存失败");
                    return;
                }
                binWriter.Write(str_SettingByte, 0, (int)pSize[0]);
            }
            binWriter.Close();
            fs.Close();
        }

        public void LoadJob(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] SettingParam = br.ReadBytes((int)fs.Length);
            using (PinnedObject pin_set = new PinnedObject(SettingParam))       //内存自动释放接
            {
                int RT = SR7LinkFunc.SR7IF_LoadParameters(0, pin_set.Pointer, (uint)fs.Length);
                if (RT < 0)
                    LoggingIF.Log("参数加载失败");
            }
            fs.Close();
            br.Close();
        }
    }
}
