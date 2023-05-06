namespace Module7.Products
{
    internal class ChocolateCake : Cake
    {
        public static string Type
        {
            get { return "Шоколадный"; }
        }

        public ChocolateCake(string name, int price, int orderNumber) : base(name, price, orderNumber)
        {
        }
    }
}
