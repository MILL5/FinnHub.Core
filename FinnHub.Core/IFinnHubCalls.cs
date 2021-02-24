using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinnHub.Core
{
    public interface IFinnHubCalls
    {
        Task<CompanyInfo> CompanyInfo(string ticker, bool usePremium = false);
    }
}
