using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> result = new List<char>();
           
            
          
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<char> text = Console.ReadLine().ToList();
            for (int i = 0; i < digits.Count; i++)
            {
                CalculateDigits(digits,i,text);
               
               
            }

           

        }

        static void CalculateDigits(List<int> digits,int i, List<char> text)
        {
            int sum = 0;
            int result = 0;
         
            while (digits[i] != 0)
            {
               sum = digits[i] % 10;
                result += sum;
                digits[i] /= 10;
                
            }

            PrintSymbol(result,text);

        }
        static void PrintSymbol(int result, List<char> text)
        {
            int index = 0;
            char symbol =' ';
        

            for (int i = 0; i < result; i++)
            {
                index++;

                if (index == text.Count)
                {
                    index = 0;
                }
               
            }
            symbol = text[index];
           
            RemoveSymbol(text, symbol);
        }
        static void RemoveSymbol(List<char> text,char symbol)
        {
            
            text.Remove(symbol);
            PrintResult(symbol);
        }


        static void PrintResult(char symbol)
        {
            Console.Write(symbol);
        }
       

    }



    
}
