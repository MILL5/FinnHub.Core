using Newtonsoft.Json;
using System.Collections.Generic;

namespace FinnHub.Core
{
    public class Quote
    {
        [JsonProperty("c")]
        public string CurrentPrice { get; set; }

        [JsonProperty("h")]
        public string HighPrice { get; set; }

        [JsonProperty("l")]
        public string LowPrice { get; set; }

        [JsonProperty("o")]
        public string OpenPrice { get; set; }

        [JsonProperty("pc")]
        public string PreviousClose { get; set; }

        [JsonProperty("t")]
        public int TimeStamp { get; set; }
    }

    public class QuoteCandle
    {
        [JsonProperty("c")]
        public List<string> CurrentPrice { get; set; }

        [JsonProperty("h")]
        public List<string> HighPrice { get; set; }

        [JsonProperty("l")]
        public List<string> LowPrice { get; set; }

        [JsonProperty("o")]
        public List<string> OpenPrice { get; set; }

        [JsonProperty("s")]
        public string Status { get; set; }

        [JsonProperty("t")]
        public List<string> TimeStamp { get; set; }
        
        [JsonProperty("v")]
        public List<string> Volume { get; set; }
    }
}
