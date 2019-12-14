using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int realDigit = 0;
            int sum = 0;
            while (digit > 0)
            {
                realDigit =digit %10;
                sum += realDigit;
                digit /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
