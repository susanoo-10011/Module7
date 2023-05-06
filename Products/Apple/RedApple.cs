namespace Module7.Products
{
    internal class RedApple : Apple
    {
        public static string Type 
        {
            get { return "Красный"; } 
        }
        public RedApple(string name, int price, int orderNumber) : base(name, price, orderNumber) 
        {
        }
    }
}
