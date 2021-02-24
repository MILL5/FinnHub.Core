using static Pineapple.Common.Preconditions;

namespace FinnHub.Core
{
    public interface IFinnHubDependencies
    {
        FinnSettings Settings { get; set; }
    }

    internal class FinnHubDependencies: IFinnHubDependencies
    {
        public FinnSettings Settings { get; set; }

        public FinnHubDependencies(FinnSettings settings)
        {
            CheckIsNotNull(nameof(settings), settings);

            Settings = settings;
        }
    }
}
