using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using RestSharp;

namespace Point.Client.Main.Api.Services
{
    public class CategoryService : IApiService
    {
        private const string _endPoint = "categories";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreateCategory(CategoryDto categoryDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, categoryDto);
        }

        public async Task UpdateCategory(int id, CategoryDto categoryDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, categoryDto);
        }

        public async Task<List<Category>?> GetCategories()
        {
            return await _pointApiClient.ExecuteAsync<List<Category>>(_endPoint, Method.Get);
        }
    }
}
