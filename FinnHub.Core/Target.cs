using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class Target
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("targetHigh")]
        public string TargetHigh { get; set; }

        [JsonProperty("targetLow")]
        public string TargetLow { get; set; }

        [JsonProperty("targetMean")]
        public string TargetMean { get; set; }

        [JsonProperty("targetMedian")]
        public string TargetMedian { get; set; }
    }
}
