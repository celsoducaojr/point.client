using Point.Client.Main.Api.Entities;

namespace Point.Client.Main.Api.Dtos
{
    public class SearchItemCriteriaDto
    {
        public string? Name { get; init; }
        public Category? Category { get; init; }
        public List<Tag>? Tags { get; init; }
    }
}
