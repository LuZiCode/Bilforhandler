using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilOpgave
{
    internal class Methods
    {
        public string GetString(string type)
        {
            string? input;
            do
            {
                Console.Write($"\n{type}");
                input = Console.ReadLine();
            }
            while (input == null || input == "");
            return input;
        }
        public int GetDecimal(string request)
        {
            decimal i;
            do
            {
                Console.Write(request);
            }
            while (!Decimal.TryParse(Console.ReadLine(), out i));
            return (int)i;
        }
        public int GetIntAccessorieCount()
        {
            int input;
            do
            {
                Console.Write("\nInput the amount of accessories: ");
            } while (!int.TryParse(Console.ReadLine(), out input) || input <= 0);
            return input;
        }
        public decimal? GetAccessoriePrice(string input, VanAccessories va)
        {
            decimal i;
            do
            {
                Console.Write($"\n{input}");
            }
            while (!Decimal.TryParse(Console.ReadLine(), out i));
            if (va.AccessorieCount > 1) { var result = i * va.AccessorieCount; return result; }
            return i;
        }
        public DateTime GetCar0to100()
        {
            DateTime time;
            do
            {
                Console.Write("0-100km on how many seconds? (hh:mm:ss): ");
            }
            while (!DateTime.TryParse("0001-01-01 " + Console.ReadLine(), out time));
            return time;
        }
        public DateTime GetCarAge(string type)
        {
            DateTime date;
            do
            {
                Console.Write($"\nEnter the age of the {type} (dd/mm/yyyy): ");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out date));
            return date;
        }
    }
}
