using Module7.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal class Buckwheat<T> : Product<T>
    {
        public Buckwheat(string name, T price, T calorie, int number) : base(name, price, calorie, number)
        {

        }
    }
}
