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
    public class VM_LogoutEl: VM_Base
    {
        private DelegateCommand? moveToLogoutPage;
        private void MoveToLogoutPage()
        {
            NavigationPageService.Instance.NavigateTo<VM_LogoutPage>();
        }
        private bool CanMoveToLogoutPage()
        {
            return !NavigationPageService.Instance.IsCurrentPage<VM_LogoutPage>();
        }
        public ICommand MoveToLogoutPageCommand
        {
            get
            {
                if (moveToLogoutPage == null)
                    moveToLogoutPage = new DelegateCommand(ex => MoveToLogoutPage(), ce => CanMoveToLogoutPage());
                return moveToLogoutPage;
            }
        }
    }
}
