using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class BasicFinancials
    {
        [JsonProperty(PropertyName = "metric")]
        public Metric Metric { get; set; }

        [JsonProperty(PropertyName = "metricType")]
        public string MetricType { get; set; }

        [JsonProperty(PropertyName = "series")]
        public Series Series { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
    }

    public class Metric
    {
        [JsonProperty(PropertyName = "10DayAverageTradingVolume")]
        public string TenDayAverageTradingVolume { get; set; }

        [JsonProperty(PropertyName = "13WeekPriceReturnDaily")]
        public string ThirteenWeekPriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "26WeekPriceReturnDaily")]
        public string TwentySixWeekPriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "3MonthAverageTradingVolume")]
        public string ThreeMonthAverageTradingVolume { get; set; }

        [JsonProperty(PropertyName = "52WeekHigh")]
        public string FiftyTwoWeekHigh { get; set; }

        [JsonProperty(PropertyName = "52WeekHighDate")]
        public string FiftyTwoWeekHighDate { get; set; }

        [JsonProperty(PropertyName = "52WeekLow")]
        public string FiftyTwoWeekLow { get; set; }

        [JsonProperty(PropertyName = "52WeekLowDate")]
        public string FiftyTwoWeekLowDate { get; set; }

        [JsonProperty(PropertyName = "52WeekPriceReturnDaily")]
        public string FiftyTwoWeekPriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "5DayPriceReturnDaily")]
        public string FiveDayPriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "assetTurnoverAnnual")]
        public string AssetTurnoverAnnual { get; set; }

        [JsonProperty(PropertyName = "assetTurnoverTTM")]
        public string AssetTurnoverTTM { get; set; }

        [JsonProperty(PropertyName = "beta")]
        public string Beta { get; set; }

        [JsonProperty(PropertyName = "bookValuePerShareAnnual")]
        public string BookValuePerShareAnnual { get; set; }

        [JsonProperty(PropertyName = "bookValuePerShareQuarterly")]
        public string BookValuePerShareQuarterly { get; set; }

        [JsonProperty(PropertyName = "bookValueShareGrowth5Y")]
        public string BookValueShareGrowth5Y { get; set; }

        [JsonProperty(PropertyName = "capitalSpendingGrowth5Y")]
        public string CapitalSpendingGrowth5Y { get; set; }

        [JsonProperty(PropertyName = "cashFlowPerShareAnnual")]
        public string CashFlowPerShareAnnual { get; set; }

        [JsonProperty(PropertyName = "cashFlowPerShareTTM")]
        public string CashFlowPerShareTTM { get; set; }

        [JsonProperty(PropertyName = "cashPerSharePerShareAnnual")]
        public string CashPerSharePerShareAnnual { get; set; }

        [JsonProperty(PropertyName = "cashPerSharePerShareQuarterly")]
        public string CashPerSharePerShareQuarterly { get; set; }

        [JsonProperty(PropertyName = "currentDividendYieldTTM")]
        public string CurrentDividendYieldTTM { get; set; }

        [JsonProperty(PropertyName = "currentEvfreeCashFlowAnnual")]
        public string CurrentEvfreeCashFlowAnnual { get; set; }

        [JsonProperty(PropertyName = "currentEvfreeCashFlowTTM")]
        public string CurrentEvfreeCashFlowTTM { get; set; }

        [JsonProperty(PropertyName = "currentRatioAnnual")]
        public string CurrentRatioAnnual { get; set; }

        [JsonProperty(PropertyName = "currentRatioQuarterly")]
        public string CurrentRatioQuarterly { get; set; }

        [JsonProperty(PropertyName = "dividendGrowthRate5Y")]
        public string DividendGrowthRate5Y { get; set; }

        [JsonProperty(PropertyName = "dividendPerShare5Y")]
        public string DividendPerShare5Y { get; set; }

        [JsonProperty(PropertyName = "dividendPerShareAnnual")]
        public string DividendPerShareAnnual { get; set; }

        [JsonProperty(PropertyName = "dividendYield5Y")]
        public string DividendYield5Y { get; set; }

        [JsonProperty(PropertyName = "dividendYieldIndicatedAnnual")]
        public string DividendYieldIndicatedAnnual { get; set; }

        [JsonProperty(PropertyName = "dividendsPerShareTTM")]
        public string DividendsPerShareTTM { get; set; }

        [JsonProperty(PropertyName = "ebitdPerShareTTM")]
        public string EbitdPerShareTTM { get; set; }

        [JsonProperty(PropertyName = "ebitdaCagr5Y")]
        public string EbitdaCagr5Y { get; set; }

        [JsonProperty(PropertyName = "ebitdaInterimCagr5Y")]
        public string EbitdaInterimCagr5Y { get; set; }

        [JsonProperty(PropertyName = "epsBasicExclExtraItemsAnnual")]
        public string EpsBasicExclExtraItemsAnnual { get; set; }

        [JsonProperty(PropertyName = "epsBasicExclExtraItemsTTM")]
        public string EpsBasicExclExtraItemsTTM { get; set; }

        [JsonProperty(PropertyName = "epsExclExtraItemsAnnual")]
        public string EpsExclExtraItemsAnnual { get; set; }

        [JsonProperty(PropertyName = "epsExclExtraItemsTTM")]
        public string EpsExclExtraItemsTTM { get; set; }

        [JsonProperty(PropertyName = "epsGrowth3Y")]
        public string EpsGrowth3Y { get; set; }

        [JsonProperty(PropertyName = "epsGrowth5Y")]
        public string EpsGrowth5Y { get; set; }

        [JsonProperty(PropertyName = "epsGrowthQuarterlyYoy")]
        public string EpsGrowthQuarterlyYoy { get; set; }

        [JsonProperty(PropertyName = "epsGrowthTTMYoy")]
        public string EpsGrowthTTMYoy { get; set; }

        [JsonProperty(PropertyName = "epsInclExtraItemsAnnual")]
        public string EpsInclExtraItemsAnnual { get; set; }

        [JsonProperty(PropertyName = "epsInclExtraItemsTTM")]
        public string EpsInclExtraItemsTTM { get; set; }

        [JsonProperty(PropertyName = "epsNormalizedAnnual")]
        public string EpsNormalizedAnnual { get; set; }

        [JsonProperty(PropertyName = "focfCagr5Y")]
        public string FocfCagr5Y { get; set; }

        [JsonProperty(PropertyName = "freeCashFlowAnnual")]
        public string FreeCashFlowAnnual { get; set; }

        [JsonProperty(PropertyName = "freeCashFlowPerShareTTM")]
        public string FreeCashFlowPerShareTTM { get; set; }

        [JsonProperty(PropertyName = "freeCashFlowTTM")]
        public string FreeCashFlowTTM { get; set; }

        [JsonProperty(PropertyName = "freeOperatingCashFlowrevenue5Y")]
        public string FreeOperatingCashFlowrevenue5Y { get; set; }

        [JsonProperty(PropertyName = "freeOperatingCashFlowrevenueTTM")]
        public string FreeOperatingCashFlowrevenueTTM { get; set; }

        [JsonProperty(PropertyName = "grossMargin5Y")]
        public string GrossMargin5Y { get; set; }

        [JsonProperty(PropertyName = "grossMarginAnnual")]
        public string GrossMarginAnnual { get; set; }

        [JsonProperty(PropertyName = "grossMarginTTM")]
        public string GrossMarginTTM { get; set; }

        [JsonProperty(PropertyName = "inventoryTurnoverAnnual")]
        public string InventoryTurnoverAnnual { get; set; }

        [JsonProperty(PropertyName = "inventoryTurnoverTTM")]
        public string InventoryTurnoverTTM { get; set; }

        [JsonProperty(PropertyName = "longTermDebtequityAnnual")]
        public string LongTermDebtequityAnnual { get; set; }

        [JsonProperty(PropertyName = "longTermDebtequityQuarterly")]
        public string LongTermDebtequityQuarterly { get; set; }

        [JsonProperty(PropertyName = "marketCapitalization")]
        public string MarketCapitalization { get; set; }

        [JsonProperty(PropertyName = "monthToDatePriceReturnDaily")]
        public string MonthToDatePriceReturnDaily { get; set; }

        [JsonProperty(PropertyName = "netDebtAnnual")]
        public string NetDebtAnnual { get; set; }

        [JsonProperty(PropertyName = "netIncomeEmployeeAnnual")]
        public string NetIncomeEmployeeAnnual { get; set; }

        [JsonProperty(PropertyName = "netIncomeEmployeeTTM")]
        public string NetIncomeEmployeeTTM { get; set; }

        [JsonProperty(PropertyName = "netInterestCoverageAnnual")]
        public string NetInterestCoverageAnnual { get; set; }

        [JsonProperty(PropertyName = "netInterestCoverageTTM")]
        public string NetInterestCoverageTTM { get; set; }

        [JsonProperty(PropertyName = "netMarginGrowth5Y")]
        public string NetMarginGrowth5Y { get; set; }

        [JsonProperty(PropertyName = "netProfitMargin5Y")]
        public string NetProfitMargin5Y { get; set; }

        [JsonProperty(PropertyName = "netProfitMarginAnnual")]
        public string NetProfitMarginAnnual { get; set; }

        [JsonProperty(PropertyName = "netProfitMarginTTM")]
        public string NetProfitMarginTTM { get; set; }

        [JsonProperty(PropertyName = "operatingMargin5Y")]
        public string OperatingMargin5Y { get; set; }

        [JsonProperty(PropertyName = "operatingMarginAnnual")]
        public string OperatingMarginAnnual { get; set; }

        [JsonProperty(PropertyName = "operatingMarginTTM")]
        public string OperatingMarginTTM { get; set; }

        [JsonProperty(PropertyName = "payoutRatioAnnual")]
        public string PayoutRatioAnnual { get; set; }

        [JsonProperty(PropertyName = "payoutRatioTTM")]
        public string PayoutRatioTTM { get; set; }

        [JsonProperty(PropertyName = "pbAnnual")]
        public string PbAnnual { get; set; }

        [JsonProperty(PropertyName = "pbQuarterly")]
        public string PbQuarterly { get; set; }

        [JsonProperty(PropertyName = "pcfShareTTM")]
        public string PcfShareTTM { get; set; }

        [JsonProperty(PropertyName = "peBasicExclExtraTTM")]
        public string PeBasicExclExtraTTM { get; set; }

        [JsonProperty(PropertyName = "peExclExtraAnnual")]
        public string PeExclExtraAnnual { get; set; }

        [JsonProperty(PropertyName = "peExclExtraHighTTM")]
        public string PeExclExtraHighTTM { get; set; }

        [JsonProperty(PropertyName = "peExclExtraTTM")]
        public string PeExclExtraTTM { get; set; }

        [JsonProperty(PropertyName = "peExclLowTTM")]
        public string PeExclLowTTM { get; set; }

        [JsonProperty(PropertyName = "peInclExtraTTM")]
        public string PeInclExtraTTM { get; set; }

        [JsonProperty(PropertyName = "peNormalizedAnnual")]
        public string PeNormalizedAnnual { get; set; }

        [JsonProperty(PropertyName = "pfcfShareAnnual")]
        public string PfcfShareAnnual { get; set; }

        [JsonProperty(PropertyName = "pfcfShareTTM")]
        public string PfcfShareTTM { get; set; }

        [JsonProperty(PropertyName = "pretaxMargin5Y")]
        public string PretaxMargin5Y { get; set; }

        [JsonProperty(PropertyName = "pretaxMarginAnnual")]
        public string PretaxMarginAnnual { get; set; }

        [JsonProperty(PropertyName = "pretaxMarginTTM")]
        public string PretaxMarginTTM { get; set; }

        [JsonProperty(PropertyName = "priceRelativeToSP50013Week")]
        public string PriceRelativeToSP50013Week { get; set; }

        [JsonProperty(PropertyName = "priceRelativeToSP50026Week")]
        public string PriceRelativeToSP50026Week { get; set; }

        [JsonProperty(PropertyName = "priceRelativeToSP5004Week")]
        public string PriceRelativeToSP5004Week { get; set; }

        [JsonProperty(PropertyName = "priceRelativeToSP50052Week")]
        public string PriceRelativeToSP50052Week { get; set; }

        [JsonProperty(PropertyName = "priceRelativeToSP500Ytd")]
        public string PriceRelativeToSP500Ytd { get; set; }

        [JsonProperty(PropertyName = "psAnnual")]
        public string PsAnnual { get; set; }

        [JsonProperty(PropertyName = "psTTM")]
        public string PsTTM { get; set; }

        [JsonProperty(PropertyName = "ptbvAnnual")]
        public string PtbvAnnual { get; set; }

        [JsonProperty(PropertyName = "ptbvQuarterly")]
        public string PtbvQuarterly { get; set; }

        [JsonProperty(PropertyName = "quickRatioAnnual")]
        public string QuickRatioAnnual { get; set; }

        [JsonProperty(PropertyName = "quickRatioQuarterly")]
        public string QuickRatioQuarterly { get; set; }

        [JsonProperty(PropertyName = "receivablesTurnoverAnnual")]
        public string ReceivablesTurnoverAnnual { get; set; }

        [JsonProperty(PropertyName = "receivablesTurnoverTTM")]
        public string ReceivablesTurnoverTTM { get; set; }

        [JsonProperty(PropertyName = "revenueEmployeeAnnual")]
        public string RevenueEmployeeAnnual { get; set; }

        [JsonProperty(PropertyName = "revenueEmployeeTTM")]
        public string RevenueEmployeeTTM { get; set; }

        [JsonProperty(PropertyName = "revenueGrowth3Y")]
        public string RevenueGrowth3Y { get; set; }

        [JsonProperty(PropertyName = "revenueGrowth5Y")]
        public string RevenueGrowth5Y { get; set; }

        [JsonProperty(PropertyName = "revenueGrowthQuarterlyYoy")]
        public string RevenueGrowthQuarterlyYoy { get; set; }

        [JsonProperty(PropertyName = "revenueGrowthTTMYoy")]
        public string RevenueGrowthTTMYoy { get; set; }

        [JsonProperty(PropertyName = "revenuePerShareAnnual")]
        public string RevenuePerShareAnnual { get; set; }

        [JsonProperty(PropertyName = "revenuePerShareTTM")]
        public string RevenuePerShareTTM { get; set; }

        [JsonProperty(PropertyName = "revenueShareGrowth5Y")]
        public string RevenueShareGrowth5Y { get; set; }

        [JsonProperty(PropertyName = "roaRfy")]
        public string RoaRfy { get; set; }

        [JsonProperty(PropertyName = "roaa5Y")]
        public string Roaa5Y { get; set; }

        [JsonProperty(PropertyName = "roae5Y")]
        public string Roae5Y { get; set; }

        [JsonProperty(PropertyName = "roaeTTM")]
        public string RoaeTTM { get; set; }

        [JsonProperty(PropertyName = "roeRfy")]
        public string RoeRfy { get; set; }

        [JsonProperty(PropertyName = "roeTTM")]
        public string RoeTTM { get; set; }

        [JsonProperty(PropertyName = "roi5Y")]
        public string Roi5Y { get; set; }

        [JsonProperty(PropertyName = "roiAnnual")]
        public string RoiAnnual { get; set; }

        [JsonProperty(PropertyName = "roiTTM")]
        public string RoiTTM { get; set; }

        [JsonProperty(PropertyName = "tangibleBookValuePerShareAnnual")]
        public string TangibleBookValuePerShareAnnual { get; set; }

        [JsonProperty(PropertyName = "tangibleBookValuePerShareQuarterly")]
        public string TangibleBookValuePerShareQuarterly { get; set; }

        [JsonProperty(PropertyName = "tbvCagr5Y")]
        public string TbvCagr5Y { get; set; }

        [JsonProperty(PropertyName = "totalDebttotalEquityAnnual")]
        public string TotalDebttotalEquityAnnual { get; set; }

        [JsonProperty(PropertyName = "TotalDebttotalEquityQuarterly")]
        public string TotalDebttotalEquityQuarterly { get; set; }

        [JsonProperty(PropertyName = "totalDebtCagr5Y")]
        public string TotalDebtCagr5Y { get; set; }

        [JsonProperty(PropertyName = "yearToDatePriceReturnDaily")]
        public string YearToDatePriceReturnDaily { get; set; }
    }

    public class Series
    {
        [JsonProperty(PropertyName = "annual")]
        public Annual Annual { get; set; }
    }

    public class Annual
    {
        [JsonProperty(PropertyName = "cashRatio")]
        public Cashratio[] CashRatio { get; set; }

        [JsonProperty(PropertyName = "currentRatio")]
        public Currentratio[] CurrentRatio { get; set; }

        [JsonProperty(PropertyName = "ebitPerShare")]
        public Ebitpershare[] EbitPerShare { get; set; }

        [JsonProperty(PropertyName = "eps")]
        public Ep[] Eps { get; set; }

        [JsonProperty(PropertyName = "grossMargin")]
        public Grossmargin[] GrossMargin { get; set; }

        [JsonProperty(PropertyName = "longtermDebtTotalAsset")]
        public Longtermdebttotalasset[] LongtermDebtTotalAsset { get; set; }

        [JsonProperty(PropertyName = "longtermDebtTotalCapital")]
        public Longtermdebttotalcapital[] LongtermDebtTotalCapital { get; set; }

        [JsonProperty(PropertyName = "longtermDebtTotalEquity")]
        public Longtermdebttotalequity[] LongtermDebtTotalEquity { get; set; }

        [JsonProperty(PropertyName = "netDebtToTotalCapital")]
        public Netdebttototalcapital[] NetDebtToTotalCapital { get; set; }

        [JsonProperty(PropertyName = "netDebtToTotalEquity")]
        public Netdebttototalequity[] NetDebtToTotalEquity { get; set; }

        [JsonProperty(PropertyName = "netMargin")]
        public Netmargin[] NetMargin { get; set; }

        [JsonProperty(PropertyName = "operatingMargin")]
        public Operatingmargin[] OperatingMargin { get; set; }

        [JsonProperty(PropertyName = "pretaxMargin")]
        public Pretaxmargin[] PretaxMargin { get; set; }

        [JsonProperty(PropertyName = "salesPerShare")]
        public Salespershare[] SalesPerShare { get; set; }

        [JsonProperty(PropertyName = "sgaToSale")]
        public Sgatosale[] SgaToSale { get; set; }

        [JsonProperty(PropertyName = "totalDebtToEquity")]
        public Totaldebttoequity[] TotalDebtToEquity { get; set; }

        [JsonProperty(PropertyName = "totalDebtToTotalAsset")]
        public Totaldebttototalasset[] TotalDebtToTotalAsset { get; set; }

        [JsonProperty(PropertyName = "totalDebtToTotalCapital")]
        public Totaldebttototalcapital[] TotalDebtToTotalCapital { get; set; }

        [JsonProperty(PropertyName = "TotalRatio")]
        public Totalratio[] TotalRatio { get; set; }
    }

    public class Cashratio
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Currentratio
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Ebitpershare
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Ep
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Grossmargin
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Longtermdebttotalasset
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Longtermdebttotalcapital
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Longtermdebttotalequity
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Netdebttototalcapital
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Netdebttototalequity
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Netmargin
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Operatingmargin
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Pretaxmargin
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Salespershare
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Sgatosale
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Totaldebttoequity
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Totaldebttototalasset
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Totaldebttototalcapital
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

    public class Totalratio
    {
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }

}
