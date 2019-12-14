using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstDigit = double.Parse(Console.ReadLine());
            char typeOperator = char.Parse(Console.ReadLine());
            double secondDigit = double.Parse(Console.ReadLine());

             choiseOperator(firstDigit, typeOperator, secondDigit);
             
            
        }

        static void sumDigits(double a ,double b)
        {
            
            double result = a + b;
            Console.WriteLine($"{Math.Round(result,2)}");
        }

        static void subtractionDigits(double a ,double b)
        {
            double result = a - b;
            Console.WriteLine($"{Math.Round(result, 2)}");
        }

        static void divisionDigits(double a ,double b)
        {
            double result = a / b;
            Console.WriteLine($"{Math.Round(result, 2)}");
        }

        static void  multiplicationDigits(double a ,double b)
        {
            double result = a * b;
            Console.WriteLine($"{Math.Round(result, 2)}");
        }

        static void choiseOperator(double firstDigit, char a, double secondDigit)
        {
            

            if (a == '+')
            {
                sumDigits(firstDigit,secondDigit);

            }
            else if (a == '-')
            {
                 subtractionDigits(firstDigit,secondDigit);
            }
            else if (a== '*')
            {
                multiplicationDigits(firstDigit,secondDigit);
            }
            else if (a =='/')
            {
                 divisionDigits(firstDigit,secondDigit);
            }
        }

    }
}
