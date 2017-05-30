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
            UpdateCommPortStatusInUi(Box1.Text, Status1);
            UpdateCommPortStatusInUi(Box2.Text, Status2);
            UpdateCommPortStatusInUi(Box3.Text, Status3);
            UpdateCommPortStatusInUi(Box4.Text, Status4);
            UpdateCommPortStatusInUi(Box5.Text, Status5);
            UpdateCommPortStatusInUi(Box6.Text, Status6);
        }
        private void UpdateCommPortStatusInUi(string boxtText, TextBox statusBox)
        {
            bool status;
            statusBox.TextAlign = HorizontalAlignment.Center;
            if (!Global.CommPortsConnectionStatus.TryGetValue(boxtText, out status))
            {
                statusBox.Text = "UNKNOWN";
                statusBox.BackColor = Color.LightSlateGray;
            }
            else
            {
                if (status)
                {
                    statusBox.Text = "CONNECTED";
                    statusBox.BackColor = Color.LightGreen;
                }
                else
                {
                    statusBox.Text = "NOT CONNECTED";
                    statusBox.BackColor = Color.Red;
                }
            }
        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {
            Global.port1 = Box1.Text;
            UpdateCommPortStatusInUi(Box1.Text, Status1);
        }

        private void Box2_TextChanged(object sender, EventArgs e)
        {
            Global.port2 = Box2.Text;
            UpdateCommPortStatusInUi(Box2.Text, Status2);
        }

        private void Box3_TextChanged(object sender, EventArgs e)
        {
            Global.port3 = Box3.Text;
            UpdateCommPortStatusInUi(Box3.Text, Status3);
        }

        private void Box4_TextChanged(object sender, EventArgs e)
        {
            Global.port4 = Box4.Text;
            UpdateCommPortStatusInUi(Box4.Text, Status4);
        }

        private void Box5_TextChanged(object sender, EventArgs e)
        {
            Global.port5 = Box5.Text;
            UpdateCommPortStatusInUi(Box5.Text, Status5);
        }

        private void Box6_TextChanged(object sender, EventArgs e)
        {
            Global.port6 = Box6.Text;
            UpdateCommPortStatusInUi(Box6.Text, Status6);
        }
    }
}
