using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHubNet
{
    public class Symbol
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displaySymbol")]
        public string DisplaySymbol { get; set; }

        [JsonProperty("symbol")]
        public string TickerSymbol { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
