using System;

namespace Multiplication_Table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int beggining = int.Parse(Console.ReadLine());
            int result = 0;
            if (beggining > 10)
            {
                Console.WriteLine($"{digit} X {beggining} = {digit*beggining}");
                
            }

            for (int i = beggining; i <=10; i++)
            {
                result = digit * i;
                
               
                Console.WriteLine($"{digit} X {i} = {result}");
            }
        }
    }
}
