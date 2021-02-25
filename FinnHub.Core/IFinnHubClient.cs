using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinnHub.Core
{
    public interface IFinnHubClient
    {
        Task<CompanyInfo> CompanyInfo(string ticker);
        Task<BasicFinancials> BasicFinancials(string ticker, string metric);
        Task<List<string>> Peers(string ticker);
        Task<SentimentRoot> Sentiment(string ticker);
        Task<ReportedFinancials> ReportedFinancials(string ticker, string freq);
        Task<List<News>> News(string category);
        Task<List<News>> CompanyNews(string ticker, string startDate, string endDate);
        Task<List<Symbol>> StockSymbols(string exchange);
        Task<Quote> Quote(string ticker);
        Task<List<Filing>> Filings(string ticker);
        Task<IpoCalendar> IpoCalendar(string startDate, string endDate);
        Task<List<Recommendation>> Recommendations(string ticker);
        Task<Target> Target(string ticker);
        Task<List<EPS>> EPSs(string ticker);
        Task<EarningsCalendar> EarningsCalendar(string startDate, string endDate);
    }
}
