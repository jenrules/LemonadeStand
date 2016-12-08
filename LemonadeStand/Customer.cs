using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public int oneLemon = 1;
        public int fourIceCubes = 4;
        public int oneSugar = 1;
        public int customerToday;
        List<int> customers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        Random choice = new Random();
        public void GetCustomer(Weather weather, Recipe recipe, Money money)
        {
            customerToday = customers[choice.Next(0, 30)];
            foreach (var customerToday in customers)
            {
                if (customerToday >= 1 - 15 && weather.weatherToday == "sunny")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Here comes a customer.");
                    Console.WriteLine("I'll buy a lemonade for {0}.", recipe.price);
                    Console.WriteLine("Yum.");
                    money.moneyLeft = money.moneyLeft + (Convert.ToDecimal(recipe.price));
                    Console.WriteLine("You have {0}.", money.moneyLeft);
                }
                else if (customerToday >= 16 - 30 && weather.weatherToday == "cloudy")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Here comes a customer.");
                    Console.WriteLine("I'll buy a lemonade for {0}.", recipe.price);
                    Console.WriteLine("Yum.");
                    money.moneyLeft = money.moneyLeft + (Convert.ToDecimal(recipe.price));
                    Console.WriteLine("You have {0}.", money.moneyLeft);
                }
                else if (customerToday <= 1 - 15 && weather.weatherToday == "windy")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Here comes a customer.");
                    Console.WriteLine("I won't buy a lemonade today.");
                    Console.WriteLine("Yuck.");
                }
                else if (customerToday <= 16 - 30 && weather.weatherToday == "rainy")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Here comes a customer.");
                    Console.WriteLine("No lemonade for me.");
                    Console.WriteLine("Yuck.");
                }
            }
        }
    }
}