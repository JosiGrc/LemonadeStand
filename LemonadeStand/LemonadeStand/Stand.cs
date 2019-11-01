using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Stand 
    {
        //Member Variables
        public Inventory standInventory;
        public LemonadeRecipe myLemonadeRecipe;
        public Store myStore;
        //public Man men;
        //public Child children;
        //public Woman women;
        public int cupsBoughtToday;
        public double moneyEarned;
        public double totalMoneyEarned;

        //Constructor
        public Stand()
        {
            cupsBoughtToday = 0;
            myStore = new Store();
            standInventory = new Inventory();
            myLemonadeRecipe = new LemonadeRecipe();

        }

        //Methods

        public void LemonadeStandInventory()
        {
            Console.WriteLine("You have " + standInventory.cups + " cups, " + standInventory.iceCubes + " ice cubes " + standInventory.lemons + " lemons " + standInventory.sugarCups + " and cups of sugar.");
        }

        public void AddingLemonsToInvetory()
        {
            standInventory.lemons += myStore.lemonsBought;
        }

        public void AddingSugarToInventory()
        {
            standInventory.sugarCups += myStore.sugarCupsBought;
        }

        public void AddingIceToInventory()
        {
            standInventory.iceCubes += myStore.sugarCupsBought;
        }

        public void AddingCupsToInventory()
        {
            standInventory.cups += myStore.cupsBought;
        }

        public double MoneyLostFromBuyingLemons()
        {
            double totalCost = myStore.lemonsBought * myStore.lemonPrice;
            if (standInventory.money < totalCost)
            {
                Console.WriteLine("You can't affor to buy lemons, guess you gotta wait till life gives you lemons.");
            }
            else
            {
                standInventory.money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + myStore.lemonsBought + " lemons.");
            }
            return standInventory.money;
        }

        public double MoneyLostFromBuyingSugar()
        {
            double totalCost = myStore.sugarCupsBought * myStore.sugarCupsPrice;
            if (standInventory.money > totalCost)
            {
                Console.WriteLine("You can't afford sugar, I hope the unsweetened version of what you're making taste good.");
            }
            else
            {
                standInventory.money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + myStore.sugarCupsBought + " cups of sugar.");
            }
            return standInventory.money;
        }

        public double MoneyLostFromBuyingIce()
        {
            double totalCost = myStore.iceCubesBought * myStore.icePrice;
            if (standInventory.money > totalCost)
            {
                Console.WriteLine("Ouch water in a solid state is too pricy for you? Best rethink some life decisions.");
            }
            else
            {
                standInventory.money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + myStore.iceCubesBought + " Ice Cubes.");
            }
            return standInventory.money;
        }

        public double MoneyLostFromBuyingCups()
        {
            double totalCost = myStore.cupsBought * myStore.cupsPrice;
            if (standInventory.money > totalCost)
            {
                Console.WriteLine("Wow not even able to afford something so cheap, these are rough time indeed.");
            }
            else
            {
                standInventory.money -= totalCost;
                Console.WriteLine("You paid " + totalCost + " for " + myStore.cupsBought + " cups.");
            }
            return standInventory.money;
        }

        public void BuyingItems()
        {
            Console.WriteLine("What would you like to buy today, cups, ice, sugar, lemons or nothing?");
            string itemsBeingBought = Console.ReadLine();
            switch (itemsBeingBought)
            {
                case "cups":
                    myStore.BuyingCups();
                    AddingCupsToInventory();
                    MoneyLostFromBuyingCups();
                    break;
                case "ice":
                    myStore.BuyingIce();
                    AddingIceToInventory();
                    MoneyLostFromBuyingIce();
                    break;
                case "sugar":
                    myStore.BuyingSugar();
                    AddingSugarToInventory();
                    MoneyLostFromBuyingSugar();
                    break;
                case "lemons":
                    myStore.BuyingLemons();
                    AddingLemonsToInvetory();
                    MoneyLostFromBuyingLemons();
                    break;
                case "nothing":
                    break;

            }
        }





        public void AvailableMoney()
        {
            Console.WriteLine("You have " + standInventory.money + " available to spend today");
        }






















        

        public void ChargingForLemonade()
        {
            standInventory.money += myLemonadeRecipe.lemonadePrice;
        }

        //public void SellignLemonadeToMen()
        //{
        //    if (men.oddsOfLemonadeBeingPurchased == 1)
        //    {
        //        ChargingForLemonade();
        //        myLemonadeRecipe.cupsPerPithcer--;
        //    }
        //    else if (men.oddsOfLemonadeBeingPurchased == 3 || men.oddsOfLemonadeBeingPurchased == 6 || men.oddsOfLemonadeBeingPurchased == 9)
        //    {
        //        ChargingForLemonade();
        //        myLemonadeRecipe.cupsPerPithcer--;

        //    }
        //}
        //public void SellingLemonadeToWomen()
        //{
        //    if (women.oddsOfLemonadeBeingPurchased == 1)
        //    {
        //        ChargingForLemonade();
        //        myLemonadeRecipe.cupsPerPithcer--;
        //    }
        //    else if (women.oddsOfLemonadeBeingPurchased == 3 || women.oddsOfLemonadeBeingPurchased == 6 || women.oddsOfLemonadeBeingPurchased == 9)
        //    {
        //        ChargingForLemonade();
        //        myLemonadeRecipe.cupsPerPithcer--;
        //    }
        //}

        //public void SellingLemonadeToChildren()
        //{
        //    if (children.oddsOfLemonadeBeingPurchased == 1)
        //    {
        //        ChargingForLemonade();
        //        myLemonadeRecipe.cupsPerPithcer--;
        //    }
        //    else if (children.oddsOfLemonadeBeingPurchased == 3 || children.oddsOfLemonadeBeingPurchased == 6 || children.oddsOfLemonadeBeingPurchased == 9)
        //    {
        //        ChargingForLemonade();
        //        myLemonadeRecipe.cupsPerPithcer--;
        //    }
        //}
    }
}
