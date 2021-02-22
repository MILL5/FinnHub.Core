using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHub.Core
{

    public class EarningsCalendar
    {
        public Earning[] earningsCalendar { get; set; }
    }
    
    public class Earning
    {
        public string date { get; set; }
        public string epsActual { get; set; }
        public string epsEstimate { get; set; }
        public string hour { get; set; }
        public string quarter { get; set; }
        public string revenueActual { get; set; }
        public string revenueEstimate { get; set; }
        public string symbol { get; set; }
        public string year { get; set; }
    }

}
