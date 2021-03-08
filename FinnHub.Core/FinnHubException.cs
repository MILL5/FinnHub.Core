using System;

namespace FinnHub.Core
{
    public class FinnHubException : Exception
    {
        public FinnHubException(string message)
        : base(message)
        {
        }
    }
}
