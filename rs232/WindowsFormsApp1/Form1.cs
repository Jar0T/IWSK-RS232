using RS232;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static RS232.Enums;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Service service = new Service();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rateComboBox.DataSource = new List<int> { 150, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200 };
            charComboBox.DataSource = new List<string> { "8E1", "8O1", "8N2", "7E1", "7O1", "7N2" };
            terminatorComboBox.DataSource = Enum.GetNames(typeof(Terminator));
            flowControlComboBox.DataSource = Enum.GetNames(typeof(FlowControl));
            transmissionTypeComboBox.DataSource = Enum.GetNames(typeof(TransmissionType));
            portComboBox.DataSource = service.GetPortNames();
            timeoutComboBox.DataSource = Enumerable.Range(1, 1000).Select(it => ((double)it) / 100).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rate = int.Parse(rateComboBox.Text);
            string charFormat = charComboBox.Text;
            Terminator terminator = (Terminator)Enum.Parse(typeof(Terminator), terminatorComboBox.Text);
            FlowControl flowControl = (FlowControl)Enum.Parse(typeof(FlowControl), flowControlComboBox.Text);
            TransmissionType transmissionType = (TransmissionType)Enum.Parse(typeof(TransmissionType), transmissionTypeComboBox.Text);
            string portName = portComboBox.Text;
            double timeout = double.Parse(timeoutComboBox.Text);

            bool opened = service.ConfigurePort(portName, rate, charFormat, terminator, flowControl, transmissionType, timeout);
            if (!opened)
            {
                richTextBox1.AppendText("Konfiguracja portu nie przebiegła pomyślnie.");
                richTextBox1.AppendText("Proszę sprawdzić ustawienia lub uruchomić program ponownie.");
                return;
            }

            richTextBox1.AppendText("Konfiguracja portu przebiegła pomyślnie.");
            richTextBox1.AppendText("Można rozpocząć komunikację.");
            sendButton.Enabled = true;
            messageTextBox.Enabled = true;
            DisableConfiguration();
            new Thread(() =>
            {
                while (true)
                {
                    string message = service.ReceiveMessage();
                    if (!string.IsNullOrEmpty(message))
                    {
                        richTextBox1.AppendText(Environment.NewLine);
                        string time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        richTextBox1.AppendText(time + " Odebrano: " + message);
                    }
                }
            }).Start();


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
            transmissionTypeComboBox.Enabled = false;
            portComboBox.Enabled = false;
            timeoutComboBox.Enabled = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            service.SendMessage(message);
            richTextBox1.AppendText(Environment.NewLine);
            string time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            richTextBox1.AppendText(time + " Wysłano: " + message);
            messageTextBox.Text = string.Empty;
        }

    }
}
