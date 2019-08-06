using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //Member Variables
        public List<string> potentialNames;
        public int temperaturePreference;

        //Constructor
        public Customer()
        {
            potentialNames = new List<string>(){"Cersei Lannister", "Gordon Ramsey", "Tony Stark", "Michael Scott", "Ron Swanson", "Dwight Schrute", "Squidward Tentacles"};
        }

        //Member Methods
    }
}
