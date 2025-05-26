using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class ItemUnitService : IApiService
    {
        private const string _endPoint = "item-units";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreateItemUnit(ItemUnitDto itemDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, itemDto);
        }

        public async Task UpdateItemUnit(int id, ItemUnitDto itemDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, itemDto);
        }

        public async Task PatchItemUnits(List<ItemUnitPatchDto> itemUnits)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}", Method.Patch, new { data = itemUnits });
        }
    }
}
