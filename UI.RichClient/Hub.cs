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

namespace UI.RichClient
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelayBarQ bxs = new DelayBarQ();
            bxs.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show('"' + "Madrix is insuperior, Liquid Systems is the best" + '"' + "-Elliot");
        }

        private void groupOBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group grp = new RichClient.Group();
            grp.Show();
        }

        private void NewLpcAssetCreate(object sender, EventArgs e)
        {
            Ports prt = new RichClient.Ports();
            prt.Show();
        }

        private void MouseHoverCheckForBoxes(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            {
                try
                {
                    ListOfBoxes.Text += entry.Value.Name + Environment.NewLine;
                    ToolStripItem subItem = new ToolStripMenuItem(entry.Value.Name);
                    portsToolStripMenuItem.DropDownItems.Add(subItem);
                }
                catch
                {
                }
            };
        }

        private void AssetListUpdate(object sender, EventArgs e)
        {
            int maxlist = Global.AssetList.Count;
            foreach (KeyValuePair<string, LpcAsset> entry in Global.AssetList)
            {
                try
                {
                    ToolStripItem subItem = new ToolStripMenuItem(entry.Value.Name);
                    portsToolStripMenuItem.DropDownItems.Add(subItem);
                }
                catch
                {
                }
            };
        }
    }
}
