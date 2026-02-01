using System.Collections.Generic;

namespace IOTSDK
{
    public interface IOT
    {
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        bool Connect(IOTParam param);

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <returns></returns>
        bool DisConnect();

        /// <summary>
        /// 心跳
        /// </summary>
        /// <returns></returns>
        bool Heartbeat(out string msg);

        /// <summary>
        /// 上传结果
        /// </summary>
        /// <returns></returns>
        bool UploadResults(string sn, double ct, List<MesResult> retList, out string msg);

        /// <summary>
        /// 上传报警信息
        /// </summary>
        /// <param name="alarmType"></param>
        /// <param name="content"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        bool UploadAlarm(string severity, string category, string id, string content, out string msg);

        /// <summary>
        /// 上传设备状态
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        bool UploadDeviceState(string state, out string msg);

        /// <summary>
        /// 上传产品状态
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        bool UploadProductState(string sn, string state, out string msg);

        /// <summary>
        /// 清除报警
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        bool ClearAlarm(out string msg);

        /// <summary>
        /// 切换工单
        /// </summary>
        /// <returns></returns>
        bool UploadRecipeState(string recipe, string state, object content, out string msg);

        /// <summary>
        /// 切换权限
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        bool UploadCurrRight(string right, out string msg);
    }
}
