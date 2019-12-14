using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] SecondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool isEqual = true;
            int cicli = 0;
            int result = 0;
            
            for(int i = 0; i < firstArray.Length; i++)
            {
                result += firstArray[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                cicli++;
                
                if (firstArray[i] == SecondArray[i])
                {
                    isEqual = true;
                }
                else
                {
                   
                   isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {result}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {cicli-1} index");
            }
        }
    }
}
