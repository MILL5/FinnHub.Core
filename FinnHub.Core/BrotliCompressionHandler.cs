﻿using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BrotliSharpLib;

namespace FinnHub.Core
{
    public class BrotliCompressionHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            if (!response.Content.Headers.TryGetValues("Content-Encoding", out var ce) || ce.First() != "br")
                return response;
            var buffer = await response.Content.ReadAsByteArrayAsync();
            response.Content = new ByteArrayContent(Brotli.DecompressBuffer(buffer, 0, buffer.Length));
            return response;
        }
    }
}
