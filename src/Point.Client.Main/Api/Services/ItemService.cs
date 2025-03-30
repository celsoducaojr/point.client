using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
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

        public async Task<List<Item>?> SearchItems()
        {
            var endPoint = $"{_endPoint}/search?fields=category&fields=description&fields=tags";
            return await _pointApiClient.ExecuteAsync<List<Item>>(endPoint, Method.Get);
        }
    }
}
