using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string weatherToday;
        public int temperatureToday;        
        List<string> weath = new List<string> { "sunny", "cloudy", "windy", "rainy" };
        List<int> temps = new List<int> { 90, 80, 70, 60 };
        Random choice = new Random();        
        public void DisplayWeather()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Magenta;
            weatherToday = weath[choice.Next(0, 4)];
            Console.WriteLine("Today's weather is {0}", weatherToday);
            temperatureToday = temps[choice.Next(0, 4)];
            Console.WriteLine("Today's temperature is {0}", temperatureToday);
        }
    }
}

