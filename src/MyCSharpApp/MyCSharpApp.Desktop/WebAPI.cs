using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MyCSharpApp.Desktop
{

    public static class WebAPI
    {

        /// <summary>
        /// Create an HTTP Client with dynamic URI and "Content-Type" header custom value.
        /// </summary>
        /// <param name="URI">The URI to request the data</param>
        /// <param name="ContentType">The Content Type to receive the server data</param>
        /// <returns></returns>
        public static HttpClient CreateHttpClient(string URI, string ContentType = "application/x-www-form-urlencoded")
        {
            HttpClient client = new HttpClient();

            // WebClientConfig
            client.BaseAddress = new Uri(URI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(ContentType)
            );

            return client;
        }

        /// <summary>
        /// Create an HTTP Client with dynamic URI.
        /// </summary>
        /// <param name="URI">The URI to request the data</param>
        /// <returns></returns>
        public static HttpClient CreateHttpClient(string URI)
        {
            HttpClient client = new HttpClient();

            // WebClientConfig
            client.BaseAddress = new Uri(URI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded")
            );

            return client;
        }
    }
}
