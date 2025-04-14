namespace Point.Client.Main.Api.Dtos.Response
{
    public abstract class PaginationResponseDto
    {
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
