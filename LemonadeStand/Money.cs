using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Money
    {
        public double moneyLeft;
        public double amountToSpend;
        public Money()
        {
            moneyLeft = 20.00;
        }
        public bool SpendMoney(double amountToSpend)
        {
            if (moneyLeft - amountToSpend >= 0)
            {
                Math.Round(moneyLeft -= amountToSpend);
                return true;
            }
            else
            {
                return false;
            }
        }
        public double ShowMoney(Customer customer, Inventory inventory, Money money, Recipe recipe)
        {
            Console.WriteLine("You have {0} dollars.", moneyLeft);
            return Math.Round(moneyLeft);
        }
    }
}
