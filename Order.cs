using Module7.Delivery.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine($"Вы собираетесь сделать заказ на сумму .\nВ ваш заказ входит: ." +
                $"\nАдрес доставки {adress}. \nВаш номер телефона {phone}");
        }

        
    }

}
