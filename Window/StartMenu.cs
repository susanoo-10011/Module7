using Module7.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class StartMenu
    {
        virtual internal void UserSelect()
        {
            Console.WriteLine("Выберите нужное действие в панели инуструментов: ");
            Console.WriteLine("1 - сделать заказ.");
            Console.WriteLine("2 - посмотреть список продуктов. ");
            Console.Write("Ваш выбор: ");

            string userChoice = Console.ReadLine();

            while (true)
            {
                switch (userChoice)
                {
                    case "1":
                        MakeOrder makeOrder = new MakeOrder();
                        makeOrder.UserSelect();
                        break;
                    case "2":
                        ViewListProducts viewListProducts = new ViewListProducts();
                        viewListProducts.UserSelect();
                        break;
                    
                }
            }
        }


    }
}
