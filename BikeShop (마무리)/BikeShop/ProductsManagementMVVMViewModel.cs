using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private IEnumerable<Product> foundProducts;
        public IEnumerable<Product> FoundProducts
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

        ProductsFactory factory = new ProductsFactory();
        public ProductsManagementMVVMViewModel()
        {
            FoundProducts = factory.GetAllProducts(); 
        }

        private void OnSearchInputChanged()
        {
            SelectedProduct = null;
            FoundProducts = factory.FindProducts(SearchInput);
        }
    }
}
