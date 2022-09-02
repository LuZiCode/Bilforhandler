using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilOpgave
{
    internal class Varevogn
    {
        Methods method = new Methods();
        DataHandling data = new DataHandling();
        public void VarevognMenu()
        {
            Console.WriteLine("You are now about to modify/handle vans\nPress (1) for list of vans\nPress (2) to search for vans in the system\nPress (3) to add a new van in the system");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowVansList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    //SearchForVan()
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    CreateNewVan();
                    break;
                default:
                    break;
            }
        }
        private void CreateNewVan()
        {
            Van van = new Van();
            van.name = method.GetString("Name of the car: ");
            van.type = method.GetString("Type of the car: ");
            van.from0to100 = method.GetCar0to100();
            van.price = method.GetDecimal("Price of the car: ");
            van.age = method.GetCarAge($"{van.name}");

            Console.Clear();
            ShowVanAndAccessories(van, false);
            Console.WriteLine("\nComfirm adding car to the list (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.VanList.Add(van); Console.WriteLine($"\n{van.name} is now added to the list");

            Console.WriteLine("\nWould you like to add accessories to the van? (Y/N)");
            while (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                AddAccessories(van);
                Console.WriteLine("\nDo you wish to add another accessorie? (Y/N)");
            }
            
        }
        private void AddAccessories(Van van)
        {
            VanAccessories va = new();
            va.AccessorieName = method.GetString("Type in the accessorie name: ");
            va.AccessorieType = method.GetString($"Type in the accessorie type for {va.AccessorieName}: ");
            va.AccessorieCount = method.GetIntAccessorieCount();
            va.AccessoriePrice = method.GetAccessoriePrice($"Type in the price for {va.AccessorieName}: ", va);
            va.AccessorieAge = method.GetCarAge($"{va.AccessorieName}");

            Console.Clear();
            ShowAccessoriesInVan(va);
            Console.WriteLine($"Would you like to add this accessorie to {van.name} (Y/N): ");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) van.vanAccessories.Add(va);


        }
        private void ShowAccessoriesInVan(VanAccessories va)
        {
            //TODO create writeline to show accessories in van (count, name, price, etc.)
            if (va.AccessorieCount <= 1) Console.WriteLine($"\nAccessorie name: {va.AccessorieName}\nType of accessorie for {va.AccessorieName}: {va.AccessorieType}\nAmount of {va.AccessorieName}: {va.AccessorieCount}\nPrice for {va.AccessorieName}: {va.AccessoriePrice}\nAge of {va.AccessorieName}: {va.AccessorieAge}");
            else Console.WriteLine($"\nAccessorie name: {va.AccessorieName}\nType of accessorie for {va.AccessorieName}: {va.AccessorieType}\nAmount of {va.AccessorieName}: {va.AccessorieCount}\nPrice for all of {va.AccessorieName}: {va.AccessoriePrice}\nPrice for each {va.AccessorieName}: {va.AccessoriePrice / va.AccessorieCount}\nAge of {va.AccessorieName}: {va.AccessorieAge}");

        }
        private void ShowVanAndAccessories(Van van, bool ShowAccessories = false)
        {
            Console.WriteLine($"\nVan name: {van.name}\nVan type: {van.type}\nVan speed from 0-100km in seconds: {van.GetSpeed()}\nVan price: {van.price}\nVan age: {van.GetCarAge()}");
            if (ShowAccessories)
            {
                Console.WriteLine($"\n--Accessorie(s) for {van.name}--");
                foreach (VanAccessories va in van.vanAccessories)
                {
                    ShowAccessoriesInVan(va);
                }
            }
        }
        private void ShowVansList()
        {
            foreach (Van v in data.VanList)
            {
                ShowVanAndAccessories(v, true);
            }
        }
    }
}
