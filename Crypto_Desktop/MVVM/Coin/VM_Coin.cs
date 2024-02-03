using Crypto_Desktop.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Desktop.MVVM.Coin
{
    public class VM_Coin:VM_Base
    {
        private M_Coin _coin;
        public VM_Coin(M_Coin coin)
        {
            _coin = coin;
        }
        public string Id
        {
            get { return  _coin.Id; }
            set
            {
                _coin.Id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Symbol
        {
            get { return _coin.Symbol; }
            set
            {
                _coin.Symbol = value;
                OnPropertyChanged(nameof(Symbol));
            }
        }
        public string Name
        {
            get { return _coin.Name; }
            set
            {
                _coin.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public Uri Image
        {
            get { return _coin.Image; }
            set
            {
                _coin.Image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public decimal? CurrentPrice
        {
            get { return _coin.CurrentPrice; }
            set
            {
                _coin.CurrentPrice = value;
                OnPropertyChanged(nameof(CurrentPrice));
            }
        }
        public decimal? MarketCap
        {
            get { return _coin.MarketCap; }
            set
            {
                _coin.MarketCap = value;
                OnPropertyChanged(nameof(MarketCap));
            }
        }
        public long? MarketCapRank
        {
            get { return _coin.MarketCapRank; }
            set
            {
                _coin.MarketCapRank = value;
                OnPropertyChanged(nameof(MarketCapRank));
            }
        }
        public double? FullyDilutedValuation
        {
            get { return _coin.FullyDilutedMarketCap; }
            set
            {
                _coin.FullyDilutedMarketCap = value;
                OnPropertyChanged(nameof(FullyDilutedValuation));
            }
        }
        public decimal? TotalVolume
        {
            get { return _coin.TotalVolume; }
            set
            {
                _coin.TotalVolume = value;
                OnPropertyChanged(nameof(TotalVolume));
            }
        }
        public double? High24H
        {
            get { return _coin.High24H; }
            set
            {
                _coin.High24H = value;
                OnPropertyChanged(nameof(High24H));
            }
        }
        public double? Low24H
        {
            get { return _coin.Low24H; }
            set
            {
                _coin.Low24H = value;
                OnPropertyChanged(nameof(Low24H));
            }
        }
        public double? PriceChange24H
        {
            get { return _coin.PriceChange24H; }
            set
            {
                _coin.PriceChange24H = value;
                OnPropertyChanged(nameof(PriceChange24H));
            }
        }
        public double? PriceChangePercentage24H
        {
            get { return _coin.PriceChangePercentage24H; }
            set
            {
                _coin.PriceChangePercentage24H = value;
                OnPropertyChanged(nameof(PriceChangePercentage24H));
            }
        }
        public double? MarketCapChange24H
        {
            get { return _coin.MarketCapChange24H; }
            set
            {
                _coin.MarketCapChange24H = value;
                OnPropertyChanged(nameof(MarketCapChange24H));
            }
        }
        public double? MarketCapChangePercentage24H
        {
            get { return _coin.MarketCapChangePercentage24H; }
            set
            {
                _coin.MarketCapChangePercentage24H = value;
                OnPropertyChanged(nameof(MarketCapChangePercentage24H));
            }
        }
        public double? CirculatingSupply
        {
            get { return _coin.CirculatingSupply; }
            set
            {
                _coin.CirculatingSupply = value;
                OnPropertyChanged(nameof(CirculatingSupply));
            }
        }
        public double? TotalSupply
        {
            get { return _coin.TotalSupply; }
            set
            {
                _coin.TotalSupply = value;
                OnPropertyChanged(nameof(TotalSupply));
            }
        }
        public double? Ath
        {
            get { return _coin.Ath; }
            set
            {
                _coin.Ath = value;
                OnPropertyChanged(nameof(Ath));
            }
        }
        public double? AthChangePercentage
        {
            get { return _coin.AthChangePercentage; }
            set
            {
                _coin.AthChangePercentage = value;
                OnPropertyChanged(nameof(AthChangePercentage));
            }
        }
        public DateTimeOffset? AthDate
        {
            get { return _coin.AthDate; }
            set
            {
                _coin.AthDate = value;
                OnPropertyChanged(nameof(AthDate));
            }
        }
        public double? Atl
        {
            get { return _coin.Atl; }
            set
            {
                _coin.Atl = value;
                OnPropertyChanged(nameof(Atl));
            }
        }
        public double? AtlChangePercentage
        {
            get { return _coin.AtlChangePercentage; }
            set
            {
                _coin.AtlChangePercentage = value;
                OnPropertyChanged(nameof(AtlChangePercentage));
            }
        }
        public DateTimeOffset? AtlDate
        {
            get { return _coin.AtlDate; }
            set
            {
                _coin.AtlDate = value;
                OnPropertyChanged(nameof(AtlDate));
            }
        }
        public Roi? Roi
        {
            get { return _coin.Roi; }
            set
            {
                _coin.Roi = value;
                OnPropertyChanged(nameof(Roi));
            }
        }
        public DateTimeOffset? LastUpdated
        {
            get { return _coin.LastUpdated; }
            set
            {
                _coin.LastUpdated = value;
                OnPropertyChanged(nameof(LastUpdated));
            }
        }
    }
}
