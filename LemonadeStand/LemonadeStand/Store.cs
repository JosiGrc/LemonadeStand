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
            icePrice = .10;
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
        public double MoneyLostFromBuyingLemons(double money)
        {
            double totalCost = lemonsBought * lemonPrice;           
            if (money < totalCost)
            {
                Console.WriteLine("You can't affor to buy lemons, guess you gotta wait till life gives you lemons.");
            }
            else
            {
                money = money - totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + lemonsBought + " lemons.");
            }
            return money;
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
        public double MoneyLostFromBuyingSugar(double money)
        {
            double totalCost = sugarCupsBought * sugarCupsPrice;
            if (money > totalCost)
            {
                Console.WriteLine("You can't afford sugar, I hope the unsweetened version of what you're making taste good.");
            }
            else
            {
                money = money - totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + sugarCupsBought + " cups of sugar.");
            }
            return money;
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
        public double MoneyLostFromBuyingIce(double money)
        {
            double totalCost = iceCubesBought * icePrice;
            if (money > totalCost)
            {
                Console.WriteLine("Ouch water in a solid state is too pricy for you? Best rethink some life decisions.");
            }
            else
            {
                money = money - totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + iceCubesBought + " Ice Cubes.");
            }
            return money;
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
        public double MoneyLostFromBuyingCups(double money)
        {
            double totalCost = cupsBought * cupsPrice;
            if (money > totalCost)
            {
                Console.WriteLine("Wow not even able to afford something so cheap, these are rough time indeed.");
            }
            else
            {
                money = money - totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + cupsBought + " cups.");
            }
            return money;
        }
        
    }
}
