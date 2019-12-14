using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(2*i-1);
                result += 2 * i - 1;


                
            }
            Console.WriteLine($"Sum: {result}");
        }
    }
}
