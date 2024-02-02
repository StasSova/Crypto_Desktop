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
    public class VM_ProfileEl
    {
        private DelegateCommand? moveToProfilePage;
        private void MoveToProfilePage()
        {
            NavigationPageService.Instance.NavigateTo<VM_ProfilePage>();
        }
        private bool CanMoveToProfilePage()
        {
            return !NavigationPageService.Instance.IsCurrentPage<VM_ProfilePage>();
        }
        public ICommand MoveToProfilePageCommand
        {
            get
            {
                if (moveToProfilePage == null)
                    moveToProfilePage = new DelegateCommand(ex => MoveToProfilePage(), ce => CanMoveToProfilePage());
                return moveToProfilePage;
            }
        }
    }
}
