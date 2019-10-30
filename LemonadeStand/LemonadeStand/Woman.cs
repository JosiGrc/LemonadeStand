using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Woman : Customer
    {
        //Member Variables
        LemonadeRecipe lemonadeRecipe = new LemonadeRecipe();


        //Ctor

        //Methods
        public new int RandomNumbers(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public new void IceCubePreference()
        {
            if(lemonadeRecipe.iceCubesInRecipe <= 2)
            {
                ChancesOfBuyingLemomnade();
            }

        }

        public new void SugarPreference()
        {
            if(lemonadeRecipe.sugarCupsInRecipe <= 3)
            {
                ChancesOfBuyingLemomnade();
            }
        }

        public new void LemonPreference()
        {
            if(lemonadeRecipe.lemonsInRecipe <= 5)
            {
                ChancesOfBuyingLemomnade();
            }
        }

        public new void PriceWillingToPay()
        {
            if(lemonadeRecipe.lemonadePrice <= .25)
            {
                ChancesOfBuyingLemomnade();
            }
        }

        public new void ChancesOfBuyingLemomnade()
        {

        }
    }
}
