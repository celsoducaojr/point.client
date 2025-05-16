namespace Point.Client.Main.Api.Dtos
{
    public sealed class ItemUnitDto
    {
        public int ItemId { get; init; }
        public int UnitId { get; init; }
        public string? ItemCode { get; init; }
        public string? PriceCode { get; init; }
        public List<PriceDto> Prices { get; init; }
    }

    public sealed class PriceDto
    {
        public int PriceTypeId { get; init; }
        public int Amount { get; init; }    
    }
}
