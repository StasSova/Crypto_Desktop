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
        public BaseApiClient() {  _httpClient = new(); }
        public BaseApiClient(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<T> GetAsync<T>(Uri resourceUri)
        {
            resourceUri = new Uri("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&ids=bitcoin&x-cg-demo-api-key=CG-swERyLU4zGgkvKSbTz6mSwym");
            //resourceUri = new Uri("https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&order=market_cap_desc&per_page=100&page=1&sparkline=false&locale=en");
            //resourceUri = new Uri("https://api.coingecko.com/v2/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=30&page=1&sparkline=true&price_change_percentage=24h");
            //resourceUri = new Uri("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false&locale=en&x_cg_demo_api_key=CG-swERyLU4zGgkvKSbTz6mSwym");
            var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, resourceUri))
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            try
            {
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
