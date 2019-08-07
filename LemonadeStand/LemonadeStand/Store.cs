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
        public int lemonsBought;
        public int sugarCupsBought;
        public int iceCupsBought;
        public int cupsBought;
        

        //Constructor
        public Store()
        {
            lemonsBought = BuyingLemons();
            sugarCupsBought = BuyingSugar();
            iceCupsBought = BuyingIce();
            cupsBought = BuyingCups();

        }

        //Member Methods
        public int BuyingLemons()
        {
            Console.WriteLine("How many lemons you buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
        public int BuyingSugar()
        {
            Console.WriteLine("How many cups of Sugar are you buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
        public int BuyingIce()
        {
            Console.WriteLine("How many cups of ice are you buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
        public int BuyingCups()
        {
            Console.WriteLine("How many cups we buying?");
            Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
    }
}
