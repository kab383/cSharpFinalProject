using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.Repository
{
    public class MenuRepository
    {
        
        private List<Menu> _menu = new List<Menu>();
        
        // CRUD

        // CREATE - customize a meal - stretch goal
        public void AddMealToMenu(Menu meal)
        {
            _menu.Add(meal);
        }


        // READ
        public List<Menu> GetMenu()
        {
            return _menu;
        }
        // NO UPDATE NECESSARY FOR THIS PROJECT


        // DELETE
        public void RemoveMealFromMenu(Menu meal)
        {
            
        }
        
        // SEED MOVIE DATA
        public void SeedMenuData()
        {
            string[] burgerIngredients = {"ground beef patty", "tomatoes", "lettuce", "pickles", "onions", "mayonnaise", "ketchup", "bun"};

            Menu burger = new Menu("#1", "Burger", "1/4lb savory flame-grilled beef", burgerIngredients, 5.99f, 667);

            string[] chickenSandwichIngredients = {"breaded chicken", "lettuce", "pickles", "mayonnaise", "bun"};

            Menu chickenSandwich = new Menu("#2", "Chicken Sandwich", "Lightly breaded white meat chicken", chickenSandwichIngredients, 6.99f, 684);

            string[] fishSandwichIngredients = {"breaded fish", "tartar sauce", "pickles", "brioche bun"};

            Menu fishSandwich = new Menu("#3", "Fish Sandwich", "Premium 100% breaded Alaskan Pollock on a toasted bun", fishSandwichIngredients, 4.99f, 560);

            string[] pizzaSliceIngredients = {"pepperoni", "sausage", "bell pepper", "olive", "onion", "garlic crust"};

            Menu pizzaSlice = new Menu("#4", "Supreme Pizza", "Melty, cheesy supreme pizza with all of your favorite toppings on one slice", pizzaSliceIngredients, 1.99f, 305);

            string[] hotDogIngredients = {"beef frank", "ketchup", "mustard", "relish", "hot dog bun"};

            Menu hotDog = new Menu("#5", "Hot Dog", "Classic 100% beef frank just like you'd get at the ball park", hotDogIngredients, 0.99f, 151);

            Menu[] menuArr = {burger, chickenSandwich, fishSandwich, pizzaSlice, hotDog};

            foreach (Menu meal in menuArr)
            {
                AddMealToMenu(meal);
            }

        }
    }
}