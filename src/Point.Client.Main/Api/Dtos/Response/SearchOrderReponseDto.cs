using Point.Client.Main.Api.Entities.Orders;

namespace Point.Client.Main.Api.Dtos.Response
{
    public sealed class SearchOrderReponseDto : PaginationResponseDto
    {
        public List<Order> Data { get; init; }
    }
}
