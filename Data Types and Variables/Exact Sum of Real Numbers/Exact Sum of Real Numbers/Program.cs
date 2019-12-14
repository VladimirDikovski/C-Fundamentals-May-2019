using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0;

            for(int i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                result += number;
            }
            Console.WriteLine($"{result}");
        }
    }
}
