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
using System.Windows.Input;
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
               
            }
        }

        private string _searchCoinName;
        public string SearchCoinName
        {
            get { return _searchCoinName; }
            set
            {
                _searchCoinName = value;
                OnPropertyChanged(nameof(SearchCoinName));
            }
        }

        private DelegateCommand? searchCoinCommand;
        private async Task SearchCoin()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SearchCoinName))
                {
                    await FetchData();
                }
                else
                {
                    await SearchByName(SearchCoinName);
                }
                SearchCoinName = string.Empty;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }
        private bool CanSearchCoin()
        {
            return true;
        }
        public ICommand SearchCoinCommand
        {
            get
            {
                if (searchCoinCommand == null)
                    searchCoinCommand = new DelegateCommand(ex => SearchCoin(), ce => CanSearchCoin());
                return searchCoinCommand;
            }
        }
        private async Task SearchByName(string SearchCoinName)
        {
            await Application.Current.Dispatcher.InvokeAsync(async() =>
            {
                try
                {
                    Coins.Clear();
                    List<M_Coin> coins = await GetCoins();
                    coins = coins.Where<M_Coin>(x =>
                            x.Name.Contains(SearchCoinName, StringComparison.OrdinalIgnoreCase) ||
                            x.Id.Contains(SearchCoinName, StringComparison.OrdinalIgnoreCase) ||
                            x.Symbol.Contains(SearchCoinName, StringComparison.OrdinalIgnoreCase)
                    ).ToList<M_Coin>();
                    if (coins.Count == 0)
                    {
                        throw new ArgumentException("No coins found for this pattern, try again");
                    }
                    foreach (var coin in coins)
                    {
                        Coins.Add(new VM_Coin(coin));
                    }
                }
                catch (ArgumentException ex)
                {
                    await FetchData();
                    MessageBox.Show(ex.Message, "Invalid input", MessageBoxButton.OK);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK); }
            });

        }
    }
}
