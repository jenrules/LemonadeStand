using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void StartGame()
        {
            DisplayWelcome();
            Rules.LearnRules();
            Player player = new Player();
            player.GetName();
            GetTotalSupplies();
            Day day = new Day();
            day.ChooseDays();
        }
        public void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the game. Lemonade Stand.");
        }
        public void GetTotalSupplies()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have a loan of $20.00 to start up your business.");
            Console.WriteLine("Then, you will need to use your profits to keep your business going.");
        }
        public void BuySupplies(Money money, LemonadeIngredients lemonadeIngredients)
        {
            Console.WriteLine("You have {0} dollars.", money.moneyLeft);
            Console.WriteLine("You currently have {0} lemons, {1} ice cubes, {2} sugar.", lemonadeIngredients.amountOfLemons, lemonadeIngredients.amountOfIceCubes, lemonadeIngredients.amountOfSugar);
            Console.WriteLine("Would you like to buy more supplies for your lemonade stand? 'Yes' or 'No.'");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "yes")
            {
                Console.WriteLine("Time to go to the store!");
            }
            else if (userInput.ToLower() == "no")
            {
                Console.WriteLine("Time to sell some lemonade!");
            }
            else
            {
                Console.WriteLine("Error. Please enter 'yes' or 'no'.");
                BuySupplies(money, lemonadeIngredients);
            }
        } 
        public void ChooseRestart()
        {
            Console.WriteLine("Would you like to play another game? Type 'yes' or 'no'.");
             string userInput = Console.ReadLine().ToLower();
             if(userInput == "yes")
            {
                StartGame();
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Have a nice day");
                Environment.Exit(0);
            }
            else
             {
                 Console.WriteLine("Error. Please write 'yes' or 'no'.");
                 ChooseRestart();
             }
         }    
    }
}
