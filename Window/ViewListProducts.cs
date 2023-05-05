﻿using Module7.Products.Base;
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

            var productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();
            productListMenu.Menu();

            Console.WriteLine();
            SumTwoProducts();

            Back.BackStartMenu();
        }

        private void SumTwoProducts()
        {
            Console.WriteLine("Вы можете посчитать сумму покупки двух товаров. Введите номера продуктов. ");
            Console.Write("Первый товар: ");
            int userFirstProduct = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второй товар: ");
            int userSecondProduct = Convert.ToInt32(Console.ReadLine());

            Product[] products = new Product[6];

            for (int i = 0; i < ProductListMenu.products.Length; i++)
                if (userFirstProduct == i)
                    products[0] = ProductListMenu.products[i];

            for (int i = 0; i < ProductListMenu.products.Length; i++)
                if (userSecondProduct == i)
                    products[1] = ProductListMenu.products[i];

            var SumPrice = products[0] + products[1];

            Console.WriteLine($"Сумма товаров {SumPrice.Price}");
            Console.Write("Нажмите 1, чтобы вернутся в главное меню: ");
        }
    }
}
