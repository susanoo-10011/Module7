using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Delivery
{
    internal class DeliveryTime
    {
        public void CalculateDeliveryTime(double fromDeliveryTime, double toDeliveryTime)
        {
            Console.WriteLine($"Доставка займет примерно от {fromDeliveryTime} дней, до {toDeliveryTime} дней.");
        }
    }
}
