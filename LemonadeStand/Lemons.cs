using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemons : Store
    {
        public void AddLemons (LemonadeIngredients lemonadeIngredients, Store store)
        {
            switch (buyLemons)
            {
                case 10:
                    store.buyLemons = 10;
                    break;
                case 20:
                    store.buyLemons = 20;
                    break;
                case 30:
                    store.buyLemons = 30;
                    break;
                case 40:
                    store.buyLemons = 40;
                    break;
            }
        }
    }
}
