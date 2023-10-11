using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Tpcly.Result.Abstractions;

namespace Tpcly.Result.Http.Json
{
    public static class HttpResponseMessageJsonExtensions
    {
        public async static Task<IResult<TSuccess, TError>> DeserializeAsync<TSuccess, TError>(this HttpResponseMessage response, JsonSerializerOptions? serializerOptions = null)
        {
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<TSuccess>(serializerOptions);
                return new Result<TSuccess, TError>(data);
            }

            var error = await response.Content.ReadFromJsonAsync<TError>(serializerOptions);
            return new Result<TSuccess, TError>(error);
        }
    }
}