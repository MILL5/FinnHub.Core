using FinnHub.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using static FinnHub.Tests.TestManager;

namespace FinnHub.Tests
{
    [TestClass]
    public class FinnHubFunctionalTests
    {
        const string TICKER = "MSFT";
        const string METRIC = "all";
        const string FREQUENCY = "all";
        const string CIK = "789019";
        const string CATEGORY = "general";
        const string START_DATE = "2021-01-01";
        const string END_DATE = "2021-01-05";
        const string EXCHANGE = "US";
        const string CURRENT_PRICE = "0";
        const string START_DATE_EARNINGS = "2021-01-25";
        const string END_DATE_EARNINGS = "2021-01-30";

        [TestMethod]
        public async Task GetCompanyInfoByTicker()
        {
            var service = GetService<FinnHubClient>();

            var companyInfo = await service.GetCompanyInfoAsync(ticker: TICKER);

            Assert.IsNotNull(companyInfo);
            Assert.IsTrue(companyInfo.Ticker == TICKER);
        }

        [TestMethod]
        public async Task GetBasicFinancialsByTickerAndMetric()
        {
            var service = GetService<FinnHubClient>();

            var basicFinancials = await service.GetBasicFinancialsAsync(ticker: TICKER, metric: METRIC);

            Assert.IsNotNull(basicFinancials);
            Assert.IsNotNull(basicFinancials.Metric);
            Assert.IsNotNull(basicFinancials.Series);
            Assert.IsTrue(basicFinancials.MetricType == METRIC);
            Assert.IsTrue(basicFinancials.Symbol == TICKER);
        }

        [TestMethod]
        public async Task GetPeersByTicker()
        {
            var service = GetService<FinnHubClient>();

            var peers = await service.GetPeersAsync(ticker: TICKER);

            Assert.IsNotNull(peers);
            Assert.IsTrue(peers.Count > 1);
        }

        [TestMethod]
        public async Task GetSentimentByTicker()
        {
            var service = GetService<FinnHubClient>();

            var sentimentRoot = await service.GetSentimentAsync(ticker: TICKER);

            Assert.IsNotNull(sentimentRoot);
            Assert.IsTrue(sentimentRoot.Symbol == TICKER);
        }

        [TestMethod]
        public async Task GetReportedFinancialsByTickerAndFrequency()
        {
            var service = GetService<FinnHubClient>();

            var reportedFinancials = await service.GetReportedFinancialsAsync(ticker: TICKER, freq: FREQUENCY);

            Assert.IsNotNull(reportedFinancials);
            Assert.IsTrue(reportedFinancials.Symbol == TICKER);
            Assert.IsTrue(reportedFinancials.Cik == CIK);
            Assert.IsNotNull(reportedFinancials.Data);
            Assert.IsTrue(reportedFinancials.Data.Length > 0);
        }

        [TestMethod]
        public async Task GetNewsByCategory()
        {
            var service = GetService<FinnHubClient>();

            var news = await service.GetNewsAsync(category: CATEGORY);

            Assert.IsNotNull(news);
            Assert.IsTrue(news.Count > 0);
        }

        [TestMethod]
        public async Task GetCompanyNewsByTickerAndDateRange()
        {
            var service = GetService<FinnHubClient>();

            var companyNews = await service.GetCompanyNewsAsync(ticker: TICKER, startDate: START_DATE, endDate: END_DATE);

            Assert.IsNotNull(companyNews);
            Assert.IsTrue(companyNews.Count > 0);
        }

        [TestMethod]
        public async Task GetStockSymbolsByExchange()
        {
            var service = GetService<FinnHubClient>();

            var symbols = await service.GetStockSymbolsAsync(exchange: EXCHANGE);

            Assert.IsNotNull(symbols);
            Assert.IsTrue(symbols.Count > 0);
        }

        [TestMethod]
        public async Task GetQuoteByTicker()
        {
            var service = GetService<FinnHubClient>();

            var symbol = await service.GetQuoteAsync(ticker: TICKER);

            Assert.IsNotNull(symbol);
            Assert.IsTrue(symbol.CurrentPrice != CURRENT_PRICE);
        }

        [TestMethod]
        public async Task GetFilingsByTicker()
        {
            var service = GetService<FinnHubClient>();

            var filings = await service.GetFilingsAsync(ticker: TICKER);

            Assert.IsNotNull(filings);
            Assert.IsTrue(filings.Count > 0);
        }

        [TestMethod]
        public async Task GetIpoCalendarByDateRange()
        {
            var service = GetService<FinnHubClient>();

            var ipoCalendar = await service.GetIpoCalendarAsync(startDate: START_DATE, endDate: END_DATE);

            Assert.IsNotNull(ipoCalendar);
            Assert.IsNotNull(ipoCalendar.IPOCalendar);
            Assert.IsTrue(ipoCalendar.IPOCalendar.Length > 0);
        }

        [TestMethod]
        public async Task GetRecommendationsByTicker()
        {
            var service = GetService<FinnHubClient>();

            var recommendations = await service.GetRecommendationsAsync(ticker: TICKER);

            Assert.IsNotNull(recommendations);
            Assert.IsNotNull(recommendations.Count > 1);
        }

        [TestMethod]
        public async Task GetTargetByTicker()
        {
            var service = GetService<FinnHubClient>();

            var target = await service.GetTargetAsync(ticker: TICKER);

            Assert.IsNotNull(target);
            Assert.IsTrue(target.Symbol == TICKER);
        }

        [TestMethod]
        public async Task GetEPSsByTicker()
        {
            var service = GetService<FinnHubClient>();

            var epss = await service.GetEPSsAsync(ticker: TICKER);

            Assert.IsNotNull(epss);
            Assert.IsNotNull(epss.Count > 1);
        }

        [TestMethod]
        public async Task GetEarningsCalendarByDateRange()
        {
            var service = GetService<FinnHubClient>();

            var earningsCalendar = await service.GetEarningsCalendarAsync(startDate: START_DATE_EARNINGS, endDate: END_DATE_EARNINGS);

            Assert.IsNotNull(earningsCalendar.EarningCalendar);
            Assert.IsNotNull(earningsCalendar.EarningCalendar.Length > 1);
        }
    }
}
