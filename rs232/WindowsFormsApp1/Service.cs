using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using static RS232.Enums;
using System.Diagnostics;

namespace RS232
{
    public class Service
    {
        private SerialPort _serialPort;
        private Stopwatch sw = new Stopwatch();

        public List<string> GetPortNames()
        {
            return SerialPort.GetPortNames().ToList();
        }

        public bool ConfigurePort(string portName, int rate, string charFormat, string terminator, FlowControl flowControl)
        {
            _serialPort = new SerialPort();
            //no option to do that
            if (flowControl.Equals(FlowControl.RTS_CTS))
            {
                flowControl = FlowControl.DTR_DSR;
            }

            _serialPort.BaudRate = rate;
            _serialPort.StopBits = (StopBits)int.Parse(charFormat[2].ToString());
            _serialPort.DataBits = int.Parse(charFormat[0].ToString());
            _serialPort.PortName = portName;
            _serialPort.Handshake = (Handshake)flowControl;
            _serialPort.Parity = GetParityFromCharFormat(charFormat);

            _serialPort.NewLine = terminator;
            try
            {
                _serialPort.Open();
                return _serialPort.IsOpen;
            }
            catch
            {
                _serialPort.Close();
                return false;
            }
        }

        public void CloseConnection()
        {
            _serialPort?.Close();
        }

        public void SendMessage(string message)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine(message);
            }
        }

        public string processMessage(string message)
        {
           if (message.StartsWith("PING"))
           {
                SendMessage("PONG");
           }
           else if (message.StartsWith("PONG") && sw.IsRunning)
           {
                sw.Stop();
                return $"PONG {sw.Elapsed.TotalMilliseconds}ms";
           }
           return message;
        }

        public void setDataReceivedHandler(SerialDataReceivedEventHandler serialDataReceivedEventHandler)
        {
            _serialPort.DataReceived += serialDataReceivedEventHandler;
        }

        public void SendPing()
        {
            SendMessage("PING");
            sw.Restart();
        }

    }
}
