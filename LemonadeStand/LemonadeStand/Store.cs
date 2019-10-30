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
        //public Inventory inventory;
        
        

        //Constructor
        public Store()
        {
            lemonPrice = .25;
            sugarCupsPrice = .75;
            icePrice = .10;
            cupsPrice = .99;
                  
        }

        //Member Methods
        public int BuyingLemons()
        {
            Console.WriteLine("How many lemons you buying?");
            lemonsBought = int.Parse(Console.ReadLine());
            return AddingLemonsToInvetory(lemonsBought);
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
                money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + lemonsBought + " lemons.");
            }
            return money;
        }

        public int BuyingSugar()
        {
            Console.WriteLine("How many cups of sugar are you buying?");
            sugarCupsBought = int.Parse(Console.ReadLine());
            return AddingSugarToInventory(sugarCupsBought);
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
                money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + sugarCupsBought + " cups of sugar.");
            }
            return money;
        }

        public int BuyingIce()
        {
            Console.WriteLine("How many ice cubes are you buying?");
            iceCubesBought = int.Parse(Console.ReadLine());
            return AddingIceToInventory(iceCubesBought);
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
                money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + iceCubesBought + " Ice Cubes.");
            }
            return money;
        }

        public int BuyingCups()
        {
            Console.WriteLine("How many cups we buying?");
            cupsBought = int.Parse(Console.ReadLine());
            return AddingCupsToInventory(cupsBought);
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
                money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + cupsBought + " cups.");
            }
            return money;
        }

        public void BuyingItems()
        {
            Inventory inventory = new Inventory();
            Console.WriteLine("What would you like to buy today, Cups, Ice, Sugar, Lemons or Nothing?");
            string itemBeingBought = Console.ReadLine().ToLower();
            switch (itemBeingBought)
            {
                case "Cups":
                    BuyingCups();
                    AddingCupsToInventory(inventory.cups);
                    MoneyLostFromBuyingCups(inventory.money);
                    break;
                case "Ice":
                    BuyingIce();
                    AddingIceToInventory(inventory.iceCubes);
                    MoneyLostFromBuyingIce(inventory.money);
                    break;
                case "Sugar":
                    BuyingSugar();
                    AddingSugarToInventory(inventory.sugarCups);
                    MoneyLostFromBuyingSugar(inventory.money);
                    break;
                case "Lemons":
                    BuyingLemons();
                    AddingLemonsToInvetory(inventory.lemons);
                    MoneyLostFromBuyingLemons(inventory.money);
                    break;
                case "Nothing":
                    break;

            }
        }
        
    }
}
