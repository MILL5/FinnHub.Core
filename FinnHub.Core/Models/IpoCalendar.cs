using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class IpoCalendar
    {
        [JsonProperty("ipoCalendar")]
        public IPO[] IPOCalendar { get; set; }
    }

    public class IPO
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("numberOfShares")]
        public string NumberOfShares { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("totalSharesValue")]
        public string TotalSharesValue { get; set; }
    }
}
