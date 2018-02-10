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
        /////////////////////////////////////////////////////////////////////////// SETUP THE FORM
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {

        }
        int delaybetweencommands = 0;
        /////////////////////////////////////////////////////////////////////////// CHOOSE ALL ASSETS TO BE USED AND GENERATE THE TILES
        private void Grouplist_Update_List(object sender, EventArgs e)
        {
            // gets the assets and place them into a list
            try
            {
                //GroupList.DisplayMember = Global.AssetList.Keys.ToString();
                //GroupList.ValueMember = Global.AssetList.Keys.ToString();
                //GroupList.DataSource = Global.AssetList;
                foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
                {
                    if (!GroupList.Items.Contains(entry.Key))
                    {
                        GroupList.Items.Add(entry.Key, true);
                    }
                };
            }
            catch
            {
                //doing nothing
            }
        }
        private void GenerateAssetControls(object sender, EventArgs e)
        {
            //gets checked assets and generates a ui for each one
            //set up the asset panels
            // 225, 13 and 13,13 are pos so 212 range
            // 200,476 size
            int i = 0;
            int distance = 212;
            int height = 476+12;
            int rows = 1;
            int maxpan = 8;
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
            {
                if (GroupList.CheckedItems.Contains(entry.Key))
                {
                    if (i >= maxpan)
                    {
                        i = 0;
                        rows++;
                        panel1.Height = (476 +12) * rows;
                    }
                    //generate the label ontop of the settings so the user knows what it is
                    Label detail = new Label();
                    detail.BackColor = Color.Gray;
                    detail.Name = "detail" + i;
                    detail.Text = "Current Settings for " + entry.Key + ":";
                    detail.Size = new System.Drawing.Size(195, 13);
                    detail.Location = new System.Drawing.Point((228 + distance * i), 27 + (height * (rows - 1)));
                    Controls.Add(detail);
                    //generate the color panel for ref
                    Panel color = new Panel();
                    color.Name = "color"+i;
                    color.Size = new System.Drawing.Size(194, 67);
                    color.Location = new System.Drawing.Point((228 + distance * i), 43 + (height * (rows - 1)));
                    color.BorderStyle = BorderStyle.FixedSingle;
                    try
                    {
                        color.BackColor = Color.FromArgb(225, entry.Value.Color[0], entry.Value.Color[1], entry.Value.Color[2]);
                    }
                    catch
                    {
                        color.BackColor = Color.Gray;
                    }
                    Controls.Add(color);
                    //generate the buttons for the color
                    Button colorbutton = new Button();
                    colorbutton.Name = "colorbutton" + i;
                    colorbutton.Size = new System.Drawing.Size(97, 35);
                    colorbutton.Location = new System.Drawing.Point((228 + distance * i), 116 + (height * (rows - 1)));
                    colorbutton.Text = "Color Wheel";
                    colorbutton.Click += (cbs, cbe) => ColorChange_Click(cbs, cbe, entry, color);
                    Controls.Add(colorbutton);
                    //generates the button for sending the string
                    Button sendbutton = new Button();
                    sendbutton.Click += (sbs, sbe) => Send_Click(sbs, sbe, entry);
                    sendbutton.Name = "sendbutton" + i;
                    sendbutton.Size = new System.Drawing.Size(97, 35);
                    sendbutton.Location = new System.Drawing.Point((325 + distance * i), 116 + (height * (rows - 1)));
                    sendbutton.Text = "Send String";
                    sendbutton.BackColor = Color.LightGreen;
                    Controls.Add(sendbutton);
                    //generates the scroll bar for the delay time in ms
                    TrackBar delayscroll = new TrackBar();
                    TextBox delaytxt = new TextBox();
                    delayscroll.Maximum = 1000;
                    delayscroll.ValueChanged += (dss, dse) => DelayBar_Scroll(dss, dse, entry,delaytxt);
                    delayscroll.Name = "delayscroll" + i;
                    delayscroll.Size = new System.Drawing.Size(136, 45);
                    delayscroll.Location = new System.Drawing.Point((228 + distance * i), (157) + (height * (rows - 1)));
                    delayscroll.BackColor = Color.Gray;
                    Controls.Add(delayscroll);
                    //generate a textbox for the delay for more "precise changes"
                    delaytxt.MouseHover += (dts, dte) => DelayTxt_Update(dts, dte, entry);
                    delaytxt.TextChanged += (dts,dte) => DelayTxt_Changed(dts, dte, entry,delayscroll);
                    delaytxt.Name = "delaytxt" + i;
                    delaytxt.Size = new System.Drawing.Size(51, 20);
                    delaytxt.Location = new System.Drawing.Point(((225 + 146) + distance * i), (157) + (height * (rows - 1)));
                    Controls.Add(delaytxt);
                    //generates the combobox for the modes for better pickability
                    ComboBox modebox = new ComboBox();
                    TrackBar modescroll = new TrackBar();
                    modebox.SelectedIndexChanged += (mbs, mbe) => ModeBox_Update(mbs, mbe, entry, modescroll);
                    modebox.DisplayMember = "Name";
                    modebox.ValueMember = "Value";
                    modebox.DataSource = entry.Value.Modes;
                    modebox.Name = "modebox" + i;
                    modebox.Size = new System.Drawing.Size(51+36, 20);
                    modebox.Location = new System.Drawing.Point(((225 + 146 - 36) + distance * i), (208) + (height * (rows - 1)));
                    Controls.Add(modebox);
                    //generates the scroll bar for modes 
                    modescroll.ValueChanged += (mss, mse) => ScrollMode_Update(mss, mse, entry, modebox);
                    modescroll.Maximum = entry.Value.Modes.Count - 1;
                    modescroll.Name = "modescroll" + i;
                    modescroll.Size = new System.Drawing.Size(100, 45);
                    modescroll.Location = new System.Drawing.Point((228 + distance * i), (208) + (height * (rows - 1)));
                    modescroll.BackColor = Color.Gray;
                    Controls.Add(modescroll);
                    //////////////////////////////////////////////////////////////////////////////////////////////// QUEING CONTROLS
                    //generate the label ontop of the settings so the user knows what it is
                    Label detailq = new Label();
                    detailq.Name = "detailq" + i;
                    detailq.Text = "Queue Settings for " + entry.Key + ":";
                    detailq.BackColor = Color.Gray;
                    detailq.Size = new System.Drawing.Size(195, 13);
                    detailq.Location = new System.Drawing.Point((228 + distance * i), 263 + (height * (rows - 1)));
                    Controls.Add(detailq);
                    //generate the que color
                    Panel colorq = new Panel(); 
                    colorq.Name = "colorq" + i;
                    colorq.Size = new System.Drawing.Size(194, 67);
                    colorq.Location = new System.Drawing.Point((228 + distance * i), (279) + (height * (rows - 1)));
                    colorq.BorderStyle = BorderStyle.FixedSingle;
                    try
                    {
                        colorq.BackColor = Color.FromArgb(225, entry.Value.ColorQue[0], entry.Value.ColorQue[1], entry.Value.ColorQue[2]);
                    }
                    catch
                    {
                        colorq.BackColor = Color.Gray;
                    }
                    Controls.Add(colorq);
                    //generate the buttons for the que color
                    Button colorbuttonq = new Button();
                    colorbuttonq.Click += (cbqs, cbqe) => ColorChangeQ_Click(cbqs, cbqe, entry, colorq);
                    colorbuttonq.Name = "colorbuttonq" + i;
                    colorbuttonq.Size = new System.Drawing.Size(97, 35);
                    colorbuttonq.Location = new System.Drawing.Point((228 + distance * i), 352 + (height * (rows - 1)));
                    colorbuttonq.Text = "Color Wheel";
                    //implement later once assets are included colorbuttonq.Click += Entry.setcolormain(panel1);
                    Controls.Add(colorbuttonq);
                    //generates the button for sending the que string
                    Button sendbuttonq = new Button();
                    sendbuttonq.Click += (sbqs, sbqe) => SendQ_Click(sbqs, sbqe, entry);
                    sendbuttonq.Name = "sendbuttonq" + i;
                    sendbuttonq.Size = new System.Drawing.Size(97, 35);
                    sendbuttonq.Location = new System.Drawing.Point((325 + distance * i), 352 + (height * (rows - 1)));
                    sendbuttonq.Text = "Send String";
                    sendbuttonq.BackColor = Color.LightGreen;
                    Controls.Add(sendbuttonq);
                    //generates the scroll bar for the que delay time in ms
                    TrackBar delayscrollq = new TrackBar();
                    TextBox delaytxtq = new TextBox();
                    delayscrollq.Maximum = 1000;
                    delayscrollq.ValueChanged += (dsqs, dsqe) => DelayBarQ_Scroll(dsqs, dsqe, entry,delaytxtq);
                    delayscrollq.Name = "delayscrollq" + i;
                    delayscrollq.Size = new System.Drawing.Size(136, 45);
                    delayscrollq.Location = new System.Drawing.Point((228 + distance * i), (393) + (height * (rows - 1)));
                    delayscrollq.BackColor = Color.Gray;
                    Controls.Add(delayscrollq);
                    //generate a textbox for the que delay for more "precise changes"
                    delaytxtq.MouseHover += (dts, dte) => DelayTxtQ_Update(dts, dte, entry);
                    delaytxtq.TextChanged += (dts, dte) => DelayTxtQ_Changed(dts, dte, entry, delayscrollq);
                    delaytxtq.Name = "delaytxtq" + i;
                    delaytxtq.Size = new System.Drawing.Size(51, 20);
                    delaytxtq.Location = new System.Drawing.Point(((371) + distance * i), (393) + (height * (rows - 1)));
                    Controls.Add(delaytxtq);
                    //generates the combobox for the que modes for better pickability
                    ComboBox modeboxq = new ComboBox();
                    TrackBar modescrollq = new TrackBar();
                    modeboxq.SelectedIndexChanged += (mbqs, mbqe) => ModeBoxQ_Update(mbqs, mbqe, entry, modescrollq);
                    modeboxq.DisplayMember = "Name";
                    modeboxq.ValueMember = "Value";
                    modeboxq.DataSource = entry.Value.QueModes;
                    modeboxq.Name = "modeboxq" + i;
                    modeboxq.Size = new System.Drawing.Size(51+36, 20);
                    modeboxq.Location = new System.Drawing.Point(((335) + distance * i), (440) + (height * (rows - 1)));
                    Controls.Add(modeboxq);
                    //generates the scroll bar for que modes
                    modescrollq.Name = "modescrollq" + i;
                    modescrollq.ValueChanged += (msqs, msqe) => ScrollMode_Update(msqs, msqe, entry, modeboxq);
                    modescrollq.Maximum = entry.Value.Modes.Count - 1;
                    modescrollq.Size = new System.Drawing.Size(136 - 36, 45);
                    modescrollq.Location = new System.Drawing.Point((228 + distance * i), (440) + (height * (rows - 1)));
                    modescrollq.BackColor = Color.Gray;
                    Controls.Add(modescrollq);
                    //generate the background
                    Panel mainback = new Panel();
                    mainback.Size = new System.Drawing.Size(200, 476);
                    mainback.Location = new System.Drawing.Point((225 + distance * i), 13 + (height * (rows - 1)));
                    mainback.BackColor = Color.Gray;
                    Controls.Add(mainback);
                    //adds so that can be gen properly  
                    i++;
                }
            };
            this.Size = new Size(244 + distance * (GroupList.CheckedItems.Count), 542 +(height * (rows-1)));
            i = 0;
        }

        /////////////////////////////////////////////////////////////////////////// SETUP THE HANDLERS FOR THE TILES
        private void ColorChange_Click(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, Panel panel)
        {
            entry.Value.setcolormain(panel);  
        }
        private void ColorChangeQ_Click(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, Panel panel)
        {
            entry.Value.setcolorque(panel);
        }
        private void Send_Click(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry)
        {
            entry.Value.updatecommandmain();
            entry.Value.sendpackage(entry.Value.Command);
        }
        private void SendQ_Click(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry)
        {
            entry.Value.updatecommandque();
            entry.Value.sendpackage(entry.Value.CommandQue);
        }
        private void DelayBar_Scroll(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object text)
        {
            TrackBar track = (TrackBar) sender;
            TextBox txt = (TextBox)text;
            entry.Value.Delay = track.Value;
            txt.Text = entry.Value.Delay.ToString();
        }
        private void DelayBarQ_Scroll(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object text)
        {
            TrackBar track = (TrackBar)sender;
            TextBox txt = (TextBox)text;
            entry.Value.DelayQue = track.Value;
            txt.Text = entry.Value.DelayQue.ToString();
        }
        private void DelayTxt_Update(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = entry.Value.Delay.ToString();
        }
        private void DelayTxt_Changed(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object track)
        {
            TextBox txt = (TextBox)sender;
            TrackBar trk = (TrackBar)track;
            try
            {
                trk.Value = Convert.ToInt32(txt.Text);
                entry.Value.Delay = Convert.ToInt32(txt.Text);
            }
            catch { }
        }
        private void DelayTxtQ_Update(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = entry.Value.DelayQue.ToString();
        }
        private void DelayTxtQ_Changed(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object track)
        {
            TextBox txt = (TextBox)sender;
            TrackBar trk = (TrackBar)track;
            try
            {
                trk.Value = Convert.ToInt32(txt.Text);
                entry.Value.DelayQue = Convert.ToInt32(txt.Text);
            }
            catch { }
        }
        private void ModeBox_Update(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object track)
        {
            ComboBox combo = (ComboBox)sender;
            TrackBar trk = (TrackBar)track;
            try
            {
                entry.Value.CurMode = Convert.ToInt32(combo.SelectedValue.ToString());
                trk.Value = entry.Value.CurMode;
                
            }
            catch { }
        }
        private void ModeBoxQ_Update(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object track)
        {
            ComboBox combo = (ComboBox)sender;
            TrackBar trk = (TrackBar)track;
            try
            {
                entry.Value.QueMode = Convert.ToInt32(combo.SelectedValue.ToString());
                trk.Value = entry.Value.QueMode;

            }
            catch { }
        }
        private void ScrollMode_Update(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object combox)
        {
            ComboBox combo = (ComboBox)combox;
            TrackBar trk = (TrackBar)sender;
            try
            {
                entry.Value.CurMode = trk.Value;
                combo.SelectedValue = entry.Value.CurMode;
            }
            catch { }
        }
        private void ScrollModeQ_Update(object sender, EventArgs e, KeyValuePair<string, LpcAsset> entry, object combox)
        {
            ComboBox combo = (ComboBox)combox;
            TrackBar trk = (TrackBar)sender;
            try
            {
                entry.Value.QueMode = trk.Value;
                combo.SelectedValue = entry.Value.QueMode;
            }
            catch { }
        }
        /////////////////////////////////////////////////////////////////////////// START AND END THE ASSETS SO THAT THEY CAN BE USED
        private void StartAssets(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
            {
                if (GroupList.CheckedItems.Contains(entry.Key))
                {
                    try
                    {
                        entry.Value.Comport.Open();
                    }
                    catch { }
                }
            }
        }
        private void EndAssets(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
            {
                if (GroupList.CheckedItems.Contains(entry.Key))
                {
                    entry.Value.Comport.Close();
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////// QUEUING AND TIMED QUE
        private void TimeBoxChanged(object sender, EventArgs e)
        {
            try
            {
                delaybetweencommands = Convert.ToInt32(TimeBox.Text);
                TimeBar.Value = delaybetweencommands;
            }
            catch
            {}
        }
        private void TimeBarChanged(object sender, EventArgs e)
        {
            delaybetweencommands = TimeBar.Value;
            TimeBox.Text = delaybetweencommands.ToString();
        }
        private async void RunTimedQ(object sender, EventArgs e)
        {
            while (RunLoopCheck.Checked)
            {
                TimeQueBtn.Text = "Running uncheck to stop..";
                TimeQueBtn.BackColor = Color.LightSalmon;
                foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
                {
                    if (GroupList.CheckedItems.Contains(entry.Key))
                    {
                        entry.Value.sendpackage(entry.Value.Command);
                    }
                }
                await Task.Delay(delaybetweencommands);
                TimeQueBtn.Text = "Running uncheck to stop...";
                TimeQueBtn.BackColor = Color.LightGreen;
                foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
                {
                    if (GroupList.CheckedItems.Contains(entry.Key))
                    {
                        entry.Value.sendpackage(entry.Value.CommandQue);
                    }
                }
                await Task.Delay(delaybetweencommands);
            }
            if(!RunLoopCheck.Checked)
            {

                TimeQueBtn.BackColor = Color.Gainsboro;
                TimeQueBtn.Text = "Run Timed Queuing";
                foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
                {
                    if (GroupList.CheckedItems.Contains(entry.Key))
                    {
                        entry.Value.sendpackage(entry.Value.Command);
                    }
                }
                // just run once
                //put delay here
                await Task.Delay(delaybetweencommands);
                foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
                {
                    if (GroupList.CheckedItems.Contains(entry.Key))
                    {
                        entry.Value.sendpackage(entry.Value.CommandQue);
                    }
                }
            }
        }
        private void SendAllCurrent(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
            {
                if (GroupList.CheckedItems.Contains(entry.Key))
                {
                    entry.Value.sendpackage(entry.Value.Command);
                }
            }
        }
        private void SendAllQue(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
            {
                if (GroupList.CheckedItems.Contains(entry.Key))
                {
                    entry.Value.sendpackage(entry.Value.CommandQue);
                }
            }
        }
        private void UpdateCommands(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)//change to the index of assets so that the assets can be assigned and the pos can be set
            {
                if (GroupList.CheckedItems.Contains(entry.Key))
                {
                    try
                    {
                        entry.Value.updatecommandmain();
                        entry.Value.updatecommandque();
                    }
                    catch { }
                }
            }
        }
    }
}
