using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHub.Core
{
    public class SentimentRoot
    {
        [JsonProperty("buzz")]
        public Buzz Buzz { get; set; }

        [JsonProperty("companyNewsScore")]
        public string NewsScore { get; set; }

        [JsonProperty("sectorAverageBullishPercent")]
        public string AverageBullishPercent { get; set; }

        [JsonProperty("sectorAverageNewsScore")]
        public string AverageNewsScore { get; set; }

        [JsonProperty("sentiment")]
        public Sentiment Sentiment { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class Buzz
    {
        [JsonProperty("articlesInLastWeek")]
        public string ArticlesInLastWeek { get; set; }

        [JsonProperty("buzz")]
        public string CompanyBuzz { get; set; }

        [JsonProperty("weeklyAverage")]
        public string WeeklyAverage { get; set; }
    }

    public class Sentiment
    {
        [JsonProperty("bearishPercent")]
        public string BearishPercent { get; set; }

        [JsonProperty("bullishPercent")]
        public string BullishPercent { get; set; }
    }
}
