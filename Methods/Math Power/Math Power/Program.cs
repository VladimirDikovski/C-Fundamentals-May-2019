using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double digit = double.Parse(Console.ReadLine());
            int PowerOfDigit = int.Parse(Console.ReadLine());
            double result = 0;
            result =  PowerOfNumbers(digit, PowerOfDigit);

            Console.WriteLine(result);
        }

        static double PowerOfNumbers(double digit,int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {

                result *= digit;
            }
            return result;
        }
    }
}
