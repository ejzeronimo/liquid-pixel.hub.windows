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
    public partial class Ports : Form
    {

        public Ports()
        {
            InitializeComponent();
        }

        private void Ports_Load(object sender, EventArgs e)
        {
            UpdateCommPortStatusInUi(PortNum.Text, Status);
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
            //Box.Comport.PortName = PortNum.Text;
            UpdateCommPortStatusInUi(PortNum.Text, Status);

        }

        private void SaveLpcAsset(object sender, EventArgs e)
        {
            //C:\_Src\Prod\LiquidPixel\UI.RichClient\bin\Debug save location
            string filestruct = "Type=LpcAsset\r\nName=" + NameBox.Text + "\r\nComport=" + PortNum.Text;
            if (NameBox.Text == "null" || PortNum.Text == "null")
            {
                MessageBox.Show("Must enter a name and port before this file can be saved");
            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(NameBox.Text + ".txt");
                file.WriteLine(filestruct);
                file.Close();

                var myAsset = new LpcAsset();

                myAsset.Comport.PortName = PortNum.Text;
                myAsset.Name = NameBox.Text;
            }

        }

        private void NameChange(object sender, EventArgs e)
        {

        }

        private void OpenAssets(object sender, EventArgs e)
        {
            //check and see what assets can be opened
            //create new form that has all Assets 

            OpenFileDialog log = new OpenFileDialog();
            log.Filter = "Text Files (*.txt*)|*.txt*";
            log.FilterIndex = 1;
            log.Multiselect = true;
            log.ShowDialog();
            string address = log.FileName;
        }
    }
}
