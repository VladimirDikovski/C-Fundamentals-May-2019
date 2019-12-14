using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDigitsPolidrom();
        }

        static void PrintDigitsPolidrom()
        {
           

            while (true)
            {
                string digit = Console.ReadLine();
                if(digit== "END")
                {
                    break;
                }
                if (digit[0] == digit[digit.Length - 1])
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }

            }
         
        }
    }
}
