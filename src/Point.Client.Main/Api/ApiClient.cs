using Newtonsoft.Json;
using Point.Client.Main.Api.Contracts;
using RestSharp;
using System.Net;

namespace Point.Client.Main.Api
{
    public class ApiErrorResponse
    {
        public string? Title { get; set; }
        public int StatusCode { get; set; }
        public string? Detail { get; set; }
    }
    public class ApiClient
    {
        public readonly RestClient _restClient;
        public ApiClient(string baseUrl) 
        {
            _restClient = new RestClient(baseUrl);
        }

        public async Task<T?> ExecuteAsync<T>(string endpoint, Method method, object? body = null) where T : class
        {
            var request = new RestRequest(endpoint, method);

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            var response = await _restClient.ExecuteAsync<T>(request);

            if (!response.IsSuccessful)
            {
                try
                {
                    var errorResponse = JsonConvert.DeserializeObject<ApiErrorResponse>(response.Content);
                    throw new HttpRequestException($"{errorResponse?.Detail}");
                }
                catch (JsonException)
                {
                    throw new HttpRequestException($"Request failed:\n\n{response.Content}");
                }
            }

            return response.Data;
        }

        public async Task ExecuteAsync(string endpoint, Method method, object? body = null)
        {
            var request = new RestRequest(endpoint, method);

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            var response = await _restClient.ExecuteAsync(request);

            if (!response.IsSuccessful)
            {
                try
                {
                    var errorResponse = JsonConvert.DeserializeObject<ApiErrorResponse>(response.Content);
                    throw new HttpRequestException($"{errorResponse?.Detail}");
                }
                catch (JsonException)
                {
                    throw new HttpRequestException($"Request failed:\n\n{response.Content}");
                }
            }
        }
    }
}
