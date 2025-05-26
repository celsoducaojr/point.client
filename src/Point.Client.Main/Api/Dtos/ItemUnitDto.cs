namespace Point.Client.Main.Api.Dtos
{
    public sealed class ItemUnitDto : ItemUnitPatchDto
    {
        public int ItemId { get; init; }
        public int UnitId { get; init; }
    }
}
