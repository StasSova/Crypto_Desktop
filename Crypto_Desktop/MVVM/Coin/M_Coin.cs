using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crypto_Desktop.MVVM.Coin
{
    public class M_Coin
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public Uri Image { get; set; }

        [JsonPropertyName("current_price")]
        public decimal? CurrentPrice { get; set; }

        [JsonPropertyName("market_cap")]
        public decimal? MarketCap { get; set; }

        [JsonPropertyName("fully_diluted_valuation")]
        public double? FullyDilutedMarketCap { get; set; }

        [JsonPropertyName("total_volume")]
        public decimal? TotalVolume { get; set; }

        [JsonPropertyName("high_24h")]
        public decimal? High24H { get; set; }

        [JsonPropertyName("low_24h")]
        public decimal? Low24H { get; set; }

        [JsonPropertyName("ath")]
        public double? Ath { get; set; }

        [JsonPropertyName("ath_change_percentage")]
        public double? AthChangePercentage { get; set; }

        [JsonPropertyName("ath_date")]
        public DateTimeOffset? AthDate { get; set; }

        [JsonPropertyName("atl")]
        public double? Atl { get; set; }

        [JsonPropertyName("atl_change_percentage")]
        public double? AtlChangePercentage { get; set; }

        [JsonPropertyName("atl_date")]
        public DateTimeOffset? AtlDate { get; set; }

        [JsonPropertyName("roi")]
        public Roi Roi { get; set; }

        [JsonPropertyName("last_updated")]
        public DateTimeOffset? LastUpdated { get; set; }

        [JsonPropertyName("sparkline_in_7d")]
        public SparklineIn7D SparklineIn7D { get; set; }

        [JsonPropertyName("price_change_percentage_14d_in_currency")]
        public double? PriceChangePercentage14DInCurrency { get; set; }

        [JsonPropertyName("price_change_percentage_1h_in_currency")]
        public double? PriceChangePercentage1HInCurrency { get; set; }

        [JsonPropertyName("price_change_percentage_1y_in_currency")]
        public double? PriceChangePercentage1YInCurrency { get; set; }

        [JsonPropertyName("price_change_percentage_200d_in_currency")]
        public double? PriceChangePercentage200DInCurrency { get; set; }

        [JsonPropertyName("price_change_percentage_24h_in_currency")]
        public double? PriceChangePercentage24HInCurrency { get; set; }

        [JsonPropertyName("price_change_percentage_30d_in_currency")]
        public double? PriceChangePercentage30DInCurrency { get; set; }

        [JsonPropertyName("price_change_percentage_7d_in_currency")]
        public double? PriceChangePercentage7DInCurrency { get; set; }

        [JsonPropertyName("market_cap_rank")]
        public long? MarketCapRank { get; set; }

        [JsonPropertyName("price_change_24h")]
        public decimal? PriceChange24H { get; set; }

        [JsonPropertyName("price_change_7h")]
        public decimal? PriceChange7H { get; set; }

        [JsonPropertyName("price_change_percentage_24h")]
        public double? PriceChangePercentage24H { get; set; }

        [JsonPropertyName("price_change_percentage_7h")]
        public double? PriceChangePercentage7H { get; set; }

        [JsonPropertyName("market_cap_change_24h")]
        public double? MarketCapChange24H { get; set; }

        [JsonPropertyName("market_cap_change_percentage_24h")]
        public double? MarketCapChangePercentage24H { get; set; }

        [JsonPropertyName("circulating_supply")]
        public double? CirculatingSupply { get; set; }

        [JsonPropertyName("total_supply")]
        public double? TotalSupply { get; set; }
    }

}
