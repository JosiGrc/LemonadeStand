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

        }

        //Member Methods

        public void RunGame()
        {
            Console.WriteLine("For how many days is the lemonade stand going to be up for?");
            daysPlaying = int.Parse(Console.ReadLine());
            ValidateDaysPlaying();
            Console.WriteLine("What do you want to name your Lemonade Stand?");
            lemonadeStandName = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < daysPlaying; daysPlaying--) 
            {
                lemonadeStand.BuyingItems();            
                Console.WriteLine("Press any key to sell lemonade for today");
                Console.ReadLine();
                Console.Clear();
                DisplayDay();
                myRecipe.MakingLemonade();                
                lemonadeStand.LoosingItemsFromRecipe();
                SellLemonade();
                lemonadeStand.LemonadeStandInventory();
                ProfitOfTheDay();
                Console.WriteLine("Press any key to sell lemonade for tomorrow");
                Console.ReadLine();
                Console.Clear();             

              

            }

            EndGame();




        }
        public void DisplayDay()
        {
            today.GetWeather();
            Console.WriteLine("You are on day " + daysPlaying + ", todays weather is " + today.GetWeather() + " with a temperature of " + today.GetTemperature());
        }

        public void SellLemonade()
        {
            today.GenerateCustomers();      
            for (int i = 0; i < today.customerList.Count; i++)
            {
                //lemonadeStand.SellignLemonadeToMen();
                //lemonadeStand.SellingLemonadeToChildren();
                //lemonadeStand.SellingLemonadeToWomen();
                lemonadeStand.myLemonadeRecipe.cupsPerPithcer--;
                CheckSuplies();
                lemonadeStand.standInventory.cups--;
                CheckSuplies();
                lemonadeStand.standInventory.money += myRecipe.lemonadePrice;
                lemonadeStand.cupsBoughtToday++;

            } 

        }

        public void ProfitOfTheDay()
        {
            lemonadeStand.moneyEarned += myRecipe.lemonadePrice;
            Console.WriteLine("Today " + lemonadeStandName + " earned " + lemonadeStand.moneyEarned );
        }

        public void ToTalProfit()
        {
            lemonadeStand.totalMoneyEarned += myRecipe.lemonadePrice;
            Console.WriteLine("Over the course of " + daysPlaying + lemonadeStandName + "eraned a total of " + lemonadeStand.totalMoneyEarned);
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

        public void EndGame()
        {
            if (daysPlaying == 0)
            {
                ToTalProfit();
                if (lemonadeStand.totalMoneyEarned > 0)
                {
                    Console.WriteLine("Congratulations on the earings, hopefully you can put these economics to good use IRL");
                }
                else if (lemonadeStand.totalMoneyEarned < 0)
                {
                    Console.WriteLine("You took an L for this game, bumer");
                }
            }
        }

        public void CheckSuplies()
        {
            if (lemonadeStand.myLemonadeRecipe.cupsPerPithcer == lemonadeStand.cupsBoughtToday)
            {
                lemonadeStand.myLemonadeRecipe.RemakingLemonade();
            }
            else if (lemonadeStand.standInventory.iceCubes == 0)
            {
                Console.WriteLine("Youre out of ice");
            }
            else if (lemonadeStand.standInventory.lemons == 0)
            {
                Console.WriteLine("Youre out of lemons");
            }
            else if (lemonadeStand.standInventory.sugarCups == 0)
            {
                Console.WriteLine("Youre out of sugar");
            }
            else if (lemonadeStand.standInventory.cups == 0)
            {
                Console.WriteLine("Youre out of cups");
            }

        }












    }
}
