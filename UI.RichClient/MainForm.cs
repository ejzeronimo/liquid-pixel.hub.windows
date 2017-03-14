using System;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace UI.RichClient
{
    public enum Mode
    {
        Solid = 0,
        Breath,
        Chase,
        Wheels,
        Slow_Breath,
        Custom
    }
    public partial class MainForm : Form
    {
        private SerialPort portleft_;
        string in_data;
        string time;
        DateTime datetime;
        string package;
        String r = String.Empty;
        String g = String.Empty;
        String b = String.Empty;
        private string typenm;
        private string box;
        private int delay;

        public MainForm()
        {
            InitializeComponent();

            portleft_ = new SerialPort();

        }

        private void Start(object sender, EventArgs e)
        {
            try
            {
                portleft_.Write("5");
                MessageBox.Show("Started");
            }
            catch
            {
                MessageBox.Show("Failure...Try Again :(");
            }
        }

        private void Stop(object sender, EventArgs e)
        {
            try
            {
                portleft_.Write("6");
                MessageBox.Show("Stopped");
            }
            catch
            {
                MessageBox.Show("Failure...Try Again :(");
            }
        }

        private void MakeConnection(object sender, EventArgs e)
        {
            portleft_.PortName = ComPort.Text;
            portleft_.BaudRate = 9600;
            portleft_.Parity = Parity.None;
            portleft_.DataBits = 8;
            portleft_.StopBits = StopBits.One;
            portleft_.Encoding = Encoding.ASCII;
            try
            {
                portleft_.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            in_data = portleft_.ReadLine();
            Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;

            // split in_data on the : this will give you an array of strings
            // array[0] is the prefix split
            // array[1] is the ascii character code as string
            // int.Parse array[1]
            // convert int to string
            // diplay array[0] + the converted ascii to character
            //var inDataSplit = in_data.Split(new char[] { ':' });
            //string inDataAsText = null;
            //if (inDataSplit.Length == 2)
            //{
                //var code = int.Parse(inDataSplit[1].Replace("\r", String.Empty));
                //var character = Convert.ToString((char)code);
                //inDataAsText = $"{inDataSplit[0]}:{character}";
            //}
            //inDataAsText = string.IsNullOrEmpty(inDataAsText) ? in_data : inDataAsText;

            ArduinoBox.AppendText(time + "\t\t\t\t" + in_data + "\n");
        }

        private void CloseConnection(object sender, EventArgs e)
        {
            try
            {
                portleft_.Close();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void ColorWheel(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;

            
            try
            {

                r = clr.R.ToString();
                g = clr.G.ToString();
                b = clr.B.ToString();
            }
            catch (Exception ex)
            {
                //doing nothing
            }

        }

        private void UpdateString(object sender, EventArgs e)
        {
            typenm = "cmd";
            box = "bx1";
            delay = 10;
            package = typenm + "B" + box + "R" + r + "G" + g + "B" + b + "D" + delay +  "W" + "true" + "M" + ModeBox.Text + "~";
            StringBox.Text = package;
            //cmdBbx1R255G255B255D10WtrueMbreath
        }

        private void SendString(object sender, EventArgs e)
        {
            try
            {
                portleft_.Write(package);
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Failure...Try Again :(");
            }
        }

        private void Dropdown(object sender, EventArgs e)
        {
        }

        private void ArduinoBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void stageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Stage stg = new Stage();
            stg.Show();
        }

        private void portsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ports prt = new Ports();
            prt.Show();
        }

        private void boxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boxes bxs = new Boxes();
            bxs.Show();
        }
    }
}
