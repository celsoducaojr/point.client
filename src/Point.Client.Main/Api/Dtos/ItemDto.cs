namespace Point.Client.Main.Api.Dtos
{
    public sealed class ItemDto
    {
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public string? Description { get; set; }
        public List<int>? Tags { get; set; }
    }
}
