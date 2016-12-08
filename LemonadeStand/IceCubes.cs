using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class IceCubes : Store
    {
        public void AddIceCubes(LemonadeIngredients lemonadeIngredients, Store store)
        {
            switch (buyIceCubes)
            {
                case 100:
                    store.buyIceCubes = 100;
                    break;
                case 200:
                    store.buyIceCubes = 200;
                    break;
                case 300:
                    store.buyIceCubes = 300;
                    break;
                case 400:
                    store.buyIceCubes = 400;
                    break;
            }
        }
    }
}
