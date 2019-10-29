using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class SpecialCharacters
    {
        //Member Variables
        public List<string> specialNames;
        public Day day;


        //Ctor
        public SpecialCharacters()
        {
            specialNames = new List<string>() { "Cersei Lannister", "Gordon Ramsey", "Tony Stark", "Michael Scott", "Ron Swanson", "Dwight Schrute", "Squidward Tentacles", "Patrick Star", "Tormund" };

        }

        //Methods

        public void PeoplesWeatherPreferance(int temperature, string weather)
        {
            if (temperature > 75)
            {
                //day.customerList.Add("Michael Scott");
                //day.customerList.Add("Dwight Schrute");
                Console.WriteLine("Michael Scott and Dwight Schrute are out and about enjoying the great weather");            
            }

            else if (weather == "Sunny")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
            }

            else if (weather == "Breezy")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
            }

            else if (weather == "Partly Cloudy")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
            }

            else if (weather == "Partly Sunny")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
            }

            else if (temperature < 75)
            {
                Console.WriteLine("Michael Scott and Dwight Schrute are enjoying the 'good weather'?");
            }

            else if (temperature < 78 && weather == "Sunny")
            {
                Console.WriteLine("Uh-Oh, Cersei Lanister has decided to come out");
            }

            else if (weather == "Drizzle")
            {
                Console.WriteLine("Ah great weather for Patrick and Squidward to enjoy the surface life");
            }

            else if (weather == "Windy")
            {
                Console.WriteLine("Tormund goes to see whats going on around town");
            }

            else if (weather == "Rainy")
            {
                Console.WriteLine("Indeed this is great weather for Patrick and Squidward to enjoy the city above the city");
            }

            else if (weather == "Cloudy")
            {
                Console.WriteLine("Gordon and Tony decide to see if the big woman is around town");
            }

            else
            {
                Console.WriteLine("Seems like no one in this town likes the weather enough to go outside and buy your lemonade");
            }
        }

    }
}
