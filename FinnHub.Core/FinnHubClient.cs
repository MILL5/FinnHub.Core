using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;
using static Pineapple.Common.Preconditions;
using System;

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
        const string QUOTE_CANDLE = "/stock/candle?symbol={symbol_placeholder}&resolution={resolution_placeholder}&from={startDate_placeholder}&to={endDate_placeholder}";
        const string HTTPCLIENT_NAME = "FinnHubHttpClient";

        private readonly JsonSerializerSettings _jsonSettings;
        private readonly IFinnHubDependencies _dependencies;

        public FinnHubClient(IFinnHubDependencies dependencies)
        {
            CheckIsNotNull(nameof(dependencies), dependencies);
            _dependencies = dependencies;
            _jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
        }

        public async Task<CompanyInfo> GetCompanyInfoAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = _dependencies.Settings.UsePremiumOptions ? $"{client.BaseAddress}{COMPANY_PROFILE_PREMIUM_ENDPOINT}{ticker}" :
                $"{client.BaseAddress}{COMPANY_PROFILE_REGULAR_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<CompanyInfo>(content);
                        }
                        else
                            return null;
                    }
                }
            }
        }

        public async Task<BasicFinancials> GetBasicFinancialsAsync(string ticker, string metric)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
            CheckIsNotNullOrWhitespace(nameof(metric), metric);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{METRIC_ENDPOINT}{ticker}&metric={metric}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<BasicFinancials>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<List<string>> GetPeersAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{PEERS_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<List<string>>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<SentimentRoot> GetSentimentAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{NEWS_SENTIMENT_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<SentimentRoot>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<ReportedFinancials> GetReportedFinancialsAsync(string ticker, string freq)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
            CheckIsNotNullOrWhitespace(nameof(freq), freq);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{FINANCIALS_REPORTED_ENDPOINT}{ticker}{"&freq="}{freq}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<ReportedFinancials>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<List<News>> GetNewsAsync(string category)
        {
            CheckIsNotNullOrWhitespace(nameof(category), category);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{NEWS_ENDPOINT}{category}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<List<News>>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<List<News>> GetCompanyNewsAsync(string ticker, string startDate, string endDate)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
            CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
            CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{COMPANY_NEWS_ENDPOINT}{ticker}{"&from="}{startDate}{"&to="}{endDate}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<List<News>>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<List<Symbol>> GetStockSymbolsAsync(string exchange)
        {
            CheckIsNotNullOrWhitespace(nameof(exchange), exchange);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{STOCK_SYMBOLS_ENDPOINT}{exchange}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<List<Symbol>>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<Quote> GetQuoteAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{QUOTE_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<Quote>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<List<Filing>> GetFilingsAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{FILINGS_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<List<Filing>>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<IpoCalendar> GetIpoCalendarAsync(string startDate, string endDate)
        {
            CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
            CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{IPO_CALENDAR_ENDPOINT}{startDate}{"&to="}{endDate}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<IpoCalendar>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<List<Recommendation>> GetRecommendationsAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{RECOMMENDATION_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<List<Recommendation>>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<Target> GetTargetAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{STOCK_PRICE_TARGET_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<Target>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<List<EPS>> GetEPSsAsync(string ticker)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{STOCK_EARNINGS_ENDPOINT}{ticker}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<List<EPS>>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<EarningsCalendar> GetEarningsCalendarAsync(string startDate, string endDate)
        {
            CheckIsNotNullOrWhitespace(nameof(startDate), startDate);
            CheckIsNotNullOrWhitespace(nameof(endDate), endDate);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{CALENDAR_EARNINGS_ENDPOINT}{startDate}{"&to="}{endDate}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<EarningsCalendar>(content);
                        }
                        else
                        {
                            throw new FinnHubException(response.ReasonPhrase);
                        }
                    }
                }
            }
        }

        public async Task<QuoteCandle> GetQuoteCandleAsync(string ticker, string resolution, DateTime startDate, DateTime endDate)
        {
            CheckIsNotNullOrWhitespace(nameof(ticker), ticker);
            CheckIsNotNullOrWhitespace(nameof(resolution), resolution);
            CheckIsNotNull(nameof(startDate), startDate);
            CheckIsNotNull(nameof(endDate), endDate);

            var startDateUnixTimeStamp = ConvertDatetimeToUnixTimeStamp(startDate).ToString();
            var endDateUnixTimeStamp = ConvertDatetimeToUnixTimeStamp(endDate).ToString();
            var candleParameters = QUOTE_CANDLE.Replace("{symbol_placeholder}", ticker)
                    .Replace("{resolution_placeholder}", resolution)
                    .Replace("{startDate_placeholder}", startDateUnixTimeStamp)
                    .Replace("{endDate_placeholder}", endDateUnixTimeStamp);

            using (var client = _dependencies.HttpClientFactory.CreateClient(HTTPCLIENT_NAME))
            {
                string requestURL = $"{client.BaseAddress}{candleParameters}";
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestURL))
                {
                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            return DeserializeObject<QuoteCandle>(content);
                        }
                        else
                            return null;
                    }
                }
            }
        }

        private static long ConvertDatetimeToUnixTimeStamp(DateTime date)
        {
            var dateTimeOffset = new DateTimeOffset(date);
            var unixDateTime = dateTimeOffset.ToUnixTimeSeconds();
            return unixDateTime;
        }
    }
}
