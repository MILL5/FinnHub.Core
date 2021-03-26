using System.Net.Http;
using static Pineapple.Common.Preconditions;

namespace FinnHub.Core
{
    public interface IFinnHubDependencies
    {
        FinnHubSettings Settings { get; set; }
        IHttpClientFactory HttpClientFactory { get; set; }
    }

    internal class FinnHubDependencies: IFinnHubDependencies
    {
        public FinnHubSettings Settings { get; set; }
        public IHttpClientFactory HttpClientFactory { get; set; }

        public FinnHubDependencies(FinnHubSettings settings, IHttpClientFactory clientFactory)
        {
            CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNull(nameof(clientFactory), clientFactory);

            Settings = settings;
            HttpClientFactory = clientFactory;
        }
    }
}
