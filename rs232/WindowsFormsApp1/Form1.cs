using RS232;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void terminatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Terminator selectedItem = (Terminator)Enum.Parse(typeof(Terminator), terminatorComboBox.SelectedItem.ToString(), true);
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
    }
}
