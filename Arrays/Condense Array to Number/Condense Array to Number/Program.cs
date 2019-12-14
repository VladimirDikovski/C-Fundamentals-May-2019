using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            
            int[] condensed = new int[digits.Length - 1];

            if (digits.Length == 1)
            {
                Console.WriteLine(digits[0]);
                return;
            }

            
            for ( int i = 0; i < digits.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = digits[j] + digits[j+ 1];
                }
                digits = condensed;
               

            }
            Console.WriteLine(condensed[0]);

            
            



        }
    }
}
