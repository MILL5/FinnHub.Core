using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static Pineapple.Common.Preconditions;

namespace FinnHub.Core
{
    public static class RegisterAssembly
    {
        public static void AddServices(IServiceCollection services, IConfiguration config)
        {
            CheckIsNotNull(nameof(services), services);
            CheckIsNotNull(nameof(config), config);

            services.AddSingleton(new FinnSettings
            {
                ApiKey = "sandbox_c0mkopf48v6tkq132be0",
                BaseURL = "https://finnhub.io/", //current URL is https://finnhub.io/
                Version = "/api/v1" //current version is "/api/v1"
            });
            services.AddTransient<IFinnHubDependencies, FinnHubDependencies>();
            services.AddTransient<FinnHubCalls>();
        }
    }
}
