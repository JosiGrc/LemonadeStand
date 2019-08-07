using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //Member Variables
        public int lemons;
        public int sugarCups;
        public int iceCubes;
        public int cups;
        public double Money;

        //Constructor
        public Inventory()
        {
            lemons = 0;
            sugarCups = 0;
            cups = 0;
            iceCubes = 0;
            Money = 20;
        }

        //Member Methods
        public int GettingItemsFromStore()
        {
            return 0;
        }
    }
}
