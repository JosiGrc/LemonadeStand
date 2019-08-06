using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //Member Variables
        public int lemons;
        public int sugarCups;
        public int iceCups;
        public int cups;

        //Constructor
        public Store()
        {
            lemons = gettingLemons();
            sugarCups = gettingSugar();
            iceCups = gettingIce();
            cups = gettingCups();

        }

        //Member Methods
        public int gettingLemons()
        {
            Console.WriteLine("How many lemons you buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
        public int gettingSugar()
        {
            Console.WriteLine("How many cups of Sugar are you buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
        public int gettingIce()
        {
            Console.WriteLine("How many cups of ice are you buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
        public int gettingCups()
        {
            Console.WriteLine("How many cups we buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
    }
}
