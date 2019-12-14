using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            SumIndexList(numbers);

        }

        static void SumIndexList(List<int> digits)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < digits.Count / 2; i++)
            {

                result.Add(digits[i] + digits[digits.Count - i - 1]);

            }
            if (digits.Count % 2 == 1)
            {
                result.Add(digits[digits.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
