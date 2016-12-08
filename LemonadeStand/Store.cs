using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public int buyLemons;
        public int buyIceCubes;
        public int buySugar;

        public decimal lemonPrice = .20m;
        public void BuyLemons(Money money)
        {
            Console.WriteLine("Ten lemons cost $2.00. Twenty lemons cost $4.00. Thirty lemons cost $6.00. Forty lemons cost $8.00.");
            Console.WriteLine("How many lemons would you like to buy?");
            Console.WriteLine("Choose '10', '20', '30', or '40'");
            buyLemons = int.Parse(Console.ReadLine());
            Console.WriteLine("You have {0} lemons.", buyLemons);
            bool moneyLeft = money.SpendMoney(Convert.ToDecimal(buyLemons) * lemonPrice);
            if (moneyLeft == true)
            {       
                Console.WriteLine("You have {0}.", money.moneyLeft);
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy any lemons.");
            }
        }
        public decimal iceCubePrice = .01m;
        public void BuyIceCubes(Money money)
        {
            Console.WriteLine("100 ice cubes cost $1.00. 200 ice cubes cost $2.00. 300 ice cubes cost $3.00. 400 ice cubes cost $4.00.");
            Console.WriteLine("How many ice cubes would you like to buy?");
            Console.WriteLine("Choose '100', '200', '300', or '400'");
            buyIceCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("You have {0} ice cubes.", buyIceCubes);
            bool moneyLeft = money.SpendMoney(Convert.ToDecimal(buyIceCubes) * iceCubePrice);
            if (moneyLeft == true)
            { 
                Console.WriteLine("You have {0}.", money.moneyLeft);
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy any ice cubes.");
            }
        }
        public decimal cupSugarPrice = .40m;
        public void BuySugar(Money money)
        {
            Console.WriteLine("Five cups of sugar cost $2.00. Ten cups of sugar cost $4.00. Fifteen cups of sugar cost $6.00.");
            Console.WriteLine("Twenty cups of sugar cost $8.00.");
            Console.WriteLine("How many cups of sugar would you like to buy?");
            Console.WriteLine("Choose '5', '10', '15', or '20'");
            buySugar = int.Parse(Console.ReadLine());
            Console.WriteLine("You have {0} cups of suger.", buySugar);
            bool moneyLeft = money.SpendMoney(Convert.ToDecimal(buySugar) * cupSugarPrice);
            if (moneyLeft == true)
            {
                Console.WriteLine("You have {0}.", money.moneyLeft);
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy any cups of sugar.");
            }
        }
    }
}
