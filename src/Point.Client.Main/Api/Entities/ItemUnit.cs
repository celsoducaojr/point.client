namespace Point.Client.Main.Api.Entities
{
    public class ItemUnit
    {
        public int Id { get; init; }
        public Unit Unit { get; init; }
        public string? ItemCode { get; init; }
        public string? PriceCode { get; init; }
        public List<Price>? Prices { get; init; }
    }
}
