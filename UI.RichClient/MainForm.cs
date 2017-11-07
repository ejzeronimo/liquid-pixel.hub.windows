using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        LpcAsset Entry;


        public DelayBarQ()
        {
            InitializeComponent();
        }
        private void MakeConnection(object sender, EventArgs e)
        {
            try
            {
                Entry.Comport.Open();
            }
            catch
            {
                //doing nothing
            }
        }
        private void CloseConnection(object sender, EventArgs e)
        {
            try
            {
                Entry.Comport.Close();
            }
            catch
            {
                //doing nothing
            }
        }
        private void Asset_List_Update(object sender, EventArgs e)
        {
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
                    //doing nothing
                }
            };
        }
        private void Asset_Changed(object sender, EventArgs e)
        {
            if (Global.AssetList.ContainsKey(PortBox.Text))
            {
                Global.AssetList.TryGetValue(PortBox.Text, out Entry);
            }
        }
        private void ModeUpdatesPreQueue(object sender, EventArgs e)
        {
            try
            {
                ModeBox.DisplayMember = "Name";
                ModeBox.ValueMember = "Value";
                ModeBox.DataSource = Entry.Modes;
            }
            catch
            {
                //doing nothing
            }
        }
        private void ModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entry.CurMode = Convert.ToInt32(ModeBox.SelectedValue);
        }
        private void ModeBar_Scroll(object sender, EventArgs e)
        {
            ModeBox.SelectedValue = ModeBar.Value;
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
                var color = new byte[] { clr.R, clr.G, clr.B };
                Entry.Color = color;
            }
            catch (Exception)
            {
                //doing nothing
            }
        }
        private void DelayBar_Scroll(object sender, EventArgs e)
        {
            Entry.Delay = DelayBar.Value;
        }
        private void UpdateString(object sender, EventArgs e)
        {
            box = "1";
            randombool = 0;
            try
            {
                package = $"T0C{box}R{Entry.Color[0]}G{Entry.Color[1]}B{Entry.Color[2]}D{Entry.Delay}X{randombool}M{Entry.CurMode}~";
                StringBox.Text = package;
            }
            catch
            {
                //doing nothing
                //cmdBbx1R255G255B255D10WtrueMbreath
            }
        }
        private void ModeBoxQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entry.QueMode = Convert.ToInt32(ModeBox.SelectedValue);
        }
        private void ModeBarQ_Scroll(object sender, EventArgs e)
        {
            ModeBoxQ.SelectedValue = ModeBarQ.Value;
        }








        private void SendString(object sender, EventArgs e)
        {
            try
            {
                Entry.Comport.Write(package);
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
            Entry.Comport.Write(fader);

            Entry.Comport.Write(packageq);
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


    }
}
