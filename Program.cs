using System;

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
