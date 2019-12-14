using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalDigit = int.Parse(Console.ReadLine());
            int interal = int.Parse(Console.ReadLine());
            int result = 0;
            int count = 0;


            List<int> Binary = new List<int>();
            while (decimalDigit != 0)
            {
                result= decimalDigit % 2;
                Binary.Add(result);
                result= decimalDigit /= 2;

            }
            for (int i = 0; i < Binary.Count; i++)
            {
                count = Binary.Count(x => x == interal);
               

            }

            Binary.Reverse();
            Console.WriteLine(string.Join(" ",Binary));
            Console.WriteLine(count);
            
        }
    }
}
