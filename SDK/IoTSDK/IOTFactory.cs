using System;

namespace IOTSDK
{
    public enum EIOTType
    {
        M2M,
        SCADA,
    }

    public class IOTFactory
    {
        public static IOT CreateIOT(EIOTType type)
        {
            switch (type)
            {
                case EIOTType.M2M:
                    return new M2M();
                case EIOTType.SCADA:
                    return new SCADA();
                default:
                    throw new Exception($"IMes interface not implemented for {type}");
            }
        }
    }
}
