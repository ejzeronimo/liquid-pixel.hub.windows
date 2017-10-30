using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace UI.RichClient
{
    public class LpcAsset
    {
        //    Off = 0,
        //    Solid,
        //    RandomCloudy,
        //    Flash,
        //    Sweep,
        //    Twinkle,
        //    RandomTwinkle,
        //    RandomFlash,
        //    TheaterChase,
        //    Chroma,
        //    FadeIn,
        //    FadeOut,
        //    SuddenFlash,
        //    RandomBreath,
        //    Breath

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
        };
        public SerialPort Comport { get { return _comport; } }
        public string FileName { get; set; }
        public string Name { get; set; }
        public float CmdsPerSecond { get; set; }
        public string Sent { get; set; }
        public byte[] Color { get; set; }
        public int CurMode { get; set; }
        public List<Mode> Modes { get { return _modes; } }
        public byte BoxNumber { get; set; }
        public int Delay { get; set; }
    }
}
