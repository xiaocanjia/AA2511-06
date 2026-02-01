using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MeasResult;
using System.Text;

namespace MesSDK
{
    public class Honor : IMes
    {
        [DllImport("MinMesSock - x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ValidateBoardWorkState(string IpAddr, string barcode, string StationName, string ProductName, [MarshalAs(UnmanagedType.LPStr)]StringBuilder ouputMsg, Int32 nLengthMsg);

        [DllImport("MinMesSock - x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SubmitBoardWorkState(string IpAddr, string barcode, string StationName, string ProductName, Int32 Slot_ID, Int32 result, [MarshalAs(UnmanagedType.LPStr)]StringBuilder outputMsg, Int32 nLengthMsg);

        private MesParam _param;

        public bool Connect(MesParam param)
        {
            _param = param;
            return true;
        }

        public bool DisConnect()
        {
            return true;
        }

        public bool Arrival(string sn, out string msg)
        {
            try
            {
                StringBuilder output = new StringBuilder(1024);
                bool ret = ValidateBoardWorkState(_param.IP, sn, _param.StationID, _param.ProductID, output, 1024);
                msg = $"产品{sn}入站信息：" + output.ToString();
                return ret;
            }
            catch (Exception ex)
            {
                msg = $"产品{sn}入站异常：" + ex.Message;
                return false;
            }
        }

        public bool Departure(string sn, List<MesResult> retList, out string msg)
        {
            try
            {
                int dec = retList.Find((mRet) => mRet.Decision == "FAIL") == null ? 1 : 0;
                StringBuilder output = new StringBuilder(1024);
                bool ret = SubmitBoardWorkState(_param.IP, sn, _param.StationID, _param.ProductID, Convert.ToInt32(_param.Lot), dec, output, 1024);
                msg = $"产品{sn}出站信息：" + output.ToString();
                return ret;
            }
            catch (Exception ex)
            {
                msg = $"产品{sn}出站异常：" + ex.Message;
                return false;
            }
        }

        public bool Departure(string sn, string passMsg, string failMsg, out string msg)
        {
            throw new NotImplementedException();
        }
    }
}
