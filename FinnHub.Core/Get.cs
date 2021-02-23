using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using static Pineapple.Common.Preconditions;

namespace FinnHub.Core
{
    public class Get
    {
        public static CompanyInfo CompanyInfo(FinnSettings settings, string ticker)
        {
            CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = settings.BaseURL + settings.Version + "/stock/profile2?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            CompanyInfo j = JsonConvert.DeserializeObject<CompanyInfo>(json);

            return j;
        }

        public static BasicFinancials BasicFinancials(FinnSettings settings, string ticker, string metric)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            string requestURL = settings.BaseURL + settings.Version + "/stock/metric?symbol=" + ticker + "&metric=" + metric;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            BasicFinancials j = JsonConvert.DeserializeObject<BasicFinancials>(json, jsonSettings);

            return j;
        }

        public static List<string> Peers(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/stock/peers?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            List<string> j = JsonConvert.DeserializeObject<List<string>>(json);

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

        public static ReportedFinancials ReportedFinancials(FinnSettings settings, string ticker, string freq)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            string requestURL = settings.BaseURL + settings.Version + "/stock/financials-reported?symbol=" + ticker + "&freq=" + freq;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            ReportedFinancials j = JsonConvert.DeserializeObject<ReportedFinancials>(json, jsonSettings);

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

        public static List<Filing> Filings(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/stock/filings?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            List<Filing> j = JsonConvert.DeserializeObject<List<Filing>>(json);

            return j;
        }

        public static IpoCalendar IpoCalendar(FinnSettings settings, string startdate, string enddate)
        {
            string requestURL = settings.BaseURL + settings.Version + "/calendar/ipo?from=" + startdate + "&to=" + enddate;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            IpoCalendar j = JsonConvert.DeserializeObject<IpoCalendar>(json);

            return j;
        }

        public static List<Recommendation> Recommendations(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/stock/recommendation?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            List<Recommendation> j = JsonConvert.DeserializeObject<List<Recommendation>>(json);

            return j;
        }

        public static Target Target(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/stock/price-target?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            Target j = JsonConvert.DeserializeObject<Target>(json);

            return j;
        }

        public static List<EPS> EPSs(FinnSettings settings, string ticker)
        {
            string requestURL = settings.BaseURL + settings.Version + "/stock/earnings?symbol=" + ticker;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            List<EPS> j = JsonConvert.DeserializeObject<List<EPS>>(json);

            return j;
        }

        public static EarningsCalendar EarningsCalendar(FinnSettings settings, string startdate, string enddate)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            string requestURL = settings.BaseURL + settings.Version + "/calendar/earnings?from=" + startdate + "&to=" + enddate;

            WebClient client = new WebClient();
            client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

            var json = client.DownloadString(requestURL);

            EarningsCalendar j = JsonConvert.DeserializeObject<EarningsCalendar>(json, jsonSettings);

            return j;
        }
    }
}
