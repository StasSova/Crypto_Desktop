using Crypto_Desktop.MVVM.Pages.ViewModel;
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

namespace Crypto_Desktop.MVVM.Coin
{
    /// <summary>
    /// Interaction logic for V_CoinPreview.xaml
    /// </summary>
    public partial class V_CoinPreview : UserControl
    {
        public V_CoinPreview()
        {
            InitializeComponent();
            this.CollectionView.DataContext = VM_MainPage.Instance;
        }
        private void CollectionView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            try
            {
                int Mult = 2;
                double newWidth = e.NewSize.Width;
                double X = newWidth / (this.gridView.Columns.Count + Mult-1);
                this.gridView.Columns[0].Width = Mult*X;
                for (int i = 1; i < this.gridView.Columns.Count; ++i)
                {
                    this.gridView.Columns[i].Width = X;
                }
            }
            catch { }
        }
    }
}
