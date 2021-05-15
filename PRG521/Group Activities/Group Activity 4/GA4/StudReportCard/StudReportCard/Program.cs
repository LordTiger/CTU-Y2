using System;

namespace StudReportCard
{
    class Program
    {
        public static void Grades()
        {
            double sc, math, eng, finalmarks;
            string studName;

            Console.WriteLine("Enter Name: ");
            studName = Console.ReadLine();

            Console.WriteLine("Enter Computer Science Marks: ");
            sc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Math Marks: ");
            math = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter English Marks: ");
            eng = Convert.ToDouble(Console.ReadLine());

            finalmarks = sc + math + eng;

            if(finalmarks >= 75)
            {
                Console.WriteLine("Congratulations " + studName + " You have scored " + finalmarks + "/150");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Grade Scored: F");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Grades();
        }
    }
}
