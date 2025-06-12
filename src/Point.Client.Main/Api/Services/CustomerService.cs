using System.Drawing.Printing;
using Point.Client.Main.Api.Contracts;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using Point.Client.Main.Api.Entities;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Point.Client.Main.Api.Services
{
    public class CustomerService : IApiService
    {
        private const string _endPoint = "customers";
        private ApiClient _pointApiClient;

        public void SetClient(ApiClient pointApiClient)
        {
            _pointApiClient = pointApiClient;
        }

        public async Task<ResponseDto?> CreateCustomer(CustomerDto customerDto)
        {
            return await _pointApiClient.ExecuteAsync<ResponseDto>(_endPoint, Method.Post, customerDto);
        }

        public async Task UpdateCustomer(int id, CustomerDto customerDto)
        {
            await _pointApiClient.ExecuteAsync($"{_endPoint}/{id}", Method.Put, customerDto);
        }
        
        public async Task<List<Customer>?> GetCustomers()
        {
            return await _pointApiClient.ExecuteAsync<List<Customer>>(_endPoint, Method.Get);
        }

        public async Task<List<Customer>?> SearchCustomers(string name)
        {
            var endPoint = $"{_endPoint}/search?name={name}";
            return await _pointApiClient.ExecuteAsync<List<Customer>>(endPoint, Method.Get);
        }
    }
}
