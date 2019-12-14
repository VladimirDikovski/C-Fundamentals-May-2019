using System;
using System.Numerics;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ");
            string firstSring = strings[0];
            string secondString = strings[1];
            string minString = string.Empty;
            string MaxString = string.Empty;
            BigInteger result = 0;

            if (firstSring.Length < secondString.Length)
            {
                minString = firstSring;
                MaxString = secondString;
            }
            else
            {
                minString = secondString;
                MaxString = firstSring;
            }

           
                for (int i = 0; i <minString.Length; i++)
                {

                 result += firstSring[i] * secondString[i];
                
               }
            for (int i = minString.Length; i < MaxString.Length; i++)
            {
                result += MaxString[i];

            }

           
           
            Console.WriteLine(result);
        }
    }
}
