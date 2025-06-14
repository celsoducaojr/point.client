namespace Point.Client.Main.Api.Dtos
{
    public class ItemUnitPatchDto
    {
        public int Id { get; set; }
        public string? ItemCode { get; init; } = null;  // Reserve for future use
        public string? CostPriceCode { get; init; } // Use as Capital Code
        public List<PriceDto>? Prices { get; init; }
    }
}
