using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class EPS
    {
        [JsonProperty("actual")]
        public string Actual { get; set; }

        [JsonProperty("estimate")]
        public string Estimate { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

    }

}
