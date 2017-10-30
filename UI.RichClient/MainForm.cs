using System;
using System.Collections.Generic;
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
        private int typenm;
        private string box;
        private int delay;
        private int randombool;
        public SerialPort ComportMain;
        private string port;
        private string temport;
        private int moder;
        private int moderq;
        private int randomboolq;
        private int delayq;
        private string packageq;
        private string rq;
        private string bq;
        private string gq;
        private int brightq;

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
                panel1.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }

        }
        private void UpdateString(object sender, EventArgs e)
        {
 
                typenm = BrightBar.Value;
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
              
            }
            catch
            {
                MessageBox.Show("Failure...Try Again :(");
            }
        }
        private void ArduinoBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void ModeBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button1q_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                rq = clr.R.ToString();
                gq = clr.G.ToString();
                bq = clr.B.ToString();
                panel2.BackColor = cdlg.Color;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fader = $"T{0}C{box}R{r}G{g}B{b}D{delay}X{randombool}M{7}~"; ;
            ComportMain.Write(fader);

            ComportMain.Write(packageq);
        }
        private void ModeBarQ_Scroll(object sender, EventArgs e)
        {
            if (ModeBarQ.Value == 0)
            {
                ModeBoxQ.Text = "Off";
            }
            if (ModeBarQ.Value == 1)
            {
                ModeBoxQ.Text = "Solid";
            }
            if (ModeBarQ.Value == 2)
            {
                ModeBoxQ.Text = "Random Cloudy";
            }
            if (ModeBarQ.Value == 3)
            {
                ModeBoxQ.Text = "Flash";
            }
            if (ModeBarQ.Value == 4)
            {
                ModeBoxQ.Text = "Sweep";
            }
            if (ModeBarQ.Value == 5)
            {
                ModeBoxQ.Text = "Twinkle";
            }
            if (ModeBarQ.Value == 6)
            {
                ModeBoxQ.Text = "Random Twinkle";
            }
            if (ModeBarQ.Value == 7)
            {
                ModeBoxQ.Text = "Random Flash";
            }
            if (ModeBarQ.Value == 8)
            {
                ModeBoxQ.Text = "Theater Chase";
            }
            if (ModeBarQ.Value == 9)
            {
                ModeBoxQ.Text = "Chroma";
            }
            if (ModeBarQ.Value == 10)
            {
                ModeBoxQ.Text = "Fade In";
            }
            if (ModeBarQ.Value == 11)
            {
                ModeBoxQ.Text = "Fade Out";
            }
            if (ModeBarQ.Value == 12)
            {
                ModeBoxQ.Text = "Sudden Flash";
            }
            if (ModeBarQ.Value == 13)
            {
                ModeBoxQ.Text = "Random Breath";
            }
            if (ModeBarQ.Value == 14)
            {
                ModeBoxQ.Text = "Breath";
            }
        }

        private void ModeBoxQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModeBoxQ.Text == "Off")
            {
                moderq = 0;
            }
            if (ModeBoxQ.Text == "Solid")
            {
                moderq = 1;
            }
            if (ModeBoxQ.Text == "Random Cloudy")
            {
                moderq = 2;
            }
            if (ModeBoxQ.Text == "Flash")
            {
                moderq = 3;
            }
            if (ModeBoxQ.Text == "Sweep")
            {
                moderq = 4;
            }
            if (ModeBoxQ.Text == "Twinkle")
            {
                moderq = 5;
            }
            if (ModeBoxQ.Text == "Random Twinkle")
            {
                moderq = 6;
            }
            if (ModeBoxQ.Text == "Random Flash")
            {
                moderq = 7;
            }
            if (ModeBoxQ.Text == "Theater Chase")
            {
                moderq = 8;
            }
            if (ModeBoxQ.Text == "Chroma")
            {
                moderq = 9;
            }
            if (ModeBoxQ.Text == "Fade In")
            {
                moderq = 10;
            }
            if (ModeBoxQ.Text == "Fade Out")
            {
                moderq = 11;
            }
            if (ModeBoxQ.Text == "Sudden Flash")
            {
                moderq = 12;
            }
            if (ModeBoxQ.Text == "Random Breath")
            {
                moderq = 13;
            }
            if (ModeBoxQ.Text == "Breath")
            {
                moderq = 14;
            }
        }

        private void UpdateStringQ_Click(object sender, EventArgs e)
        {
            box = "1";
            randomboolq = 0;
            delayq = Delayq.Value;
            brightq = BrightBarQ.Value;
            packageq = $"T{brightq}C{box}R{rq}G{gq}B{bq}D{delayq}X{randomboolq}M{moderq}~";
            StringBoxQ.Text = packageq;
            //cmdBbx1R255G255B255D10WtrueMbreath
        }

        private void Asset_Changed(object sender, EventArgs e)
        {

        }

        private void Asset_List_Update(object sender, EventArgs e)
        {
            int maxlist = Global.AssetList.Count;

            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            {
                try
                {
                    if (!PortBox.Items.Contains(entry.Key))
                    { 
                    PortBox.Items.Add(entry.Key);
                    }
                }
                catch
                {
                }
            };
        }

        private void ModeUpdatesPreQueue(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            {
                try
                {
                    if (PortBox.SelectedText == entry.Key)
                    {
                        ModeBox.DisplayMember = "Name";
                        ModeBox.ValueMember = "Value";
                        ModeBox.DataSource = entry.Value.Modes;
                    }
                }
                catch
                {
                }
            };

        }
        private void ModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            {
                try
                {
                    if (PortBox.SelectedText == entry.Key)
                    {
                        entry.Value.CurMode = Convert.ToByte(ModeBox.SelectedValue);
                        //StringBox.Text = entry.Value.CurMode.ToString();
                    }
                }
                catch
                {
                }
            };
        }

        private void ModeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            {
                try
                {
                    if (PortBox.SelectedText == entry.Key)
                    {
                        entry.Value.CurMode = Convert.ToByte(ModeBox.SelectedValue);
                        StringBox.Text = entry.Value.CurMode.ToString();
                    }
                }
                catch
                {
                }
            };
        }
    }
}
