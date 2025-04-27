using Point.Client.Main.Api.Entities;

namespace Point.Client.Main.Api.Dtos
{
    public class SearchItemDto
    {
        public string? Name { get; set; }
        public Category? Category { get; set; }
        public List<Tag>? Tags { get; set; }
    }
}
