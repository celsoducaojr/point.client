using Point.Client.Main.Api.Entities.Orders;

namespace Point.Client.Main.Api.Dtos.Response
{
    public class GetOrdersResponseDto : PaginationResponseDto
    {
        public List<Order> Data { get; init; }
    }
}
