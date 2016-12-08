using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Rules
    {
        public static void LearnRules()
        {
            Console.WriteLine("Do you know the rules?");
            string rules = Console.ReadLine();
            if (rules.ToLower() == "no")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("You are going to start a Lemonade Stand and try to make a profit.");
                Console.WriteLine("See how the descisions that you make affect your business.");
                Console.WriteLine("Each day, you will be shown the weather forecast, and you will be given the option to go to the store to buy ");
                Console.WriteLine("your ingredients.");
                Console.WriteLine("Be sure to pay attention to the weather forecast, so that you know how much to buy and what to set the price at.");
                Console.WriteLine("Try to maximize your profits while your stand is open.");
            }
            else if (rules.ToLower() == "yes")
            {
            Console.WriteLine("Great to have you play again!");
            }
            else
            {
                Console.WriteLine("Error. Please write 'yes' or 'no'.");
                LearnRules();
            }
        }
    }
}
