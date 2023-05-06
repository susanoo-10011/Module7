using Module7.Delivery.Base;
using System;

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
