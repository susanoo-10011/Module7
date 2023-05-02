using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Food.Base
{
    public class Product<T>
    {
        public string Name { get; }
        public T Price { get; set; }
        public T Calorie { get; set; }
        public T Mass { get; set; }

        public Product(string name, T price, T calorie, T mass) 
        {
            Name = name;
            Price = price;
            Calorie = calorie;
            Mass = mass;

        }

    }
}
