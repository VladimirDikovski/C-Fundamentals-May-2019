using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] digits = new int[n];

            for(int i = 0; i < digits.Length; i++)
            {
                digits[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < digits.Length; i++)
           {
                Console.Write(digits[digits.Length-i-1]+" ");
           }
      
    }
}
