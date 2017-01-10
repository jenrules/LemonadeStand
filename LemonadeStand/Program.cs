using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Recipe recipe = new Recipe();
            Weather weather = new Weather();
            Money money = new Money();
            Store store = new Store();
            Inventory inventory = new Inventory();
            Customer customer = new Customer();
            game.PlayGame(recipe, weather, game, money, store, inventory, customer);
        }
    }
}
