using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHub.Core
{
    public class News
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("tyrelatedpe")]
        public string Related { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
