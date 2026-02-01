using MeasResult;
using System.Collections.Generic;

namespace MesSDK
{
    public interface IMes
    {
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        bool Connect(MesParam param);
        
        /// <summary>
        /// 断开连接
        /// </summary>
        /// <returns></returns>
        bool DisConnect();

        /// <summary>
        /// 进站
        /// </summary>
        /// <returns></returns>
        bool Arrival(string sn, out string msg);

        /// <summary>
        /// 出站
        /// </summary>
        /// <returns></returns>
        bool Departure(string sn, List<MesResult> retList, out string msg);

        /// <summary>
        /// 出站
        /// </summary>
        /// <returns></returns>
        bool Departure(string sn, string passMsg, string failMsg, out string msg);
    }
}
