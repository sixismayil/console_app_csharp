using System;

namespace ConversionApplicarion
{
    class Conversion
    {
        static void Main(string[] args)
        {
            int intValue = 555;
            double doubleValue = Convert.ToDouble(intValue);
            Console.WriteLine(doubleValue);

            float floatValue = 555;
            int intValue1 = Convert.ToInt32(floatValue);
            Console.WriteLine(intValue1);

            string stringValue = "123";
            int intValue2 = Convert.ToInt32(stringValue);
            Console.WriteLine(intValue2);

            bool boolValue2 = true;
            string stringValue2 = Convert.ToString(boolValue2);
            Console.WriteLine(stringValue2);

            double doubleValue3 = 999;
            string stringValue3 = Convert.ToString(doubleValue3);
            Console.WriteLine(stringValue3);

        }
    }
}



