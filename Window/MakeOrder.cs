using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Window
{
    internal class MakeOrder : StartMenu
    {
        internal override void UserSelect()
        {
            Console.Clear();
            OrderDescription();
        }
        public void OrderDescription()
        {
            Console.WriteLine("Здесь вы можете сделать свой заказ.");
            Console.WriteLine("--------------");
            Console.WriteLine("Меню");

            var productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();
            productListMenu.Menu();
            Console.WriteLine("--------------");

            Back.BackStartMenu();
        }
    }
}
