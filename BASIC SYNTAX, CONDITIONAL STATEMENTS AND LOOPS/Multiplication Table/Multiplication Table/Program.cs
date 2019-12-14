using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int result = 0;

            for(int i = 1; i <= 10; i++)
            {
                result = digit * i;
                Console.WriteLine($"{digit} X {i} = {result}");
            }
        }
    }
}
