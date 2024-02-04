using Crypto_Desktop.Base;
using Crypto_Desktop.Base.Enums;
using Crypto_Desktop.Client;
using Crypto_Desktop.Interfaces;
using Crypto_Desktop.MVVM.Coin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Crypto_Desktop.MVVM.Pages.ViewModel
{
    internal class VM_DetailCoin:VM_Base
    {
        public override async void Initialize(object parameter)
        {
            base.Initialize(parameter);
            string coinName = parameter.ToString();
            Client = VM_MainPage.Instance.Client;
            SelectedCurrency = VM_MainPage.Instance.SelectedCurrency;


            await FetchData(coinName);
        }
        public ICoinClient Client { get; set; }

        private VM_Coin coin;
        public VM_Coin Coin
        {
            get { return coin; }
            private set
            {
                coin = value;
                OnPropertyChanged(nameof(Coin));
            }
        }

        private Currency _selCurrency;
        public Currency SelectedCurrency
        {
            get { return _selCurrency; }
            set
            {
                _selCurrency = value;
                OnPropertyChanged(nameof(SelectedCurrency));
            }
        }

        private async Task<M_Coin> GetCoin(string coin)
        {
             return (await Client.GetCoinMarkets(
                vsCurrency: SelectedCurrency.ToString(),
                ids: new[] { coin },
                order: "market_cap_desc",
                perPage: 1,
                page: 0,
                sparkline: true,
                priceChangePercentage: "24h",
                category: "")).FirstOrDefault();
        }
        private async Task FetchData(string coinName)
        {
            try
            {
                await Application.Current.Dispatcher.BeginInvoke(async () =>
                {
                    M_Coin coin = await GetCoin(coinName);
                    Coin = new VM_Coin(coin);
                });
            }
            catch
            {

            }
        }
    }
}
