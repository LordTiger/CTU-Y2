using System;
// Brandon de Bruyn 6854
// Luke de Kiwiet 7293

namespace Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            int choice, price;
            Console.WriteLine("-----------------" + "\n1. Pine \n2. Oak \n3. Mahogany" + "\n-----------------");
            Console.WriteLine("Choose Number:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    price = 100;
                    Console.WriteLine("Pine Costs: $" + price);
                    break;
                case 2:
                    price = 225;
                    Console.WriteLine("Oak Costs: $" + price);
                    break;
                case 3:
                    price = 310;
                    Console.WriteLine("Mahogany Costs: $" + price);
                    break;
                default:
                    price = 0;
                    Console.WriteLine("Price: $" + price);
                    break;

            }
            Console.ReadLine();

        }
    }
}
