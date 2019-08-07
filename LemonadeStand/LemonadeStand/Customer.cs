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
        public bool temperaturePreference;
       


        //Constructor
        public Customer(int temp, string weather)
        {
            potentialNames = new List<string>(){"Cersei Lannister", "Gordon Ramsey", "Tony Stark", "Michael Scott", "Ron Swanson", "Dwight Schrute", "Squidward Tentacles", "Patrick Star", "Tormund"};
            temperaturePreference = PeoplesWeatherPreferance(temp, weather);


        }

        //Member Methods

        //if both if statements are true then gordon, tony & ron come outside
        //otherwise cersei and squidward come outside
        //then michael and dwight go outside regardless
        public bool PeoplesWeatherPreferance(int temperature, string weather)
        {   
            if (temperature > 75)
            {
                Console.WriteLine("Michael Scott and Dwight Schrute are out and about enjoying the great weather");
                return true;
            }
            else if (weather == "Sunny")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
                return true;
            }
            else if (weather == "Breezy")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
                return true;
            }
            else if (weather == "Partly Cloudy")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
                return true;
            }
            else if (weather == "Partly Sunny")
            {
                Console.WriteLine("Tony Stark, Ron Swanson and Gordon Ramsey decide to enjoy the good weather");
                return true;
            }
            else if (temperature < 75)
            {
                Console.WriteLine("Michael Scott and Dwight Schrute are enjoying the 'good weather'?");
                return false;
            }
            else if (temperature < 68 && weather == "Sunny")
            {
                Console.WriteLine("Uh-Oh, Cersei Lanister has decided to come out");
                return false;
            }
            else if (weather == "Drizzle")
            {
                Console.WriteLine("Ah great weather for Patrick and Squidward to enjoy the surface life");
                return false;
            }
            else if (weather == "Windy")
            {
                Console.WriteLine("Tormund goes to see whats going on around town");
                return false;
            }
            else if (weather == "Rainy")
            {
                Console.WriteLine("Indeed this is great weather for Patrick and Squidward to enjoy the city above the city");
                return false;
            }
            else if (weather =="Cloudy")
            {
                Console.WriteLine("Gordon and Tony decide to see if the big woman is around town");
                return false;
            }
            else
            {

            }
            return false;
            
                
        }




    }
}
