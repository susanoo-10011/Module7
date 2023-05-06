using Module7.Delivery.Base;
using Module7.Products.Base;
using Module7.Window;
using System;

namespace Module7
{

    class Order<TDelivery> where TDelivery : DeliveryBase
    {
        public TDelivery Delivery;
        public Order(TDelivery delivery)
        {
            Delivery = delivery;
        }
        public void DisplayDeliveryTime()
        {
            Delivery.DeliveryTime();
        }
        public void DisplayOrderResults( string adress, string phone)
        {
            Delivery["Adress"] = adress;
            Delivery["Phone"] = phone;

            Console.WriteLine($"\nВы собираетесь сделать заказ на сумму {CalculateSumPrices().Price}." +
                $"\nАдрес доставки {adress}. \nВаш номер телефона {phone}");
        }

        private Product CalculateSumPrices()
        {
            ProductListMenu productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();

            Product product = new Product("", 0, 0);

            for(int i = 0; i < MakeOrder.values.Count; i++)
            {
                foreach(Product product1 in ProductListMenu.products)
                {
                    if (MakeOrder.values[i] == product1.OrderNumber)
                    {
                        product += product1;
                        break;
                    }
                }
            }
            return product;
        }
    }
}
