using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public Weather()
        {
        }
        public int weatherNumber;
        public int DetermineWeather()
        {
            Random randomW = new Random();
            int randomWeather = randomW.Next(0, 50);
            if (randomWeather >= 0 && randomWeather <= 10)
            {
                weatherNumber = 1;
            }
            else if (randomWeather >= 11 && randomWeather <= 20)
            {
                weatherNumber = 2;
            }
            else if (randomWeather >= 21 && randomWeather <= 30)
            {
                weatherNumber = 3;
            }
            else if (randomWeather >= 31 && randomWeather <= 40)
            {
                weatherNumber = 4;
            }
            else if (randomWeather >= 41 && randomWeather <= 50)
            {
                weatherNumber = 5;
            }
            return weatherNumber;
        }
        public void ShowPredictedWeather(Recipe recipe, Game game, Money money, Store store, Inventory inventory, Customer customer, Weather weather, Day day)
        {
            switch (weatherNumber)
            {
                case 1:
                    Console.WriteLine("Today's predicted weather forecast is Sunny and 90.");
                    recipe.SetPriceOfLemonade(recipe, game, money, store, inventory, customer, weather, day);
                    break;
                case 2:
                    Console.WriteLine("Today's predicted weather forecast is Sunny but 60.");
                    recipe.SetPriceOfLemonade(recipe, game, money, store, inventory, customer, weather, day);
                    break;
                case 3:
                    Console.WriteLine("Today's predicted weather forecast is Rainy and 60.");
                    recipe.SetPriceOfLemonade(recipe, game, money, store, inventory, customer, weather, day);
                    break;
                case 4:
                    Console.WriteLine("Today's predicted weather forecast is Showers but 90.");
                    recipe.SetPriceOfLemonade(recipe, game, money, store, inventory, customer, weather, day);
                    break;
                case 5:
                    Console.WriteLine("Today's predicted weather forecast is Hazy and 80.");
                    recipe.SetPriceOfLemonade(recipe, game, money, store, inventory, customer, weather, day);
                    break;
                default:
                    break;
            }
        }
        public void ShowActualWeather(Recipe recipe, Game game, Money money, Store store, Inventory inventory, Customer customer, Weather weather, Day day)
        {
            switch (weatherNumber)
            {
                case 1:
                    Console.WriteLine("Today's actual weather forecast is Sunny and 95.");
                    break;
                case 2:
                    Console.WriteLine("Today's actual weather forecast is Sunny but 55.");
                    break;
                case 3:
                    Console.WriteLine("Today's actual weather forecast is Rainy and 55.");
                    break;
                case 4:
                    Console.WriteLine("Today's actual weather forecast is Showers but 95.");
                    break;
                case 5:
                    Console.WriteLine("Today's actual weather forecast is Hazy and 85.");
                    break;
                default:
                    break;
            }
        }
    }
}
