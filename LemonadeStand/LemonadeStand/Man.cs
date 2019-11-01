using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Man : Customer
    {
        //Member Variables
        LemonadeRecipe lemonadeRecipe = new LemonadeRecipe();
        public bool lemonsInRecipe;
        public bool iceInRecipe;
        public bool sugarInRecipe;
        public bool priceofLemonade;
        public int oddsOfLemonadeBeingPurchased;


        //Ctor
        public Man()
        {
            oddsOfLemonadeBeingPurchased = ChancesOfBuyingBasedOnLemomnadeRecipe();
        }

        //Methods
        public new int RandomNumbers(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public new void IceCubePreference()
        {
            if (lemonadeRecipe.iceCubesInRecipe <= 1)
            {
                iceInRecipe = true;
            }

        }

        public new void SugarPreference()
        {
            if (lemonadeRecipe.sugarCupsInRecipe <= 3)
            {
                sugarInRecipe = true;
            }
        }

        public new void LemonPreference()
        {
            if (lemonadeRecipe.lemonsInRecipe <= 4)
            {
                lemonsInRecipe = true;
            }
        }

        public new void PriceWillingToPay()
        {
            if (lemonadeRecipe.lemonadePrice >= .20)
            {
                priceofLemonade = true;
            }
        }

        public new int ChancesOfBuyingBasedOnLemomnadeRecipe()
        {
            if (sugarInRecipe && lemonsInRecipe && iceInRecipe && priceofLemonade == true)
            {
                return RandomNumbers(1, 2);
                
            }
            else if (sugarInRecipe && iceInRecipe == true)
            {
                return RandomNumbers(3, 10);
            }
            return 0;
        }

    }
}
