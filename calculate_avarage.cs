using System;
using System.IO;
public class CalculateAvarage
{
    public static void Main()
    {
        double number1, number2, number3;

        Console.Write("Enter the First number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3) / 3;
        Console.WriteLine("The average of {0}, {1}, {2} is: {3} ",
        number1, number2, number3, result);

        Console.ReadKey();
    }
}