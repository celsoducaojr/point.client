namespace Point.Client.Main.Api.Dtos
{
    public sealed class ItemDto
    {
        public string Name { get; init; }
        public int? CategoryId { get; init; }
        public string? Description { get; init; }
        public List<int>? Tags { get; init; }
    }
}
