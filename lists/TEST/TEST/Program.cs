using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Random digits = new Random();
            

            for (int i = 0; i <100; i++)
            {
                int numbers = digits.Next(0, 132);
                if (numbers>=26 && numbers <= 100)
                {
                    continue;
                }
                Console.Write(numbers+" ");
            }
        }
    }
}
