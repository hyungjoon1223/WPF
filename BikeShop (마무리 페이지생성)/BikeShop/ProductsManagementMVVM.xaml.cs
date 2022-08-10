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

namespace BikeShop
{
    /// <summary>
    /// ProductManagementMVVM.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductsManagementMVVM : Page
    {
        public ProductsManagementMVVM()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as ProductsManagementMVVMViewModel;
            vm.FoundProducts.Add(vm.AddProduct);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {  //추가 페이지 생성
            Page addPage = new AddPageView();
            NavigationService.Navigate(addPage);
        }
    }
}