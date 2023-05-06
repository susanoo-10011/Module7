namespace Module7.Products
{
    internal class GreenApple : Apple
    {
        public static string Type
        {
            get { return "Зеленый"; }
        }

        public GreenApple(string name, int price, int orderNumber) : base(name, price, orderNumber)
        {
        }

    }
}
