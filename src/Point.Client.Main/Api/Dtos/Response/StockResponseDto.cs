using Point.Client.Main.Api.Entities.Stocks;

namespace Point.Client.Main.Api.Dtos.Response
{
    public class StockResponseDto
    {
        public int ItemUnitId { get; init; }
        public string ItemName { get; init; }
        public string CategoryName { get; init; }
        public string ItemUnitName { get; init; }
        public int Quantity { get; set; }
        public List<StockHistory> Histories { get; init; }
    }
}
