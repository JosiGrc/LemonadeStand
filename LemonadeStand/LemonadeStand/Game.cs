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
          
        }

        //Member Methods
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
