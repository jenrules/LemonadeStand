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
        public decimal lemonPrice = .20m;
        public int tenLemons = 10;
        public int twentyLemons = 20;
        public int thirtyLemons = 30;
        public int fortyLemons = 40;
        public int amountOfLemons;
        public int GetLemons(Store store, Customer customer)
        {
            amountOfLemons = store.buyLemons - (oneLemon * customer.customerToday);           
            return amountOfLemons;
        }
        public int fourIceCubes = 4;
        public decimal iceCubePrice = .01m;
        public int oneHundredIceCubes = 100;
        public int twoHundredIceCubes = 200;
        public int threeHundredIceCubes = 300;
        public int fourHundredIceCubes = 400;
        public int amountOfIceCubes;
        public int GetIceCubes(Store store, Customer customer)            
        {
            amountOfIceCubes = store.buyIceCubes - (fourIceCubes * customer.customerToday);          
            return amountOfIceCubes;
        }
        public int oneSugar = 1;
        public decimal cupSugarPrice = .40m;
        public int fiveCupsOfSugar = 5;
        public int tenCupsOfSugar = 10;
        public int fifteenCupsOfSugar = 15;
        public int twentyCupsOfSugar = 20;
        public int amountOfSugar;
        public int GetSugar(Store store, Customer customer)
        {
            amountOfSugar = store.buySugar - (oneSugar * customer.customerToday);                
            return amountOfSugar;
        }
    }
}
    

