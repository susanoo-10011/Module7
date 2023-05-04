using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class ViewListProducts : StartMenu
    {
        internal override void UserSelect()
        {
            Console.Clear();

            var productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();
            productListMenu.Menu();

            Console.WriteLine("Нажмите 1, чтобы вернутся в главное меню");

            Back.BackStartMenu();
        }
    }
}
