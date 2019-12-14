using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar = double.Parse(Console.ReadLine());
            const double POUND = 1.31;
            double result = dolar * 1.31;
            Console.WriteLine($"{result:f3}");
        }
    }
}
