using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            int result = NTerm_Tribonacci(digit);
            Console.WriteLine(result);
          
            
        }
        private static int NTerm_Tribonacci(int term)
        {
            int a = 0;
            int b = 1;
            int c = 1;
            int result = 0;

            if (term == 0) result = a;
            if (term == 1) result = b;
            if (term == 2) result = c;

            while (term > 2)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
                term--;
            }

            return result;
        }

    }
}
