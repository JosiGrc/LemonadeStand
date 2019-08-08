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
            Customer test = new Customer(weather.temperature, weather.todaysWeather);
            Inventory inventory = new Inventory();            inventory.lemons = 0;
            Store testore = new Store();
            inventory.lemons = testore.BuyingLemons(inventory.lemons);
            Store.          


            Console.ReadLine();
        }
    }
}
