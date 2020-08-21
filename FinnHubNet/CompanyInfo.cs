using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHubNet
{
    public class CompanyInfo
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("finnhubIndustry")]
        public string FinnHubIndustry { get; set; }

        [JsonProperty("ipo")]
        public string IPO { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("marketCapitalization")]
        public decimal MarketCapitalization { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("shareOutstanding")]
        public float SharesOutstanding { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("weburl")]
        public string WebUrl { get; set; }
    }
}
