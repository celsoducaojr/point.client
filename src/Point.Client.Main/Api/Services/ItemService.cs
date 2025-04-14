using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using Point.Client.Main.Api.Entities;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class ItemService : IApiService
    {
        private const string _endPoint = "items";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreateItem(ItemDto itemDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, itemDto);
        }

        public async Task UpdateItem(int id, ItemDto itemDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, itemDto);
        }

        public async Task<SearchItemResponseDto?> SearchItems(int page, int pageSize, string? name = null, int? categoryId = null)
        {
            var endPoint = $"{_endPoint}/search?page={page}&pageSize={pageSize}&fields=category&fields=description&fields=tags";
            if (!string.IsNullOrEmpty(name)) endPoint += $"&name={name}";
            if (categoryId.HasValue) endPoint += $"categoryId={categoryId}";
            return await _pointApiClient.ExecuteAsync<SearchItemResponseDto>(endPoint, Method.Get);
        }
    }
}
