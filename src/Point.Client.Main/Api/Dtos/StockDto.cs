using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Api.Dtos
{
    public sealed record StockDto(
        StockUpdateType Type,
        int Quantity,
        string? Remarks);
}
