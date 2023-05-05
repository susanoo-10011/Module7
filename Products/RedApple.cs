using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal class RedApple : Apple
    {
        public static string Type 
        {
            get { return "Красный"; } 
        }
        public RedApple(string name, int price, double calorie, int volume) : base(name, price, calorie, volume) 
        {
        }
    }
}
