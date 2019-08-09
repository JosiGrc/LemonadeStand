using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game 
    {
        //Member Variables
        public int daysPlaying;
        public string lemonadeStandName;
        

        //Constructor
        public Game()
        {
            daysPlaying = HowManyDaysAreBeingPlayed();
            lemonadeStandName = WhatIsTheNameOfYourStand();
        }

        //Member Methods
        private int HowManyDaysAreBeingPlayed()
        {
            Console.WriteLine("For how many days is the lemonade stand going to be up for?"); 
            daysPlaying = int.Parse(Console.ReadLine());
            for (int i = 0; i > 0; i --);
            return daysPlaying;
        }
        
        public string WhatIsTheNameOfYourStand()
        {
            Console.WriteLine("What do you want to name your Lemonade Stand?");
            lemonadeStandName = Console.ReadLine();
            return lemonadeStandName;
        }
        public object LemonadeRecipe()
        {
            Console.WriteLine(");
        }
      










    }
}
