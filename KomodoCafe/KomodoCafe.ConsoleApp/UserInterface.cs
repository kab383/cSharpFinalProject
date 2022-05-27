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

                string input = _customConsole.CustomerInput();

                MainMenuSelectionSwitchCase(input);
            }
        }
        
        private void MainMenuSelectionSwitchCase(string input)
        {
            switch(input)
            {
                case "1":
                    ViewFullMenu();
                    break;
                case "2":
                    AddMeal();
                    break;
                case "3":
                    DeleteMeal();
                    break;
                default:
                    Console.WriteLine("Please select one of the options provided.");
                    break;
            }            
        }

        private void ViewFullMenu()
        {
            List<Menu> allMeals = _menuRepo.GetMenu();

            foreach (Menu meal in allMeals)
            {
                _customConsole.PrintMeal(meal);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void DeleteMeal()
        {
            Console.Write("Please enter the name of the meal to delete: ");
            string input = _customConsole.CustomerInput();

            bool successfulDeletion = _menuRepo.DeleteMealFromMenu(input);

            if (successfulDeletion)
            {
                Console.WriteLine("Meal successfully deleted from the menu. Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I'm sorry, that meal was not found on the menu. Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void AddMeal()
        {
            Console.WriteLine("Please complete the following fields to add a meal to the menu.");

            Console.Write("\nMeal Number (please include #): ");
            string number = _customConsole.CustomerInput();
            
            Console.Write("\nMeal Name: ");
            string name = _customConsole.CustomerInput();

            Console.Write("\nMeal Description: ");
            string description = _customConsole.CustomerInput();

            Console.WriteLine("\nMeal Ingredients (when finished adding ingredients, please type 'done' to the console): ");
            bool addIngredientsLoop = true;
            
            List<string> ingredients = new List<string>();

            while(addIngredientsLoop)
            {
                string inputIngredients = _customConsole.CustomerInput();
                ingredients.Add(inputIngredients);
                
                if(inputIngredients == "done")
                {
                    addIngredientsLoop = false;
                }
            }

            ingredients.Remove("done");
            
            string[] ingredientsArr = ingredients.ToArray();
            
            Console.Write("\nMeal Price: $");
            float price = _customConsole.CustomerInputAsFloat();

            Console.Write("\nCalories: ");
            int calories = _customConsole.CustomerInputAsInt();

            Menu newMeal = new Menu(number, name, description, ingredientsArr, price, calories);

            _menuRepo.AddMealToMenu(newMeal);

            Console.WriteLine($"\nYou have added {name} to the menu. Press any key to continue...");
            Console.ReadKey();
        }
    }
}