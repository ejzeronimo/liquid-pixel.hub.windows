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
        //public bool IsComport1Connected => Comport1.IsOpen;
        public SerialPort Comport2;
        //public bool IsComport2Connected => Comport2.IsOpen;
        public SerialPort Comport3;
        //public bool IsComport3Connected => Comport3.IsOpen;
        public SerialPort Comport4;
        //public bool IsComport4Connected => Comport4.IsOpen;
        public SerialPort Comport5;
        //public bool IsComport5Connected => Comport5.IsOpen;
        public SerialPort Comport6;
        //public bool IsComport6Connected => Comport6.IsOpen;
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
            
        }
        void ColorChange(int[] array, Panel pan)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();

            try
            {
                array[0] = (cdlg.Color.R);
                array[1] = (cdlg.Color.G);
                array[2] = (cdlg.Color.B);
                pan.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while setting color, please try again.");
            }
        }
        void PackageCompAndSend(LpcAsset asset, string package)
        {
            try
            {
                if (package == null)
                {
                    asset.Comport.Write($"T0C{asset.BoxNumber}R{asset.Color[0]}G{asset.Color[1]}B{asset.Color[2]}D{asset.Delay}X0M{0}~");
                }
                else
                {
                    asset.Comport.Write(package);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while sending command, please try again.");
            }
        }
        void ModeSelect(LpcAsset asset, ComboBox mode)
        {
            //Mode CurrentMode = Mode.Off;
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while choosing the mode, please try again.");
            }
        }
        void BindToSetting(LpcAsset asset,ComboBox mode )
        {
            try
            {

            }
            catch
            {

            }
        }
        //changes the color
        private void button7_Click(object sender, EventArgs e)
        {
            ColorChange(null, panel1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorChange(null, panel2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorChange(null, panel3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ColorChange(null, panel4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ColorChange(null, panel5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ColorChange(null, panel6);
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e, ref int moder)
        {
            //var comboBox = (ComboBox)sender;
            //if (comboBox.Text == "Off")//done
            //{
            //    moder = 0;
            //    return;
            //}
            //if (comboBox.Text == "Solid")//done
            //{
            //    moder = 1;
            //    return;
            //}
            //if (comboBox.Text == "Random Cloudy")//done
            //{
            //    moder = 2;
            //    return;
            //}
            //if (comboBox.Text == "Flash")//done
            //{
            //    moder = 3;
            //    return;
            //}
            //if (comboBox.Text == "Sweep")//done
            //{
            //    moder = 4;
            //    return;
            //}
            //if (comboBox.Text == "Twinkle")//done
            //{
            //    moder = 5;
            //    return;
            //}
            //if (comboBox.Text == "Random Twinkle")//done
            //{
            //    moder = 6;
            //    return;
            //}
            //if (comboBox.Text == "Random Flash")//done
            //{
            //    moder = 7;
            //    return;
            //}
            //if (comboBox.Text == "Theater Chase")//done
            //{
            //    moder = 8;
            //    return;
            //}
            //if (comboBox.Text == "Chroma")
            //{
            //    moder = 9;
            //    return;
            //}
            //if (comboBox.Text == "Fade In")//done
            //{
            //    moder = 10;
            //    return;
            //}
            //if (comboBox.Text == "Fade Out")//done
            //{
            //    moder = 11;
            //    return;
            //}
            //if (comboBox.Text == "Sudden Flash")//done
            //{
            //    moder = 12;
            //    return;
            //}
            //if (comboBox.Text == "Random Breath")//done
            //{
            //    moder = 13;
            //    return;
            //}
            //if (comboBox.Text == "Breath")//done
            //{
            //    moder = 14;
            //    return;
            //}
        }


        private void initializeCommPortsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Comport2.Parity = Parity.None;
                //Comport2.DataBits = 8;
                //Comport2.StopBits = StopBits.One;
                //Comport2.Encoding = Encoding.ASCII;
            }
            catch
            {

            }      
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
                        //qDelay = q1Delay.Value;
                        PackageCompAndSend(null, null);
                        //packagePortSender = () => queueCommand_Click(sender, e, 0, package, command1SelectedCommPorts);
                        break;
                    case 1:
                        //qDelay = q2Delay.Value;
                        PackageCompAndSend(null, null);
                        //packagePortSender = () => queueCommand_Click(sender, e, 0, package, command2SelectedCommPorts);
                        break;
                    case 2:
                        //qDelay = q3Delay.Value;
                        PackageCompAndSend(null, null);
                        //packagePortSender = () => queueCommand_Click(sender, e, 0, package, command3SelectedCommPorts);
                        break;
                    case 3:
                        //qDelay = q4Delay.Value;
                        PackageCompAndSend(null, null);
                        //packagePortSender = () => queueCommand_Click(sender, e, 0, package, command4SelectedCommPorts);
                        break;
                    case 4:
                        //qDelay = q5Delay.Value;
                        PackageCompAndSend(null, null);
                        //packagePortSender = () => queueCommand_Click(sender, e, 0, package, command5SelectedCommPorts);
                        break;
                    case 5:
                        //qDelay = q6Delay.Value;
                        PackageCompAndSend(null, null);
                        //packagePortSender = () => queueCommand_Click(sender, e, 0, package, command6SelectedCommPorts);
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
            switch (selectedIndex)
            {
                case 0:
                    PackageCompAndSend(null, null);
                    break;
                case 1:
                    PackageCompAndSend(null, null);
                    break;
                case 2:
                    PackageCompAndSend(null, null);
                    break;
                case 3:
                    PackageCompAndSend(null, null);
                    break;
                case 4:
                    PackageCompAndSend(null, null);
                    break;
                case 5:
                    PackageCompAndSend(null, null);
                    break;
                default:
                    break;
            }
        }

        //private async Task SendWatchdogResetAsyncInfiniteLoop()
        //{
        //    var keepAlivePackage = $"T99~";
        //    while (true)
        //    {
        //        for (int i = 0; i < 6; i++)
        //        {
        //            //Global.Comport1.Write($"T99~");
        //        }
        //        await Task.Delay(2000);
        //    }
        //}

        private void Disconnect(object sender, EventArgs e)
        {
            try
            {
                for (;;)
                {

                }
            }
            catch
            {
                MessageBox.Show("An error ocurred while closing ports");
            }
        }
    }
}
