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
            weather = new List<string>() {"Sunny", "Breezy", "Partly Cloudy", "Partly Sunny", "Drizzle", "Windy", "Rainy", "Cloudy" }; 
            temperature = GetTemperature(); 
            todaysWeather = GetWeather(); //Bad weather starts at index 4 until end (index 7)
            Console.WriteLine("Its" + todaysWeather + " with a temperature of " + temperature+ " today");
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
