using Point.Client.Main.Api.Entities;

namespace Point.Client.Main.Api.Dtos.Response
{
    public sealed class SearchItemResponseDto : PaginationResponseDto
    {
        public List<Item> Data { get; set; }
    }
}
