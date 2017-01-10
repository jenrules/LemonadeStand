using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Rules
    {
        Game game = new Game();
        public void ShowRules(Recipe recipe, Weather weather, Game game, Money money, Store store, Inventory inventory, Customer customer)
        {
            Console.WriteLine("Do you know the rules?");
            string rules = Console.ReadLine();
            if (rules.ToLower() == "no")
            {
                Console.WriteLine("You are going to start a Lemonade Stand and try to make a profit.");
                Console.WriteLine("See how the decisions that you make affect your business.");
                Console.WriteLine("Each day, you will be shown the weather forecast, and you will be given the option to go to the store to buy ");
                Console.WriteLine("your ingredients.");
                Console.WriteLine("Be sure to pay attention to the weather forecast, so that you know how much to buy and what to set the price at.");
                Console.WriteLine("Try to maximize your profits while your stand is open.");
                Console.WriteLine("You have a loan of $20.00 to start up your business.");
                Console.WriteLine("Then, you will need to use your profits to keep your business going.");
                game.RunGame(recipe, weather, game, money, store, inventory, customer);
            }
            else if (rules.ToLower() == "yes")
            {
                Console.WriteLine("Great to have you play again!");
                game.RunGame(recipe, weather, game, money, store, inventory, customer);
            }
            else
            {
                Console.WriteLine("Error. Please write 'yes' or 'no'.");
                ShowRules(recipe, weather, game, money, store, inventory, customer);
            }
        }
    }
}
