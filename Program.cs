using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.UserSelect();


            Console.ReadKey();
        }
    }
}
