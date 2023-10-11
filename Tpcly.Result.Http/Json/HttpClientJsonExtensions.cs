using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Tpcly.Result.Abstractions;

namespace Tpcly.Result.Http.Json
{
    public static class HttpClientJsonExtensions
    {
        public static Tuple<HttpResponseMessage, IResult<TSuccess, TError>> Send<TSuccess, TError>(
            this HttpClient client,
            HttpRequestMessage request,
            CancellationToken cancellationToken = default)
        {
            var response = client.Send(request, cancellationToken);
            var result = response.DeserializeAsync<TSuccess, TError>().Result;

            return new Tuple<HttpResponseMessage, IResult<TSuccess, TError>>(response, result);
        }

        public static Tuple<HttpResponseMessage, IResult<TSuccess, TError>> Send<TSuccess, TError>(
            this HttpClient client,
            HttpMethod httpMethod,
            string requestUri,
            CancellationToken cancellationToken = default)
        {
            var request = new HttpRequestMessage(httpMethod, requestUri);

            return client.Send<TSuccess, TError>(request, cancellationToken);
        }

        public async static Task<Tuple<HttpResponseMessage, IResult<TSuccess, TError>>> SendAsync<TSuccess, TError>(
            this HttpClient client,
            HttpRequestMessage request,
            CancellationToken cancellationToken = default)
        {
            var response = await client.SendAsync(request, cancellationToken);
            var result = await response.DeserializeAsync<TSuccess, TError>();

            return new Tuple<HttpResponseMessage, IResult<TSuccess, TError>>(response, result);
        }

        public async static Task<Tuple<HttpResponseMessage, IResult<TSuccess, TError>>> SendAsync<TSuccess, TError>(
            this HttpClient client,
            HttpMethod httpMethod,
            string requestUri,
            CancellationToken cancellationToken = default)
        {
            var request = new HttpRequestMessage(httpMethod, requestUri);

            return await client.SendAsync<TSuccess, TError>(request, cancellationToken);
        }
    }
}