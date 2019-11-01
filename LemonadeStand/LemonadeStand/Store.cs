using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
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
            icePrice = .10;
            cupsPrice = .99;
                  
        }

        //Member Methods
        public void BuyingLemons()
        {
            Console.WriteLine("How many lemons you buying?");
            lemonsBought = int.Parse(Console.ReadLine());
        }        

        public void BuyingSugar()
        {
            Console.WriteLine("How many cups of sugar are you buying?");
            sugarCupsBought = int.Parse(Console.ReadLine());
        }      

        public void BuyingIce()
        {
            Console.WriteLine("How many ice cubes are you buying?");
            iceCubesBought = int.Parse(Console.ReadLine());
         
        }
       
        public void BuyingCups()
        {
            Console.WriteLine("How many cups we buying?");
            cupsBought = int.Parse(Console.ReadLine());
        }       
        
    }
}
