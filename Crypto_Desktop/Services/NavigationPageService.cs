using Crypto_Desktop.Base;
using Crypto_Desktop.MVVM.Header.View;
using Crypto_Desktop.MVVM.Header.ViewModel;
using Crypto_Desktop.MVVM.Pages.View;
using Crypto_Desktop.MVVM.Pages.ViewModel;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Crypto_Desktop.Services
{
    public class NavigationPageService
    {
        private readonly Dictionary<Type, Type> _mappings;
        private static NavigationPageService _instance;
        private NavigationPageService()
        {
            _mappings = new Dictionary<Type, Type>();
            CreatePageViewModelMappings();
        }
        public static NavigationPageService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NavigationPageService();

                return _instance;
            }
        }

        private Type CurrentViewModel;
        public void NavigateTo<TViewModel>() where TViewModel : VM_Base
        {
            InternalNavigateTo(typeof(TViewModel), null);
        }

        public void NavigateTo<TViewModel>(object parameter) where TViewModel : VM_Base
        {
            InternalNavigateTo(typeof(TViewModel), parameter);
        }

        protected virtual void InternalNavigateTo(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"Mapping type for {viewModelType} is not a page");
            }

            Page page = (Page)Activator.CreateInstance(pageType);
            if (page.DataContext is VM_Base viewModel)
            {
                viewModel.Initialize(parameter);
            }

            if (Application.Current.MainWindow != null && Application.Current.MainWindow.Content is Frame frame)
            {
                frame.Navigate(page);
            }

            CurrentViewModel = viewModelType;
        }

        protected Type GetPageTypeForViewModel(Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new KeyNotFoundException($"No map for ${viewModelType} was found on navigation mappings");
            }
            return _mappings[viewModelType];
        }

        private void CreatePageViewModelMappings()
        {
            // Add your ViewModel to View mappings here
            _mappings.Add(typeof(VM_MainPage), typeof(V_MainPage));

            //_mappings.Add(typeof(VM_Logo), typeof(V_Logo));
            //_mappings.Add(typeof(VM_LogoutEl), typeof(V_LogoutEl));
            //_mappings.Add(typeof(VM_ProfileEl), typeof(V_ProfileEl));
            
            _mappings.Add(typeof(VM_LogoutPage), typeof(V_LogoutPage));
            _mappings.Add(typeof(VM_ProfilePage), typeof(V_ProfilePage));

            // ... add other mappings
        }

        public bool IsCurrentPage<TViewModel>() where TViewModel : VM_Base
        {
            try
            {
                return typeof(TViewModel) == CurrentViewModel;
            }
            catch { return false; }
        }
    }
}
