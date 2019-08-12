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

        //constructor
        public LemonadeRecipe()
        {
            lemonsInRecipe = LemonsInRecipe();
            sugarCupsInRecipe = SugarCupsInRecipe();
            iceCubesInRecipe = IceCubesPerCups();
        }

        //methods
        int LemonsInRecipe()
        {
            Console.WriteLine("How many lemons would you like to have in a pitcher of Lemonade?");
            lemonsInRecipe = int.Parse(Console.ReadLine());
            return lemonsInRecipe;
        }
        int SugarCupsInRecipe()
        {
            Console.WriteLine("How many cups of sugar would you like to have in a pitcher of Lemoade?");
            sugarCupsInRecipe = int.Parse(Console.ReadLine());
            return sugarCupsInRecipe;
        }
        int IceCubesPerCups()
        {
            Console.WriteLine("How many sugar cubes are going to be in a cup of Lemonade?");
            iceCubesInRecipe = int.Parse(Console.ReadLine());
            return iceCubesInRecipe;
        }
    }
}
