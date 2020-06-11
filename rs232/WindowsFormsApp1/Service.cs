using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using static RS232.Enums;
using System.Diagnostics;

namespace RS232
{
    public class Service
    {
        private readonly SerialPort _serialPort = new SerialPort();
        private Stopwatch sw = new Stopwatch();


        public List<string> GetPortNames()
        {
            return SerialPort.GetPortNames().ToList();
        }

        public bool ConfigurePort(string portName, int rate, string charFormat, Terminator terminator, FlowControl flowControl, TransmissionType transmissionType, double timeout)
        {
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
            _serialPort.ReadTimeout = (int)(timeout * 100);
            _serialPort.WriteTimeout = (int)(timeout * 100);
            _serialPort.NewLine = GetStringFromTerminator(terminator);
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

        public void SendMessage(string message)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine(message);
            }
        }

        public string ReceiveMessage()
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadLine();

                    // check if ping
                    if (message.Equals("PING"))
                    {
                        SendMessage("PONG");
                        return null;
                    }
                    else if (message.Equals("PONG"))
                    {
                        sw.Stop();
                        return "PING {sw.Elapsed.TotalMilliseconds}ms";
                    }

                    return message;
                }
                catch {  }
            }
            return null;
        }

        public void SendPing()
        {
            sw.Restart();
            SendMessage("PING");
        }

    }
}
