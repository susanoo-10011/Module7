﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal class HoneyCake : Cake
    {
        public static string Type
        {
            get { return "Медовый"; }
        }

        public HoneyCake(string name, int price, double calorie, int volume) : base(name, price, calorie, volume)
        {
        }
    }
}