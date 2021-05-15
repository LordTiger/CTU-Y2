using System;
// Brandon de Bruyn 6854
// Luke de Kiwiet 7293


namespace Divide
{
    class divide
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            double One = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            double Two = Convert.ToDouble(Console.ReadLine());
            divide(One, Two);

        }

        static void divide(double One, double Two)
        {
            double answer = (One / Two);
            double remainder = One % Two;
            Console.WriteLine("Remainder:" + remainder + "\nAnswer: " + answer);
            Console.ReadLine();
        }
    }
}
