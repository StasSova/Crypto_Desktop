using Crypto_Desktop.Base;
using Crypto_Desktop.Base.Enums;
using Crypto_Desktop.Client;
using Crypto_Desktop.Interfaces;
using Crypto_Desktop.MVVM.Coin;
using Crypto_Desktop.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Crypto_Desktop.MVVM.Pages.ViewModel
{
    public class VM_MainPage:VM_Base
    {
        private static VM_MainPage _instance;
        public static VM_MainPage Instance
        {
            get
            {
                if (_instance == null)  _instance = new VM_MainPage();
                return _instance;
            }
        }
        public VM_MainPage() 
        {
            Client = new CoinsClient();
            SelectedCurrency = Currency.usd;
            Task.Run(async () =>
            {
                await FetchData();
            });
        }
        private ObservableCollection<VM_Coin> _coins = new();
        public ObservableCollection<VM_Coin> Coins
        {
            get { return _coins; }
            set
            {
                _coins = value;
                OnPropertyChanged(nameof(Coins));
            }
        }
        public ICoinClient Client { get; set; }

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
        private async Task<List<M_Coin>> GetCoins(int size = 100, int page = 1)
        {
            return await Client.GetCoinMarkets(
                vsCurrency: SelectedCurrency.ToString(),
                ids: Array.Empty<string>(),
                order: "market_cap_desc",
                perPage: size,
                page: page,
                sparkline: true,
                priceChangePercentage: "24h",
                category: "");
        }
        private async Task FetchData()
        {
            try
            {
                await Application.Current.Dispatcher.BeginInvoke(async () =>
                {
                    Coins.Clear();
                    List<M_Coin> coins = await GetCoins();
                    foreach (var coin in coins)
                    {
                        Coins.Add(new VM_Coin(coin));
                    }
                });
            }
            catch
            {
                // Обработка ошибок
            }
        }
    }
}
