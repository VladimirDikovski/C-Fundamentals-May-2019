using System;
using System.Linq;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int digits2 = Math.Abs(digits);
            string digitToString = digits2.ToString();

            int SumEven = SumEvenNumbers(digits2, digitToString);
            int sumOdd = SumOddNumbers(digits2, digitToString);

            int MultipleOfEvenAndOdd = GetMultipleOfEvenAndOdds(SumEven, sumOdd);
            Console.WriteLine(MultipleOfEvenAndOdd);


        }

        static int SumEvenNumbers(int digit,string lenghtOfDigits)
        {
            int resuldEven = 0;
            for (int i = 0; i < lenghtOfDigits.Length; i++)
            {
                int takeLastDigit = digit % 10;
                if (takeLastDigit % 2 == 0)
                {
                    resuldEven += takeLastDigit;
                }

                digit /= 10;
            }
            return resuldEven;
        }

        static int SumOddNumbers(int digit, string lenghtOfDigits)
        {
            int resultOdd = 0;
            for (int i = 0; i < lenghtOfDigits.Length; i++)
            {
                int takeLastDigit = digit % 10;
                if (takeLastDigit % 2 != 0)
                {
                    resultOdd += takeLastDigit;
                }

                 digit /= 10;
               
            }
            return resultOdd;
        }

        static int GetMultipleOfEvenAndOdds(int digit1 ,int digit2)
        {

            int resultMultiple = digit1 * digit2;
            return resultMultiple;
        }

    }
}
