
namespace Module7.Products
{
    internal class HoneyCake : Cake
    {
        public static string Type
        {
            get { return "Медовый"; }
        }

        public HoneyCake(string name, int price, int orderNumber) : base(name, price, orderNumber)
        {
        }
    }
}
