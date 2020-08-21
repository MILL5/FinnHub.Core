using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FinnHubNet
{

    public class Get
    {
        public static CompanyInfo CompanyInfo(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/stock/profile2?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            CompanyInfo j = JsonConvert.DeserializeObject<CompanyInfo>(json);

            return j;
        }

        public static SentimentRoot Sentiment(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/news-sentiment?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            SentimentRoot j = JsonConvert.DeserializeObject<SentimentRoot>(json);

            return j;
        }


        public static List<News> News(FinnSettings settings, string category)
        {
            string requestURL = settings.BaseURL + settings.Version + "/news?category=" + category;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            List<News> j = JsonConvert.DeserializeObject<List<News>>(json);

            return j;
        }

        public static List<News> CompanyNews(FinnSettings settings, string ticker, string startdate, string enddate)
        {

            string requestURL = settings.BaseURL + settings.Version + "/company-news?symbol=" + ticker + "&from=" + startdate + "&to=" + enddate;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            List<News> j = JsonConvert.DeserializeObject<List<News>>(json);

            return j;
        }

        public static List<Symbol> StockSymbols(FinnSettings settings, string exchange)
        {
            string requestURL = settings.BaseURL + settings.Version + "/stock/symbol?exchange=" + exchange;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            List<Symbol> j = JsonConvert.DeserializeObject<List<Symbol>>(json);

            return j;
        }

        public static Quote Quote(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/quote?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            Quote j = JsonConvert.DeserializeObject<Quote>(json);

            return j;
        }
    }
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

    public class Quote
    {

        [JsonProperty("c")]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("h")]
        public decimal HighPrice { get; set; }

        [JsonProperty("l")]
        public decimal LowPrice { get; set; }

        [JsonProperty("o")]
        public decimal OpenPrice { get; set; }

        [JsonProperty("pc")]
        public decimal PreviousClose { get; set; }

        [JsonProperty("t")]
        public int TimeStamp { get; set; }
    }

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


    public class News
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("datetime")]
        public int Datetime { get; set; }

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


    public class SentimentRoot
    {
        [JsonProperty("buzz")]
        public Buzz Buzz { get; set; }

        [JsonProperty("companyNewsScore")]
        public float NewsScore { get; set; }

        [JsonProperty("sectorAverageBullishPercent")]
        public float AverageBullishPercent { get; set; }

        [JsonProperty("sectorAverageNewsScore")]
        public float AverageNewsScore { get; set; }

        [JsonProperty("sentiment")]
        public Sentiment Sentiment { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class Buzz
    {
        [JsonProperty("articlesInLastWeek")]
        public int ArticlesInLastWeek { get; set; }

        [JsonProperty("buzz")]
        public float CompanyBuzz { get; set; }

        [JsonProperty("weeklyAverage")]
        public float WeeklyAverage { get; set; }
    }

    public class Sentiment
    {
        [JsonProperty("bearishPercent")]
        public float BearishPercent { get; set; }

        [JsonProperty("bullishPercent")]
        public float BullishPercent { get; set; }
    }


}
