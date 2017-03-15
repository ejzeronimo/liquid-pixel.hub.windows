using System;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace UI.RichClient
{

    public partial class MainForm : Form
    {
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
        private int randombool;
        public SerialPort ComportMain;
        private string port;
        private string temport;

        enum methodcall { }
      
        public MainForm()
        {
            InitializeComponent();

            ComportMain = new SerialPort();

        }
        private void Start(object sender, EventArgs e)
        {
            try
            {
                ComportMain.Write("5");
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
                ComportMain.Write("6");
                MessageBox.Show("Stopped");
            }
            catch
            {
                MessageBox.Show("Failure...Try Again :(");
            }
        }
        private void MakeConnection(object sender, EventArgs e)
        {
            ComportMain.PortName = PortBox.Text;
            ComportMain.BaudRate = 9600;
            ComportMain.Parity = Parity.None;
            ComportMain.DataBits = 8;
            ComportMain.StopBits = StopBits.One;
            ComportMain.Encoding = Encoding.ASCII;
            try
            {
                ComportMain.Open();
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            in_data = ComportMain.ReadLine();
            Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            ArduinoBox.AppendText(time + "\t\t\t\t" + in_data + "\n");
        }

        private void CloseConnection(object sender, EventArgs e)
        {
            try
            {
                ComportMain.Close();
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
            typenm = "0";
            box = "1";
            randombool = 0;
            delay = 10;
            package = $"T{typenm}C{box}R{r}G{g}B{b}D{delay}W{randombool}M1~";
            StringBox.Text = package;
            //cmdBbx1R255G255B255D10WtrueMbreath
        }

        private void SendString(object sender, EventArgs e)
        {
            try
            {
                ComportMain.Write(package);
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
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
