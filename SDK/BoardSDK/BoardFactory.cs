using System;

namespace BoardSDK
{
    public class BoardFactory
    {
        public static BoardBase CreateBoard(EBoardType type)
        {
            switch (type)
            {
                case EBoardType.GTS:
                    return new GenCard();
                case EBoardType.Advantech:
                    return new AdvantechBoard();
                case EBoardType.CS485IO:
                    return new CS485IOBoard();
                case EBoardType.CSCanIO:
                    return new CSCanIOBoard();
                case EBoardType.CSAXIS:
                    return new CSAX04NBoard();
                case EBoardType.RM:
                    return new RMCEP();
                case EBoardType.ELS:
                    return new ELS();
                case EBoardType.LTDMC:
                    return new LTDMCBoard();
                case EBoardType.LTSMC:
                    return new LTSMCBoard();
                default:
                    throw new Exception($"BoardBase not implemented for {type}");
            }
        }
    }
}
