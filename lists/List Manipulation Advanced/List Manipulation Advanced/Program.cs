using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            bool isMakeChange = false;

            while (true)
            {
                string typeOperation = Console.ReadLine();
                if (typeOperation == "end")
                {
                    break;
                }
                string[] token = typeOperation.Split(" ");
                if (token[0] == "Contains")
                {
                    ConteinDigitInList(token, digits);
                }
                else if (token[0] == "PrintEven")
                {
                    PrintEvenNumbersInList(token, digits);
                }
                else if (token[0] == "PrintOdd")
                {
                    PrintOddNumbersInList(token, digits);
                }
                else if (token[0] == "GetSum")
                {
                    GetSumOfList(token, digits);
                }
                else if (token[0] == "Filter")
                {
                    int compareDigits = int.Parse(token[2]);
                    FiterList(token, digits, compareDigits);
                }
                else if (token[0] == "Add")
                {
                    AddNumberToList(token,digits);
                    isMakeChange = true;
                    
                }
                else if(token[0]== "Remove")
                {
                    RemoveFromList(token, digits);
                    isMakeChange = true;
                }
                else if(token[0]== "RemoveAt")
                {
                    RemoveAtFromList(token, digits);
                    isMakeChange = true;
                }
                else if (token[0] == "Insert")
                {
                    InsertInList(token, digits);
                    isMakeChange = true;
                }


            }
            if (isMakeChange)
            {
                Console.WriteLine(string.Join(" ", digits));
            }
            

        }
        static void AddNumberToList(string[]token, List<int> digits)
        {
            digits.Add(int.Parse(token[1]));
        }
        static void RemoveFromList(string[] token, List<int> digits)
        {
            digits.Remove(int.Parse(token[1]));
        }
        static void RemoveAtFromList(string[] token, List<int> digits)
        {
            digits.RemoveAt(int.Parse(token[1]));
        }
        static void InsertInList(string[] token, List<int> digits)
        {
            digits.Insert(int.Parse(token[2]), int.Parse(token[1]));
        }

        static void ConteinDigitInList(string[] token, List<int> digits)
        {
            if (digits.Contains(int.Parse(token[1])))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEvenNumbersInList(string[] token, List<int> digits)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    Console.Write(digits[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOddNumbersInList(string[] token, List<int> digits)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] % 2 == 1)
                {
                    Console.Write(digits[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void GetSumOfList(string[] token, List<int> digits)
        {
            int sumOFlist = digits.Sum();
            Console.WriteLine(sumOFlist);
        }

        static void FiterList(string[] token, List<int> digits, int compareDigits)
        {
            List<int> filterList = new List<int>();

            if (token[1] == ">=")
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    if (digits[i] >= compareDigits)
                    {
                        filterList.Add(digits[i]);

                    }

                }
                Console.WriteLine(string.Join(" ", filterList));
            }

            else if (token[1] == "<=")
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    if (digits[i] <= compareDigits)
                    {
                        filterList.Add(digits[i]);

                    }

                }
                Console.WriteLine(string.Join(" ", filterList));
            }
            else if (token[1] == "<")
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    if (digits[i] < compareDigits)
                    {
                        filterList.Add(digits[i]);

                    }

                }
                Console.WriteLine(string.Join(" ", filterList));
            }
            else if (token[1] == ">")
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    if (digits[i] > compareDigits)
                    {
                        filterList.Add(digits[i]);

                    }

                }
                Console.WriteLine(string.Join(" ", filterList));
            }
        }
    }
}