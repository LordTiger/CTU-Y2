// 7293 - Luke de Kiewit
// 6854 - Brandon de Bruyn

using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 3;
            sum(valueOne, valueTwo);
            Console.WriteLine("Difference: ");
            Console.WriteLine(product(valueOne, valueTwo));
        }

        public static void sum(int numOne, int numTwo)

        {

            int numSum;
            numSum = numOne + numTwo;
            Console.WriteLine("Value 1 + Value 2 = " + numSum);

        }

        public static void difference(int valueOne, int valueTwo)

        {

            int differenceOne;
            differenceOne = valueOne - valueTwo;
            Console.WriteLine("Value 1 - Value 2 = " + differenceOne);

        }

        public static int product(int valueOne, int valueTwo)

        {

            int product = valueOne * valueTwo;
            return product;

        }
    }
}
   
