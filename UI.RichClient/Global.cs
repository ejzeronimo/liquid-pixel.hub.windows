using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.RichClient
{
    public class Global
    {
        public static SortedDictionary<string, LpcAsset> AssetList = new SortedDictionary<string, LpcAsset>();
        private static readonly List<Mode> _modes = new List<Mode>()
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
            new Mode() { Name="Pong", Value=17 }
        };
        public static List<Mode> Modes { get { return _modes; } }
    }
}
