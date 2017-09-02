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
            new Mode() { Name="RandomCloudy", Value=2 }
        };
        public SerialPort Comport { get { return _comport; } }
        public string FileName { get; set; }
        public string Name { get; set; }
        public bool IsOpen { get; set; }
        public float CmdsPerSecond { get; set; }
        public string Sent { get; set; }
        public int[] Color { get; set; }
        public byte Mode { get; set; }
        public List<Mode> Modes { get { return _modes; } }
        public byte BoxNumber { get; set; }
        public int Delay { get; set; }

    }
}
