using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string method = Console.ReadLine();
            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());
            int result = 0;
            
            if(method=="subtract")
            {
               result= subtractDigits(digit1, digit2);
            }
            else if (method == "multiply")
            {
                 result =multiplyDigits(digit1, digit2);
            }
            else if (method == "add")
            {
              result=  addDigits(digit1, digit2);
            }
            else if (method == "divide")
            {
               result =  divideDigits(digit1, digit2);
            }


            Console.WriteLine(result);
        }

        static int subtractDigits(int firstDigit,int secondDigit)
        {
            int result = firstDigit - secondDigit;
            return result;
            
        }
        static int divideDigits(int firstDigit, int secondDigit)
        {
            int result = firstDigit /secondDigit;
            return result;
        }
        static int addDigits(int firstDigit, int secondDigit)
        {
            int result = firstDigit + secondDigit;
            return result;
        }
        static int multiplyDigits(int firstDigit, int secondDigit)
        {
            int result = firstDigit * secondDigit;
            return result;
        }

    }
}
