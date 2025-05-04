using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using Point.Client.Main.Api.Entities;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class PriceTypeService : IApiService
    {
        private const string _endPoint = "price-types";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreatePriceType(PriceTypeDto priceTypeDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, priceTypeDto);
        }

        public async Task UpdatePriceType(int id, PriceTypeDto priceTypeDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, priceTypeDto);
        }

        public async Task UpdatePriceTypeDisplayIndexes(Dictionary<int, int> priceTypeIndexes)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/indexes", Method.Put, priceTypeIndexes);
        }

        public async Task<List<PriceType>?> GetPricesTypes()
        {
            return await _pointApiClient.ExecuteAsync<List<PriceType>>(_endPoint, Method.Get);
        }
    }
}
