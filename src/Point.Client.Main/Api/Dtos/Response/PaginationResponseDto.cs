namespace Point.Client.Main.Api.Dtos.Response
{
    public abstract class PaginationResponseDto
    {
        public int TotalCount { get; init; }
        public int Page { get; init; }
        public int PageSize { get; init; }
    }
}
