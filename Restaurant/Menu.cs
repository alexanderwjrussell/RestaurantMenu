using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Menu
    {
        private readonly Dictionary<string, string[]> _foodCategories = new()
        {
            {"starters", new []{"dumplings", "shrimp", "scallops", "leg", "monkey"}},
            {"mains", new []{"beef", "turkey", "lobster", "leg", "monkey"}},
            {"desserts", new []{"trifle", "ice cream", "fire", "leg", "monkey"}} };

        private readonly List<string> _chefDishes = new(new[] 
        {
            "dumplings", "shrimp", "scallops", "beef", "turkey",
            "lobster", "trifle", "ice cream", "fire"
        });

        public string GetMenuCopy()
        {
            var starters = GetDishes("starters");
            var mains = GetDishes("mains");
            var desserts = GetDishes("desserts");

            var menuCopy = CreateMenuCopy(starters, mains, desserts);

            return menuCopy;
        }

        private string CreateMenuCopy(List<string> starters, List<string> mains, List<string> desserts)
        {
            var headingCopy = GetHeading();
            var starterCopy = $"\nStarters\n{starters[0]}, {starters[1]} or {starters[2]}\n";
            var mainsCopy = $"\nMains\n{mains[0]}, {mains[1]} or {mains[2]}\n";
            var dessertsCopy = $"\nDesserts\n{desserts[0]}, {desserts[1]} or {desserts[2]}";

            return headingCopy + starterCopy + mainsCopy + dessertsCopy;
        }

        private List<string> GetDishes(string typeOfDish)
        {
            var dishes = _foodCategories[typeOfDish];

            return _chefDishes.Where(food => dishes.Contains(food)).ToList(); 
        }

        private static string GetHeading()
        {
            return $"\n~* RESTAURANT NAME *~\nMENU\n";
        }
    }
}