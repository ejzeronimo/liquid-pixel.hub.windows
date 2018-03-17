using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.RichClient
{

    public partial class MainForm : Form
    {
        /////////////////////////////////////////////////////////////////////////// SETUP OF FORM
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //initializes the form
        }
        LpcAsset Entry;
        /////////////////////////////////////////////////////////////////////////// LPCASSET LOADING AND CHOOSING
        private void Asset_List_Update(object sender, EventArgs e)
        {
            //updates the list of the boxes
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
            //chooses the box that you select in the dropdown
            if (Global.AssetList.ContainsKey(PortBox.Text))
            {
                Global.AssetList.TryGetValue(PortBox.Text, out Entry);
            }
        }
        /////////////////////////////////////////////////////////////////////////// MODE CHOOSING
        private void ModeUpdatesPreQueue(object sender, EventArgs e)
        {
            // gets the modes of the asset
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
            try
            {
                //chooses the mode that you choose from the dropdown
                Entry.CurMode = Convert.ToInt32(ModeBox.SelectedValue);
            }
            catch { }
        }
        private void ModeBar_Scroll(object sender, EventArgs e)
        {
            //connects the scroll bar and dropdown
            ModeBox.SelectedValue = ModeBar.Value;
        }
        private void ModeUpdatesQueue(object sender, EventArgs e)
        {
            // gets the modes of the asset
            try
            {
                ModeBoxQ.DisplayMember = "Name";
                ModeBoxQ.ValueMember = "Value";
                ModeBoxQ.DataSource = Entry.QueModes;
            }
            catch
            {
                //doing nothing
            }
        }
        private void ModeBoxQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Entry.QueMode = Convert.ToInt32(ModeBoxQ.SelectedValue);
            }
            catch { }
        }
        private void ModeBarQ_Scroll(object sender, EventArgs e)
        {
            ModeBoxQ.SelectedValue = ModeBarQ.Value;
        }
        /////////////////////////////////////////////////////////////////////////// CONNECT AND DISCONNECT TO THE ASSET
        private void MakeConnection(object sender, EventArgs e)
        {
            try
            {
                Global.PortList.Add(Entry.Comport.PortName, Entry.Comport);
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
                Global.PortList.Remove(Entry.Comport.PortName);
                Entry.Comport.Close();
            }
            catch
            {
                //doing nothing
            }
        }
        /////////////////////////////////////////////////////////////////////////// GET THE COLORS FROM THE COLOR DIALOG
        private void ColorWheel(object sender, EventArgs e)
        {
            try
            {
                //updated to use the classes
                Entry.Setcolormain(panel1);
            }
            catch { }
        }
        private void Colorq_Click(object sender, EventArgs e)
        {
            try
            {
                //updated to use the classes
                Entry.Setcolorque(panel2);
            }
            catch { }
        }
        /////////////////////////////////////////////////////////////////////////// GET THE DELAY FROM THE DELAY SCROLL BARS
        private void DelayBar_Scroll(object sender, EventArgs e)
        {
            Entry.Delay = DelayBar.Value;
        }
        private void DelayBarQ_Scroll(object sender, EventArgs e)
        {
            Entry.DelayQue = DelayBarQ.Value;
        }
        /////////////////////////////////////////////////////////////////////////// UPDATE THE STRINGS WITH ALL OF THE DATA
        private void UpdateString(object sender, EventArgs e)
        {
            try
            {
                Entry.Updatecommandmain();
                StringBox.Text = Entry.Command;
            }
            catch { }
        }
        private void UpdateStringQ_Click(object sender, EventArgs e)
        {
            try
            {
                Entry.Updatecommandque();
                StringBoxQ.Text = Entry.CommandQue;
            }
            catch{ }
        }
        /////////////////////////////////////////////////////////////////////////// SEND THE DATA TO THE BOXES
        private void SendString(object sender, EventArgs e)
        {
            try
            {
                Entry.Sendpackage(Entry.Command);
            }
            catch
            {
                
            }
        }
        private void TransitionFromCurrentToQ(object sender, EventArgs e)
        {
            //note this fader will only be used for certain transistions
            string fader = $"T{0}C{Entry.BoxNumber}R{Entry.Color[0]}G{Entry.Color[1]}B{Entry.Color[2]}D{Entry.Delay}X{Entry.Random}M{10}~";
            try
            {
                DateTime then = DateTime.Now;
                do
                {
                    Entry.Sendpackage(fader);
                } while (then.AddSeconds(Entry.Random/1000) > DateTime.Now);
                Entry.Sendpackage(Entry.CommandQue);
            }
            catch
            {

            }

        }
        private void SendQ(object sender, EventArgs e)
        {
            try
            {
                Entry.Sendpackage(Entry.CommandQue);
            }
            catch
            {

            }
        }
    }
}
