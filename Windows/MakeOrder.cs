using System;
using System.Collections.Generic;

namespace Module7.Window
{
    internal class MakeOrder : StartMenu
    {

        internal override void UserSelect()
        {
            Console.Clear();

            ProductListMenu productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();
            productListMenu.Menu();

            UserData();
            Console.ReadKey();
        }

        private void UserData()
        {
            UserSelectProducts();

            Console.WriteLine("Выберите тип доставки. 1 - доставка на дом, 2 - доставка в пункт выдачи, 3 - доставка в розничный магазин");
            Console.Write("Тип доставки: ");
            var userDelivery = Console.ReadLine();
            Console.Write("\nВаш адресс для доставки: ");
            var userAdress = Console.ReadLine();
            Console.Write("\nВаш телефон: ");
            var userPhone = Console.ReadLine();
            Console.WriteLine();

            DetermineTypeDelivery(userDelivery, userAdress, userPhone);
        }

        private void DetermineTypeDelivery(string userDelivery, string userAdress, string userPhone)
        {
            if (userDelivery == "1")
            {
                Order<HomeDelivery> order = new Order<HomeDelivery>(new HomeDelivery());
                order.DisplayDeliveryTime();
                order.DisplayOrderResults(userAdress, userPhone);
            }
            else if (userDelivery == "2")
            {
                Order<PickPointDelivery> order = new Order<PickPointDelivery>(new PickPointDelivery());
                order.DisplayDeliveryTime();
                order.DisplayOrderResults(userAdress, userPhone);
            }
            else if (userDelivery == "3")
            {
                Order<ShopDelivery> order = new Order<ShopDelivery>(new ShopDelivery());
                order.DisplayDeliveryTime();
                order.DisplayOrderResults(userAdress, userPhone);
            }
        }

        public static List<int> values = new List<int>();

        private void UserSelectProducts()
        {
            Console.WriteLine("\nДля создания заказа нужно заполнить данные.");

            do
            {
                Console.WriteLine("\nВыберите товары, которые хотите заказать. Указывайте товары через пробел.");
                string userInputProducts = Console.ReadLine();
                string[] userProducts = userInputProducts.Split(' ');

                values.Clear();

                foreach (string Product in userProducts)
                {
                    if (int.TryParse(Product, out int Products))
                    {
                        values.Add(Products);
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка: \"{Product}\" не является цифрой. Повторите ввод.");
                        values.Clear();
                        break;
                    }
                }
            } while (values.Count == 0);

            ShowOrderProducts(values);
        }

        private void ShowOrderProducts(List<int> values)
        {

            Console.WriteLine("Вы заказали: ");
            for (int j = 0; j < values.Count; j++)
            {
                if (values[j] == 1)
                {
                    Console.WriteLine($"{j + 1}-ый товар: {ProductListMenu.products[0].Name}");
                }
                else if (values[j] == 2)
                {
                    Console.WriteLine($"{j + 1}-ый товар: {ProductListMenu.products[1].Name}");
                }
                else if (values[j] == 3)
                {
                    Console.WriteLine($"{j + 1}-ый товар: {ProductListMenu.products[2].Name}");
                }
                else if (values[j] == 4)
                {
                    Console.WriteLine($"{j + 1}-ый товар: {ProductListMenu.products[3].Name}");
                }
            }
        }
    }
}
