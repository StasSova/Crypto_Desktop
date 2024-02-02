using Crypto_Desktop.MVVM.Coin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Desktop.Interfaces
{
    public interface ICoinClient
    {
        /// <summary>
        /// List all supported coins price, market cap, volume, and market related data (no pagination required)
        /// </summary>
        /// <param name="vsCurrency">The target currency of market data</param>
        /// <returns></returns>
        Task<List<M_Coin>> GetCoinMarkets(string vsCurrency);
        /// <summary>
        /// List all supported coins price, market cap, volume, and market related data (no pagination required)
        /// </summary>
        /// <param name="vsCurrency">The target currency of market data</param>
        /// <param name="ids">List of coin id to filter if you want specific results in comma-separated</param>
        /// <param name="category">filter by coin category, only decentralized_finance_defi is supported at the moment</param>
        /// <param name="order">Results ordered by</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <param name="sparkline">Include sparkline 7 days data default false</param>
        /// <param name="priceChangePercentage">Include price change percentage in 1h, 24h, 7d, 14d, 30d, 200d, 1y (eg. '1h,24h,7d' comma-separated, invalid values will be discarded)</param>
        /// <returns></returns>
        Task<List<M_Coin>> GetCoinMarkets(string vsCurrency, string[] ids, string order, int? perPage, int? page,
        bool sparkline, string priceChangePercentage, string category);
    }
}
