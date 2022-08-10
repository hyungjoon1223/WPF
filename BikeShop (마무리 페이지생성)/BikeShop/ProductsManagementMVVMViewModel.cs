using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BikeShop
{
    class ProductsManagementMVVMViewModel : Notifier
    {
        private string searchInput;
        public string SearchInput
        {
            get { return searchInput; }
            set
            {
                searchInput = value;
                base.OnPropertyChanged("SearchInput");
                OnSearchInputChanged();
            }
        }

        private ObservableCollection<Product> foundProducts;
        public ObservableCollection<Product> FoundProducts
        {
            get { return foundProducts; }
            set
            {
                foundProducts = value;
                OnPropertyChanged("FoundProducts");
            }
        }

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        
        private Product addProduct;
        public Product AddProduct
        {
            get { return addProduct; }
            set
            {
                addProduct = value;
                OnPropertyChanged("AddProduct");
            }
        }

        ProductsFactory factory = new ProductsFactory();
        public ProductsManagementMVVMViewModel()
        {
            FoundProducts = factory.GetAllProducts();
            AddProduct = new Product() { Title = "영상을 위한 제품", Price = 200.12M, Color = "Orange", Reference = "참고" };

            Application.Current.Properties["products"] = FoundProducts;
        }

        private void OnSearchInputChanged()
        {
            SelectedProduct = null;
            FoundProducts = factory.FindProducts(SearchInput);
        }
    }
}
