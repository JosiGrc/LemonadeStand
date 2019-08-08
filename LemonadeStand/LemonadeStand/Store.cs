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
        public int BuyingLemons(int invLemons)
        {
            Console.WriteLine("How many lemons you buying?");
            lemonsBought = int.Parse(Console.ReadLine());
            return AddingLemonsToInvetory(invLemons);
        }
        public int AddingLemonsToInvetory(int lemons)
        {
            lemons = lemonsBought + lemons;
            return lemons;
        }


        public int BuyingSugar(int invsugarcCups)
        {
            Console.WriteLine("How many cups of sugar are you buying?");
            sugarCupsBought = int.Parse(Console.ReadLine());
            return AddingSugarToInventory(invsugarcCups);
        }
        public int AddingSugarToInventory(int sugarCups)
        {
            sugarCups = sugarCupsBought + sugarCups;
            return sugarCups;
        }

        public int BuyingIce(int inviceCubes)
        {
            Console.WriteLine("How many ice cubes are you buying?");
            iceCubesBought = int.Parse(Console.ReadLine());
            return AddingIceToInventory(inviceCubes);
        }
        public int AddingIceToInventory(int iceCubes)
        {
            iceCubes = iceCubesBought + iceCubes;
            return iceCubes;
        }



        public int BuyingCups(int invcups)
        {
            Console.WriteLine("How many cups we buying?");
            cupsBought = int.Parse(Console.ReadLine());
            return AddingCupsToInventory(invcups);
        }       
        public int AddingCupsToInventory(int cups)
        {
            cups = cupsBought + cups;
            return cups;
        }
    }
}
