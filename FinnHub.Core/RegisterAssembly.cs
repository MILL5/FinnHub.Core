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
        // FinnHub API Key
        const string API_KEY = "sandbox_c0mkopf48v6tkq132be0";
        //current URL is https://finnhub.io/
        const string BASE_URL = "https://finnhub.io/";
        //current version is "/api/v1"
        const string API_VERSION = "/api/v1";
        const string FINNHUB_TOKEN_HEADER = "X-Finnhub-Token";

        public static void AddServices(IServiceCollection services, IConfiguration config)
        {
            CheckIsNotNull(nameof(services), services);
            CheckIsNotNull(nameof(config), config);

            var settings = new FinnSettings
            {
                ApiKey = API_KEY,
                BaseURL = BASE_URL,
                Version = API_VERSION,
                UsePremiumOptions = true
            };

            services.AddSingleton(settings);
            services.AddTransient<IFinnHubDependencies, FinnHubDependencies>();
            services.AddTransient<FinnHubClient>();
            services.AddTransient<BrotliCompressionHandler>();
            services.AddHttpClient(HTTPCLIENT_NAME, client =>
            {
                client.BaseAddress = new Uri($"{settings.BaseURL}{settings.Version}");
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
