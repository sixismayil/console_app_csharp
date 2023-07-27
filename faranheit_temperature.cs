using System;
namespace FahranheitApplication
{
    class FaranheitTemperature
    {
        public void print()
        {
            double number1;
            Console.WriteLine("Enter your temperature");
            number1 = Convert.ToDouble(Console.ReadLine());

            double result = number1 * 33.8;
            Console.WriteLine("Temperature is {0} F",result);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.print();
            Console.ReadKey();
        }
    }
}