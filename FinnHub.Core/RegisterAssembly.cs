using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Net.Http;
using static Pineapple.Common.Preconditions;

namespace FinnHub.Core
{
    public static class RegisterAssembly
    {
        const string HTTPCLIENT_NAME = "FinnHubHttpClient";

        public static void AddServices(IServiceCollection services, IConfiguration config)
        {
            const string FINNHUB_URL = "https://finnhub.io/api/v1";
            const string FINNHUB_TOKEN_HEADER = "X-Finnhub-Token";

            CheckIsNotNull(nameof(services), services);
            CheckIsNotNull(nameof(config), config);
            
            var settings = new FinnHubSettings
            {
                ApiKey = config["FinnHubApiKey"],
                UsePremiumOptions = bool.Parse(config["UsePremiumOptions"])
            };

            services.AddSingleton(settings);
            services.AddTransient<IFinnHubDependencies, FinnHubDependencies>();
            services.AddTransient<IFinnHubClient, FinnHubClient>();
            services.AddTransient<BrotliCompressionHandler>();
            services.AddHttpClient(HTTPCLIENT_NAME, client =>
            {
                client.BaseAddress = new Uri(FINNHUB_URL);
                client.DefaultRequestHeaders.Add(FINNHUB_TOKEN_HEADER, settings.ApiKey);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
            }).AddHttpMessageHandler<BrotliCompressionHandler>();
        }
    }
}
