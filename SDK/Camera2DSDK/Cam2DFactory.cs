using System;

namespace Camera2DSDK
{
    public class Cam2DFactory
    {
        public static I2DCamera Create2DCamera(ECam2DType camType)
        {
            switch (camType)
            {
                case ECam2DType.HIK:
                    return new MVDevice();
                default:
                    return new MVDevice();
            }
        }
    }
}
