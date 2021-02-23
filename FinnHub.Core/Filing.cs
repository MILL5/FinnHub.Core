using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class Filing
    {
        [JsonProperty("accessNumber")]
        public string AccessNumber { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("filedDate")]
        public string FiledDate { get; set; }

        [JsonProperty("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonProperty("reportUrl")]
        public string ReportUrl { get; set; }

        [JsonProperty("filingUrl")]
        public string FilingUrl { get; set; }
    }
}
