using RS232;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using static RS232.Enums;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Service service = new Service();
        //private Thread readThread;

        public Form1()
        {
            InitializeComponent();
            FormClosed += Form1_FormClosed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rateComboBox.DataSource = new List<int> { 150, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200 };
            charComboBox.DataSource = new List<string> { "8E1", "8O1", "8N2", "7E1", "7O1", "7N2" };
            terminatorComboBox.DataSource = Enum.GetNames(typeof(Terminator));
            flowControlComboBox.DataSource = Enum.GetNames(typeof(FlowControl));
            portComboBox.DataSource = service.GetPortNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rate = int.Parse(rateComboBox.Text);
            string charFormat = charComboBox.Text;
            string termStr = GetCurrentTerminatorAsString();
            FlowControl flowControl = (FlowControl)Enum.Parse(typeof(FlowControl), flowControlComboBox.Text);
            string portName = portComboBox.Text;

            bool opened = service.ConfigurePort(portName, rate, charFormat, termStr, flowControl);
            if (!opened)
            {
                richTextBox1.AppendText("Konfiguracja portu nie przebiegła pomyślnie.");
                richTextBox1.AppendText("Proszę sprawdzić ustawienia lub uruchomić program ponownie.");
                richTextBox1.AppendText(Environment.NewLine);
                return;
            }
            richTextBox1.AppendText("Konfiguracja portu przebiegła pomyślnie.");
            richTextBox1.AppendText("Można rozpocząć komunikację.");
            richTextBox1.AppendText(Environment.NewLine);
            sendButton.Enabled = true;
            messageTextBox.Enabled = true;
            DisableConfiguration();
            service.setDataReceivedHandler(new SerialDataReceivedEventHandler(DataReceivedHandler));
        }

        private string GetCurrentTerminatorAsString()
        {
            string termStr;
            Terminator terminator = ((Terminator)Enum.Parse(typeof(Terminator), terminatorComboBox.Text));
            if (!terminator.Equals(Terminator.CUSTOM))
            {
                termStr = GetStringFromTerminator(terminator);
            }
            else
            {
                termStr = terminatorTextBox.Text;
            }
            return termStr;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string message = sp.ReadExisting();
            if (!string.IsNullOrEmpty(message))
            {
                //idk what is does but fixes thread exception
                Invoke((MethodInvoker)delegate ()
                {
                    string terminator = GetCurrentTerminatorAsString();
                    message = message.Substring(0, message.Length - terminator.Length);
                    message = service.processMessage(message);
                    string time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    richTextBox1.AppendText(time + " Odebrano: " + message);
                    richTextBox1.AppendText(Environment.NewLine);
                });
            }
        }

        private void terminatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Terminator selectedItem = (Terminator)Enum.Parse(typeof(Terminator), terminatorComboBox.Text);
            if (selectedItem.Equals(Terminator.CUSTOM))
            {
                terminatorTextBox.Enabled = true;
            }
            else
            {
                terminatorTextBox.Text = string.Empty;
                terminatorTextBox.Enabled = false;
            }
        }

        private void DisableConfiguration()
        {
            rateComboBox.Enabled = false;
            startButton.Enabled = false;
            charComboBox.Enabled = false;
            terminatorComboBox.Enabled = false;
            flowControlComboBox.Enabled = false;
            portComboBox.Enabled = false;
            stopButton.Enabled = true;
            pingButton.Enabled = true;
        }

        private void EnableConfiguration()
        {
            rateComboBox.Enabled = true;
            startButton.Enabled = true;
            charComboBox.Enabled = true;
            terminatorComboBox.Enabled = true;
            flowControlComboBox.Enabled = true;
            portComboBox.Enabled = true;
            stopButton.Enabled = false;
            pingButton.Enabled = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            service.SendMessage(message);
            string time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            richTextBox1.AppendText(time + " Wysłano: " + message);
            richTextBox1.AppendText(Environment.NewLine);
            messageTextBox.Text = string.Empty;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            service.CloseConnection();
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            richTextBox1.AppendText(time + " Wysłano: PING");
            richTextBox1.AppendText(Environment.NewLine);
            service.SendPing();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            service.CloseConnection();
            EnableConfiguration();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
