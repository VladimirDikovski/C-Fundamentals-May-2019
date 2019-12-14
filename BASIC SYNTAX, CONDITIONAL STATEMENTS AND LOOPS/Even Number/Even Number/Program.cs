using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            while (true)
            {
                if (digit % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(digit)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                digit = int.Parse(Console.ReadLine());

            }

           
        }
    }
}
