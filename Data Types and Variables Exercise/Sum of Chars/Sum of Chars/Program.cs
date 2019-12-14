using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                char Symbol = char.Parse(Console.ReadLine());
                result += Symbol;
            }

            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
