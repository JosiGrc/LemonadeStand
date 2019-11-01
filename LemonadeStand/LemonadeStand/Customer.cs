using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Customer
    {
        //Member Variables
       
        public bool lemonsInRecipe;
        public bool iceInRecipe;
        public bool sugarInRecipe;
        public bool priceofLemonade;
        public int oddsOfLemonadeBeingPurchased;  //Liskovs principle it makes sense for man woman and child to inherit customer because theres an Is-a relationship


        //Constructor


        //Member Methods



        public int RandomNumbers(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void IceCubePreference()
        {

        }

        public void SugarPreference()
        {

        }

        public void LemonPreference()
        {

        }

        public void ChancesOfBuyingBasedOnLemomnadeRecipe()
        {

        }

        public void PriceWillingToPay()
        {

        }

       
    }
}
