using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game 
    {
        //Member Variables (HAS A)
        public Player player1;
        public Store store;
        public Day today;
        public Stand lemonadeStand;
        public LemonadeRecipe myRecipe;
        public int daysPlaying;
        public string lemonadeStandName;     
        


        //Constructor
        public Game()
        {
            myRecipe = new LemonadeRecipe();
            lemonadeStand = new Stand();
            player1 = new Player();
            store = new Store();
            today = new Day();
            //daysPlaying = HowManyDaysAreBeingPlayed();
            //lemonadeStandName = WhatIsTheNameOfYourStand();

        }

        //Member Methods

        //private int HowManyDaysAreBeingPlayed()
        //{
        //    Console.WriteLine("For how many days is the lemonade stand going to be up for?");
        //    daysPlaying = int.Parse(Console.ReadLine());
        //    if (daysPlaying >= 100)
        //    {
        //        Console.WriteLine("If youre gonna be playing that long wouldn't it be better to have a real life lemonade stand?");
        //        return HowManyDaysAreBeingPlayed();
        //    }
        //    return daysPlaying;
        //}

        //public string WhatIsTheNameOfYourStand()
        //{
        //    Console.WriteLine("What do you want to name your Lemonade Stand?");
        //    lemonadeStandName = Console.ReadLine();
        //    return lemonadeStandName;
        //}

        public void RunGame()
        {
            Console.WriteLine("For how many days is the lemonade stand going to be up for?");
            daysPlaying = int.Parse(Console.ReadLine());
            Console.WriteLine("What do you want to name your Lemonade Stand?");
            lemonadeStandName = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < daysPlaying; daysPlaying--) 
            {
                DisplayDay();
                lemonadeStand.LemonadeStandInventory();
                AvailableMoney();
                lemonadeStand.BuyingItems();            
                lemonadeStand.LemonadeStandInventory();
                lemonadeStand.AvailableMoney();
                Console.WriteLine("Press any key to sell lemonade for today");
                Console.Clear();
                Console.ReadLine();
                Console.Clear();
                today.GetWeather();
                today.GetTemperature();
                SellLemonade();
                lemonadeStand.LemonadeStandInventory();
                lemonadeStand.AvailableMoney();
                Console.WriteLine("Press any key to sell lemonade for tomorrow");
                Console.ReadLine();
                Console.Clear();             



            }





        }
        public void DisplayDay()
        {
            today.GetWeather();
            Console.WriteLine("You are on day " + daysPlaying + ", todays weather is " + today.GetWeather() + " with a temperature of " + today.GetTemperature());
        }

        public void SellLemonade()
        {
            today.GenerateCustomers();
            myRecipe.IceCubesPerCups();
            myRecipe.LemonsInRecipe();
            myRecipe.SugarCupsInRecipe();
            for (int i = 0; i < today.customerList.Count; i++)
            {
                //lemonadeStand.SellignLemonadeToMen();
                //lemonadeStand.SellingLemonadeToChildren();
                //lemonadeStand.SellingLemonadeToWomen();
                lemonadeStand.myLemonadeRecipe.cupsPerPithcer--;
                lemonadeStand.standInventory.cups--;
                lemonadeStand.standInventory.iceCubes -= myRecipe.lemonsInRecipe;
                lemonadeStand.standInventory.lemons -= myRecipe.lemonsInRecipe;
                lemonadeStand.standInventory.sugarCups -= myRecipe.sugarCupsInRecipe;
                lemonadeStand.standInventory.money += myRecipe.lemonadePrice;
                lemonadeStand.cupsBoughtToday++;

                if(lemonadeStand.myLemonadeRecipe.cupsPerPithcer == 0)
                {
                    lemonadeStand.myLemonadeRecipe.RemakingLemonade();

                    if (lemonadeStand.standInventory.cups == 0 || lemonadeStand.standInventory.iceCubes == 0 || lemonadeStand.standInventory.lemons == 0 || lemonadeStand.standInventory.sugarCups == 0)
                    {
                        Console.WriteLine("You're out of " + lemonadeStand.standInventory.Equals(0));
                    }
                }

               
            } 

        }

        public void ProfitOfTheDay()
        {
            lemonadeStand.moneyEarned += myRecipe.lemonadePrice;
            Console.WriteLine("Today you " +lemonadeStandName + "earned " + lemonadeStand.moneyEarned );
        }

        public void ToTalProfit()
        {
            lemonadeStand.totalMoneyEarned += myRecipe.lemonadePrice;
            Console.WriteLine("Over the course of " + daysPlaying + lemonadeStandName + "eraned a total of " + lemonadeStand.totalMoneyEarned);
        }

        public void AvailableMoney()
        {
            lemonadeStand.AvailableMoney();
        }

        public int ValidateDaysPlaying()
        {
            if (daysPlaying >= 100)
            {
                Console.WriteLine("If youre gonna be playing that long wouldn't it be better to have a real life lemonade stand?");
                return ValidateDaysPlaying();
            }
            return daysPlaying;
        }












    }
}
