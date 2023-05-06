using Module7.Delivery.Base;
using Module7.Products;
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

            ProductListMenu productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();
            productListMenu.Menu();



            UserData();
            Console.ReadKey();
        }

        private void UserData()
        {
            Console.WriteLine("Для создания заказа нужно заполнить данные. \n");

            Console.WriteLine("Выберите товары, которые хотите заказать. Указывайте товары через пробел.");
            string userInputProducts = Console.ReadLine();
            string[] userProducts = userInputProducts.Split(' ');

            List<int> values = new List<int>();

            for (int i = 0; i < userProducts.Length; i++)
            {
                if (int.TryParse(userProducts[i], out int userProduct))
                {
                    values.Add(userProduct);
                }
                else
                {
                    Console.WriteLine($"Ошибка: \"{userProducts[i]}\" не является цифрой!");
                    return;
                }
            }

            Console.WriteLine("Вы заказали: ");
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine($"{i}-ый товар: {ProductListMenu.products[i].Name}");
            }

            Console.WriteLine("Выберите тип доставки. 1 - доставка на дом, 2 - доставка в пункт выдачи, 3 - доставка в розничный магазин");
            Console.Write("Тип доставки: ");
            var userDelivery = Console.ReadLine();
            Console.Write("\nВаш адресс для доставки: ");
            var userAdress = Console.ReadLine();
            Console.Write("\nВаш телефон: ");
            var userPhone = Console.ReadLine();
            Console.WriteLine();

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
    }
}
