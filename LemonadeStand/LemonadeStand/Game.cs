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
        public int lemonsBought;
        public int sugarCupsBought;
        public int iceCubesBought;
        public int cupsBought;
        

        //Constructor
        public Game()
        {
            lemonsBought = BuyingLemons();
            sugarCupsBought = BuyingSugar();
            iceCubesBought = BuyingIce();
            cupsBought = BuyingCups();
        }

        //Member Methods*
        //so when the player buys things from the store they will be added to the inventory. money will also be subtracted from their total
        public int AddingLemonsToInvetory(int lemons, int lemonsBought)
        {
            lemons = lemonsBought + lemons;
            return lemons;
        }
        public int AddingIceToInventory(int iceCubes, int iceCubesBought)
        {
            iceCubes = iceCubesBought + iceCubes;
                return iceCubes;
        }
        public int AddingSugarToInventory(int sugarCups, int sugarCupsBought)
        {
            sugarCups = sugarCupsBought + sugarCups;
            return sugarCups;
        }
        public int AddingCupsToInventory(int cups, int cupsBought)
        {
            cups = cupsBought + cups;
            return cups;
        }
    }
}
