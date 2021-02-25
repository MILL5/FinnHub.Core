using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;
using static Pineapple.Common.Preconditions;

// no static methods, use dependency injection
// replace string concatenation with interpolation
// use const for strings
// add compression (gzip brotli)
namespace FinnHub.Core
{
    public class FinnHubClient : IFinnHubClient
    {
        const string COMPANY_PROFILE_REGULAR_ENDPOINT = "/stock/profile2?symbol=";
        const string COMPANY_PROFILE_PREMIUM_ENDPOINT = "/stock/profile?symbol=";
        const string METRIC_ENDPOINT = "/stock/metric?symbol=";
        const string PEERS_ENDPOINT = "/stock/peers?symbol=";
        const string NEWS_SENTIMENT_ENDPOINT = "/news-sentiment?symbol=";
        const string FINANCIALS_REPORTED_ENDPOINT = "/stock/financials-reported?symbol=";
        const string NEWS_ENDPOINT = "/news?category=";
        const string COMPANY_NEWS_ENDPOINT = "/company-news?symbol=";
        const string STOCK_SYMBOLS_ENDPOINT = "/stock/symbol?exchange=";
        const string QUOTE_ENDPOINT = "/quote?symbol=";
        const string FILINGS_ENDPOINT = "/stock/filings?symbol=";
        const string IPO_CALENDAR_ENDPOINT = "/calendar/ipo?from=";
        const string RECOMMENDATION_ENDPOINT = "/stock/recommendation?symbol=";
        const string STOCK_PRICE_TARGET_ENDPOINT = "/stock/price-target?symbol=";
        const string STOCK_EARNINGS_ENDPOINT = "/stock/earnings?symbol=";
        const string CALENDAR_EARNINGS_ENDPOINT = "/calendar/earnings?from=";
        const string HTTPCLIENT_NAME = "FinnHubHttpClient";

        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _jsonSettings;
        private readonly IFinnHubDependencies _dependencies;

        public FinnHubClient(IFinnHubDependencies dependencies)
        {
            CheckIsNotNull(nameof(dependencies), dependencies);
            _dependencies = dependencies;
            _httpClient = new HttpClient();
            _jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
        }

        //static Get()
        //{
        //    _httpClient = new HttpClient();
        //    _jsonSettings = new JsonSerializerSettings
        //    {
        //        NullValueHandling = NullValueHandling.Ignore,
        //        MissingMemberHandling = MissingMemberHandling.Ignore
        //    };
        //}

        //public static CompanyInfo CompanyInfo(string ticker)
        //{
        //    
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = settings.BaseURL + settings.Version + "/stock/profile2?symbol=" + ticker;

        //    WebClient client = new WebClient();
        //    client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

        //    var json = client.DownloadString(requestURL);

        //    CompanyInfo j = JsonConvert.DeserializeObject<CompanyInfo>(json);

        //    return j;
        //}
        
        public async Task<CompanyInfo> CompanyInfo(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = _dependencies.Settings.UsePremiumOptions ? $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{COMPANY_PROFILE_PREMIUM_ENDPOINT}{ticker}" :
                $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{COMPANY_PROFILE_REGULAR_ENDPOINT}{ticker}";

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                client.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        string content = await response.Content.ReadAsStringAsync();
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new FinnHubException
                            {
                                StatusCode = (int)response.StatusCode,
                                Content = content
                            };
                        }
                        return DeserializeObject<CompanyInfo>(content);
                    }
                }
            }

            //string requestURL = usePremium ? $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{COMPANY_PROFILE_PREMIUM_ENDPOINT}{ticker}" :
            //    $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{COMPANY_PROFILE_REGULAR_ENDPOINT}{ticker}";
            //_httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            //string json = await _httpClient.GetStringAsync(requestURL);
            
            //return DeserializeObject<CompanyInfo>(json);
        }

        public async Task<BasicFinancials> BasicFinancials(string ticker, string metric)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
            CheckIsNotNullOrWhitespace(nameof(metric), metric);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{METRIC_ENDPOINT}{ticker}&metric={metric}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<BasicFinancials>(json, _jsonSettings);
        }

        public async Task<List<string>> Peers(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{PEERS_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<List<string>>(json);
        }

        public async Task<SentimentRoot> Sentiment(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{NEWS_SENTIMENT_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<SentimentRoot>(json);
        }

        public async Task<ReportedFinancials> ReportedFinancials(string ticker, string freq)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
            CheckIsNotNullOrWhitespace(nameof(freq), freq);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{FINANCIALS_REPORTED_ENDPOINT}{ticker}{"&freq="}{freq}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<ReportedFinancials>(json, _jsonSettings);
        }

        public async Task<List<News>> News(string category)
        {
            CheckIsNotNullOrWhitespace(nameof(category), category);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{NEWS_ENDPOINT}{category}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<List<News>>(json);
        }

        public async Task<List<News>> CompanyNews(string ticker, string startDate, string endDate)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
            CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
            CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{COMPANY_NEWS_ENDPOINT}{ticker}{"&from="}{startDate}{"&to="}{endDate}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<List<News>>(json);
        }

        public async Task<List<Symbol>> StockSymbols(string exchange)
        {
            CheckIsNotNullOrWhitespace(nameof(exchange), exchange);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{STOCK_SYMBOLS_ENDPOINT}{exchange}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<List<Symbol>>(json);
        }

        public async Task<Quote> Quote(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{QUOTE_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<Quote>(json);
        }

        public async Task<List<Filing>> Filings(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{FILINGS_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<List<Filing>>(json);
        }

        public async Task<IpoCalendar> IpoCalendar(string startDate, string endDate)
        {
            CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
            CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{IPO_CALENDAR_ENDPOINT}{startDate}{"&to="}{endDate}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<IpoCalendar>(json);
        }

        public async Task<List<Recommendation>> Recommendations(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{RECOMMENDATION_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<List<Recommendation>>(json);
        }

        public async Task<Target> Target(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{STOCK_PRICE_TARGET_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<Target>(json);
        }

        public async Task<List<EPS>> EPSs(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{STOCK_EARNINGS_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<List<EPS>>(json);
        }

        public async Task<EarningsCalendar> EarningsCalendar(string startDate, string endDate)
        {
            CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
            CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

            string requestURL = $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{CALENDAR_EARNINGS_ENDPOINT}{startDate}{"&to="}{endDate}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            return DeserializeObject<EarningsCalendar>(json, _jsonSettings);
        }
    }

    public class FinnHubException : Exception
    {
        public int StatusCode { get; set; }

        public string Content { get; set; }
    }
}
