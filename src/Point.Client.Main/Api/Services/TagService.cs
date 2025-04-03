using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class TagService : IApiService
    {
        private const string _endPoint = "tags";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreateTag(TagDto tagDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, tagDto);
        }

        public async Task UpdateTag(int id, TagDto tagDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, tagDto);
        }

        public async Task<List<Tag>?> GetTags()
        {
            return await _pointApiClient.ExecuteAsync<List<Tag>>(_endPoint, Method.Get);
        }
    }
}
