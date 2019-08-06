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
        // public DateTime Time;
        public int DayCounter;
        public List<string>daysOfWeek;
        public string People;

        //Constructor
        public Day()
        {
            daysOfWeek = new List<string>(){"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        }

        //Member Methods
       public string GetTheDay()
        {
            throw new NotImplementedException();
        }
    }
}
