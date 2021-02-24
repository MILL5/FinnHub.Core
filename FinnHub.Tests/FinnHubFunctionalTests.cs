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

        [TestMethod]
        public async Task GetMicrosoftByTicker()
        {
            var service = GetService<FinnHubCalls>();

            var companyInfo = await service.CompanyInfo(ticker: TICKER);

            Assert.IsNotNull(companyInfo);
            Assert.IsTrue(companyInfo.Ticker == TICKER);
        }
    }
}
