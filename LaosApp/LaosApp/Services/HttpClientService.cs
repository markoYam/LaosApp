using LaosApp.Interfaces;
using System.Text;
using System.Text.Json;

namespace MauiAppTest.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly IConnectionString _connectionString;
        public HttpClientService(IConnectionString connectionString)
        {
            _connectionString = connectionString;
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
            _httpClient = new HttpClient();
        }
        public async Task<T?> PostAsync<T>(string url, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_connectionString.BaseUrl}{url}", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
        }

        public async Task<T?> GetAsync<T>(string url)
        {
            var response = await _httpClient.GetAsync($"{_connectionString.BaseUrl}{url}");
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
        }

        public async Task<T?> PutAsync<T>(string url, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{_connectionString.BaseUrl}{url}", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
        }

        public async Task<T?> DeleteAsync<T>(string url)
        {
            var response = await _httpClient.DeleteAsync($"{_connectionString.BaseUrl}{url}");
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
        }
    }
}
