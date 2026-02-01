using System;

namespace Camera2DSDK
{
    public interface I2DCamera
    {
        /// <summary>
        /// 连接相机
        /// </summary>
        /// <param name="Name"></param>
        bool Connect(string Name);

        /// <summary>
        /// 断开相机
        /// </summary>
        void Disconnect();

        /// <summary>
        /// 检测相机连接状态
        /// </summary>
        /// <returns></returns>
        bool CheckConnection();

        /// <summary>
        /// Set working params  
        /// trigger mode, exposure...
        /// </summary>
        /// <param name="name"></param>
        /// <param name="val"></param>
        void SetParams(EParamNames name, object val);

        /// <summary>
        /// Get working params  
        /// trigger mode, exposure...
        /// </summary>
        /// <param name="name"></param>
        /// <param name="val"></param>
        object GetParams(EParamNames name);

        /// <summary>
        /// Start grabing image
        /// </summary>
        void Open();

        /// <summary>
        /// Stop grabing image
        /// </summary>
        /// <returns></returns>
        void Close();
        
        void GrabImage(out IntPtr pData, out int width, out int height);

        /// <summary>
        /// Register callback;
        /// </summary>
        /// <param name="OnRcvPtrImage"></param>
        void GrabImageRGB(out IntPtr pData, out int width, out int height);

        /// <summary>
        /// 打开/关闭软件触发
        /// </summary>
        /// <param name="isOn"></param>
        void SwitchSoftTrigger(bool isOn);

        /// <summary>
        /// 触发一次拍照
        /// </summary>
        void TriggerOnce();
    }
}
