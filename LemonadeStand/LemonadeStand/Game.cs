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
          
        }

        //Member Methods
        public int HowManyDaysAreBeingPlayed()
        {
            Console.WriteLine("For howe many days is the lemonade stand going to be up for?");
            daysPlaying = int.Parse(Console.ReadLine());
            return daysPlaying;
        }
        public string WhatIsTheNameOfYourSTand()
        {
            Console.WriteLine("What do you want to name your Lemonade Stand?");
            lemonadeStandName = Console.ReadLine();
            return lemonadeStandName;
        }


        public void RunGame(int money, int getTemperature, string GetWeather)
        {
            //while (daysPlaying > 0 || && money > 0)
            //getTemperature();
            //GetWeather();
        }


       
       
    }
}
