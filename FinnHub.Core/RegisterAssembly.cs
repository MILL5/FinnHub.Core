using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Net.Http;
using static Pineapple.Common.Preconditions;
using static System.Environment;

namespace FinnHub.Core
{
    public static class RegisterAssembly
    {
        const string HTTPCLIENT_NAME = "FinnHubHttpClient";

        public static void AddServices(IServiceCollection services, IConfiguration config)
        {
            CheckIsNotNull(nameof(services), services);
            CheckIsNotNull(nameof(config), config);
            
            var settings = new FinnSettings
            {
                ApiKey = GetEnvironmentVariable("ApiKey"),
                BaseURL = GetEnvironmentVariable("FinnHubBaseUrl"),
                Version = GetEnvironmentVariable("FinnHubApiVersion"),
                UsePremiumOptions = bool.Parse(GetEnvironmentVariable("UsePremiumOptions"))
            };

            services.AddSingleton(settings);
            services.AddTransient<IFinnHubDependencies, FinnHubDependencies>();
            services.AddTransient<IFinnHubClient, FinnHubClient>();
            services.AddTransient<BrotliCompressionHandler>();
            services.AddHttpClient(HTTPCLIENT_NAME, client =>
            {
                client.BaseAddress = new Uri($"{settings.BaseURL}{settings.Version}");
                client.DefaultRequestHeaders.Add(GetEnvironmentVariable("FinnHubTokenHeader"), settings.ApiKey);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
            }).AddHttpMessageHandler<BrotliCompressionHandler>();
        }
    }
}
