using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    internal class AddProductViewModel : Notifier
    {
        public Product AddProduct { get; set; }
        public AddProductViewModel()
        {
            AddProduct = new Product() { Title = "영상을 위한 제품", Price = 200.12M, Color = "Orange", Reference = "참고" };
        }

    }
}
