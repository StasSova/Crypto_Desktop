using Crypto_Desktop.ApiEndPointUrl;
using Crypto_Desktop.Interfaces;
using Crypto_Desktop.MVVM.Coin;
using Crypto_Desktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Desktop.Client
{
    public class CoinsClient : BaseApiClient, ICoinClient
    {
        public CoinsClient(HttpClient httpClient) : base(httpClient){ }
        public CoinsClient():base() { }
        public async Task<List<M_Coin>> GetCoinMarkets(string vsCurrency)
        {
            try
            {
                return await GetCoinMarkets(vsCurrency, new string[] { }, null, null, null, false, null, null);
            }
            catch { }
            return null;
        }

        public async Task<List<M_Coin>> GetCoinMarkets(string vsCurrency, string[] ids, string order, int? perPage, int? page, bool sparkline, string priceChangePercentage, string category = null)
        {
            return await GetAsync<List<M_Coin>>(QueryStringService.AppendQueryString(CoinsApiEndPoints.CoinMarkets,
            new Dictionary<string, object>
            {
                {"vs_currency", vsCurrency},
                {"ids", string.Join(",", ids)},
                {"order",order},
                {"per_page", perPage},
                {"page", page},
                {"sparkline", sparkline},
                {"price_change_percentage", priceChangePercentage},
                {"category",category}
            }));
        }
    }
}
