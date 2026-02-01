namespace BoardSDK
{
    public class BoardBase
    {
        protected bool _isConnected = false;

        /// <summary>
        /// 连接板卡
        /// </summary>
        /// <returns></returns>
        public virtual bool Connect(string filePath) { return true; }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <returns></returns>
        public virtual bool Disconnect() { return true; }

        /// <summary>
        /// 检测是否连接
        /// </summary>
        /// <returns></returns>
        public virtual bool CheckConnect() { return true; }
    }
}
