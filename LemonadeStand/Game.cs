using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Game()
        {
        }
        public void PlayGame(Recipe recipe, Weather weather, Game game, Money money, Store store, Inventory inventory, Customer customer)
        {
            Console.WriteLine("Welcome to the game Lemonade Stand.");
            Console.WriteLine("Would you like to try to play?");
            Console.WriteLine("Write 'yes' or 'no'.");
            string playGame = Console.ReadLine().ToLower();
            switch (playGame)
            {
                case "yes":
                    Console.WriteLine("Excellent! Let's play!");
                    Player player = new Player();
                    player.GetName(recipe, weather, game, money, store, inventory, customer);
                    break;
                case "no":
                    Console.WriteLine("Too bad. Maybe next time.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("What's that??");
                    PlayGame(recipe, weather, game, money, store, inventory, customer);
                    break;
            }
        }
        public void RunGame(Recipe recipe, Weather weather, Game game, Money money, Store store, Inventory inventory, Customer customer)
        {
            for (int i = 0; i < 1; i++)
            {
                Day day = new Day();
                day.ChooseDays(recipe, weather, game, money, store, inventory, customer, day);
            }
            ChooseRestart(recipe, weather, game, money, store, inventory, customer);
        }
        public void BuySupplies(Money money, Inventory inventory, Store store, Customer customer, Recipe recipe, Weather weather, Game game, Day day)
        {
            Console.WriteLine("You have {0} dollars.", money.moneyLeft);
            Console.WriteLine("You currently have {0} lemons, {1} ice cubes, {2} sugar.", inventory.amountOfLemons, inventory.amountOfIceCubes, inventory.amountOfSugarCubes);
            Console.WriteLine("Would you like to buy more supplies for your lemonade stand? 'Yes' or 'No.'");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "yes")
            {
                Console.WriteLine("Time to go to the store!");
                store.BuyLemons(money, inventory, customer, recipe, weather, game, store, day);
            }
            else if (userInput.ToLower() == "no")
            {
                Console.WriteLine("Time to sell some lemonade!");
                customer.PotentialCustomers(inventory, money, recipe, weather, customer, game, store, day);
            }
            else
            {
                Console.WriteLine("Error. Please enter 'yes' or 'no'.");
                BuySupplies(money, inventory, store, customer, recipe, weather, game, day);
            }
        }
        public double profit;
        public double ShowProfit(Money money)
        {

            profit = Math.Round(money.moneyLeft - 20);
            if (profit < 0.00)
            {
                Console.WriteLine("Current Total Profit : -{0}.", profit);
            }
            else if (profit > 0.00)
            {
                Console.WriteLine("Current Total Profit : {0}.", profit);

            }
            return Math.Round(profit);
        }
        public void ChooseRestart(Recipe recipe, Weather weather, Game game, Money money, Store store, Inventory inventory, Customer customer)
        {
            Console.WriteLine("The week is over.  Your final profit is : {0}.", profit);
            Console.WriteLine("Would you like to play another game? Type 'yes' or 'no'.");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                RunGame(recipe, weather, game, money, store, inventory, customer);
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Have a nice day");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Error. Please write 'yes' or 'no'.");
                ChooseRestart(recipe, weather, game, money, store, inventory, customer);
            }
        }
    }
}
