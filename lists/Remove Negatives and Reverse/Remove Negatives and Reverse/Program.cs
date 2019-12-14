using System;
using System.Collections.Generic;
using System.Linq;


namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            RemoveNegativDigits(digits);
            ReversList(digits);
            PrintList(digits);
  
        }
        static void RemoveNegativDigits(List<int> digits)
        {
            for (int i = 0; i < digits.Count; i++)
            {

                if (digits[i] < 0)
                {
                    digits.Remove(digits[i]);
                    i--;
                }
                if (digits.Count < 1)
                {
                    Console.WriteLine("empty");
                    return;
                }
            }

        }
        static void ReversList(List<int> digits)
        {
            digits.Reverse();
        }

        static void PrintList(List<int> digits)
        {
            Console.WriteLine(string.Join(" ", digits));
        }
    }

  
   
}
