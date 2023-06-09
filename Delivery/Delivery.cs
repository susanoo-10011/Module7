﻿using Module7.Delivery;
using Module7.Delivery.Base;

namespace Module7
{
    class HomeDelivery : DeliveryBase
    {
        public override void DeliveryTime()
        {
            double fromDeliveruTime = 3.0;
            double toDeliveruTime = 5.0;
            DeliveryTime deliveryTime = new DeliveryTime();
            deliveryTime.CalculateDeliveryTime(fromDeliveruTime, toDeliveruTime);
            deliveryTime.UserDeliveryTime(fromDeliveruTime, toDeliveruTime);
        }
    }

    class PickPointDelivery : DeliveryBase
    {
        public override void DeliveryTime()
        {
            double fromDeliveruTime = 1.0;
            double toDeliveruTime = 2.0;
            DeliveryTime deliveryTime = new DeliveryTime();
            deliveryTime.CalculateDeliveryTime(fromDeliveruTime, toDeliveruTime);
            deliveryTime.UserDeliveryTime(fromDeliveruTime, toDeliveruTime);
        }
    }

    class ShopDelivery : DeliveryBase
    {
        public override void DeliveryTime()
        {
            double fromDeliveruTime = 2.0;
            double toDeliveruTime = 3.0;
            DeliveryTime deliveryTime = new DeliveryTime();
            deliveryTime.CalculateDeliveryTime(fromDeliveruTime, toDeliveruTime);
            deliveryTime.UserDeliveryTime(fromDeliveruTime, toDeliveruTime);
        }
    }
}
