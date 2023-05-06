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


            Console.WriteLine("Для создания заказа нужно заполнить данные. \n");

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


            }
            else if(userDelivery == "2")
            {
                Order<PickPointDelivery> order = new Order<PickPointDelivery>(new PickPointDelivery());
                order.DisplayDeliveryTime();
            }
            else if( userDelivery == "3")
            {
                Order<ShopDelivery> order = new Order<ShopDelivery>(new ShopDelivery());
                order.DisplayDeliveryTime();
            }



        }
    }
}
