using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());

            double kilometer = 1000;
            double result = meter / kilometer;
            Console.WriteLine($"{result:F2}");
        }
    }
}
