using System;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.RichClient
{
    public partial class Group : Form
    {
        private string r1;
        private string g1;
        private string b1;
        private string r2;
        private string g2;
        private string b2;
        private string r3;
        private string g3;
        private string b3;
        private string r4;
        private string g4;
        private string b4;
        private string r5;
        private string g5;
        private string b5;
        private string r6;
        private string g6;
        private string b6;
        private string package1;
        private string package2;
        private string package3;
        private string package4;
        private string package5;
        private string package6;
        private int delay1;
        private int delay2;
        private int delay3;
        private int delay4;
        private int delay5;
        private int delay6;
        private string box;
        private int moder1;
        private int moder2;
        private int moder3;
        private int moder4;
        private int moder5;
        private int moder6;
        public SerialPort Comport1;
        public SerialPort Comport2;
        public SerialPort Comport3;
        public SerialPort Comport4;
        public SerialPort Comport5;
        public SerialPort Comport6;
        public bool check11;
        public bool check12;
        public bool check13;
        public bool check14;
        public bool check15;
        public bool check16;
        public bool check21;
        public bool check22;
        public bool check23;
        public bool check24;
        public bool check25;
        public bool check26;
        public bool check31;
        public bool check32;
        public bool check33;
        public bool check34;
        public bool check35;
        public bool check36;
        public bool check41;
        public bool check42;
        public bool check43;
        public bool check44;
        public bool check45;
        public bool check46;
        public bool check51;
        public bool check52;
        public bool check53;
        public bool check54;
        public bool check55;
        public bool check56;
        public bool check61;
        public bool check62;
        public bool check63;
        public bool check64;
        public bool check65;
        public bool check66;
        public bool check01;
        public bool check02;
        public bool check03;
        public bool check04;
        public bool check05;
        public bool check06;

        public Group()
        {
            InitializeComponent();
            
            Comport1 = new SerialPort();
            Comport2 = new SerialPort();
            Comport3 = new SerialPort();
            Comport4 = new SerialPort();
            Comport5 = new SerialPort();
            Comport6 = new SerialPort();
            try
            {
                Comport1.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            check01 = checkedListBox1.GetItemChecked(0);
            check02 = checkedListBox1.GetItemChecked(1);
            check03 = checkedListBox1.GetItemChecked(2);
            check04 = checkedListBox1.GetItemChecked(3);
            check05 = checkedListBox1.GetItemChecked(4);
            check06 = checkedListBox1.GetItemChecked(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                r1 = clr.R.ToString();
                g1 = clr.G.ToString();
                b1 = clr.B.ToString();
                panel1.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                r2 = clr.R.ToString();
                g2 = clr.G.ToString();
                b2 = clr.B.ToString();
                panel2.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                r3 = clr.R.ToString();
                g3 = clr.G.ToString();
                b3 = clr.B.ToString();
                panel3.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                r4 = clr.R.ToString();
                g4 = clr.G.ToString();
                b4 = clr.B.ToString();
                panel4.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                r5 = clr.R.ToString();
                g5 = clr.G.ToString();
                b5 = clr.B.ToString();
                panel5.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                r6 = clr.R.ToString();
                g6 = clr.G.ToString();
                b6 = clr.B.ToString();
                panel6.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Off")
            {
                moder1 = 0;
            }
            if (comboBox1.Text == "Solid")
            {
                moder1 = 1;
            }
            if (comboBox1.Text == "Random Cloudy")
            {
                moder1 = 2;
            }
            if (comboBox1.Text == "Flash")
            {
                moder1 = 3;
            }
            if (comboBox1.Text == "Sweep")
            {
                moder1 = 4;
            }
            if (comboBox1.Text == "Twinkle")
            {
                moder1 = 5;
            }
            if (comboBox1.Text == "Random Twinkle")
            {
                moder1 = 6;
            }
            if (comboBox1.Text == "Fade")
            {
                moder1 = 7;
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            Comport1.PortName = "COM4";
            Comport1.BaudRate = 9600;
            Comport1.Parity = Parity.None;
            Comport1.DataBits = 8;
            Comport1.StopBits = StopBits.One;
            Comport1.Encoding = Encoding.ASCII;
            Comport2.PortName = "COM5";
            Comport2.BaudRate = 9600;
            Comport2.Parity = Parity.None;
            Comport2.DataBits = 8;
            Comport2.StopBits = StopBits.One;
            Comport2.Encoding = Encoding.ASCII;
            Comport3.PortName = "COM6";
            Comport3.BaudRate = 9600;
            Comport3.Parity = Parity.None;
            Comport3.DataBits = 8;
            Comport3.StopBits = StopBits.One;
            Comport3.Encoding = Encoding.ASCII;
            Comport4.PortName = "COM7";
            Comport4.BaudRate = 9600;
            Comport4.Parity = Parity.None;
            Comport4.DataBits = 8;
            Comport4.StopBits = StopBits.One;
            Comport4.Encoding = Encoding.ASCII;
            Comport5.PortName = "COM8";
            Comport5.BaudRate = 9600;
            Comport5.Parity = Parity.None;
            Comport5.DataBits = 8;
            Comport5.StopBits = StopBits.One;
            Comport5.Encoding = Encoding.ASCII;
            Comport6.PortName = "COM9";
            Comport6.BaudRate = 9600;
            Comport6.Parity = Parity.None;
            Comport6.DataBits = 8;
            Comport6.StopBits = StopBits.One;
            Comport6.Encoding = Encoding.ASCII;
            Comport1.Open();
            Comport2.Open();
            Comport3.Open();
            Comport4.Open();
            Comport5.Open();
            Comport6.Open();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            box = "1";
            delay1 = command1Delay.Value;
            package1 = $"T0C{box}R{r1}G{g1}B{b1}D{delay1}X0M{moder1}~";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            box = "1";
            delay2 = command2Delay.Value;
            package2 = $"T0C{box}R{r2}G{g2}B{b2}D{delay2}X0M{moder2}~";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            box = "1";
            delay3 = command3Delay.Value;
            package3 = $"T0C{box}R{r3}G{g3}B{b3}D{delay3}X0M{moder3}~";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            box = "1";
            delay4 = command3Delay.Value;
            package4 = $"T0C{box}R{r4}G{g4}B{b4}D{delay4}X0M{moder4}~";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            box = "1";
            delay5 = command5Delay.Value;
            package5 = $"T0C{box}R{r5}G{g5}B{b5}D{delay5}X0M{moder5}~";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            box = "1";
            delay6 = command6Delay.Value;
            package6 = $"T0C{box}R{r6}G{g6}B{b6}D{delay6}X0M{moder6}~";
        }

        private async void QueueUpNow_ClickAsync(object sender, EventArgs e)
        {
            string package = string.Empty;
            int qDelay = 0;
            Action packagePortSender = null;
            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        package = package1 ?? string.Empty;
                        qDelay = q1Delay.Value;
                        packagePortSender = () => booltopackage0(true, package);
                        break;
                    case 2:
                        package = package2 ?? string.Empty;
                        qDelay = q2Delay.Value;
                        packagePortSender = () => booltopackage1(true, package);
                        break;
                    case 3:
                        package = package3 ?? string.Empty;
                        qDelay = q3Delay.Value;
                        packagePortSender = () => booltopackage2(true, package);
                        break;
                    case 4:
                        package = package4 ?? string.Empty;
                        qDelay = q4Delay.Value;
                        packagePortSender = () => booltopackage3(true, package);
                        break;
                    case 5:
                        package = package5 ?? string.Empty;
                        qDelay = q5Delay.Value;
                        packagePortSender = () => booltopackage4(true, package);
                        break;
                    case 6:
                        package = package6 ?? string.Empty;
                        qDelay = q6Delay.Value;
                        packagePortSender = () => booltopackage5(true, package);
                        break;
                    default:
                        break;
                }

                if (string.IsNullOrEmpty(package.Trim()))
                    continue;

                // send payload out serial port and wait
                var payloadSenderTask = Task.Run(packagePortSender);
                var delayTask = Task.Delay(TimeSpan.FromSeconds(qDelay));
                await Task.WhenAll(payloadSenderTask, delayTask); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boolset1
            booltopackage0(check11, package1);
            booltopackage0(check12, package1);
            booltopackage0(check13, package1);
            booltopackage0(check14, package1);
            booltopackage0(check15, package1);
            booltopackage0(check16, package1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //boolset2
            booltopackage1(check21, package2);
            booltopackage1(check22, package2);
            booltopackage1(check23, package2);
            booltopackage1(check24, package2);
            booltopackage1(check25, package2);
            booltopackage1(check26, package2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boolset3
            booltopackage2(check31, package3);
            booltopackage2(check32, package3);
            booltopackage2(check33, package3);
            booltopackage2(check34, package3);
            booltopackage2(check35, package3);
            booltopackage2(check36, package3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boolset4
            booltopackage3(check41, package4);
            booltopackage3(check42, package4);
            booltopackage3(check43, package4);
            booltopackage3(check44, package4);
            booltopackage3(check45, package4);
            booltopackage3(check46, package4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //boolset5
            booltopackage4(check51, package5);
            booltopackage4(check52, package5);
            booltopackage4(check53, package5);
            booltopackage4(check54, package5);
            booltopackage4(check55, package5);
            booltopackage4(check56, package5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //boolset6
            booltopackage5(check61, package6);
            booltopackage5(check62, package6);
            booltopackage5(check63, package6);
            booltopackage5(check64, package6);
            booltopackage5(check65, package6);
            booltopackage5(check66, package6);
        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {     
            check01 = checkedListBox7.GetItemChecked(0);
            check02 = checkedListBox7.GetItemChecked(1);
            check03 = checkedListBox7.GetItemChecked(2);
            check04 = checkedListBox7.GetItemChecked(3);
            check05 = checkedListBox7.GetItemChecked(4);
            check06 = checkedListBox7.GetItemChecked(5);
        }
        void booltopackage0(bool bob, string sender)
        {
            if (bob == true && Comport1.IsOpen)
            {
                Comport1.Write(sender);
            }
        }
        void booltopackage1(bool bob, string sender)
        {
            if (bob == true && Comport2.IsOpen)
            {
                Comport2.Write(sender);
            }
        }
        void booltopackage2(bool bob, string sender)
        {
            if (bob == true && Comport3.IsOpen)
            {
                Comport3.Write(sender);
            }
        }
        void booltopackage3(bool bob, string sender)
        {
            if (bob == true && Comport4.IsOpen)
            {
                Comport4.Write(sender);
            }
        }
        void booltopackage4(bool bob, string sender)
        {
            if (bob == true && Comport5.IsOpen)
            {
                Comport5.Write(sender);
            }
        }
        void booltopackage5(bool bob, string sender)
        {
            if (bob == true && Comport6.IsOpen)
            {
                Comport6.Write(sender);
            }
        }
    }
}
