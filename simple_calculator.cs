using System;
using System.Diagnostics.Metrics;

namespace Calculator
{
    class SimpleCalculator
    {

        static void Main(string[] args)
        {
            Console.Write($"Enter first number:");
            int num1;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter operator:");
            string num2;
            num2 = Convert.ToString(Console.ReadLine());
            Console.Write($"Enter second number:");
            int num3;
            num3 = Convert.ToInt32(Console.ReadLine());




            if (num2 == "/")
            {
                if (num3 != 0)
                {
                    Console.WriteLine("Answer: {0}", (num1 / num3));
                }
                else
                {
                    Console.WriteLine("Cannot divide by 0");
                }

            }

            else if (num2 == "*")
            {
                Console.WriteLine("Answer: {0}", (num1 * num3));
            }

            else if (num2 == "+")
            {
                Console.WriteLine("Answer: {0}", (num1 + num3));
            }

            else if (num2 == "-")
            {
                Console.WriteLine("Answer: {0}", (num1 - num3));
            }

            else
            {
                Console.Write("Error");
            }

        }


    }


}
