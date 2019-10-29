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
        public int cupsBoughtToday;


        //Constructor
        public Stand()
        {
            cupsBoughtToday = 0;
            myStore = new Store();
            standInventory = new Inventory();
            myLemonadeRecipe = new LemonadeRecipe();

        }

        //Methods
    }
}
