using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal class ChocolateCake : Cake
    {
        public static string Type
        {
            get { return "Шоколадный"; }
        }

        public ChocolateCake(string name, int price, double calorie, int volume) : base(name, price, calorie, volume)
        {
        }
    }
}
