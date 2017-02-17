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
    //hoi mike
    public partial class MainForm : Form
    {
        private SerialPort _portleft;
        string in_data;
        string time;
        DateTime datetime;
        string package;
        String r = String.Empty;
        String g = String.Empty;
        String b = String.Empty;
        private string typenm;

        public MainForm()
        {
            InitializeComponent();

            _portleft = new SerialPort();

        }

        private void Start(object sender, EventArgs e)
        {
            try
            {
                _portleft.Write("5");
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
                _portleft.Write("6");
                MessageBox.Show("Stopped");
            }
            catch
            {
                MessageBox.Show("Failure...Try Again :(");
            }
        }

        private void MakeConnection(object sender, EventArgs e)
        {

            _portleft.PortName = ComPort.Text;
            _portleft.BaudRate = 9600;
            _portleft.Parity = Parity.None;
            _portleft.DataBits = 8;
            _portleft.StopBits = StopBits.One;
            _portleft.Encoding = Encoding.ASCII;
            _portleft.DataReceived += Myport_DataReceived;
            try
            {
                _portleft.Open();
                ArduinoBox.Text = "";
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            in_data = _portleft.ReadLine();
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
                _portleft.Close();
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
            typenm = "color";
            package = typenm + "<" +  r + ">" + g + "?" + b + "{" + ModeBox.Text +  "}" + "~" + "*";
            StringBox.Text = package;
        }

        private void SendString(object sender, EventArgs e)
        {
            try
            {
                _portleft.Write(package);
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
    }
}
