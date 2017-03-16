using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.RichClient
{
    public partial class Ports : Form
    {

        public Ports()
        {
            InitializeComponent();

        }

        private void Ports_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {
            Global.port1 = Box1.Text;
        }

        private void Box2_TextChanged(object sender, EventArgs e)
        {
            Global.port2 = Box2.Text;
        }

        private void Box3_TextChanged(object sender, EventArgs e)
        {
            Global.port3 = Box3.Text;
        }

        private void Box4_TextChanged(object sender, EventArgs e)
        {
            Global.port4 = Box4.Text;
        }

        private void Box5_TextChanged(object sender, EventArgs e)
        {
            Global.port5 = Box5.Text;
        }

        private void Box6_TextChanged(object sender, EventArgs e)
        {
            Global.port6 = Box6.Text;
        }
    }
}
