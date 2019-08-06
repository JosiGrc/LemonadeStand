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
        public int temperature;
        public string todaysWeather;



        //Constructor
        public Weather()
        {
            weather = new List<string>() {"Sunny", "Cloudy", "Rainy", "Partly Cloudy", "Partly Snny", "Drizzle", "Breezy", "Windy"};
            temperature = GetTemperature();
            todaysWeather = GetWeather();

        }

        //Member Methods
        public int GetTemperature()
        {
            Random random = new Random();
            int temperature = random.Next(55, 111);
            return temperature;
        }

        public string GetWeather()
        {
            Random random = new Random();
            int randomIndex = random.Next(weather.Count);
            return weather[randomIndex];

        }

    }
}
