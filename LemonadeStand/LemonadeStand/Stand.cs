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
        public double moneyEarned;
        public double totalMoneyEarned;

        //Constructor
        public Stand()
        {
            cupsBoughtToday = 0;
            myStore = new Store();
            standInventory = new Inventory();
            myLemonadeRecipe = new LemonadeRecipe();
        }

        //Methods

        public void LemonadeStandInventory()
        {
            Console.WriteLine("You have " + standInventory.cups + " cups, " + standInventory.iceCubes + " ice cubes " + standInventory.lemons + " lemons " + standInventory.sugarCups + " and cups of sugar.");
        }

        public void AvailableMoney()
        {
            Console.WriteLine("You have " + standInventory.money + " available to spend today");
        }


    }
}
