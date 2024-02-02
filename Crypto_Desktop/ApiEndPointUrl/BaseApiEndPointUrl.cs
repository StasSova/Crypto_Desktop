using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Desktop.ApiEndPointUrl
{
    public static class BaseApiEndPointUrl
    {
        public static readonly Uri ApiEndPoint = new("https://api.coingecko.com/api/v3/");
        public static string AddCoinsIdUrl(string id) => "coins/" + id;
    }
    public static class CoinsApiEndPoints
    {
        public static readonly string Coins = "coins";
        public static readonly string CoinList = "coins/list";
        public static readonly string CoinMarkets = "coins/markets";
        public static string AllDataByCoinId(string id) => BaseApiEndPointUrl.AddCoinsIdUrl(id);
        public static string TickerByCoinId(string id) => BaseApiEndPointUrl.AddCoinsIdUrl(id) + "/tickers";
        public static string HistoryByCoinId(string id) => BaseApiEndPointUrl.AddCoinsIdUrl(id) + "/history";
        public static string MarketChartByCoinId(string id) => BaseApiEndPointUrl.AddCoinsIdUrl(id) + "/market_chart";
        public static string MarketChartRangeByCoinId(string id) => BaseApiEndPointUrl.AddCoinsIdUrl(id) + "/market_chart/range";
    }
}
