using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products.Base
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public double Calorie { get; set; }
        public int Volume { get; set; }

        


        public Product(string name, int price, double calorie, int volume) 
        {
            Name = name;
            Price = price;
            Calorie = calorie;
            Volume = volume;
        }

        public static Product operator +(Product productOne, Product productTwo)
        {
            var calories = Math.Round((productOne.Calorie + productTwo.Calorie) / 2.0);
            var name = productOne.Name;
            var volume = productOne.Volume + productTwo.Volume;
            var price = productOne.Price + productTwo.Price;
            var product = new Product(name, price, calories, volume);
            return product;
        }
    }
}
