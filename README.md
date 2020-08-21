# FinnHubNet
A C# Wrapper for FinnHub.io API


To Use:

Create a FinnSettings Object to pass into each request:

Example:

```
FinnHubNet.FinnSettings settings = new FinnHubNet.FinnSettings
            {
                ApiKey = "YOUR API KEY",
                BaseURL = "CURRENT BASE URL", //current URL is https://finnhub.io/
                Version = "API VERSION URL" //current version is "/api/v1"
            };
```


In requests you will pass that settinges object along with any other parameters needed.

Example:

```
var j = FinnHubNet.Get.CompanyInfo(settings, ticker);
```

You can then access data from CompanyInfo object J or whichever request you are using.



