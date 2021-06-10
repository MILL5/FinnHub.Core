using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class ReportedFinancials
    {
        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class Datum
    {
        [JsonProperty("accessNumber")]
        public string AccessNumber { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("quarter")]
        public string Quarter { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("filedDate")]
        public string FiledDate { get; set; }

        [JsonProperty("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonProperty("report")]
        public Report Report { get; set; }
    }

    public class Report
    {
        [JsonProperty("bs")]
        public B[] Bs { get; set; }

        [JsonProperty("cf")]
        public Cf[] Cf { get; set; }

        [JsonProperty("ic")]
        public Ic[] Ic { get; set; }
    }

    public class B
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("concept")]
        public string Concept { get; set; }
    }

    public class Cf
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("concept")]
        public string Concept { get; set; }
    }

    public class Ic
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("concept")]
        public string Concept { get; set; }
    }
}
