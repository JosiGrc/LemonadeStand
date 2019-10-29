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

        public List<string> daysOfWeek;
        Weather weather = new Weather();
        public List<string> customerList;
        public SpecialCharacters npc;





        //Constructor
        public Day()
        {
            daysOfWeek = new List<string>(){"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

        }

        //Member Methods
        public string GetWeather()
        {
            return weather.GetWeather();
        }

        public int GetTemperature()
        {
            return weather.GetTemperature();
        }

        //public bool PeoplesWeatherPreferance()
        //{
        //    return npc.PeoplesWeatherPreferance();
        //}

        public List<string> GenerateCustomers()
        {
            if(weather.temperature <= 111)
            {
                customerList = new List<string>(new string[RandomNumbers(50, 60)]);
                return customerList;
            }
            else if (weather.temperature <= 90)
            {
                customerList = new List<string>(new string[RandomNumbers(70, 90)]);
                return customerList;
            }
            else if (weather.temperature <= 75)
            {
                customerList = new List<string>(new string[RandomNumbers(70, 80)]);
                return customerList;
            }
            else if (weather.temperature <= 60)
            {
                customerList = new List<string>(new string[RandomNumbers(50, 70)]);
                return customerList;
            }
            else if (weather.temperature <= 50)
            {
                customerList = new List<string>(new string[RandomNumbers(60, 70)]);
                return customerList;
            }
            else
            {
                customerList = new List<string>(new string[RandomNumbers(90, 100)]);
                return customerList;
            }

        }
        public int RandomNumbers(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }





    }
}
