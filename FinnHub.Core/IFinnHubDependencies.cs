using System.Net.Http;
using AutoMapper;
using static Pineapple.Common.Preconditions;

namespace FinnHub.Core
{
    public interface IFinnHubDependencies
    {
        FinnHubSettings Settings { get; set; }
        IHttpClientFactory HttpClientFactory { get; set; }
        IMapper Mapper { get; set; }
    }

    internal class FinnHubDependencies: IFinnHubDependencies
    {
        public FinnHubSettings Settings { get; set; }
        public IHttpClientFactory HttpClientFactory { get; set; }
        
        public IMapper Mapper { get; set; }

        public FinnHubDependencies(FinnHubSettings settings, IHttpClientFactory clientFactory, IMapper mapper)
        {
            CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNull(nameof(clientFactory), clientFactory);

            Settings = settings;
            HttpClientFactory = clientFactory;
            Mapper = mapper;
        }
    }
}
