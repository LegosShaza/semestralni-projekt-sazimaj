using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestralni_projekt_sazimaj
{
    internal class ScanResult
    {
        public string IP { get; set; }
        public string Status { get; set; }
        public string PingTime { get; set; }
        public string Hostname { get; set; }
        public string OpenPorts { get; set; }
    }
}
