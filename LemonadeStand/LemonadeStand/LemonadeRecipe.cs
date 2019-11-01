using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeRecipe
    {
        //variables
        public int lemonsInRecipe;
        public int sugarCupsInRecipe;
        public int iceCubesInRecipe;
        public double lemonadePrice;
        public int cupsPerPithcer;

        //constructor
        public LemonadeRecipe()
        {
            lemonsInRecipe = 0;
            sugarCupsInRecipe = 0;
            iceCubesInRecipe = 0;
            lemonadePrice = 0;
            cupsPerPithcer = 15;
        }

        //methods
        public int LemonsInRecipe()
        {
            Console.WriteLine("How many lemons would you like to have in a pitcher of Lemonade?");
            lemonsInRecipe = int.Parse(Console.ReadLine());
            return lemonsInRecipe;
        }
        public int SugarCupsInRecipe()
        {
            Console.WriteLine("How many cups of sugar would you like to have in a pitcher of Lemonade?");
            sugarCupsInRecipe = int.Parse(Console.ReadLine());
            return sugarCupsInRecipe;
        }
        public int IceCubesPerCups()
        {
            Console.WriteLine("How many ice cubes are going to be in a cup of Lemonade?");
            iceCubesInRecipe = int.Parse(Console.ReadLine());
            return iceCubesInRecipe;
        }
        public double PriceOfLemonade()
        {
            Console.WriteLine("How much do you want to charge per cup of lemonade?");
            lemonadePrice = double.Parse(Console.ReadLine());
            return lemonadePrice;
        }

        public void RemakingLemonade()
        {
            if(cupsPerPithcer == 0)
            {
                LemonsInRecipe();
                SugarCupsInRecipe();
                IceCubesPerCups();
            }
        }
    }
}
