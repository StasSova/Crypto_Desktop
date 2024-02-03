using Crypto_Desktop.MVVM.Pages.ViewModel;
using Crypto_Desktop.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Crypto_Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Crypto_Desktop.MainWindow window = new Crypto_Desktop.MainWindow();
            MainWindow = window;

            // Start page
            NavigationPageService.Instance.NavigateTo<VM_MainPage>();

            MainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {

            base.OnExit(e);
        }
    }
}
