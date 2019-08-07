using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Weather weather = new Weather();
            weather.temperature = 70;
            weather.todaysWeather = "Sunny";
            Customer test = new Customer(weather.temperature, weather.todaysWeather);
            Console.ReadLine();
            Store testore = new Store();
        }
    }
}
