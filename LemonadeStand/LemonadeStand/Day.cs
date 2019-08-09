using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //Member Variables
                
        public List<string>daysOfWeek;

        //Constructor
        public Day()
        {
            daysOfWeek = new List<string>(){"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};            
        }

        //Member Methods
       public void GetTheDay()
       {
            for (int i = 0; i < daysOfWeek.Count; i++)
            {
                Console.WriteLine($"Today is {daysOfWeek[i]}");                
            }
       }
      
    }
}
