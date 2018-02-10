using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace UI.RichClient
{
    public class LpcAsset
    {
        /////////////////////////////////////////////////////////////////////////// VALUES OF THEA ASSET
        private readonly SerialPort _comport = new SerialPort();
        private readonly List<Mode> _modes = new List<Mode>()
        {
            new Mode() { Name="Off", Value=0 },
            new Mode() { Name="Solid", Value=1 },
            new Mode() { Name="Random Cloudy", Value=2 },
            new Mode() { Name="Flash", Value=3 },
            new Mode() { Name="Sweep", Value=4 },
            new Mode() { Name="Twinkle", Value=5 },
            new Mode() { Name="Random Twinkle", Value=6 },
            new Mode() { Name="Random Flash", Value=7 },
            new Mode() { Name="Theater Chase", Value=8 },
            new Mode() { Name="Chroma", Value=9 },
            new Mode() { Name="Fade In", Value=10 },
            new Mode() { Name="Fade Out", Value=11 },
            new Mode() { Name="Sudden Flash", Value=12 },
            new Mode() { Name="Random Breath", Value=13 },
            new Mode() { Name="Breath", Value=14 },
            new Mode() { Name="Falling Stars", Value=15 },
            new Mode() { Name="Xmas Chase", Value=16 },
            new Mode() { Name="Pong", Value=17 },
            new Mode() { Name="Waterfall", Value=18 }
        };
        private readonly List<Mode> _modesq = new List<Mode>() // mast be exaclty like the _modes for system to work
        {
            new Mode() { Name="Off", Value=0 },
            new Mode() { Name="Solid", Value=1 },
            new Mode() { Name="Random Cloudy", Value=2 },
            new Mode() { Name="Flash", Value=3 },
            new Mode() { Name="Sweep", Value=4 },
            new Mode() { Name="Twinkle", Value=5 },
            new Mode() { Name="Random Twinkle", Value=6 },
            new Mode() { Name="Random Flash", Value=7 },
            new Mode() { Name="Theater Chase", Value=8 },
            new Mode() { Name="Chroma", Value=9 },
            new Mode() { Name="Fade In", Value=10 },
            new Mode() { Name="Fade Out", Value=11 },
            new Mode() { Name="Sudden Flash", Value=12 },
            new Mode() { Name="Random Breath", Value=13 },
            new Mode() { Name="Breath", Value=14 },
            new Mode() { Name="Falling Stars", Value=15 },
            new Mode() { Name="Xmas Chase", Value=16 },
            new Mode() { Name="Pong", Value=17 },
            new Mode() { Name="Waterfall", Value=18 }
        };
        public SerialPort Comport { get { return _comport; } }
        public List<Mode> Modes { get { return _modes; } }
        public List<Mode> QueModes { get { return _modesq; } }
        public string FileName { get; set; }
        public string Name { get; set; }
        public float CmdsPerSecond { get; set; }
        public string Sent { get; set; }
        public byte BoxNumber { get; set; }
        public byte[] Color { get; set; } 
        public byte[] ColorQue { get; set; }
        public int CurMode { get; set; }
        public int QueMode { get; set; }
        public int Delay { get; set; }
        public int DelayQue { get; set; }
        public int Random { get; set; }
        public int RandomQue { get; set; }
        public string Command { get; set; }
        public string CommandQue { get; set; }
        /////////////////////////////////////////////////////////////////////////// PUBLIC FUNCTIONS
        public void Setcolormain(Panel colorpanel)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                colorpanel.BackColor = cdlg.Color;
                var color = new byte[] { clr.R, clr.G, clr.B };
                this.Color = color;
            }
            catch (Exception)
            {
                //doing nothing
            }
        }
        public void Setcolorque(Panel colorpanel)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            try
            {
                colorpanel.BackColor = cdlg.Color;
                var color = new byte[] { clr.R, clr.G, clr.B };
                this.ColorQue = color;
            }
            catch (Exception)
            {
                //doing nothing
            }
        }
        public void Updatecommandmain(int type = 0)
        {
            try
            {
                this.Command = $"T{type}C{this.BoxNumber}R{this.Color[0]}G{this.Color[1]}B{this.Color[2]}D{this.Delay}X{this.Random}M{this.CurMode}~";
            }
            catch
            {
                //doing nothing
            }
        }
        public void Updatecommandque(int type = 0)
        {
            try
            {
                this.CommandQue = $"T{type}C{this.BoxNumber}R{this.ColorQue[0]}G{this.ColorQue[1]}B{this.ColorQue[2]}D{this.DelayQue}X{this.RandomQue}M{this.QueMode}~";
            }
            catch
            {
                //doing nothing
            }
        }
        public void Sendpackage(string package)
        {
            try
            {
                this.Comport.Write(package);
            }
            catch
            {
                MessageBox.Show("Failure to send data to asset... Try again :(");
            }
        }
    }
}
