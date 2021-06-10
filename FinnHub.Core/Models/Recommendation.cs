using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class Recommendation
    {
        [JsonProperty("buy")]
        public string Buy { get; set; }

        [JsonProperty("hold")]
        public string Hold { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("sell")]
        public string Sell { get; set; }

        [JsonProperty("strongBuy")]
        public string StrongBuy { get; set; }

        [JsonProperty("strongSell")]
        public string StrongSell { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

    }

}
