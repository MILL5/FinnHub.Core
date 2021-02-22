using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHub.Core
{
    public class Target
    {
        public string lastUpdated { get; set; }
        public string symbol { get; set; }
        public string targetHigh { get; set; }
        public string targetLow { get; set; }
        public string targetMean { get; set; }
        public string targetMedian { get; set; }
    }

}
