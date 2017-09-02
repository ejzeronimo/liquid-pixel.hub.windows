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
        }
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
                Global.Assets.Add(new Mode() { Name = NameBox.Text, Value = Global.AssetAmount });
                Global.AssetAmount++;
                UpdatePortStatus(myAsset, Status);
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
            var tempobj = new LpcAsset();
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
                        Global.Assets.Add(new Mode() { Name = name, Value = Global.AssetAmount });
                        Global.AssetAmount++;
                        tempobj.Name = name;
                        NameBox.Text = name;
                        tempobj.Comport.PortName = port;
                    }
                    i++;
                }
            }
            UpdatePortStatus(tempobj,Status);
        }
    }
}

