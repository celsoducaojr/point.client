using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class OrderService : IApiService
    {
        private const string _endPoint = "orders";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreateOrder(OrderDto orderDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, orderDto);
        }
    }
}
