using Point.Client.Main.Api.Contracts;
using RestSharp;

namespace Point.Client.Main.Api
{
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
            return response.Data;
        }
    }
}
