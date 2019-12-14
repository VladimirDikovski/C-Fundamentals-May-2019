using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int threeNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());
            int result = 0;
            result = (firstNumber + secondNumber) / threeNumber * fourNumber;
            Console.WriteLine(result);

        }
    }
}
