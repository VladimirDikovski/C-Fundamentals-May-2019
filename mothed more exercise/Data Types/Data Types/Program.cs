using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOperation = Console.ReadLine();
            string value = Console.ReadLine();
            
            if (typeOperation == "int")
            {
                int stringToDigit = int.Parse(value);
                multiplyNumber(stringToDigit);
            }
            else if(typeOperation== "real")
            {
                double stringToDecimal = double.Parse(value);
                multiplyDecimalNumber(stringToDecimal);
            }
            else if (typeOperation == "string")
            {
                StringModificatin(value);
            }

        }

        static void multiplyNumber(int value)
        {
            
            int result = value * 2;
            Console.WriteLine(result);
            
        }

        static void multiplyDecimalNumber(double value)
        {
           
            double result = value * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        static void StringModificatin(string value)
        {
            
            Console.WriteLine("$"+value+"$");
        }
    }
}
