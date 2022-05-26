using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.Repository;

namespace KomodoCafe.ConsoleApp
{
    public class CustomConsole
    {
        MenuRepository _menuRepo = new MenuRepository();
        public void PrintMainMenu()
        {
            Console.WriteLine("1. See menu items\n" +
                                "2. Add a meal to the menu\n" +
                                "3. Delete a meal from the menu\n");
        }

        public string CustomerInput()
        {
            return Console.ReadLine();
        }

        private void CustomerOrderSwitchCase(string orderNumber)
        {
            switch(orderNumber)
            {
                case "1":
                    PrintMainMenu();
                    break;
                case "2":
                    _menuRepo.AddMealToMenu();
                    break;
                case "3":
                    _menuRepo.DeleteMealFromMenu();
                    break;
                default:
                    Console.WriteLine("Please select one of the options provided.");
                    break;
            }            
        }

    }
}