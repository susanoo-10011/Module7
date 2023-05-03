using Module7.Products;
using Module7.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class ProductListMenu
    {
        public Product<int>[] products = new Product<int>[4];
        public void CreateListProducts()
        {

            products[0] = new Apple<int>("Яблоко", 55, 52);
            products[1] = new Banana<int>("Банан", 129, 96);
            products[2] = new Beef<int>("Говядина", 1500, 218);
            products[3] = new Buckwheat<int>("Гречка", 150, 330);
            products[4] = new Cake<int>("Торт", 3200, 500);
        }
    }
}
