using System;
using System.Collections.Generic;
using System.Linq;


namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "end")
                {
                    break;
                }
                if (input[0] == "Delete")
                {
                    int ConvertToDigits = int.Parse(input[1]);
                    DeleteElemnts(input, digits, ConvertToDigits);
                }
                else if(input[0]== "Insert")
                {
                    int convertElement = int.Parse(input[1]);
                    int convertIndex = int.Parse(input[2]);
                    InsterInList(input, digits, convertElement, convertIndex);
                }
            }

            Console.WriteLine(string.Join(" ", digits));
        }
        static void DeleteElemnts(string[] input, List<int> digits, int convertToDigit)
        {
            digits.RemoveAll(x => x == convertToDigit);

        }

        static void InsterInList(string[] input, List<int> digits, int convertElemen, int convertIndex)
        {
            digits.Insert(convertIndex, convertElemen);
        }

       
    }

   
}
