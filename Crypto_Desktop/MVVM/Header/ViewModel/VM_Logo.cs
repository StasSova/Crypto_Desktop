using Crypto_Desktop.Base;
using Crypto_Desktop.MVVM.Pages.ViewModel;
using Crypto_Desktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Crypto_Desktop.MVVM.Header.ViewModel
{
    public class VM_Logo:VM_Base
    {
        private DelegateCommand? moveToMainPage;
        private void MoveToMainPage()
        {
            NavigationPageService.Instance.NavigateTo<VM_MainPage>();
        }
        private bool CanMoveToMainPage()
        {
            return !NavigationPageService.Instance.IsCurrentPage<VM_MainPage>();
        }
        public ICommand MoveToMainPageCommand
        {
            get
            {
                if (moveToMainPage == null)
                    moveToMainPage = new DelegateCommand(ex => MoveToMainPage(), ce => CanMoveToMainPage());
                return moveToMainPage;
            }
        }
    }
}
