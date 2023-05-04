using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products.Base
{
    public class Product<T>
    {
        public string Name { get; set; }
        public T Price { get; set; }
        public T Calorie { get; set; }
        public int Number { get; set; }


        public Product(string name, T price, T calorie, int number ) 
        {
            Name = name;
            Price = price;
            Calorie = calorie;
            Number = number;
        }

    }
}
