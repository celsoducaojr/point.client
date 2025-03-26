using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class UnitService : IApiService
    {
        private const string _endPoint = "units";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreateUnit(UnitDto unitDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, unitDto);
        }

        public async Task UpdateUnit(int id, UnitDto unitDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, unitDto);
        }

        public async Task<List<Unit>?> GetUnits()
        {
            return await _pointApiClient.ExecuteAsync<List<Unit>>(_endPoint, Method.Get);
        }
    }
}
