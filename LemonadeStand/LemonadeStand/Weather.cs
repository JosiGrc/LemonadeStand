using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //Member Variables
        public List<string> weather;
        public int Temp;



        //Constructor
        public Weather()
        {
            weather = new List<string>() {"Sunny", "Cloudy", "Rainy", "Partly Cloudy"};
            Temp = GetWeather();
        }

        //Member Methods
        public int GetWeather()
        {
            Random random = new Random();
            int temp = random.Next(55, 111);
            return temp;
        }

    }
}
