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
        public int daysPlaying;
        public string lemonadeStandName;     
        


        //Constructor
        public Game()
        {
            player1 = new Player();
            store = new Store();
            daysPlaying = HowManyDaysAreBeingPlayed();
            lemonadeStandName = WhatIsTheNameOfYourStand();       
            
        }

        //Member Methods
        private int HowManyDaysAreBeingPlayed()
        {
            Console.WriteLine("For how many days is the lemonade stand going to be up for?");
            daysPlaying = int.Parse(Console.ReadLine());
            if (daysPlaying >= 100)
            {
                Console.WriteLine("If youre gonna be playing that long wouldn't it be better to have a real life lemonade stand?");
                return HowManyDaysAreBeingPlayed();
            }
            return daysPlaying;
        }

        public string WhatIsTheNameOfYourStand()
        {
            Console.WriteLine("What do you want to name your Lemonade Stand?");
            lemonadeStandName = Console.ReadLine();
            return lemonadeStandName;
        }

        public void RunGame()
        {
            for (int i = 0; i < daysPlaying; daysPlaying--) 
            {
                
            }



        }
        
      










    }
}
