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

        
        // SEED MOVIE DATA
        // public void SeedMenuData()
        // {
            
        // }
    }
}