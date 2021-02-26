using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinnHub.Core
{
    public interface IFinnHubClient
    {
        Task<CompanyInfo> GetCompanyInfo(string ticker);
        Task<BasicFinancials> GetBasicFinancials(string ticker, string metric);
        Task<List<string>> GetPeers(string ticker);
        Task<SentimentRoot> GetSentiment(string ticker);
        Task<ReportedFinancials> GetReportedFinancials(string ticker, string freq);
        Task<List<News>> GetNews(string category);
        Task<List<News>> GetCompanyNews(string ticker, string startDate, string endDate);
        Task<List<Symbol>> GetStockSymbols(string exchange);
        Task<Quote> GetQuote(string ticker);
        Task<List<Filing>> GetFilings(string ticker);
        Task<IpoCalendar> GetIpoCalendar(string startDate, string endDate);
        Task<List<Recommendation>> GetRecommendations(string ticker);
        Task<Target> GetTarget(string ticker);
        Task<List<EPS>> GetEPSs(string ticker);
        Task<EarningsCalendar> GetEarningsCalendar(string startDate, string endDate);
    }
}
