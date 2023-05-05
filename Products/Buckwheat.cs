using Module7.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal class Buckwheat : Product
    {
        public Buckwheat(string name, int price, double calorie, int volume) : base(name, price, calorie, volume)
        {

        }
    }
}
