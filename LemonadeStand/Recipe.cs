using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public double price;
        public Recipe()
        {
        }

        public double SetPriceOfLemonade(Recipe recipe, Game game, Money money, Store store, Inventory inventory, Customer customer, Weather weather, Day day)
        {
            Console.WriteLine("You are allowed to charge to charge as much as you want for a cup of lemonade.");
            Console.WriteLine("The standard price is .25.");
            try
            {
                Console.WriteLine("How much you would like to charge for a cup of lemonade today?");
                price = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please try again");
                return SetPriceOfLemonade(recipe, game, money, store, inventory, customer, weather, day);
            }
            HowToMakeLemonade(game, money, inventory, store, customer, recipe, weather, day);
            return price;
        }
        public double lemons;
        public double sugarCubes;
        public double iceCubes;
        public void HowToMakeLemonade(Game game, Money money, Inventory inventory, Store store, Customer customer, Recipe recipe, Weather weather, Day day)
        {
            Console.WriteLine("The standard recipe is one lemon, one sugar cube, and four ice cubes to make a cup of lemonade.");
            Console.WriteLine("You are allowed to keep or change the recipe.");
            Console.WriteLine("Type 'keep' or 'change'?");
            string changeRecipe = Console.ReadLine();
            if (changeRecipe.ToLower() == "keep")
            {
                lemons = 1;
                iceCubes = 4;
                sugarCubes = 1;
                Console.WriteLine("Time to sell some lemonade!.");
                game.BuySupplies(money, inventory, store, customer, recipe, weather, game, day);
            }
            else if (changeRecipe.ToLower() == "change")
            {
                Console.WriteLine("How many lemons per cup would you like?");
                try
                {
                    double lemons = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a positive whole number, or zero");
                    Console.WriteLine("How many lemons per cup would you like?");
                    double lemons = Double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Okay.");
                Console.WriteLine("How many sugar cubes per cup would you like?");
                try
                {
                    double sugarCubes = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a positive whole number, or zero");
                    Console.WriteLine("How many sugar cubes per cup would you like?");
                    double sugarCubes = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Okay.");
                Console.WriteLine("How many ice cubes per cup would you like?");
                try
                {
                    double iceCubes = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a positive whole number, or zero");
                    Console.WriteLine("How many ice cubes per cup would you like?");
                    double iceCubes = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Okay.");
                Console.WriteLine("The new recipe is {0} lemons, {1} sugar cubes, and {2} ice cubes.", lemons, sugarCubes, iceCubes);
                game.BuySupplies(money, inventory, store, customer, recipe, weather, game, day);
            }
            else
            {
                Console.WriteLine("Error. Please write 'keep' or 'change'.");
                HowToMakeLemonade(game, money, inventory, store, customer, recipe, weather, day);
            }
        }  c
    }
}


