using Module7.Products;
using Module7.Products.Base;
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

            ProductListMenu productListMenu = new ProductListMenu();
            productListMenu.CreateListProducts();



        }
    }
}
