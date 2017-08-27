using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI.RichClient
{
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search(object sender, EventArgs e)
        {
            string filename = FileName.Text;
            if (System.IO.File.Exists(filename))
            {
                MessageBox.Show("Beta feature - doesnt work");
            }
        }

        private void Use(object sender, EventArgs e)
        {
            string filename = FileName.Text;
            if (System.IO.File.Exists(filename))
            {
                MessageBox.Show("Beta feature - doesnt work");
            }
        }
    }
}
