using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int digit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= digit; i++)
            {
                PrintNumbers(i);
               
            }


            for (int i= digit-1;i>=1;i--)
            {
                PrintNumbers(i);
                
            }
        }

        static void PrintNumbers(int i )
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

        }
    }
}
