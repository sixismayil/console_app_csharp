using System;

namespace Increment1Application
{
    class Increment1
    {
        static void Main(string[] args)
        {
            int x = 24;
            int y = 13;

            int z = (x + y) / 2 + y++ + ++y + 2*(x--*4);
            int w = z++ + (w = y) - --w;
            Console.WriteLine("{0} {1} {2} {3}", x, y, z, w);
            Console.ReadLine();
        }
    }
}