using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class StockService : IApiService
    {
        private const string _endPoint = "stocks";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task UpdateStocks(int id, StockDto stockDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, stockDto);
        }
    }
}
