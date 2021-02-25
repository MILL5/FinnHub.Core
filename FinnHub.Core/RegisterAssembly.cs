using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            CheckIsNotNull(nameof(services), services);
            CheckIsNotNull(nameof(config), config);

            services.AddSingleton(new FinnSettings
            {
                ApiKey = "sandbox_c0mkopf48v6tkq132be0",
                BaseURL = "https://finnhub.io/", //current URL is https://finnhub.io/
                Version = "/api/v1", //current version is "/api/v1"
                UsePremiumOptions = true
            });
            services.AddTransient<IFinnHubDependencies, FinnHubDependencies>();
            services.AddTransient<FinnHubClient>();
            services.AddHttpClient(HTTPCLIENT_NAME, c =>
            {
                c.DefaultRequestHeaders.Add("Accept", "application/json");
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.Deflate |
                DecompressionMethods.GZip
            });
        }
    }
}
