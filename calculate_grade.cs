using System;

namespace Calculate_Grade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double point;
            Console.Write("Write your point: ");
            point = double.Parse(Console.ReadLine());
            string letter_grade;
            letter_grade = (point >= 90 && point <= 100) ? "A" : ((point >= 80 && point <= 89.99) ? "B" : ((point >= 70 && point <= 79.99) ? "C" : ((point >= 60 && point <= 69.99) ? "D" : ((point >= 0 && point <= 59.99) ? "F" : "undefined"))));
            Console.WriteLine("Your letter grade is: {0}", letter_grade);
        }
    }
}
