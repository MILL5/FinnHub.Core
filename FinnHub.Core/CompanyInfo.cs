using Newtonsoft.Json;

namespace FinnHub.Core
{
    public class CompanyInfo
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("finnhubIndustry")]
        public string FinnHubIndustry { get; set; }

        [JsonProperty("ipo")]
        public string IPO { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("marketCapitalization")]
        public decimal MarketCapitalization { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("shareOutstanding")]
        public float SharesOutstanding { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("weburl")]
        public string WebUrl { get; set; }

        #region Premium properties

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("sedol")]
        public string Sedol { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("employeeTotal")]
        public string EmployeeTotal { get; set; }

        [JsonProperty("ggroup")]
        public string Ggroup { get; set; }

        [JsonProperty("gind")]
        public string Gind { get; set; }

        [JsonProperty("gsector")]
        public string Gsector { get; set; }

        [JsonProperty("gsubind")]
        public string Gsubind { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("naics")]
        public string Naics { get; set; }

        [JsonProperty("naicsNationalIndustry")]
        public string NaicsNationalIndustry { get; set; }

        [JsonProperty("naicsSector")]
        public string NaicsSector { get; set; }

        [JsonProperty("naicsSubsector")]
        public string NaicsSubsector { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        #endregion
    }
}
