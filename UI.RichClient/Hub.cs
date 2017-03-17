using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void portsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ports prts = new RichClient.Ports();
            prts.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show('"' + "Madrix is insuperior, Liquid Pixel is the best" + '"' +  "-Elliot");
        }

        private void groupOBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group prts = new RichClient.Group();
            prts.Show();
        }
    }
}
