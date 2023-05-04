using Module7.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Window
{
    internal class MakeOrder : StartMenu
    {
        internal override void UserSelect()
        {
            Console.Clear();
            OrderDescription();
        }
        private void OrderDescription()
        {
            Console.WriteLine("Здесь вы можете сделать свой заказ. Следуйте инструкции.");
            Console.WriteLine("--------------");
            Console.WriteLine("Меню");

            var productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();
            productListMenu.Menu();
            Console.WriteLine("--------------");

            Console.WriteLine("1 - вернутся в главное меню.");
            Console.WriteLine("2 - выбрать продукты для заказа.");
            Console.WriteLine();

            var userInput = Console.ReadLine();
            if (userInput == "1")
                Back.BackStartMenu();
            else if (userInput == "2")
            {
                SelectProduct();
                ChooseDelivery();
                Console.ReadLine();
            }
        }

        private void SelectProduct()
        {
            ProductListMenu productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();

            string[] userOrder = new string[0];

            while (true)
            {
                Console.Write("Введите номер продукта, который вы хотите заказать, если хотите завершить заказы, напишите 'Завершить': ");
                string userInput = Console.ReadLine();

                if (userInput == "Завершить") break;

                Array.Resize(ref userOrder, userOrder.Length + 1);
                userOrder[userOrder.Length - 1] = userInput;

                for (int i = 0; i < ProductListMenu.products.Length; i++)
                {
                    if (ProductListMenu.products[i].Number == Convert.ToInt32(userInput))
                    {
                        userOrder[i] = ProductListMenu.products[i].Name;
                        Console.WriteLine("Вы заказали: ");
                        foreach (string word in userOrder)
                            Console.WriteLine(word + " ");
                        break;
                    }
                }

            }
            Console.WriteLine();

        }

        private void ChooseDelivery()
        {
            Console.WriteLine("Выберите тип доставки: 1 - доставка на дом, 2 - доставка в пункт выдачи, 3 - доставка в розничный магазин");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                   HomeDelivery homeDelivery = new HomeDelivery();
                    homeDelivery.HomeDeliveryTime();
                    break;
                case "2":
                    PickPointDelivery pickPointDelivery = new PickPointDelivery();
                    pickPointDelivery.PickPointDeliveryTime();
                    break;
                case "3":
                    ShopDelivery shopDelivery = new ShopDelivery();
                    shopDelivery.ShopDeliveryTime();
                    break;
            }
        }
    }
}
