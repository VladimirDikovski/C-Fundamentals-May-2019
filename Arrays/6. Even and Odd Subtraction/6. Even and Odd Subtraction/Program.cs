using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfevenNumber = 0;
            int sumOfOddNumber = 0;
            int diffrent = 0;
            int[] digits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < digits.Length; i++)
            {
                int currentNumber = digits[i];
                if (currentNumber % 2 == 0)
                {
                    sumOfevenNumber += digits[i];
                }
                else
                {
                    sumOfOddNumber += digits[i];
                }

            }

            diffrent = sumOfevenNumber- sumOfOddNumber;
            Console.WriteLine(diffrent);
        }
    }
}
