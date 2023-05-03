﻿using Module7.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal class Apple<T> : Product<T>
    {
        public Apple(string name, T price, T calorie) : base (name, price, calorie)
        {

        }
    }
}
