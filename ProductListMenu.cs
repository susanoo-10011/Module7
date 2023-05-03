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
        public static Product<int>[] products = new Product<int>[5];
        public void CreateListProducts()
        {
            products[0] = new Apple<int>("Яблоко", 55, 52);
            products[1] = new Banana<int>("Банан", 129, 96);
            products[2] = new Beef<int>("Говядина", 1500, 218);
            products[3] = new Buckwheat<int>("Гречка", 150, 330);
            products[4] = new Cake<int>("Торт", 3200, 500);
        }

        public void Menu()
        {
            Console.WriteLine("Здесь представлен список продуктов, которые вы можете заказать: ");
            Console.WriteLine($"1 - {products[0].Name}. Цена на 1кг: {products[0].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {products[0].Calorie}");
            Console.WriteLine($"2 - {products[1].Name}. Цена на 1кг: {products[1].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {products[1].Calorie}");
            Console.WriteLine($"3 - {products[2].Name}. Цена на 1кг: {products[2].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {products[2].Calorie}");
            Console.WriteLine($"4 - {products[3].Name}. Цена на 1кг: {products[3].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {products[3].Calorie}");
            Console.WriteLine($"5 - {products[4].Name}. Цена на 1кг: {products[4].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {products[4].Calorie}");
        }
    }
}
