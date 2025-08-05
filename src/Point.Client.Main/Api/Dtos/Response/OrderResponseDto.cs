using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Api.Dtos.Response
{
    public class OrderResponseDto
    {
        public int Id { get; init; }
        public OrderStatus Status { get; init; }
    }
}
