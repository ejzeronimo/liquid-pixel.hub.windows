using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.RichClient
{
    public partial class Ports : Form
    {
        public SerialPort Comport1;
        public SerialPort Comport2;
        public SerialPort Comport3;
        public SerialPort Comport4;
        public SerialPort Comport5;
        public SerialPort Comport6;
        public Ports()
        {
            InitializeComponent();
            Comport1 = new SerialPort();
            Comport2 = new SerialPort();
            Comport3 = new SerialPort();
            Comport4 = new SerialPort();
            Comport5 = new SerialPort();
            Comport6 = new SerialPort();
        }

        private void Ports_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comport1.PortName = Box1.Text;
            Comport1.BaudRate = 9600;
            Comport1.Parity = Parity.None;
            Comport1.DataBits = 8;
            Comport1.StopBits = StopBits.One;
            Comport1.Encoding = Encoding.ASCII;
            try
            {
                Comport1.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comport2.PortName = Box2.Text;
            Comport2.BaudRate = 9600;
            Comport2.Parity = Parity.None;
            Comport2.DataBits = 8;
            Comport2.StopBits = StopBits.One;
            Comport2.Encoding = Encoding.ASCII;
            try
            {
                Comport2.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comport3.PortName = Box3.Text;
            Comport3.BaudRate = 9600;
            Comport3.Parity = Parity.None;
            Comport3.DataBits = 8;
            Comport3.StopBits = StopBits.One;
            Comport3.Encoding = Encoding.ASCII;
            try
            {
                Comport3.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comport4.PortName = Box4.Text;
            Comport4.BaudRate = 9600;
            Comport4.Parity = Parity.None;
            Comport4.DataBits = 8;
            Comport4.StopBits = StopBits.One;
            Comport4.Encoding = Encoding.ASCII;
            try
            {
                Comport4.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Comport5.PortName = Box5.Text;
            Comport5.BaudRate = 9600;
            Comport5.Parity = Parity.None;
            Comport5.DataBits = 8;
            Comport5.StopBits = StopBits.One;
            Comport5.Encoding = Encoding.ASCII;
            try
            {
                Comport5.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Comport6.PortName = Box6.Text;
            Comport6.BaudRate = 9600;
            Comport6.Parity = Parity.None;
            Comport6.DataBits = 8;
            Comport6.StopBits = StopBits.One;
            Comport6.Encoding = Encoding.ASCII;
            try
            {
                Comport6.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }
    }
}
