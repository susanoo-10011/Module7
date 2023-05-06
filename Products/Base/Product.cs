using System;

namespace Module7.Products.Base
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int OrderNumber { get; set; }

        public Product(string name, int price, int orderNumber) 
        {
            Name = name;
            Price = price;
            OrderNumber = orderNumber;
        }

        public static Product operator +(Product productOne, Product productTwo)
        {
            string name = null;
            var orderNumber = 0;
            var price = productOne.Price + productTwo.Price;
            var product = new Product(name, price, orderNumber);
            return product;
        }
    }
}
