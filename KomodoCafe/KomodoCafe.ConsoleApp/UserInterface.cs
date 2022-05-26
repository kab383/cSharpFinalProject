using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.Repository;

namespace KomodoCafe.ConsoleApp
{
    public class UserInterface
    {
        private bool isRunning = true;

        MenuRepository _menuRepo = new MenuRepository();
        CustomConsole _customConsole = new CustomConsole();

        public void Run()
        {
            _menuRepo.SeedMenuData();

            while(isRunning)
            {
                _customConsole.PrintMainMenu();

                string orderNumber = _customConsole.CustomerInput();

                //customerOrderSwitchCase(orderNumber);
            }
        }


    }
}