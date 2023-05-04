using Module7.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal class Beef<T> : Product<T>
    {
        public Beef(string name, T price, T calorie, int number) : base(name, price, calorie, number)
        {

        }
    }
}
