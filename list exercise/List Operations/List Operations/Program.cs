using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
 
                if(input[0]== "End")
                {
                    break;
                }

                else if(input[0]== "Add")
                {
                    AddElementsInTheList(input, digits);
                }
                else if(input[0] == "Insert")
                {
                    InsterElementsInList(input, digits);
                }
                else if(input[0] == "Remove")
                {
                   
                    RemoveFromList(input, digits);
                }
                else if (input[1] == "left")
                {
                    MovesListLeft(input, digits);
                }
                else if (input[1] == "right")
                {
                    MoveListRight(input, digits);
                }
                
            }
            Console.WriteLine(string.Join(" ", digits));
        }

        static void AddElementsInTheList(string[] input, List<int> digits)
        {
            digits.Add(int.Parse(input[1]));
        }

        static void InsterElementsInList(string[] input, List<int> digits)
        {
            int parseIndex = int.Parse(input[2]);
            int parseElement = int.Parse(input[1]);
            
                if (parseIndex >= digits.Count||parseIndex<0)
                {
                    Console.WriteLine("Invalid index");
                }
            else
            {
                digits.Insert(parseIndex,parseElement);
            }
            
        }

        static void RemoveFromList(string[] input, List<int> digits)
        {
            int parseIndex = int.Parse(input[1]);
            if (parseIndex >= digits.Count || parseIndex<0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                digits.RemoveAt(parseIndex);
            }

           
        }

        static void MovesListLeft(string[] input, List<int> digits)
        {
            int countMoves = 0;
            int countTimesMoves = int.Parse(input[2]);
            for (int i = 0; i < countTimesMoves; i++)
            {
                countMoves++;
                digits.Add(digits[i]);
                digits.RemoveAt(i);
                i--;
                if (countMoves == countTimesMoves)
                {
                    break;
                }
                
            }

        }
        static void MoveListRight(string[] input, List<int> digits)
        {
            int countMoves = 0;
            int countTimesMoves = int.Parse(input[2]);
            for (int i = 0; i <countTimesMoves; i++)
            {
                countMoves++;
                int lastElemnts = digits[digits.Count - 1];
                digits.Insert(i,lastElemnts);
                digits.RemoveAt(digits.Count-1);
                i--;
                if (countMoves == countTimesMoves)
                {
                    break;
                }
            }
        }
    }
}
