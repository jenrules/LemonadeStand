using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Store
    {
        public void AddSugar(LemonadeIngredients lemonadeIngredients, Store store)
        {
            switch (buySugar)
            {
                case 5:
                    store.buySugar = 5;
                    break;
                case 10:
                    store.buySugar = 10;
                    break;
                case 15:
                    store.buySugar = 15;
                    break;
                case 30:
                    store.buySugar = 20;
                    break;
            }
        }
    }
}
