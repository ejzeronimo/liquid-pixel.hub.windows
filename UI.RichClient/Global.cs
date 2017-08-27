using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace UI.RichClient
{
    
    
    class Global
    {
        static public string port1;
        static public string port2;
        static public string port3;
        static public string port4;
        static public string port5;
        static public string port6;
        public static readonly Dictionary<string, bool> CommPortsConnectionStatus = new Dictionary<string, bool>();
        
    }
}
