using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHubNet
{ 
    public class ReportedFinancials
    {
        public string cik { get; set; }
        public Datum[] data { get; set; }
        public string symbol { get; set; }
    }

    public class Datum
    {
        public string accessNumber { get; set; }
        public string symbol { get; set; }
        public string cik { get; set; }
        public string year { get; set; }
        public string quarter { get; set; }
        public string form { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string filedDate { get; set; }
        public string acceptedDate { get; set; }
        public Report report { get; set; }
    }

    public class Report
    {
        public B[] bs { get; set; }
        public Cf[] cf { get; set; }
        public Ic[] ic { get; set; }
    }

    public class B
    {
        public string unit { get; set; }
        public string label { get; set; }
        public string value { get; set; }
        public string concept { get; set; }
    }
    public class Cf
    {
        public string unit { get; set; }
        public string label { get; set; }
        public string value { get; set; }
        public string concept { get; set; }
    }

    public class Ic
    {
        public string unit { get; set; }
        public string label { get; set; }
        public string value { get; set; }
        public string concept { get; set; }
    }

}
