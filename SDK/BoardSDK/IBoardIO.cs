namespace BoardSDK
{
    public interface IBoardIO
    {
        /// <summary>
        /// 设置输出
        /// </summary>
        /// <param name="IOIdx">轴序号</param>
        /// <param name="IOIdx">IO序号</param>
        /// <param name="Value"></param>
        /// <returns>是否设置成功</returns>
        bool SetOut(int axisIdx, int IOIdx, bool Value);

        /// <summary>
        /// 获取指定位输出值
        /// </summary>
        /// <param name="IOIdx">轴序号</param>
        /// <param name="IOIdx">IO序号</param>
        /// <returns></returns>
        bool GetOut(int axisIdx, int IOIdx);

        /// <summary>
        /// 获取输入口值
        /// </summary>
        /// <param name="IOIdx">轴序号</param>
        /// <param name="IOIdx">IO序号</param>
        /// <returns></returns>
        bool GetIn(int axisIdx, int IOIdx);
    }
}
