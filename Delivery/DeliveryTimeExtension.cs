using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Delivery
{
    internal static class DeliveryTimeExtension
    {
        public static void UserDeliveryTime(this DeliveryTime deliveryTime, double fromDeliveryTime, double toDeliveryTime)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Ваша доставка оидается приблизительно {now.Date.AddDays(fromDeliveryTime)} - {now.Date.AddDays(toDeliveryTime)}");
        }
    }
}
