﻿using Crypto_Desktop.MVVM.Pages.ViewModel;
using Crypto_Desktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Crypto_Desktop.MVVM.Pages.View
{
    /// <summary>
    /// Interaction logic for V_UC_CollectionCoins.xaml
    /// </summary>
    public partial class V_UC_CollectionCoins : UserControl
    {
        public V_UC_CollectionCoins()
        {
            this.DataContext = VM_MainPage.Instance;
            InitializeComponent();
        }

        private void Coin_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string CoinId = (string)((StackPanel)sender).Tag;
                NavigationPageService.Instance.NavigateTo<VM_DetailCoin>(CoinId);
            }
            catch { }
        }
    }
}
