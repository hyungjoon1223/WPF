using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BikeShop
{
    /// <summary>
    /// AddPageView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddPageView : Page
    {
        public AddPageView()
        {
            InitializeComponent();
            DataContext = new AddProductViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = Application.Current.Properties["products"] as ObservableCollection<Product>;
            var vm = DataContext as AddProductViewModel;
            list.Add(vm.AddProduct);
        }
    }
}
