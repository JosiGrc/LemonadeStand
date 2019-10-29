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
        //public string todaysWeather;



        //Constructor
        public Weather()
        {
            weather = new List<string>() {"Sunny", "Breezy", "Partly Cloudy", "Partly Sunny", "Drizzle", "Windy", "Rainy", "Cloudy" }; 
            //temperature = GetTemperature(); 
            //todaysWeather = GetWeather(); //Bad weather starts at index 4 until end (index 7)
            //Console.WriteLine("Its " + todaysWeather + " with a temperature of " + temperature + "degrees Fahrenheit today");
        }

        //Member Methodsh
        public int GetTemperature()
        {
            temperature = GenerateNumbers(50, 111);
            return temperature;
        }

        public string GetWeather()
        {
            int randomIndex = GenerateNumbers(0, weather.Count);
            return weather[randomIndex];

        }
        public int GenerateNumbers(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
