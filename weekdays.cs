using System;

namespace WeekdaysApplication
{
    class Weekdays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day please (1-7):");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1: Console.WriteLine("Monday");
                break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
               default:
                    Console.WriteLine("Don't have this day");
                    break;

            }

        }
    }
}