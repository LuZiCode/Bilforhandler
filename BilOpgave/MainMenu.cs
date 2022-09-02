using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BilOpgave
{
    internal class MainMenu
    {
        Personbil personbil = new Personbil();
        Varevogn varevogn = new Varevogn();
        public MainMenu()
        {
            while (true)
            {
                Menu();
            }
        }
        private void Menu()
        {
            Console.WriteLine("Welcome to the Carealership Program\nPress (1) for vans\nPress (2) for passenger cars");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    varevogn.VarevognMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    break;
                default:
                    break;
            }
        }
    }
}
