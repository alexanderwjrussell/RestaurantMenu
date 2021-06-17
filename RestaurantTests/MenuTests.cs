using NUnit.Framework;
using Restaurant;

namespace RestaurantTests
{
    public class MenuTests
    {
        private const string ExpectedResult = @"
~* RESTAURANT NAME *~
MENU

Starters
dumplings, shrimp or scallops

Mains
beef, turkey or lobster

Desserts
trifle, ice cream or fire";

        [Test]
        public void Menu_Should_Return_Expected_Created_Menu()
        {
            var menu = new Menu();

            var result = menu.GetMenuCopy();
            
            Assert.That(result, Is.EqualTo(ExpectedResult));
        }
    }
}