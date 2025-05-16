namespace Point.Client.Main.Api.Entities
{
    public class Item
    {
        public int Id { get; init; }
        public string Name { get; init; } 
        public Category? Category { get; init; }
        public string? Description { get; init; }
        public List<Tag>? Tags { get; init; }
        public List<Price>? Prices { get; init; }
    }

    public class Price
    {
        public PriceType PriceType { get; init; }
        public decimal Amount { get; init; }
    }
}
