using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        List<int> customers = new List<int> { 1, 50 };
        public Customer()
        {
        }
        public bool willBuy;
        public int PotentialCustomers(Inventory inventory, Money money, Recipe recipe, Weather weather, Customer customer, Game game, Store store, Day day)
        {
            weather.ShowActualWeather(recipe, game, money, store, inventory, customer, weather, day);
            Console.WriteLine("Here come some customers!");
            Random randomC = new Random();
            int randomCustomer = randomC.Next(0, 50);
            for (int i = 0; i < 10; i++)
            {
                if (randomCustomer >= 0 && randomCustomer <= 10)
                {
                    inventory.CheckInventory(recipe, game, store, money, inventory, customer, weather, day);
                    if (weather.weatherNumber == 1 || weather.weatherNumber == 4 || weather.weatherNumber == 5 && recipe.price <= 1.00)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else if (weather.weatherNumber == 2 || weather.weatherNumber == 3 && recipe.price <= .05)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else willBuy = false;
                }
                else if (randomCustomer >= 11 && randomCustomer <= 20)
                {
                    inventory.CheckInventory(recipe, game, store, money, inventory, customer, weather, day);
                    if (weather.weatherNumber == 1 || weather.weatherNumber == 4 || weather.weatherNumber == 5 && recipe.price <= .80)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else if (weather.weatherNumber == 2 || weather.weatherNumber == 3 && recipe.price <= .10)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else willBuy = false;
                }
                else if (randomCustomer >= 21 && randomCustomer <= 30)
                {
                    inventory.CheckInventory(recipe, game, store, money, inventory, customer, weather, day);
                    if (weather.weatherNumber == 1 || weather.weatherNumber == 4 || weather.weatherNumber == 5 && recipe.price <= .60)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else if (weather.weatherNumber == 2 || weather.weatherNumber == 3 && recipe.price <= .15)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else willBuy = false;
                }
                else if (randomCustomer >= 31 && randomCustomer <= 40)
                {
                    inventory.CheckInventory(recipe, game, store, money, inventory, customer, weather, day);
                    if (weather.weatherNumber == 1 || weather.weatherNumber == 4 || weather.weatherNumber == 5 && recipe.price <= .40)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else if (weather.weatherNumber == 2 || weather.weatherNumber == 3 && recipe.price <= .20)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else willBuy = false;
                }
                else if (randomCustomer >= 41 && randomCustomer <= 50)
                {
                    inventory.CheckInventory(recipe, game, store, money, inventory, customer, weather, day);
                    if (weather.weatherNumber == 1 || weather.weatherNumber == 4 || weather.weatherNumber == 5 && recipe.price <= .20)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else if (weather.weatherNumber == 2 || weather.weatherNumber == 3 && recipe.price <= .25)
                    {
                        willBuy = true;
                        inventory.SubtractInventory(recipe);
                        money.moneyLeft = money.moneyLeft + recipe.price;
                    }
                    else willBuy = false;
                }
            }
            money.ShowMoney(customer, inventory, money, recipe);
            game.ShowProfit(money);
            return randomCustomer;
        }
    }
}