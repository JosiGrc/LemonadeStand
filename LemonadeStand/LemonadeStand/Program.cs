﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
            //game.SellLemonade();
            //Stand stand = new Stand();
            //stand.BuyingItems();

            Console.ReadLine();
           
        }
    }
}
