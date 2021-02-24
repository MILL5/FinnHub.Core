using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;
using static Pineapple.Common.Preconditions;

// no static methods, use dependency injection
namespace FinnHub.Core
{
    public class FinnHubCalls : IFinnHubCalls
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

        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _jsonSettings;
        private readonly IFinnHubDependencies _dependencies;

        public FinnHubCalls(IFinnHubDependencies dependencies)
        {
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

        //public static CompanyInfo CompanyInfo(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = settings.BaseURL + settings.Version + "/stock/profile2?symbol=" + ticker;

        //    WebClient client = new WebClient();
        //    client.Headers.Set("X-Finnhub-Token", settings.ApiKey);

        //    var json = client.DownloadString(requestURL);

        //    CompanyInfo j = JsonConvert.DeserializeObject<CompanyInfo>(json);

        //    return j;
        //}
        // add compression (gzip brotli)
        public async Task<CompanyInfo> CompanyInfo(string ticker, bool usePremium = false)
        {
            //CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            string requestURL = usePremium ? $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{COMPANY_PROFILE_PREMIUM_ENDPOINT}{ticker}" :
                $"{_dependencies.Settings.BaseURL}{_dependencies.Settings.Version}{COMPANY_PROFILE_REGULAR_ENDPOINT}{ticker}";
            _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", _dependencies.Settings.ApiKey);

            string json = await _httpClient.GetStringAsync(requestURL);
            // 1 get response
            // 2 ensure success, if error get the exception
            // 3 get string and deserialize object from response
            return DeserializeObject<CompanyInfo>(json);
        }

        //public static async Task<BasicFinancials> BasicFinancials(FinnSettings settings, string ticker, string metric)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
        //    CheckIsNotNullOrWhitespace(nameof(metric), metric);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{METRIC_ENDPOINT}{ticker}&metric={metric}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<BasicFinancials>(json, _jsonSettings);
        //}

        //public static async Task<List<string>> Peers(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{PEERS_ENDPOINT}{ticker}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<List<string>>(json);
        //}

        //public static async Task<SentimentRoot> Sentiment(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{NEWS_SENTIMENT_ENDPOINT}{ticker}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<SentimentRoot>(json);
        //}

        //public static async Task<ReportedFinancials> ReportedFinancials(FinnSettings settings, string ticker, string freq)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
        //    CheckIsNotNullOrWhitespace(nameof(freq), freq);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{FINANCIALS_REPORTED_ENDPOINT}{ticker}{"&freq="}{freq}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<ReportedFinancials>(json, _jsonSettings);
        //}

        //public static async Task<List<News>> News(FinnSettings settings, string category)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(category), category);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{NEWS_ENDPOINT}{category}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<List<News>>(json);
        //}

        //public static async Task<List<News>> CompanyNews(FinnSettings settings, string ticker, string startDate, string endDate)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
        //    CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
        //    CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{COMPANY_NEWS_ENDPOINT}{ticker}{"&from="}{startDate}{"&to="}{endDate}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<List<News>>(json);
        //}

        //public static async Task<List<Symbol>> StockSymbols(FinnSettings settings, string exchange)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(exchange), exchange);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{STOCK_SYMBOLS_ENDPOINT}{exchange}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<List<Symbol>>(json);
        //}

        //public static async Task<Quote> Quote(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{QUOTE_ENDPOINT}{ticker}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<Quote>(json);
        //}

        //public static async Task<List<Filing>> Filings(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{FILINGS_ENDPOINT}{ticker}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<List<Filing>>(json);
        //}

        //public static async Task<IpoCalendar> IpoCalendar(FinnSettings settings, string startDate, string endDate)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
        //    CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{IPO_CALENDAR_ENDPOINT}{startDate}{"&to="}{endDate}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<IpoCalendar>(json);
        //}

        //public static async Task<List<Recommendation>> Recommendations(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{RECOMMENDATION_ENDPOINT}{ticker}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<List<Recommendation>>(json);
        //}

        //public static async Task<Target> Target(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{STOCK_PRICE_TARGET_ENDPOINT}{ticker}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<Target>(json);
        //}

        //public static async Task<List<EPS>> EPSs(FinnSettings settings, string ticker)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{STOCK_EARNINGS_ENDPOINT}{ticker}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<List<EPS>>(json);
        //}

        //public static async Task<EarningsCalendar> EarningsCalendar(FinnSettings settings, string startDate, string endDate)
        //{
        //    CheckIsNotNull(nameof(settings), settings);
        //    CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
        //    CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

        //    string requestURL = $"{settings.BaseURL}{settings.Version}{CALENDAR_EARNINGS_ENDPOINT}{startDate}{"&to="}{endDate}";
        //    _httpClient.DefaultRequestHeaders.Add("X-Finnhub-Token", settings.ApiKey);

        //    string json = await _httpClient.GetStringAsync(requestURL);
        //    return DeserializeObject<EarningsCalendar>(json, _jsonSettings);
        //}
    }
}
