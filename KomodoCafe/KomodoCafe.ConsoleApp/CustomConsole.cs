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
                                "3. Delete a meal from the menu");
        }

        public string CustomerInput()
        {
            return Console.ReadLine();
        }

        public void PrintMeal(Menu meal)
        {
            Console.WriteLine($"\nMeal {meal.MealNumber}\n" +
                        $"{meal.MealName}\n" +
                        $"Description: {meal.MealDescription}\n" +
                        $"Ingredients: {meal.MealIngredients}\n" +
                        $"Price: ${meal.MealPrice}\n" +
                        $"Calories: {meal.Calories}");
        }
    }
}