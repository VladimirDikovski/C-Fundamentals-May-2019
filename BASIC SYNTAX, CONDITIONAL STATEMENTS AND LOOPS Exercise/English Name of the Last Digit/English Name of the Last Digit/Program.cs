using System;

namespace English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            LastNumber();  

            void LastNumber()
            {
                decimal digit = decimal.Parse(Console.ReadLine());
                int n = 0;

                string convertDigit = digit.ToString();
                n = convertDigit.Length;
                char lastNumber = convertDigit[n - 1];

                if (lastNumber == '0')
                {
                    Console.WriteLine("zero");
                }
                else if (lastNumber == '1')
                {
                    Console.WriteLine("one");
                }
                else if (lastNumber == '2')
                {
                    Console.WriteLine("two");
                }
                else if (lastNumber == '3')
                {
                    Console.WriteLine("three");
                }
                else if (lastNumber == '4')
                {
                    Console.WriteLine("four");
                }
                else if (lastNumber == '5')
                {
                    Console.WriteLine("five");
                }
                else if (lastNumber == '6')
                {
                    Console.WriteLine("six");
                }
                else if (lastNumber == '7')
                {
                    Console.WriteLine("seven");
                }
                else if (lastNumber == '8')
                {
                    Console.WriteLine("eight");
                }
                else if (lastNumber == '9')
                {
                    Console.WriteLine("nine");
                }
            }

           
        }
    }
}
