namespace BoardSDK
{
    /// <summary>
    /// 板卡接口
    /// </summary>
    public interface IBoardAxis
    {
        /// <summary>
        /// 清除轴的报警信号
        /// </summary>
        /// <param name="axisCount">轴号</param>
        bool ClearAlarm(int axis);

        /// <summary>
        /// 指定轴使能
        /// </summary>
        /// <param name="axis">轴号</param>
        /// <param name="isOn"></param>
        /// <returns>返回值:0成功</returns>
        bool SetAxisServoEnabled(int axis, bool isOn);

        /// <summary>
        /// 回原点
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="homeVelL"></param>
        /// <param name="homeVelH"></param>
        /// <param name="homeAcc"></param>
        /// <param name="homeDcc"></param>
        /// <param name="homeMode"></param>
        /// <param name="homeDir"></param>
        /// <returns></returns>
        bool GoHome(int axis, double homeVelL, double homeVelH, double homeAcc, double homeDcc, uint homeMode, uint homeDir);

        /// <summary>
        /// 检查当前轴是否停止
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        bool CheckIsStop(int axis);

        /// <summary>
        /// 获取指定轴的运动状态
        /// </summary>
        /// <param name="axis"></param>
        /// <returns>0-驱动器报警,1-正限位,2-负限位,3-原点,4-急停,5-使能</returns>
        byte GetAxisState(int axis);

        /// <summary>
        /// 获取指定轴的实际位置
        /// </summary>
        /// <param name="axis">轴号</param>
        /// <returns>位置</returns>
        double GetActPos(int axis);

        /// <summary>
        /// 设置指定轴的实际位置
        /// </summary>
        /// <param name="axis">轴号</param>
        /// <returns>位置</returns>
        void SetActPos(int axis, double pos);

        /// <summary>
        /// 获取指定轴的命令位置
        /// </summary>
        /// <param name="axis">轴号</param>
        /// <returns>位置</returns>
        double GetCmdPos(int axis);

        /// <summary>
        /// 以绝对位置做点位运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="moveVelL"></param>
        /// <param name="moveVelH"></param>
        /// <param name="moveAcc"></param>
        /// <param name="moveDcc"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        bool AbsMove(int axis, double pos);

        /// <summary>
        /// 相对运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="moveVelL"></param>
        /// <param name="moveVelH"></param>
        /// <param name="moveAcc"></param>
        /// <param name="moveDcc"></param>
        /// <param name="dist"></param>
        /// <returns></returns>
        bool RelMove(int axis, double dist);

        /// <summary>
        /// Jog运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="isPositive"></param>
        /// <param name="moveVelL"></param>
        /// <param name="moveVelH"></param>
        /// <param name="moveAcc"></param>
        /// <param name="moveDcc"></param>
        /// <returns></returns>
        bool JogMove(int axis, bool isPositive);

        /// <summary>
        /// 圆弧插补运动
        /// </summary>
        /// <param name="axis1"></param>
        /// <param name="axis2"></param>
        /// <param name="moveVelL"></param>
        /// <param name="moveVelH"></param>
        /// <param name="moveAcc"></param>
        /// <param name="moveDcc"></param>
        /// <param name="isPositive"></param>
        /// <param name="center1"></param>
        /// <param name="center2"></param>
        /// <param name="endPos1"></param>
        /// <param name="endPos2"></param>
        /// <returns></returns>
        bool CircularInterpolation(int axis1, int axis2, bool isPositive, double center1, double center2, double endPos1, double endPos2);

        /// <summary>
        /// 直线插补运动
        /// </summary>
        /// <param name="axisArr"></param>
        /// <param name="posArr"></param>
        /// <param name="moveVelL"></param>
        /// <param name="moveVelH"></param>
        /// <param name="moveAcc"></param>
        /// <param name="moveDcc"></param>
        /// <returns></returns>
        bool LineInterpolation(int[] axisArr, double[] posArr, double moveVelL, double moveVelH, double moveAcc, double moveDcc);

        /// <summary>
        /// 震荡运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="count"></param>
        /// <param name="freq"></param>
        /// <param name="amp"></param>
        /// <param name="acqInterval"></param>
        /// <returns></returns>
        bool OscillationMove(int axis, uint count, double freq, double amp, int acqInterval);

        /// <summary>
        /// 停止震荡运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        bool EndOscillation(int axis, out int[] data);

        /// <summary>
        /// 设置速度
        /// </summary>
        /// <param name="moveVelL">起步速度</param>
        /// <param name="moveVelH">运行速度</param>
        /// <param name="moveAcc">加速度</param>
        /// <param name="moveDcc">减速度</param>
        /// <returns></returns>
        bool SetSpeed(int axis, double moveVelL, double moveVelH, double moveAcc, double moveDcc);

        /// <summary>
        /// 指定轴停止
        /// </summary>
        /// <returns></returns>
        bool Stop(int axis);

        /// <summary>
        /// 紧急停止
        /// </summary>
        /// <returns></returns>
        bool InstancyStop(int axis);
    }
}
