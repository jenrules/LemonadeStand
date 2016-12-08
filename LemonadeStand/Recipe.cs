using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public string price;        
        public void SetPriceOfLemonade()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are allowed to create your own lemonade recipe, and to charge as much as you want.");
            Console.WriteLine("The standard price for a cup of lemonade is .25.");
            Console.WriteLine("Do you want to keep '.25' or 'change' the price?");
            price = Console.ReadLine();
            if (price.ToLower() == ".25")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Your price is .25 per cup of lemonade.");
            }
            else if (price.ToLower() == "change")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("What would you like to change the price to?");
                price = Console.ReadLine();
                Console.WriteLine("Okay. Your price is {0}.", price);
            }
            else
            {
                Console.WriteLine("Error. Please write 'keep' or 'change'.");
                SetPriceOfLemonade();
            }
        }
        public void HowToMakeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("Each pitcher of lemonade holds 10 cups of lemonade.");
            Console.WriteLine("The recommended recipe for a pitcher is 4 lemons, 4 cups of sugar, and 4 ice cubes.");
            Console.WriteLine("Do you want to 'keep' or 'change' the recipe?");
            string recipe = Console.ReadLine();
            if (recipe.ToLower() == "keep")
            {
                Console.WriteLine("Time to sell some lemonade!.");
            }
            else if (recipe.ToLower() == "change")
            {
                Console.WriteLine("How many lemons per pitcher would you like?");
                string lemons = Console.ReadLine();
                Console.WriteLine("Okay.");
                Console.WriteLine("How many cups of sugar per pitcher would you like?");
                string cupsOfSugar = Console.ReadLine();
                Console.WriteLine("Okay.");
                Console.WriteLine("How many ice cubes per pitcher would you like?");
                string iceCubes = Console.ReadLine();
                Console.WriteLine("Okay.");
                Console.WriteLine("The new recipe is {0} lemons, {1} cups of sugar, and {2} ice cubes.", lemons, cupsOfSugar, iceCubes);
            }
            else
            {
                Console.WriteLine("Error. Please write 'keep' or 'change'.");
                HowToMakeLemonade();
            }
        }
    }
}


