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
        public string Image
        {
            get { return _coin.Image; }
            set
            {
                _coin.Image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public double CurrentPrice
        {
            get { return _coin.CurrentPrice; }
            set
            {
                _coin.CurrentPrice = value;
                OnPropertyChanged(nameof(CurrentPrice));
            }
        }
        public long MarketCap
        {
            get { return _coin.MarketCap; }
            set
            {
                _coin.MarketCap = value;
                OnPropertyChanged(nameof(MarketCap));
            }
        }
        public int MarketCapRank
        {
            get { return _coin.MarketCapRank; }
            set
            {
                _coin.MarketCapRank = value;
                OnPropertyChanged(nameof(MarketCapRank));
            }
        }
        public double FullyDilutedValuation
        {
            get { return _coin.FullyDilutedValuation; }
            set
            {
                _coin.FullyDilutedValuation = value;
                OnPropertyChanged(nameof(FullyDilutedValuation));
            }
        }
        public double TotalVolume
        {
            get { return _coin.TotalVolume; }
            set
            {
                _coin.TotalVolume = value;
                OnPropertyChanged(nameof(TotalVolume));
            }
        }
        public double High24h
        {
            get { return _coin.High24h; }
            set
            {
                _coin.High24h = value;
                OnPropertyChanged(nameof(High24h));
            }
        }
        public double Low24h
        {
            get { return _coin.Low24h; }
            set
            {
                _coin.Low24h = value;
                OnPropertyChanged(nameof(Low24h));
            }
        }
        public double PriceChange24h
        {
            get { return _coin.PriceChange24h; }
            set
            {
                _coin.PriceChange24h = value;
                OnPropertyChanged(nameof(PriceChange24h));
            }
        }
        public double PriceChangePercentage24h
        {
            get { return _coin.PriceChangePercentage24h; }
            set
            {
                _coin.PriceChangePercentage24h = value;
                OnPropertyChanged(nameof(PriceChangePercentage24h));
            }
        }
        public long MarketCapChange24h
        {
            get { return _coin.MarketCapChange24h; }
            set
            {
                _coin.MarketCapChange24h = value;
                OnPropertyChanged(nameof(MarketCapChange24h));
            }
        }
        public double MarketCapChangePercentage24h
        {
            get { return _coin.MarketCapChangePercentage24h; }
            set
            {
                _coin.MarketCapChangePercentage24h = value;
                OnPropertyChanged(nameof(MarketCapChangePercentage24h));
            }
        }
        public double CirculatingSupply
        {
            get { return _coin.CirculatingSupply; }
            set
            {
                _coin.CirculatingSupply = value;
                OnPropertyChanged(nameof(CirculatingSupply));
            }
        }
        public double TotalSupply
        {
            get { return _coin.TotalSupply; }
            set
            {
                _coin.TotalSupply = value;
                OnPropertyChanged(nameof(TotalSupply));
            }
        }
        public double MaxSupply
        {
            get { return _coin.MaxSupply; }
            set
            {
                _coin.MaxSupply = value;
                OnPropertyChanged(nameof(MaxSupply));
            }
        }
        public double Ath
        {
            get { return _coin.Ath; }
            set
            {
                _coin.Ath = value;
                OnPropertyChanged(nameof(Ath));
            }
        }
        public double AthChangePercentage
        {
            get { return _coin.AthChangePercentage; }
            set
            {
                _coin.AthChangePercentage = value;
                OnPropertyChanged(nameof(AthChangePercentage));
            }
        }
        public DateTime AthDate
        {
            get { return _coin.AthDate; }
            set
            {
                _coin.AthDate = value;
                OnPropertyChanged(nameof(AthDate));
            }
        }
        public double Atl
        {
            get { return _coin.Atl; }
            set
            {
                _coin.Atl = value;
                OnPropertyChanged(nameof(Atl));
            }
        }
        public double AtlChangePercentage
        {
            get { return _coin.AtlChangePercentage; }
            set
            {
                _coin.AtlChangePercentage = value;
                OnPropertyChanged(nameof(AtlChangePercentage));
            }
        }
        public DateTime AtlDate
        {
            get { return _coin.AtlDate; }
            set
            {
                _coin.AtlDate = value;
                OnPropertyChanged(nameof(AtlDate));
            }
        }
        public double? Roi
        {
            get { return _coin.Roi; }
            set
            {
                _coin.Roi = value;
                OnPropertyChanged(nameof(Roi));
            }
        }
        public DateTime LastUpdated
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
