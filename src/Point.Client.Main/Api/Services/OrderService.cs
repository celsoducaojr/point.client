using System.Drawing.Printing;
using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Constants;
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

        public async Task<OrderResponseDto?> CreateOrder(OrderDto orderDto)
        {
            return await _pointApiClient.ExecuteAsync<OrderResponseDto>(_endPoint, Method.Post, orderDto);
        }

        public async Task<OrderResponseDto?> UpdateOrder(int id, OrderDto orderDto)
        {
            return await _pointApiClient.ExecuteAsync<OrderResponseDto>($"{_endPoint}/{id}", Method.Put, orderDto);
        }

        public async Task<OrderResponseDto?> AddPayment(int id, PaymentDto paymentDto)
        {
            return await _pointApiClient.ExecuteAsync<OrderResponseDto>($"{_endPoint}/{id}/payment", Method.Post, paymentDto);
        }

        public async Task ReleaseOrder(int id, PaymentTerm paymentTerm)
        {
            var statusAction = FormConstants.Order.StatusActionDictionary[OrderStatus.Released];
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}/{statusAction}", Method.Put, new { paymentTerm });
        }

        public async Task CancelOrder(int id)
        {
            var statusAction = FormConstants.Order.StatusActionDictionary[OrderStatus.Cancelled];
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}/{statusAction}", Method.Put);
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
