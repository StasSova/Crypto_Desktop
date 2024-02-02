using Crypto_Desktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Crypto_Desktop
{
    public class VM_Main
    {
        public string Response { get; set; }

        private DelegateCommand? _Generate;
        private async void Generate()
        {
            Response = await HttpClientAPI.Instance.GetResponse("assets");
        }
        private bool CanGenerate()
        {
            return true;
        }
        public ICommand GenerateCommand
        {
            get
            {
                if (_Generate == null)
                    _Generate = new DelegateCommand(ex => Generate(), ce => CanGenerate());
                return _Generate;
            }
        }
    }
}
