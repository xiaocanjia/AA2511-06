//----------------------------------------------------------------------------- 
// <copyright file="VONetLinkFunc.cs" company="O-NET">
//	 Copyright (c) 2021 O-NET.  All rights reserved.
// </copyright>
//----------------------------------------------------------------------------- 


using System;
using System.Runtime.InteropServices;

namespace Camera3DSDK
{
    internal class VONetLinkFunc
    {
        /***************************************************************
        *    brief VONET_FindSensorByIpAddress   查找配置设备.
        *    param sensor    [OUT]    设备（相机）对象
        *    param address   [IN]       设备ip地址
        *    return:         false:     失败.
        *                    true:      成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_FindSensorByIpAddress(string ip, out IntPtr sensor);

        /***************************************************************
        *    brief VONET_HasBuddies     查找设备伙伴.
        *    param sensor    [IN]       设备（相机）对象
        *    return:         false:     失败.
        *                    true:      成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_HasBuddies(IntPtr sensor);

        /***************************************************************
        *    brief VONET_BuddiesCount   查找设备伙伴个数.
        *    param sensor    [IN]       设备（相机）对象
        *    return:                    设备伙伴个数
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_BuddiesCount(IntPtr sensor);

        /***************************************************************
        *    brief VONET_RemoveBuddy    移除设备伙伴.
        *    param sensor    [IN]       设备（相机）对象
        *    return:       <0:          失败.
        *                   0:          成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_RemoveBuddy(IntPtr sensor);

        /***************************************************************
        *    brief VONET_AddBuddyBlocking  添加设备伙伴.
        *    param sensor    [IN]       主设备（相机）对象
        *    param buddy     [IN]       伙伴设备（相机）对象
        *    return:       <0:          失败.
        *                   0:          成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_AddBuddyBlocking(IntPtr sensor, IntPtr buddy);

        /***************************************************************
        *    brief VONET_EthernetOpenBySensor   通信连接.
        *    param sensor    [INOUT]    设备（相机）对象
        *    return:       <0:          失败.
        *                   0:          成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_EthernetOpenBySensor(IntPtr sensor);

        /***************************************************************
        *    brief VONET_GetIdBySensor  获取已连接的设备ID.
        *    param sensor    [IN]       设备（相机）对象
        *    return:                    设备ID号，范围为0-3
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_GetIdBySensor(IntPtr sensor);


        /***************************************************************
        *    brief VONET_CommClose      断开与相机的连接.
        *    param IDeviceId [IN]       设备ID号，范围为0-3
        *    return:       <0:          失败.
        *                   0:          成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_CommClose(uint IDeviceId);


        /***************************************************************
        *    brief VONET_GetVersion         获取sdk版本号.
        *    return:                        sdk版本号
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern IntPtr VONET_GetVersion();


        /***************************************************************
        *    brief VONET_GetModels          获取相机型号.
        *    param IDeviceId [IN]           设备ID号，范围为0-3
        *    return:                        相机型号
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern IntPtr VONET_GetModels(uint IDeviceId);

        /***************************************************************
        *    brief VONET_ProfilePointGetCount      当前批处理设定行数.
        *    param IDeviceId [IN]                  设备ID号，范围为0-3
        *    return:       <0:                     失败.
        *                 其他:                     实际批处理设定行数.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_ProfilePointGetCount(uint IDeviceId);


        /***************************************************************
        *    brief VONET_ProfileDataWidth   获取批处理数据宽度.
        *    param IDeviceId [IN]           设备ID号，范围为0-3
        *    return:        返回x方向上像素点数
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_ProfileDataWidth(uint IDeviceId);


        /***************************************************************
        *    brief VONET_StartMeasure       开始批处理,立即执行批处理程序.
        *    param IDeviceId [IN]           设备ID号，范围为0-3
        *    param Timeout   [IN]           非循环获取时，超时时间(单位ms).
        *    return:       <0:              失败.
        *                   0:              成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_StartMeasure(uint IDeviceId, int Timeout = 50000);


        /***************************************************************
        *    brief VONET_StartIOTriggerMeasure      开始批处理,硬件IO触发开始批处理，具体查看硬件手册.
        *    param IDeviceId [IN]                   设备ID号，范围为0-3
        *    param Timeout   [IN]                   非循环获取时，超时时间(单位ms).
        *    return:       <0:                      失败.
        *                   0:                      成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_StartIOTriggerMeasure(uint IDeviceId, int Timeout = 50000, int Restart = 0);


        /***************************************************************
        *    brief VONET_StopMeasure      停止批处理.
        *    param IDeviceId [IN]         设备ID号，范围为0-3
        *    return:       <0:            失败.
        *                   0:            成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_StopMeasure(uint IDeviceId);


        /***************************************************************
        *    brief VONET_GetBatchProfile        非阻塞式批处理获取轮廓线数据
        *    param IDeviceId        [IN]        设备ID号，范围为0-3
        *    param count            [IN]        每次获取轮廓线和亮度线的条数
        *    param profile          [OUT]       轮廓线数据缓存
        *    param intensity        [OUT]       亮度图数据缓存
        *    return:         <0:                失败.
        *                 其他值:                返回实际获取到的轮廓线和亮度线的条数.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_GetBatchProfile(uint IDeviceId, uint count, float[] center, byte[] light);    //参数的转换形式待定

        /***************************************************************
        *    brief VONET_GetBatchProfileBlock   阻塞式批处理获取轮廓线数据
        *    param IDeviceId        [IN]        设备ID号，范围为0-3
        *    param profile          [OUT]       轮廓线数据缓存
        *    param intensity        [OUT]       亮度图数据缓存
        *    return:         <0:                失败.
        *                 其他值:                返回实际获取到的轮廓线和亮度线的条数.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_GetBatchProfileBlock(uint IDeviceId, float[] profile, byte[] intensity);

        /***************************************************************
        *    brief VONET_GetBatchRollData       无限循环批处理获取轮廓线数据
        *    param IDeviceId        [IN]        设备ID号，范围为0-3
        *    param count            [IN]        每次获取轮廓线和亮度线的条数
        *    param profile          [OUT]       轮廓线数据缓存
        *    param intensity        [OUT]       亮度图数据缓存
        *    param frameLoss        [OUT]       批处理过快掉帧数量数据指针，不需要赋值为NULL
        *    return:         <0:                失败.
        *                 其他值:                返回实际获取到的轮廓线和亮度线的条数.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_GetBatchRollData(uint IDeviceId, uint count, float[] profile, byte[] intensity, uint[] frameLoss);

        /***************************************************************
        *    brief VONET_ChangeActiveProgram       切换相机活动程序编号.
        *    param IDeviceId [IN]                  设备ID号，范围为0-3
        *    param prog_no   [IN]                  工程号.
        *    return:       <0:                     失败.
        *                   0:                     成功.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_ChangeActiveProgram(uint IDeviceId, uint prog_no);

        /***************************************************************
        *    brief VONET_GetActiveProgram          获取活动程序编号.
        *    param IDeviceId [IN]                  设备ID号，范围为0-3
        *    return:       <0:                     失败.
        *                 其他:                     当前程序活动编号.
        ****************************************************************/
        [DllImport("vonet_sdk.dll")]
        internal static extern int VONET_GetActiveProgram(uint IDeviceId);

        [DllImport("vonet_sdk.dll")]
        internal static extern IntPtr VONET_ExportParameters(uint[] size);

        [DllImport("vonet_sdk.dll")]
        internal static extern void VONET_LoadParameters(byte[] param, uint size);
    }
}