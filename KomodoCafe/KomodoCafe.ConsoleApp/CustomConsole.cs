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

        public float CustomerInputAsFloat()
        {
            return float.Parse(Console.ReadLine());
        }

        public int CustomerInputAsInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public void PrintMeal(Menu meal)
        {
            Console.WriteLine($"\nMeal {meal.MealNumber}\n" +
                        $"{meal.MealName}\n" +
                        $"Description: {meal.MealDescription}");
            Console.Write("Ingredients: ");
            Print(meal.MealIngredients);
            Console.WriteLine($"\nPrice: ${meal.MealPrice}\n" +
                            $"Calories: {meal.Calories}");
        }

        public void Print(string[] mealingredients)
        {
            foreach(string ingredient in mealingredients)
            {
                Console.Write($"*{ingredient}* ");
            }
        }
    }
}