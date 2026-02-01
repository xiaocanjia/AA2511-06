namespace Camera3DSDK
{
    public interface I3DCamera
    {
        /// <summary>
        /// 连接相机
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="port"></param>
        bool Connect(string IP, string port);

        /// <summary>
        /// 断开相机
        /// </summary>
        void Disconnect();

        /// <summary>
        /// 清除缓存
        /// </summary>
        void ClearBuffer();

        /// <summary>
        /// Switch on/off laser
        /// </summary>
        /// <param name="isOn"></param>
        void SwitchLaser(bool isOn);

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
        /// Read batch profiles
        /// </summary>
        /// <param name="heightData"></param>
        /// <param name="intensityData"></param>
        /// <returns>0-success, 1-fail</returns>
        int ReadBatchProfiles(out float[] heightData, out byte[] intensityData);

        /// <summary>
        /// Read single profile
        /// </summary>
        /// <param name="heightData"></param>
        /// <param name="intensityData"></param>
        /// <returns>0-success, 1-fail</returns>
        int ReadSingleProfile(out float[] heightData, out byte[] intensityData);

        /// <summary>
        /// Load sensor job
        /// </summary>
        /// <param name="filePath"></param>
        void LoadJob(string filePath);

        /// <summary>
        /// Save sensor job
        /// </summary>
        /// <param name="filePath"></param>
        void SaveJob(string filePath);
    }
}
