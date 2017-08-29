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
        private readonly SerialPort _comport = new SerialPort();

        public SerialPort Comport { get { return _comport; } }
        public string FileName { get; set; }
        public string Name { get; set; }
        public bool IsOpen { get; set; }
        public float CmdsPerSecond { get; set; }
        public string LastSent { get; set; }
        public int[] LastColor { get; set; }
        public byte LastMode { get; set; }
    }
}
