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
        /////////////////////////////////////////////////////////////////////////// SETUP THE FORM
        public Ports(LpcAsset asset = null)
        {
            InitializeComponent();
            if (asset != null)
            {
                NameBox.Text = asset.Name;
                PortNum.Text = asset.Comport.PortName;
                Baudrate.Text = asset.Comport.BaudRate.ToString();
                try
                {
                    UpdatePortStatus(asset, Status);
                    ColorPanel.BackColor = Color.FromArgb(asset.Color[0], asset.Color[1], asset.Color[2]);
                    panelq.BackColor = Color.FromArgb(asset.ColorQue[0], asset.ColorQue[1], asset.ColorQue[2]);
                }
                catch { }
            }
        }
        private void Ports_Load(object sender, EventArgs e)
        {
        }
        /////////////////////////////////////////////////////////////////////////// INFORMATION ON THE ASSET
        private void UpdatePortStatus(LpcAsset asset, TextBox statusBox)
        {
            bool status = asset.Comport.IsOpen;
            if (status)
            {
                statusBox.Text = "CONNECTED";
                statusBox.BackColor = Color.LightGreen;
            }
            else
            {
                statusBox.Text = "NOT CONNECTED";
                statusBox.BackColor = Color.LightSalmon;
            }
        }
        /////////////////////////////////////////////////////////////////////////// ASSET LOADING AND SAVING
        private void SaveLpcAsset(object sender, EventArgs e)
        {
            //C:\_Src\Prod\LiquidPixel\UI.RichClient\bin\Debug save location   
            if (NameBox.Text == "null" || PortNum.Text == "null")
            {
                MessageBox.Show("Must enter a name and port before this file can be saved");
            }
            else
            {
                SaveFileDialog log = new SaveFileDialog();
                //writes file to address
                log.Filter = "Text Files (*.txt*)|*.txt*";
                log.FilterIndex = 1;
                log.DefaultExt = "txt";
                log.FileName = NameBox.Text;
                log.ShowDialog();
                string filestruct = "Type=LpcAsset\r\nName=" + NameBox.Text + "\r\nComport=" + PortNum.Text;
                System.IO.StreamWriter file = new System.IO.StreamWriter(log.FileName);
                file.WriteLine(filestruct);
                file.Close();
                //creates LpcAsset and puts in list
                var myAsset = new LpcAsset();
                myAsset.Comport.PortName = PortNum.Text;
                myAsset.Name = NameBox.Text;
                UpdatePortStatus(myAsset, Status);
                myAsset.Comport.Parity = Parity.None;
                myAsset.Comport.DataBits = 8;
                myAsset.Comport.StopBits = StopBits.One;
                myAsset.Comport.Encoding = Encoding.ASCII;
                myAsset.Comport.BaudRate = Int32.Parse(Baudrate.Text);
                Global.AssetList.Add(myAsset.Name, myAsset);
                this.Text = NameBox.Text;
            }
        }
        private void OpenAssets(object sender, EventArgs e)
        {
            //check and see what assets can be opened
            OpenFileDialog log = new OpenFileDialog();
            log.Filter = "Text Files (*.txt*)|*.txt*";
            log.FilterIndex = 1;
            log.Multiselect = false;
            log.ShowDialog();
            string address = log.FileName;
            System.IO.StreamReader file = new System.IO.StreamReader(address);
            //reads file and assigns to temp values
            string name = "";
            string type = "";
            string port = "";
            int i = 0;
            string line = "not null";
            var tempAsset = new LpcAsset();
            while (line != null && i < 3)
            {
                line = file.ReadLine();
                if (line != null)
                {
                    if (i == 0)
                    {
                        type = line;
                        type = type.Replace("Type=",null);
                        TypeBox.Text = type;
                    }
                    if (i == 1)
                    {
                        name = line;
                        name = name.Replace("Name=", null);  
                    }
                    if (i == 2)
                    {
                        port = line;
                        port = port.Replace("Comport=", null);
                        PortNum.Text = port;
                        tempAsset.Name = name;
                        NameBox.Text = name;
                        tempAsset.Comport.PortName = port;
                        tempAsset.Comport.Parity = Parity.None;
                        tempAsset.Comport.DataBits = 8;
                        tempAsset.Comport.StopBits = StopBits.One;
                        tempAsset.Comport.Encoding = Encoding.ASCII;
                        tempAsset.Comport.BaudRate = Int32.Parse(Baudrate.Text);
                        Global.AssetList.Add(tempAsset.Name, tempAsset);
                    }
                    i++;
                }
            }
            this.Text = NameBox.Text;
            UpdatePortStatus(tempAsset, Status);
        }
    }
}

