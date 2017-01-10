using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public double amountOfLemons;
        public double amountOfSugarCubes;
        public double amountOfIceCubes;
        public Inventory()
        {
        }
        public void ShowInventory()
        {
            Console.WriteLine("Inventory: You have {0} Lemons, {1} sugar cubes, {2} ice cubes", amountOfLemons, amountOfSugarCubes, amountOfIceCubes);

        }
        public bool enoughInventory;
        public bool CheckInventory(Recipe recipe, Game game, Store store, Money money, Inventory inventory, Customer customer, Weather weather, Day day)
        {
            if (amountOfLemons >= recipe.lemons && amountOfIceCubes >= recipe.iceCubes && amountOfSugarCubes >= recipe.sugarCubes)
                enoughInventory = true;
            else
            {
                enoughInventory = false;
                Console.WriteLine("You ran out of product before you could serve all your customers!! Buy more and try again tomorrow!!");
                day.ChooseDays(recipe, weather, game, money, store, inventory, customer, day);
            }

            return enoughInventory;
        }
        public void SubtractInventory(Recipe recipe)
        {
            amountOfLemons = amountOfLemons - recipe.lemons;
            amountOfIceCubes = amountOfIceCubes - recipe.iceCubes;
            amountOfSugarCubes = amountOfSugarCubes - recipe.sugarCubes;
        }
    }
}
