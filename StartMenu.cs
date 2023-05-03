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
        protected bool FirstChoice;
        protected bool SecondChoice;

        
        virtual internal void UserSelect()
        {
            Console.WriteLine("Выберите нужное действие в панели инуструментов: ");
            Console.WriteLine("1 - сделать заказ.");
            Console.WriteLine("2 - посмотреть список продуктов. ");
            Console.Write("Ваш выбор: ");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                switch (userChoice)
                {
                    case 1:
                        FirstChoice = true;
                        SecondChoice = false;
                        break;
                    case 2:
                        ViewListProducts viewListProducts = new ViewListProducts();
                        viewListProducts.UserSelect();
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректное значение, повторите попытку!");
                        break;
                }
            }
        }


    }
}
