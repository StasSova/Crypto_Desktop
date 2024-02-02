using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Crypto_Desktop.Services
{
    public class HttpClientAPI
    {
        private static HttpClientAPI _instance;
        public static HttpClientAPI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HttpClientAPI();
                return _instance;
            }
        }
        private HttpClientAPI() 
        {
            _url = "api.coincap.io/v2/";
        }
        private string _url;
        public async Task<string> GetResponse(string request)
        {
            //try
            //{
            //    if (string.IsNullOrWhiteSpace(request))
            //    {
            //        throw new ArgumentException("Request string is null or white space", nameof(request));
            //    }

            //    using (var client = new HttpClient())
            //    {
            //        var fullrequest = new HttpRequestMessage(HttpMethod.Get, "https://api.coincap.io/v2/assets");
            //        var response = await client.SendAsync(fullrequest);
            //        response.EnsureSuccessStatusCode();
            //        return await response.Content.ReadAsStringAsync();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Log or handle the exception appropriately
            //    //Console.WriteLine($"An error occurred: {ex.Message}");
            //    return null;
            //}
            var client = new HttpClient();
            var request2 = new HttpRequestMessage(HttpMethod.Get, "https://api.coingecko.com/api/v3/asset_platforms");
            var response = await client.SendAsync(request2);
            response.EnsureSuccessStatusCode();
            string test = await response.Content.ReadAsStringAsync();
            return test;
        }
    }
}
