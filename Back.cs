﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Back
    {
        public static void BackStartMenu()
        {
            string back = Console.ReadLine();

            if (back == "1")
            {
                Console.Clear();
                StartMenu startMenu = new StartMenu();
                startMenu.UserSelect();
            }
        }
    }
}
