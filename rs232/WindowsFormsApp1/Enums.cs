using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS232
{
    public static class Enums
    {
        public enum TransmissionType { ASCII, HEX };

        public enum Terminator { CR, LF, CRLF, BRAK, CUSTOM };

        public static string GetStringFromTerminator(Terminator ter)
        {
            switch (ter)
            {
                case Terminator.CR:
                    return "\r";
                case Terminator.LF:
                    return "\n";
                case Terminator.CRLF:
                    return "\r\n";
                case Terminator.BRAK:
                case Terminator.CUSTOM:
                default:
                    return "";
            }
        }

        public enum FlowControl { XON_XOFF = 1, RTS_CTS = 2, DTR_DSR = -1, BRAK = 0 };

        public enum Signal { OB, DA, DTR, DSR, RTS, CTS, CD, RI };

        public enum SignalState { Unknown = 0, Inactive = 1, Active = 2 };
    }
}
