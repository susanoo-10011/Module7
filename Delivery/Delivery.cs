using Module7.Delivery;
using Module7.Delivery.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    
    class HomeDelivery : DeliveryBase
    {
        public void HomeDeliveryTime()
        {
            double fromDeliveruTime = 3.0;
            double ToDeliveruTime = 5.0;
            DeliveryTime deliveryTime = new DeliveryTime();
            deliveryTime.AddTime(fromDeliveruTime, ToDeliveruTime);
        }
    }

    class PickPointDelivery : DeliveryBase
    {
        public void PickPointDeliveryTime()
        {
            double fromDeliveruTime = 1.0;
            double toDeliveruTime = 2.0;
            DeliveryTime deliveryTime = new DeliveryTime();
            deliveryTime.AddTime(fromDeliveruTime, toDeliveruTime);

        }
    }

    class ShopDelivery : DeliveryBase
    {
        public void ShopDeliveryTime()
        {
            double fromDeliveruTime = 2.0;
            double toDeliveruTime = 3.0;
            DeliveryTime deliveryTime = new DeliveryTime();
            deliveryTime.AddTime(fromDeliveruTime, toDeliveruTime);
        }
    }
}
