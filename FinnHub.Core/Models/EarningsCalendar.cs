using Newtonsoft.Json;

namespace FinnHub.Core
{

    public class EarningsCalendar
    {
        [JsonProperty("earningsCalendar")]
        public Earning[] EarningCalendar { get; set; }
    }

    public class Earning
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("epsActual")]
        public string EpsActual { get; set; }

        [JsonProperty("epsEstimate")]
        public string EpsEstimate { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("quarter")]
        public string Quarter { get; set; }

        [JsonProperty("revenueActual")]
        public string RevenueActual { get; set; }

        [JsonProperty("revenueEstimate")]
        public string RevenueEstimate { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }
    }

}
