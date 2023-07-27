using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number please:");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a>0){
                Console.WriteLine("The number " + a + " is positive");
            }
            else if (a == 0)
            {
                Console.WriteLine("The number " + a + " is positive nor negative");
            }
            else
            {
                Console.WriteLine("The number " + a + " is negative");
            }
        }
    }
}