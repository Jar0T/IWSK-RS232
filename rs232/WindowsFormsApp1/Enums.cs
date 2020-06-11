using System.IO.Ports;

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

        public static Parity GetParityFromCharFormat(string charFormat)
        {
            char par = charFormat[1];
            switch (par)
            {
                case 'O':
                    return Parity.Odd;
                case 'E':
                    return Parity.Even;
                case 'N':
                default:
                    return Parity.None;
            }
        }

        public enum FlowControl { BRAK, XON_XOFF, RTS_CTS, DTR_DSR };
    }
}
