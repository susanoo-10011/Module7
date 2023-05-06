using Module7.Products;
using Module7.Products.Base;
using System;

namespace Module7
{
    internal class ProductListMenu
    {
        public static Product[] products = new Product[6];
        public void CreateListProducts()
        {
            products[0] = new GreenApple("Зеленое яблоко", 55, 1);
            products[1] = new RedApple("Красное яблоко", 60, 2);
            products[2] = new ChocolateCake("Шоколадный торт", 3200, 3);
            products[3] = new HoneyCake("Медовый торт", 3500, 4);
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
