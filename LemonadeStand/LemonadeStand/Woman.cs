using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Woman : Customer    //The classes inheriting from Customer are not forced to use any methods they dont need
    {
        //Member Variables
        public new bool lemonsInRecipe;
        public new bool iceInRecipe;
        public new bool sugarInRecipe;
        public new bool priceofLemonade;
        public new int oddsOfLemonadeBeingPurchased;



        //Ctor
       

        //Methods
        public new int RandomNumbers(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public new void IceCubePreference()
        {
            

        }

        public new void SugarPreference()
        {
        
        }

        public new void LemonPreference()
        {
        
        }

        public new void PriceWillingToPay()
        {
    
        }

        public new void ChancesOfBuyingBasedOnLemomnadeRecipe()
        {
           
            
        }
    }
}
