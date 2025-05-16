using Point.Client.Main.Api.Contracts;
using System;

namespace Point.Client.Main.Api
{
    public static class ServiceFactory
    {
        private static ApiClient _apiClient;
        public static void ConfigureServices(string baseUrl)
        {
            _apiClient = new ApiClient(baseUrl);
        }

        private static readonly Dictionary<Type, IApiService> _services = new();
        public static T GetService<T>() where T : IApiService, new()
        {
            if (!_services.TryGetValue(typeof(T), out var service))
            {
                service = new T();
                service.SetClient(_apiClient);
                _services[typeof(T)] = service;
            }
            return (T)service;
        }

    }
}
