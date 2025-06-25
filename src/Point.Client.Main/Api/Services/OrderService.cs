using System.Drawing.Printing;
using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Enums;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public async Task<GetOrdersResponseDto?> SearchOrders(int page, int pageSize, int? customerId = null, List<OrderStatus>? statuses = null)
        {
            var endPoint = $"{_endPoint}/search?page={page}&pageSize={pageSize}";
            if (customerId.HasValue) endPoint += $"&customerId={customerId}";
            if (statuses?.Count > 0) endPoint += $"&{string.Join("&", statuses.Select(status => $"statuses={(int)status}"))}";
            return await _pointApiClient.ExecuteAsync<GetOrdersResponseDto>(endPoint, Method.Get);
        }
    }
}
