using System.Linq;
using System.Net.Http;

namespace CopilotDev.NET.Api.Extension
{
    internal static class HttpClientExtension
    {
        /// <summary>
        /// Adds or replaces the given header with the given value.
        /// </summary>
        internal static void AddOrReplaceHeader(this HttpClient httpClient, string header, string value)
        {
            if (httpClient.DefaultRequestHeaders.Contains(header))
            {
                if (httpClient.DefaultRequestHeaders.TryGetValues(header, out var values) && values.All(v => v == value))
                {
                    return;
                }
                httpClient.DefaultRequestHeaders.Remove(header);
            }

            httpClient.DefaultRequestHeaders.Add(header, value);
        }
    }
}
