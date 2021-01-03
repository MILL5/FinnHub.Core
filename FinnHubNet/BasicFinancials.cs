using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinnHubNet
{
    public class BasicFinancials
    {
        public Metric metric { get; set; }
        public string metricType { get; set; }
        public Series series { get; set; }
        public string symbol { get; set; }
    }

    public class Metric
    {
        [JsonProperty(PropertyName = "10DayAverageTradingVolume")]
        public string _10DayAverageTradingVolume { get; set; }

        [JsonProperty(PropertyName = "13WeekPriceReturnDaily")]
        public string _13WeekPriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "26WeekPriceReturnDaily")]
        public string _26WeekPriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "3MonthAverageTradingVolume")]
        public string _3MonthAverageTradingVolume { get; set; }

        [JsonProperty(PropertyName = "52WeekHigh")]
        public string _52WeekHigh { get; set; }

        [JsonProperty(PropertyName = "52WeekHighDate")]
        public string _52WeekHighDate { get; set; }

        [JsonProperty(PropertyName = "52WeekLow")]
        public string _52WeekLow { get; set; }

        [JsonProperty(PropertyName = "52WeekLowDate")]
        public string _52WeekLowDate { get; set; }

        [JsonProperty(PropertyName = "52WeekPriceReturnDaily")]
        public string _52WeekPriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "5DayPriceReturnDaily")]
        public string _5DayPriceReturnDaily { get; set; }

        public string assetTurnoverAnnual { get; set; }
        public string assetTurnoverTTM { get; set; }
        public string beta { get; set; }
        public string bookValuePerShareAnnual { get; set; }
        public string bookValuePerShareQuarterly { get; set; }
        public string bookValueShareGrowth5Y { get; set; }
        public string capitalSpendingGrowth5Y { get; set; }
        public string cashFlowPerShareAnnual { get; set; }
        public string cashFlowPerShareTTM { get; set; }
        public string cashPerSharePerShareAnnual { get; set; }
        public string cashPerSharePerShareQuarterly { get; set; }
        public string currentDividendYieldTTM { get; set; }
        public string currentEvfreeCashFlowAnnual { get; set; }
        public string currentEvfreeCashFlowTTM { get; set; }
        public string currentRatioAnnual { get; set; }
        public string currentRatioQuarterly { get; set; }
        public string dividendGrowthRate5Y { get; set; }
        public string dividendPerShare5Y { get; set; }
        public string dividendPerShareAnnual { get; set; }
        public string dividendYield5Y { get; set; }
        public string dividendYieldIndicatedAnnual { get; set; }
        public string dividendsPerShareTTM { get; set; }
        public string ebitdPerShareTTM { get; set; }
        public string ebitdaCagr5Y { get; set; }
        public string ebitdaInterimCagr5Y { get; set; }
        public string epsBasicExclExtraItemsAnnual { get; set; }
        public string epsBasicExclExtraItemsTTM { get; set; }
        public string epsExclExtraItemsAnnual { get; set; }
        public string epsExclExtraItemsTTM { get; set; }
        public string epsGrowth3Y { get; set; }
        public string epsGrowth5Y { get; set; }
        public string epsGrowthQuarterlyYoy { get; set; }
        public string epsGrowthTTMYoy { get; set; }
        public string epsInclExtraItemsAnnual { get; set; }
        public string epsInclExtraItemsTTM { get; set; }
        public string epsNormalizedAnnual { get; set; }
        public string focfCagr5Y { get; set; }
        public string freeCashFlowAnnual { get; set; }
        public string freeCashFlowPerShareTTM { get; set; }
        public string freeCashFlowTTM { get; set; }
        public string freeOperatingCashFlowrevenue5Y { get; set; }
        public string freeOperatingCashFlowrevenueTTM { get; set; }
        public string grossMargin5Y { get; set; }
        public string grossMarginAnnual { get; set; }
        public string grossMarginTTM { get; set; }
        public string inventoryTurnoverAnnual { get; set; }
        public string inventoryTurnoverTTM { get; set; }
        public string longTermDebtequityAnnual { get; set; }
        public string longTermDebtequityQuarterly { get; set; }
        public string marketCapitalization { get; set; }
        public string monthToDatePriceReturnDaily { get; set; }
        public string netDebtAnnual { get; set; }
        public string netIncomeEmployeeAnnual { get; set; }
        public string netIncomeEmployeeTTM { get; set; }
        public string netInterestCoverageAnnual { get; set; }
        public string netInterestCoverageTTM { get; set; }
        public string netMarginGrowth5Y { get; set; }
        public string netProfitMargin5Y { get; set; }
        public string netProfitMarginAnnual { get; set; }
        public string netProfitMarginTTM { get; set; }
        public string operatingMargin5Y { get; set; }
        public string operatingMarginAnnual { get; set; }
        public string operatingMarginTTM { get; set; }
        public string payoutRatioAnnual { get; set; }
        public string payoutRatioTTM { get; set; }
        public string pbAnnual { get; set; }
        public string pbQuarterly { get; set; }
        public string pcfShareTTM { get; set; }
        public string peBasicExclExtraTTM { get; set; }
        public string peExclExtraAnnual { get; set; }
        public string peExclExtraHighTTM { get; set; }
        public string peExclExtraTTM { get; set; }
        public string peExclLowTTM { get; set; }
        public string peInclExtraTTM { get; set; }
        public string peNormalizedAnnual { get; set; }
        public string pfcfShareAnnual { get; set; }
        public string pfcfShareTTM { get; set; }
        public string pretaxMargin5Y { get; set; }
        public string pretaxMarginAnnual { get; set; }
        public string pretaxMarginTTM { get; set; }
        public string priceRelativeToSP50013Week { get; set; }
        public string priceRelativeToSP50026Week { get; set; }
        public string priceRelativeToSP5004Week { get; set; }
        public string priceRelativeToSP50052Week { get; set; }
        public string priceRelativeToSP500Ytd { get; set; }
        public string psAnnual { get; set; }
        public string psTTM { get; set; }
        public string ptbvAnnual { get; set; }
        public string ptbvQuarterly { get; set; }
        public string quickRatioAnnual { get; set; }
        public string quickRatioQuarterly { get; set; }
        public string receivablesTurnoverAnnual { get; set; }
        public string receivablesTurnoverTTM { get; set; }
        public string revenueEmployeeAnnual { get; set; }
        public string revenueEmployeeTTM { get; set; }
        public string revenueGrowth3Y { get; set; }
        public string revenueGrowth5Y { get; set; }
        public string revenueGrowthQuarterlyYoy { get; set; }
        public string revenueGrowthTTMYoy { get; set; }
        public string revenuePerShareAnnual { get; set; }
        public string revenuePerShareTTM { get; set; }
        public string revenueShareGrowth5Y { get; set; }
        public string roaRfy { get; set; }
        public string roaa5Y { get; set; }
        public string roae5Y { get; set; }
        public string roaeTTM { get; set; }
        public string roeRfy { get; set; }
        public string roeTTM { get; set; }
        public string roi5Y { get; set; }
        public string roiAnnual { get; set; }
        public string roiTTM { get; set; }
        public string tangibleBookValuePerShareAnnual { get; set; }
        public string tangibleBookValuePerShareQuarterly { get; set; }
        public string tbvCagr5Y { get; set; }
        public string totalDebttotalEquityAnnual { get; set; }
        public string totalDebttotalEquityQuarterly { get; set; }
        public string totalDebtCagr5Y { get; set; }
        public string yearToDatePriceReturnDaily { get; set; }
    }

    public class Series
    {
        public Annual annual { get; set; }
    }

    public class Annual
    {
        public Cashratio[] cashRatio { get; set; }
        public Currentratio[] currentRatio { get; set; }
        public Ebitpershare[] ebitPerShare { get; set; }
        public Ep[] eps { get; set; }
        public Grossmargin[] grossMargin { get; set; }
        public Longtermdebttotalasset[] longtermDebtTotalAsset { get; set; }
        public Longtermdebttotalcapital[] longtermDebtTotalCapital { get; set; }
        public Longtermdebttotalequity[] longtermDebtTotalEquity { get; set; }
        public Netdebttototalcapital[] netDebtToTotalCapital { get; set; }
        public Netdebttototalequity[] netDebtToTotalEquity { get; set; }
        public Netmargin[] netMargin { get; set; }
        public Operatingmargin[] operatingMargin { get; set; }
        public Pretaxmargin[] pretaxMargin { get; set; }
        public Salespershare[] salesPerShare { get; set; }
        public Sgatosale[] sgaToSale { get; set; }
        public Totaldebttoequity[] totalDebtToEquity { get; set; }
        public Totaldebttototalasset[] totalDebtToTotalAsset { get; set; }
        public Totaldebttototalcapital[] totalDebtToTotalCapital { get; set; }
        public Totalratio[] totalRatio { get; set; }
    }

    public class Cashratio
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Currentratio
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Ebitpershare
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Ep
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Grossmargin
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Longtermdebttotalasset
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Longtermdebttotalcapital
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Longtermdebttotalequity
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Netdebttototalcapital
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Netdebttototalequity
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Netmargin
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Operatingmargin
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Pretaxmargin
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Salespershare
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Sgatosale
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Totaldebttoequity
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Totaldebttototalasset
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Totaldebttototalcapital
    {
        public string period { get; set; }
        public string v { get; set; }
    }

    public class Totalratio
    {
        public string period { get; set; }
        public string v { get; set; }
    }

}
