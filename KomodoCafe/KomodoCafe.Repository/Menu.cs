using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.Repository
{
    public class Menu
    {
        public string MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string[] MealIngredients { get; set; }
        public float MealPrice { get; set; }
        public int Calories { get; set; }

        public Menu(string mealNumber, string mealName, string mealDescription, string[] mealIngredients, float mealPrice, int calories)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
            Calories = calories;
        }

    }
}