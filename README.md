# FinnHub.Core
This is a .NET class library for the FinnHub APIs for use with .NET Standard, .NET Core, and the new .NET 5.0.


**To Use:**

Install using Nuget: 

```
PM > Install-Package FinnHub.Core -Version 1.0.0
```

Create a FinnSettings Object to pass into each request:

**Example:**

```
FinnHub.Core.FinnSettings settings = new FinnHubNet.FinnSettings
            {
                ApiKey = "YOUR API KEY",
                BaseURL = "CURRENT BASE URL", //current URL is https://finnhub.io/
                Version = "API VERSION URL" //current version is "/api/v1"
            };
```


In requests you will pass the FinnSettings object along with any other parameters needed.

**Example:**

```
var j = FinnHub.Core.Get.CompanyInfo(settings, ticker);
```
You can then access data from CompanyInfo object J or whichever request you are using.

All implemented requests are in the Get class for easy access.

**Current FinnnHub API Requests available:**

-CompanyInfo

-CompanyNews

-News

-Quote

-StockSymbols

-Sentiment

-Peers

-BasicFinancials

-ReportedFinancials

-Filings (SEC Filings)

-IpoCalendar

-Recommendations

-Target (Target Prices)

-EPSs (Earnings Releases)

-EarningsCalendar
