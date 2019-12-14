using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintIntegers(n);
            
        }

        static void PrintIntegers(int n)
        {
            for (int i = 1; i <= n * n; i++)
            {

                Console.Write(n + " ");
                if (i % n == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
