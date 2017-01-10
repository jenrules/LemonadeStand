using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double numberOfLemons;
        public double lemonPrice = .20;
        public Store()
        {
        }
        public double BuyLemons(Money money, Inventory inventory, Customer customer, Recipe recipe, Weather weather, Game game, Store store, Day day)
        {
            Console.WriteLine("You currently have {0} lemons.", inventory.amountOfLemons);
            Console.WriteLine("Lemons costs .20 per lemon.");
            Console.WriteLine("How many lemons would you like to buy?");
            try
            {
                numberOfLemons = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number, or zero");
                return BuyLemons(money, inventory, customer, recipe, weather, game, store, day);
            }
            if (money.moneyLeft - (numberOfLemons * .20) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyLemons(money, inventory, customer, recipe, weather, game, store, day);
            }
            else
            {
                inventory.amountOfLemons = inventory.amountOfLemons + numberOfLemons;
                money.moneyLeft = money.moneyLeft - (numberOfLemons * .20);
                Console.WriteLine("You have purchased {0} lemons.", numberOfLemons);
                money.ShowMoney(customer, inventory, money, recipe);
            }
            BuyIceCubes(money, inventory, customer, recipe, weather, game, store, day);
            return money.moneyLeft;
        }
        public double numberOfIceCubes;
        public double iceCubePrice = .01;
        public double BuyIceCubes(Money money, Inventory inventory, Customer customer, Recipe recipe, Weather weather, Game game, Store store, Day day)
        {
            Console.WriteLine("You currently have {0} ice cubes.", inventory.amountOfIceCubes);
            Console.WriteLine("Lemons costs .01 per ice cube.");
            Console.WriteLine("How many ice cubes would you like to buy?");
            try
            {
                numberOfIceCubes = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuyIceCubes(money, inventory, customer, recipe, weather, game, store, day);
            }
            if (money.moneyLeft - (numberOfIceCubes * .01) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyIceCubes(money, inventory, customer, recipe, weather, game, store, day);
            }
            else
            {
                inventory.amountOfIceCubes = inventory.amountOfIceCubes + numberOfIceCubes;
                money.moneyLeft = money.moneyLeft - (numberOfIceCubes * .01);
                Console.WriteLine("You have purchased {0} ice cubes", numberOfIceCubes);
                money.ShowMoney(customer, inventory, money, recipe);
            }
            BuySugarCubes(money, inventory, customer, recipe, weather, game, store, day);
            return money.moneyLeft;
        }
        public double numberOfSugarCubes;
        public double sugarCubePrice = .40;
        public double BuySugarCubes(Money money, Inventory inventory, Customer customer, Recipe recipe, Weather weather, Game game, Store store, Day day)
        {
            Console.WriteLine("You currently have {0} sugar cubes.", inventory.amountOfSugarCubes);
            Console.WriteLine("Sugar cubes costs .40 per sugar cube.");
            Console.WriteLine("How many sugar cubes would you like to buy?");
            try
            {
                numberOfSugarCubes = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuySugarCubes(money, inventory, customer, recipe, weather, game, store, day);
            }
            if (money.moneyLeft - (numberOfSugarCubes * .40) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuySugarCubes(money, inventory, customer, recipe, weather, game, store, day);
            }
            else
            {
                inventory.amountOfSugarCubes = inventory.amountOfSugarCubes + numberOfSugarCubes;
                money.moneyLeft = money.moneyLeft - (numberOfSugarCubes * .1);
                Console.WriteLine("You have purchased {0} sugar cubes", numberOfSugarCubes);
                money.ShowMoney(customer, inventory, money, recipe);
                customer.PotentialCustomers(inventory, money, recipe, weather, customer, game, store, day);
            }
            return money.moneyLeft;
        }
    }
}
