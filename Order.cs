﻿using Module7.Delivery.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{

    class Order<TDelivery> where TDelivery : DeliveryBase
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;
        public Order(TDelivery delivery)
        {
            Delivery = delivery;
        }

        public void DisplayDeliveryTime()
        {
            Delivery.DeliveryTime();
        }

        
    }

}
