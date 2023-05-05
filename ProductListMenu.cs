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
        public static Product[] products = new Product[6];
        public void CreateListProducts()
        {
            products[0] = new GreenApple("Яблоко", 55, 50, 100);
            products[1] = new RedApple("Яблоко", 60, 62, 100);
            products[2] = new ChocolateCake("Торт", 3200, 600, 100);
            products[3] = new HoneyCake("Торт", 3500, 450, 100);
        }

        public void Menu()
        {
            Console.WriteLine("Меню");

            Console.WriteLine($"{products[0].Name}. Имеет два вида: 1 - {GreenApple.Type}, по цене {products[0].Price}" +
                $" и 2 - {RedApple.Type}, по цене {products[1].Price}. ");
            Console.WriteLine($"{products[2].Name}. Имеет два вида: 3 - {ChocolateCake.Type}, по цене {products[2].Price}" +
                $" и 4 - {HoneyCake.Type}, по цене {products[3].Price}. ");
        }
    }
}
