using System;
using System.IO;
using LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lemonadeTest
{
    [TestClass]
    public class MoneyBoolTest
    {
        [TestMethod]
        public void AmountToSpendLeftChangesBalance()
        {
            Money money = new Money();

            double moneyToSpend = 25;

            bool result = money.SpendMoney(moneyToSpend);
            //assert
            Assert.IsFalse(result);
        }
        [TestClass]
        public class NewMoneyBoolTest
        {
            [TestMethod]
            public void AmountToSpendLeftChangesBalance()
            {
                Money money = new Money();

                double moneyToSpend = 20;

                bool result = money.SpendMoney(moneyToSpend);
                //assert
                Assert.IsTrue(result);
            }
        }
    }
}
