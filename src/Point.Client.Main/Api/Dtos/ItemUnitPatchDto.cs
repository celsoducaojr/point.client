namespace Point.Client.Main.Api.Dtos
{
    public class ItemUnitPatchDto
    {
        public int Id { get; set; }
        public string? ItemCode { get; init; }
        public string? PriceCode { get; init; }
        public List<PriceDto>? Prices { get; init; }
    }
}
