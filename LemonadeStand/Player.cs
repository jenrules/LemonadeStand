using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Player()
        { }
        public string GetName(Recipe recipe, Weather weather, Game game, Money money, Store store, Inventory inventory, Customer customer)
        {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome {0}.", playerName);
            Rules rules = new Rules();
            rules.ShowRules(recipe, weather, game, money, store, inventory, customer);
            return playerName;
        }
    }
}
