using System;

namespace FinnHub.Core
{
    public class FinnHubException : Exception
    {
        public int StatusCode { get; set; }

        public string Content { get; set; }
    }
}
