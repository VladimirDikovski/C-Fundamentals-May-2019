using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int digit = int.Parse(Console.ReadLine());
            PrintPossibleOrNegativeNumbers(digit);
        }

        static void PrintPossibleOrNegativeNumbers(int digit)
        {

            if (digit < 0)
            {
                Console.WriteLine($"The number {digit} is negative.");
            }
            else if (digit > 0)
            {
                Console.WriteLine($"The number {digit} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {digit} is zero.");
            }

        }
    }
}
