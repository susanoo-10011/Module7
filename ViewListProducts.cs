using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class ViewListProducts : StartMenu
    {

        internal override void UserSelect()
        {
            Console.Clear();

            ProductListMenu productList = new ProductListMenu();

            Console.WriteLine("Здесь представлен список продуктов, которые вы можете заказать: ");
            Console.WriteLine($"1 - {productList.products[0].Name}. Цена на 1кг: {productList.products[0].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {productList.products[0].Calorie}");
            Console.WriteLine($"1 - {productList.products[1].Name}. Цена на 1кг: {productList.products[1].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {productList.products[1].Calorie}");
            Console.WriteLine($"1 - {productList.products[2].Name}. Цена на 1кг: {productList.products[2].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {productList.products[2].Calorie}");
            Console.WriteLine($"1 - {productList.products[3].Name}. Цена на 1кг: {productList.products[3].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {productList.products[3].Calorie}");
            Console.WriteLine($"1 - {productList.products[4].Name}. Цена на 1кг: {productList.products[4].Price} рублей. " +
                $"Калорийность данного продукта на 100г составляет: {productList.products[4].Calorie}");

        }



    }
}
