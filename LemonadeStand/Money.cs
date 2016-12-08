using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Money
    {
        public decimal moneyLeft;        
        public Money()
        {
            moneyLeft = 20.00m;
        }        
        public bool SpendMoney(decimal amountToSpend)
        {
            if(moneyLeft - amountToSpend >= 0)
            {
                moneyLeft -= amountToSpend;
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
