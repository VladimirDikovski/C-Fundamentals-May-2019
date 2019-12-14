using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;

            for(int i = 0; i < digits.Length; i++)
            {
                 
                 if(digits[i] % 2 == 0)
                {
                    sum += digits[i];
                } 
                   

                
                
            }

            Console.WriteLine(sum);
        }
    }
}
