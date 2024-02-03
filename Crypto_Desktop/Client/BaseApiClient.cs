using Crypto_Desktop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Crypto_Desktop.Client
{
    public class BaseApiClient : IHttpClient
    {
        private readonly HttpClient _httpClient;
        public BaseApiClient() 
        {  
            _httpClient = new();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML,"+ " like Gecko) Chrome/112.0.0.0 Safari/537.36");
        }
        public BaseApiClient(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<T> GetAsync<T>(Uri resourceUri)
        {
            try
            {
                var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, resourceUri));
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();

                T var = JsonSerializer.Deserialize<T>(responseContent);
                return var;
            }
            catch (Exception e)
            {
                throw new HttpRequestException(e.Message);
            }
        }

    }
}
