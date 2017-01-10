using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        List<string> dayOfTheWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public Day()
        {
        }
        public void ChooseDays(Recipe recipe, Weather weather, Game game, Money money, Store store, Inventory inventory, Customer customer, Day day)
        {
            foreach (var dayOfTheWeek in dayOfTheWeek)
            {
                Console.WriteLine("Today is {0}", dayOfTheWeek);
                weather.DetermineWeather();
                weather.ShowPredictedWeather(recipe, game, money, store, inventory, customer, weather, day);
            }
        }
        }
}
