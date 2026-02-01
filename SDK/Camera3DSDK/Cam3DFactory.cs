using System;

namespace Camera3DSDK
{
    public class Cam3DFactory
    {
        public static I3DCamera Create3DCamera(ECamera3DType cameraType)
        {
            switch (cameraType)
            {
                case ECamera3DType.LJX8020:
                case ECamera3DType.LJX8060:
                case ECamera3DType.LJX8080:
                case ECamera3DType.LJX8200:
                case ECamera3DType.LJX8400:
                case ECamera3DType.LJX8900:
                    return new KeyenceLJX8XXX(cameraType);
                case ECamera3DType.LMI2420:
                    return new LMILine();
                case ECamera3DType.MVSTEREO:
                    return new MvStereo();
                case ECamera3DType.LP3030M:
                case ECamera3DType.LP3060M:
                case ECamera3DType.LP3240M:
                    return new VoNetLP3000(cameraType);
                case ECamera3DType.SR7050:
                case ECamera3DType.SR7060:
                case ECamera3DType.SR7080:
                case ECamera3DType.SR8060:
                    return new SSZNSR7000(cameraType);
                case ECamera3DType.LVM2520:
                    return new LVMCapture();
                case ECamera3DType.LCI1220:
                    return new LCI(cameraType);
                default:
                    throw new Exception($"I3DScanner interface not implemented for {cameraType}");
            }
        }
    }
}
