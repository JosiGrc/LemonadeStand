using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //Member Variables
        public int lemonsBought;
        public int sugarCupsBought;
        public int iceCubesBought;
        public int cupsBought;
        public double lemonPrice;
        public double sugarCupsPrice;
        public double icePrice;
        public double cupsPrice;
        

        //Constructor
        public Store()
        {
            lemonPrice = .25;
            sugarCupsPrice = .75;
            icePrice = .99;
            cupsPrice = .99;
        
        }

        //Member Methods
        public int BuyingLemons()
        {
            Console.WriteLine("How many lemons you buying?");
            lemonsBought = int.Parse(Console.ReadLine());
            return lemonsBought;
        }
        public int BuyingSugar()
        {
            Console.WriteLine("How many cups of Sugar are you buying?");
            sugarCupsBought = int.Parse(Console.ReadLine());
            return sugarCupsBought;
        }
        public int BuyingIce()
        {
            Console.WriteLine("How many ice cubes are you buying?");
            iceCubesBought = int.Parse(Console.ReadLine());
            return iceCubesBought;
        }
        public int BuyingCups()
        {
            Console.WriteLine("How many cups we buying?");
            cupsBought = int.Parse(Console.ReadLine());
            return cupsBought;
        }
    }
}
