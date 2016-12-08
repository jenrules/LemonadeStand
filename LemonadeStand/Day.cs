using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        List<string> daysOfTheWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        
        public int numberOfDays;
        public void ChooseDays()
        {
        Console.WriteLine("You can run your lemonade stand for 7, 14, or 21 days. How long would you like to run your stand? Type '7', '14', '21'.");
            numberOfDays = int.Parse(Console.ReadLine());
            if (numberOfDays == 7)
            {
                Console.WriteLine("Time to buy some supplies.");

                foreach (var day in daysOfTheWeek)
                {
                    Console.WriteLine("Today is {0}.", day);
                    Weather weather = new Weather();
                    weather.DisplayWeather();
                    Recipe recipe = new Recipe();
                    recipe.SetPriceOfLemonade();
                    recipe.HowToMakeLemonade();
                    Store store = new Store();
                    Money money = new Money();
                    store.BuyLemons(money);
                    store.BuyIceCubes(money);
                    store.BuySugar(money);
                    Customer customer = new Customer();
                    customer.GetCustomer(weather, recipe, money);
                }    
                }
            else if (numberOfDays == 14)
            {
                Console.WriteLine("Time to buy some supplies.");
                
                foreach (var day in daysOfTheWeek)
                    {
                        Console.WriteLine("Today is {0}.", day);
                        Weather weather = new Weather();
                        weather.DisplayWeather();
                        Recipe recipe = new Recipe();
                        recipe.SetPriceOfLemonade();
                        recipe.HowToMakeLemonade();
                        Store store = new Store();
                        Money money = new Money();
                        store.BuyLemons(money);
                        store.BuyIceCubes(money);
                        store.BuySugar(money);
                        Customer customer = new Customer();
                        customer.GetCustomer(weather, recipe, money);
                    }
             }
            else if (numberOfDays == 21)
            {
                Console.WriteLine("Time to buy some supplies.");

                foreach (var day in daysOfTheWeek)
                    {
                        Console.WriteLine("Today is {0}.", day);
                        Weather weather = new Weather();
                        weather.DisplayWeather();
                        Recipe recipe = new Recipe();
                        recipe.SetPriceOfLemonade();
                        recipe.HowToMakeLemonade();
                        Store store = new Store();
                        Money money = new Money();
                        store.BuyLemons(money);
                        store.BuyIceCubes(money);
                        store.BuySugar(money);
                        Customer customer = new Customer();
                        customer.GetCustomer(weather, recipe, money);
                     }
            }
            else
            {
                Console.WriteLine("Error. Please type '7', '14', or '21'.");
                ChooseDays();
            }
        }

    }
}
