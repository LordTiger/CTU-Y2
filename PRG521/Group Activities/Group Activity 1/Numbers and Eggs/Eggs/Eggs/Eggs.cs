// 7293 - Luke de Kiewit
// 6854 - Brandon de Bruyn

using System;

namespace Eggs
{

    class Eggs
    {

        static void eggDozens(int eggies)
        {
            Console.WriteLine(Convert.ToString(eggies) + " is " + Convert.ToString(eggies / 12) + " Dozen " + "and " + Convert.ToString(eggies % 12) + " Bonus Eggs");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of eggs: ");
            int numberOfEggs = Convert.ToInt32(Console.ReadLine());
            eggDozens(numberOfEggs);
        }
    }
}
