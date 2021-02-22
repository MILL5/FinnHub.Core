using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHub.Core
{
    public class IpoCalendar
    {
        public IPO[] ipoCalendar { get; set; }
    }

    public class IPO
    {
        public string date { get; set; }
        public string exchange { get; set; }
        public string name { get; set; }
        public string numberOfShares { get; set; }
        public string price { get; set; }
        public string status { get; set; }
        public string symbol { get; set; }
        public string totalSharesValue { get; set; }
    }
}
