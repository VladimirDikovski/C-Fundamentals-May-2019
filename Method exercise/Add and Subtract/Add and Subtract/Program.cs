using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int threeDigit = int.Parse(Console.ReadLine());

            int resultSum = SumIntegers(firstDigit,secondDigit);

            int finalResult = SubtractIntegers(resultSum, threeDigit);
            Console.WriteLine(finalResult);
        }

        static int SumIntegers(int first,int second)
        {
            int result = first + second;
            return result;
        }

        static int SubtractIntegers(int resultSum ,int threeDigits)
        {

            int result = resultSum - threeDigits;
            return result;
        }
    }
}
