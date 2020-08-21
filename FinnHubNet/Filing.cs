using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHubNet
{

    public class Filing
    {
        public string accessNumber { get; set; }
        public string symbol { get; set; }
        public string cik { get; set; }
        public string form { get; set; }
        public string filedDate { get; set; }
        public string acceptedDate { get; set; }
        public string reportUrl { get; set; }
        public string filingUrl { get; set; }
    }

}
