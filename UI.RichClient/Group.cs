using System;
using System.Collections.Generic;
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
        public bool IsComport1Connected => Comport1.IsOpen;
        public SerialPort Comport2;
        public bool IsComport2Connected => Comport2.IsOpen;
        public SerialPort Comport3;
        public bool IsComport3Connected => Comport3.IsOpen;
        public SerialPort Comport4;
        public bool IsComport4Connected => Comport4.IsOpen;
        public SerialPort Comport5;
        public bool IsComport5Connected => Comport5.IsOpen;
        public SerialPort Comport6;
        public bool IsComport6Connected => Comport6.IsOpen;
        public CheckedListBox.CheckedIndexCollection command1SelectedCommPorts;
        public CheckedListBox.CheckedIndexCollection command2SelectedCommPorts;
        public CheckedListBox.CheckedIndexCollection command3SelectedCommPorts;
        public CheckedListBox.CheckedIndexCollection command4SelectedCommPorts;
        public CheckedListBox.CheckedIndexCollection command5SelectedCommPorts;
        public CheckedListBox.CheckedIndexCollection command6SelectedCommPorts;
        public CheckedListBox.CheckedIndexCollection queueSelectedCommands;

        public Group()
        {
            InitializeComponent();

            // custom wired queue this event handlers
            button1.Click += (sender, EventArgs) => { queueCommand_Click(sender, EventArgs, 0, package1, command1SelectedCommPorts); };
            button2.Click += (sender, EventArgs) => { queueCommand_Click(sender, EventArgs, 1, package2, command2SelectedCommPorts); };
            button3.Click += (sender, EventArgs) => { queueCommand_Click(sender, EventArgs, 2, package3, command3SelectedCommPorts); };
            button4.Click += (sender, EventArgs) => { queueCommand_Click(sender, EventArgs, 3, package4, command4SelectedCommPorts); };
            button5.Click += (sender, EventArgs) => { queueCommand_Click(sender, EventArgs, 4, package5, command5SelectedCommPorts); };
            button6.Click += (sender, EventArgs) => { queueCommand_Click(sender, EventArgs, 5, package6, command6SelectedCommPorts); };

            // custom wired select mode event handlers
            mode1ComboBox.SelectedIndexChanged += (sender, EventArgs) => { modeComboBox_SelectedIndexChanged(sender, EventArgs, ref moder1); };
            mode2ComboBox.SelectedIndexChanged += (sender, EventArgs) => { modeComboBox_SelectedIndexChanged(sender, EventArgs, ref moder2); };
            mode3ComboBox.SelectedIndexChanged += (sender, EventArgs) => { modeComboBox_SelectedIndexChanged(sender, EventArgs, ref moder3); };
            mode4ComboBox.SelectedIndexChanged += (sender, EventArgs) => { modeComboBox_SelectedIndexChanged(sender, EventArgs, ref moder4); };
            mode5ComboBox.SelectedIndexChanged += (sender, EventArgs) => { modeComboBox_SelectedIndexChanged(sender, EventArgs, ref moder5); };
            mode6ComboBox.SelectedIndexChanged += (sender, EventArgs) => { modeComboBox_SelectedIndexChanged(sender, EventArgs, ref moder6); };

            Comport1 = new SerialPort();
            Comport2 = new SerialPort();
            Comport3 = new SerialPort();
            Comport4 = new SerialPort();
            Comport5 = new SerialPort();
            Comport6 = new SerialPort();
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

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e, ref int moder)
        {
            var comboBox = (ComboBox)sender;
            if (comboBox.Text == "Off")
            {
                moder = 0;
                return;
            }
            if (comboBox.Text == "Solid")
            {
                moder = 1;
                return;
            }
            if (comboBox.Text == "Random Cloudy")
            {
                moder = 2;
                return;
            }
            if (comboBox.Text == "Flash")
            {
                moder = 3;
                return;
            }
            if (comboBox.Text == "Sweep")
            {
                moder = 4;
                return;
            }
            if (comboBox.Text == "Twinkle")
            {
                moder = 5;
                return;
            }
            if (comboBox.Text == "Random Twinkle")
            {
                moder = 6;
                return;
            }
            if (comboBox.Text == "Random Flash")
            {
                moder = 7;
                return;
            }
            if (comboBox.Text == "Theater Chase")
            {
                moder = 8;
                return;
            }
            if (comboBox.Text == "Chroma")
            {
                moder = 9;
                return;
            }
            if (comboBox.Text == "Fade In")
            {
                moder = 10;
                return;
            }
            if (comboBox.Text == "Fade Out")
            {
                moder = 11;
                return;
            }
            if (comboBox.Text == "Sudden Flash")
            {
                moder = 12;
                return;
            }
            if (comboBox.Text == "Random Breath")
            {
                moder = 13;
                return;
            }
            if (comboBox.Text == "Breath")
            {
                moder = 14;
                return;
            }
        }


        private void initializeCommPortsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Comport1.PortName = Global.port1;
                Comport1.BaudRate = 9600;
                Comport1.Parity = Parity.None;
                Comport1.DataBits = 8;
                Comport1.StopBits = StopBits.One;
                Comport1.Encoding = Encoding.ASCII;
                Comport2.PortName = Global.port2;
                Comport2.BaudRate = 9600;
                Comport2.Parity = Parity.None;
                Comport2.DataBits = 8;
                Comport2.StopBits = StopBits.One;
                Comport2.Encoding = Encoding.ASCII;
                Comport3.PortName = Global.port3;
                Comport3.BaudRate = 9600;
                Comport3.Parity = Parity.None;
                Comport3.DataBits = 8;
                Comport3.StopBits = StopBits.One;
                Comport3.Encoding = Encoding.ASCII; 
                Comport4.PortName = Global.port4;
                Comport4.BaudRate = 9600;
                Comport4.Parity = Parity.None;
                Comport4.DataBits = 8;
                Comport4.StopBits = StopBits.One;
                Comport4.Encoding = Encoding.ASCII;
                Comport5.PortName = Global.port5;
                Comport5.BaudRate = 9600;
                Comport5.Parity = Parity.None;
                Comport5.DataBits = 8;
                Comport5.StopBits = StopBits.One;
                Comport5.Encoding = Encoding.ASCII;
                Comport6.PortName = Global.port6;
                Comport6.BaudRate = 9600;
                Comport6.Parity = Parity.None;
                Comport6.DataBits = 8;
                Comport6.StopBits = StopBits.One;
                Comport6.Encoding = Encoding.ASCII;
            }
            catch { }
            Global.CommPortsConnectionStatus.Clear();

            try
            {
                Comport1.Open();
                Global.CommPortsConnectionStatus.Add(Comport1.PortName, Comport1.IsOpen);
            }
            catch { }

            try
            {
                Comport2.Open();
                Global.CommPortsConnectionStatus.Add(Comport2.PortName, Comport2.IsOpen);
            }
            catch { }

            try
            {
                Comport3.Open();
                Global.CommPortsConnectionStatus.Add(Comport3.PortName, Comport3.IsOpen);
            }
            catch { }

            try
            {
                Comport4.Open();
                Global.CommPortsConnectionStatus.Add(Comport4.PortName, Comport4.IsOpen);
            }
            catch { }

            try
            {
                Comport5.Open();
                Global.CommPortsConnectionStatus.Add(Comport5.PortName, Comport5.IsOpen);
            }
            catch { }

            try
            {
                Comport6.Open();
                Global.CommPortsConnectionStatus.Add(Comport5.PortName, Comport5.IsOpen);
            }
            catch { }
            
            
          
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
            delay4 = command4Delay.Value;
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
            for (int i = 0; i < queueSelectedCommands?.Count; i++)
            {
                switch (queueSelectedCommands[i])
                {
                    case 0:
                        package = package1 ?? string.Empty;
                        qDelay = q1Delay.Value;
                        packagePortSender = () => queueCommand_Click(sender, e, 0, package, command1SelectedCommPorts);
                        break;
                    case 1:
                        package = package2 ?? string.Empty;
                        qDelay = q2Delay.Value;
                        packagePortSender = () => queueCommand_Click(sender, e, 0, package, command2SelectedCommPorts);
                        break;
                    case 2:
                        package = package3 ?? string.Empty;
                        qDelay = q3Delay.Value;
                        packagePortSender = () => queueCommand_Click(sender, e, 0, package, command3SelectedCommPorts);
                        break;
                    case 3:
                        package = package4 ?? string.Empty;
                        qDelay = q4Delay.Value;
                        packagePortSender = () => queueCommand_Click(sender, e, 0, package, command4SelectedCommPorts);
                        break;
                    case 4:
                        package = package5 ?? string.Empty;
                        qDelay = q5Delay.Value;
                        packagePortSender = () => queueCommand_Click(sender, e, 0, package, command5SelectedCommPorts);
                        break;
                    case 5:
                        package = package6 ?? string.Empty;
                        qDelay = q6Delay.Value;
                        packagePortSender = () => queueCommand_Click(sender, e, 0, package, command6SelectedCommPorts);
                        break;
                    default:
                        break;
                }

                // send payload out serial port and wait
                var payloadSenderTask = Task.Run(packagePortSender);
                var delayTask = Task.Delay(TimeSpan.FromSeconds(qDelay));
                await Task.WhenAll(payloadSenderTask, delayTask); 
            }
        }

        private void queueCommand_Click(object sender, EventArgs e, int index, string package, CheckedListBox.CheckedIndexCollection checkedCommPorts)
        {
            int selectedIndex;
            for (int i = 0; i < checkedCommPorts?.Count; i++)
            {
                selectedIndex = checkedCommPorts[i];
                SendDataToSerialPorts(package, selectedIndex);
            }
        }

        private void command1CommPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            command1SelectedCommPorts = command1CommPortCheckedListBox.CheckedIndices;
        }

        private void command2CommPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            command2SelectedCommPorts = command2CommPortCheckedListBox.CheckedIndices;
        }

        private void command3CommPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            command3SelectedCommPorts = command3CommPortCheckedListBox.CheckedIndices;
        }

        private void command4CommPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            command4SelectedCommPorts = command4CommPortCheckedListBox.CheckedIndices;
        }

        private void command5CommPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            command5SelectedCommPorts = command5CommPortCheckedListBox.CheckedIndices;
        }

        private void command6CommPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            command6SelectedCommPorts = command6CommPortCheckedListBox.CheckedIndices;
        }

        private void queueCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {     
            queueSelectedCommands = queueCheckedListBox.CheckedIndices;
        }

        private void SendDataToSerialPorts(string package, int selectedIndex)
        {
            if (string.IsNullOrEmpty(package?.Trim()))
                return;

            switch (selectedIndex)
            {
                case 0:
                    if (Comport1.IsOpen)
                        Comport1.Write(package);
                    break;
                case 1:
                    if (Comport2.IsOpen)
                        Comport2.Write(package);
                    break;
                case 2:
                    if (Comport3.IsOpen)
                        Comport3.Write(package);
                    break;
                case 3:
                    if (Comport4.IsOpen)
                        Comport4.Write(package);
                    break;
                case 4:
                    if (Comport5.IsOpen)
                        Comport5.Write(package);
                    break;
                case 5:
                    if (Comport6.IsOpen)
                        Comport6.Write(package);
                    break;
                default:
                    break;
            }
        }

        private async Task SendWatchdogResetAsyncInfiniteLoop()
        {
            var keepAlivePackage = $"T99~";
            while (true)
            {
                for (int i = 0; i < 6; i++)
                {
                    Comport1.Write($"T99~");
                }

                await Task.Delay(2000);
            }
        }

        private void Disconnect(object sender, EventArgs e)
        {
            try
            {
                Comport1.Close();
                Global.CommPortsConnectionStatus.Add(Comport1.PortName, !Comport1.IsOpen);
            }
            catch { }
            try
            {
                Comport2.Close();
                Global.CommPortsConnectionStatus.Add(Comport2.PortName, !Comport2.IsOpen);
            }
            catch { }
            try
            {
                Comport3.Close();
                Global.CommPortsConnectionStatus.Add(Comport3.PortName, !Comport3.IsOpen);
            }
            catch { }
            try
            {
                Comport4.Close();
                Global.CommPortsConnectionStatus.Add(Comport4.PortName, !Comport4.IsOpen);
            }
            catch { }
            try
            {
                Comport5.Close();
                Global.CommPortsConnectionStatus.Add(Comport5.PortName, !Comport5.IsOpen);
            }
            catch { }
            try
            {
                Comport6.Close();
                Global.CommPortsConnectionStatus.Add(Comport6.PortName, !Comport6.IsOpen);
            }
            catch { }
        }
    }
}
