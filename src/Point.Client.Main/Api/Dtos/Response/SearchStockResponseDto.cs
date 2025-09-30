namespace Point.Client.Main.Api.Dtos.Response
{
    public class SearchStockResponseDto : PaginationResponseDto
    {
        public List<StockResponseDto> Data { get; init; }
    }
}
