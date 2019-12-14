using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstDigits = long.Parse(Console.ReadLine());
            long secondDigits = long.Parse(Console.ReadLine());
            double fakturielFirstResult = FaktureilFirstDigit(firstDigits);
            double fakturielSecondResult = FaktureilsecondDigit(secondDigits);
           
            double devideResult = devideTwoFacturiels(fakturielFirstResult, fakturielSecondResult);
            Console.WriteLine($"{devideResult:f2}");

           
        }
        static long FaktureilFirstDigit(long first)
        {
            long fakturielFirstDigit = 1;
            for (int i = 1; i <= first; i++)
            {

                fakturielFirstDigit *= i;


            }
            return fakturielFirstDigit;
        }
        static long FaktureilsecondDigit(long second)
        {
            long fakturielSecondDigit = 1;
            for (int i = 1; i <= second; i++)
            {

                fakturielSecondDigit *= i;


            }
            return fakturielSecondDigit;
        }

        static double devideTwoFacturiels(double first,double second)
        {
            double result = first / second;
            return result;
        }
    }

   
}
