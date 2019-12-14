using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] digits = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for(int i = 0; i < digits.Length; i++)
            {
                double rounded = Math.Round(digits[i],0,MidpointRounding.AwayFromZero);
                Console.WriteLine(digits[i] + " => " + rounded);
            }
        }
    }
}
