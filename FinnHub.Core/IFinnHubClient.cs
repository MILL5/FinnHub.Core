using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinnHub.Core
{
    public interface IFinnHubClient
    {
        Task<CompanyInfo> GetCompanyInfoAsync(string ticker, bool expandAbbreviations = false);
        Task<BasicFinancials> GetBasicFinancialsAsync(string ticker, string metric);
        Task<List<string>> GetPeersAsync(string ticker);
        Task<SentimentRoot> GetSentimentAsync(string ticker);
        Task<ReportedFinancials> GetReportedFinancialsAsync(string ticker, string freq);
        Task<List<News>> GetNewsAsync(string category);
        Task<List<News>> GetCompanyNewsAsync(string ticker, string startDate, string endDate);
        Task<List<Symbol>> GetStockSymbolsAsync(string exchange);
        Task<Quote> GetQuoteAsync(string ticker);
        Task<List<Filing>> GetFilingsAsync(string ticker);
        Task<IpoCalendar> GetIpoCalendarAsync(string startDate, string endDate);
        Task<List<Recommendation>> GetRecommendationsAsync(string ticker);
        Task<Target> GetTargetAsync(string ticker);
        Task<List<EPS>> GetEPSsAsync(string ticker);
        Task<EarningsCalendar> GetEarningsCalendarAsync(string startDate, string endDate);
        Task<QuoteCandle> GetQuoteCandleAsync(string ticker, string resolution, DateTime startDate, DateTime endDate);
    }
}
