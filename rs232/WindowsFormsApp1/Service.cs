using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;


namespace RS232
{
    public class Service
    {
        private readonly SerialPort _serialPort = new SerialPort();

        public List<string> GetPortNames()
        {
            return SerialPort.GetPortNames().ToList();
        }
    }
}
