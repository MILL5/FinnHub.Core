using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static Pineapple.Common.Preconditions;

namespace FinnHub.Tests
{
    public static class RegisterAssembly
    {
        public static void AddApplication(this IServiceCollection services,
                                          IConfiguration config)
        {
            CheckIsNotNull(nameof(services), services);
            CheckIsNotNull(nameof(config), config);

            Core.RegisterAssembly.AddServices(services, config);
        }
    }
}
