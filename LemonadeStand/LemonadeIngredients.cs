using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeIngredients
    {
        public int oneLemon = 1;
        public int fourIceCubes = 4;
        public int oneSugar = 1;
        public decimal lemonPrice = .20m;
        public int amountOfLemons;
        public int GetLemons(Store store, Customer customer)
        {
                amountOfLemons = store.buyLemons - (oneLemon * customer.customerToday);           
            return amountOfLemons;
        }
        public decimal iceCubePrice = .01m;
        public int amountOfIceCubes;
        public int GetIceCubes(Store store, Customer customer)            
        {
                amountOfIceCubes = store.buyIceCubes - (fourIceCubes * customer.customerToday);          
            return amountOfIceCubes;
        }
        public decimal cupSugarPrice = .40m;
        public int amountOfSugar;
        public int GetSugar(Store store, Customer customer)
        {
                amountOfSugar = store.buySugar - (oneSugar * customer.customerToday);                
            return amountOfSugar;
        }
    }
}
    

