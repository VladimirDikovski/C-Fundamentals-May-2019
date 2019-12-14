using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int sum = 0;
                int SeparateNumbers = i;

                while (SeparateNumbers > 0)
                {
                    sum += SeparateNumbers % 10;
                    SeparateNumbers = SeparateNumbers / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

               

            }
        }
    }
}
