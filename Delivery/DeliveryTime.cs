using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Delivery
{
    internal class DeliveryTime
    {
        public void AddTime(double fromDeliveryTime, double ToDeliveryTime)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Ваша доставка оидается приблизительно {now.Date.AddDays(fromDeliveryTime)} - {now.Date.AddDays(ToDeliveryTime)}");
        }
    }
}
