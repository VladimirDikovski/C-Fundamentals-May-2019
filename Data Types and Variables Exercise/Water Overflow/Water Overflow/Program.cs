using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int volume = 255;
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int quantiti = int.Parse(Console.ReadLine());
                sum += quantiti;
                if (sum > volume)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantiti;
                    continue;
                }
               
            }
            Console.WriteLine(sum);
        }
    }
}
