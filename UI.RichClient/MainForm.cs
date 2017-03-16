using System;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace UI.RichClient
{

    public partial class DelayBarQ : Form
    {
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
        private int moder;

        enum methodcall { }
      
        public DelayBarQ()
        {
            InitializeComponent();
            ComportMain = new SerialPort();
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
            delay = DelayBar.Value;
            package = $"T{typenm}C{box}R{r}G{g}B{b}D{delay}X{randombool}M{moder}~";
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
            if(ModeBox.Text == "Off" )
            {
                moder = 0;
            }
            if (ModeBox.Text == "Solid")
            {
                moder = 1;
            }
            if (ModeBox.Text == "Random Cloudy")
            {
                moder = 2;
            }
            if (ModeBox.Text == "Flash")
            {
                moder = 3;
            }
            if (ModeBox.Text == "Sweep")
            {
                moder = 4;
            }
            if (ModeBox.Text == "Twinkle")
            {
                moder = 5;
            }
            if (ModeBox.Text == "Random Twinkle")
            {
                moder = 6;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void ModeBar_Scroll(object sender, EventArgs e)
        {
            if (ModeBar.Value == 0)
            {
                ModeBox.Text = "Off";
            }
            if (ModeBar.Value == 1)
            {
                ModeBox.Text = "Solid";
            }
            if (ModeBar.Value == 2)
            {
                ModeBox.Text = "Random Cloudy";
            }
            if (ModeBar.Value == 3)
            {
                ModeBox.Text = "Flash";
            }
            if (ModeBar.Value == 4)
            {
                ModeBox.Text = "Sweep";
            }
            if (ModeBar.Value == 5)
            {
                ModeBox.Text = "Twinkle";
            }
            if (ModeBar.Value == 6)
            {
                ModeBox.Text = "Random Twinkle";
            }
        }
    }
}
