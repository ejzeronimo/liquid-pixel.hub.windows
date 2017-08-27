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
            byte i = 1;
            //C:\_Src\Prod\LiquidPixel\UI.RichClient\bin\Debug save location
            string filestruct = "Type=LpcAsset\r\nName=" + NameBox.Text + "\r\nComport=" + PortNum.Text;
            if (NameBox.Text == "null" || PortNum.Text == "null")
            {
                MessageBox.Show("Must enter a name and port before this file can be saved");
            }
            else
            {
                if (i < 6)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(NameBox.Text + ".txt");
                    file.WriteLine(filestruct);
                    file.Close();
                    switch (i)
                    {
                        case 1:
                            Box1.Comport.PortName = PortNum.Text;
                            Box1.Name = NameBox.Text;
                            Box1.FileName = NameBox.Text + ".txt";
                            break;
                        case 2:
                            Box2.Comport.PortName = PortNum.Text;
                            Box2.Name = NameBox.Text;
                            Box2.FileName = NameBox.Text + ".txt";
                            break;
                        case 3:
                            Box3.Comport.PortName = PortNum.Text;
                            Box3.Name = NameBox.Text;
                            Box3.FileName = NameBox.Text + ".txt";
                            break;
                        case 4:
                            Box4.Comport.PortName = PortNum.Text;
                            Box4.Name = NameBox.Text;
                            Box4.FileName = NameBox.Text + ".txt";
                            break;
                        case 5:
                            Box5.Comport.PortName = PortNum.Text;
                            Box5.Name = NameBox.Text;
                            Box5.FileName = NameBox.Text + ".txt";
                            break;
                        case 6:
                            Box6.Comport.PortName = PortNum.Text;
                            Box6.Name = NameBox.Text;
                            Box6.FileName = NameBox.Text + ".txt";
                            break;
                        default:
                            break;
                    }
                            i++;
                }
                else
                {
                    MessageBox.Show("Beta has bugs");
                }

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
