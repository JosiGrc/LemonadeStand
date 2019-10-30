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
        //public List<string> potentialNames;
        //public bool temperaturePreference;


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

        public void ChancesOfBuyingLemomnade()
        {

        }

        public void PriceWillingToPay()
        {

        }


    }
}
