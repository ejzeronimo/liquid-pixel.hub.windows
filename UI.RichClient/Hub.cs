using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI.RichClient
{
    public partial class Hub : Form
    {
        /////////////////////////////////////////////////////////////////////////// SETUP FORM
        public Hub()
        {
            InitializeComponent();
        }
        bool rundiagnostics = false;
        int i = 0;
        /////////////////////////////////////////////////////////////////////////// DROPDOWN ITEMS CLICKED
        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm bxs = new MainForm();
            bxs.Show();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show('"' + "Madrix is insuperior, Liquid Systems is the best" + '"' + "-Elliot");
            Information info = new Information();
            info.Show();
        }
        private void groupOBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group grp = new RichClient.Group();
            grp.Show();
        }
        /////////////////////////////////////////////////////////////////////////// NESTED DROPDOWNS ITEMS CLICKED
        private void NewLpcAssetCreate(object sender, EventArgs e)
        {
            Ports prt = new RichClient.Ports();
            prt.Show();
        }
        private void AssetListClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //foreach button in the asset list dropdown
                foreach (ToolStripMenuItem item in portsToolStripMenuItem.DropDownItems)
                {
                    //check to see if there is a legit asset that has been made in the global list
                    foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
                    {
                        try
                        {
                            //if item does have a golbal asset
                            if (entry.Value.Name == item.Name)
                            {
                                //if the item was the one clicked or not
                                if (item.Selected)
                                {
                                    Ports prt = new RichClient.Ports(entry.Value);
                                    prt.Show();
                                }
                            }
                        }
                        catch
                        {
                        }
                    };

                };

            }
            catch
            {

            }
        }
        /////////////////////////////////////////////////////////////////////////// NESTED DROPDOWNS UPDATE
        private void AssetListUpdate(object sender, EventArgs e)
        {
            //update the dropdown
            int maxlist = Global.AssetList.Count;
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            {
                try
                {
                    ToolStripItem subItem = new ToolStripMenuItem(entry.Value.Name);
                    subItem.Name = entry.Value.Name;
                    if (!portsToolStripMenuItem.DropDownItems.ContainsKey(entry.Value.Name))
                    {
                        portsToolStripMenuItem.DropDownItems.Add(subItem);
                    }
                }
                catch
                {
                }
            };
        }
        /////////////////////////////////////////////////////////////////////////// GENRATE THE HUB CHARTS AND DATA
        private async void RefreshHubClick(object sender, EventArgs e)
        {
            MessageBox.Show("Warning: This feature has been disabled because of it's beta status. if you would like to use this feature, please contact the developer.");
            
            //if (0 < Global.AssetList.Count)
            //{
            //    WarningLabel.Visible = false;
            //    //genrate charts and other data in here
            //    //ModeChart.//ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //    ModeChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //    ModeChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //    ModeChart.ChartAreas[0].AxisX.Minimum = 0;
            //    ModeChart.ChartAreas[0].AxisX.Maximum = 60;
            //    ModeChart.ChartAreas[0].AxisY.Minimum = -1;
            //    ModeChart.ChartAreas[0].AxisY.Maximum = 16;
            //    ModeChart.Series[0].IsVisibleInLegend = false;
            //    ModeChart.Visible = true;
            //};

            //foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            //{
            //    while (rundiagnostics)
            //    {
            //        if (i > Global.AssetList.Count)
            //        {
            //            i = 0;
            //        }
            //        try
            //        {
            //            //ModeChart.Series[].Add
            //            //s.Points.AddXY(DateTime.Now.Second, entry.Value.CurMode);
            //            ModeChart.Series[i].Points.AddXY(DateTime.Now.Second, entry.Value.CurMode);
            //            ModeChart.Series[i].Name = Global.AssetList.ElementAt(i).Value.Name;
            //            //ModeChart.Series.Add(s);
            //            i++;
            //        }
            //        catch
            //        {
            //        }
            //        await Task.Delay(1000);
            //    }
                
            //};
        }
        /////////////////////////////////////////////////////////////////////////// ACTUAL FORM FUNCTIONS
    }
}
