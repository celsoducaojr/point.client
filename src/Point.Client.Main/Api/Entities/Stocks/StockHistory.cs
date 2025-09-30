using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Api.Entities.Stocks
{
    public class StockHistory
    {
        public DateTime Created { get; set; }
        public int QuantityChanged { get; set; }
        public int QuantityAfterChange { get; set; }
        public StockUpdateType Type { get; set; }
        public string? Remarks { get; set; }
    }
}
