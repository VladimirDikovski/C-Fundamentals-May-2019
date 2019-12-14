
using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            
            if (firstNumbers.Count == secondNumbers.Count)
            {
                EqualLists(firstNumbers, secondNumbers);
            }
            else
            {
                NotEqualLists(firstNumbers, secondNumbers);
            }

        }

        static void EqualLists(List<int>firstNumbers,List<int>secondNumbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Min(firstNumbers.Count, secondNumbers.Count); i++)
            {
               
                result.Add(firstNumbers[i]);
                result.Add(secondNumbers[i]);

            }
            Console.WriteLine(string.Join(" ", result));
        }

        static void NotEqualLists(List<int> firstNumbers, List<int> secondNumbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Min(firstNumbers.Count, secondNumbers.Count); i++)
            {

                result.Add(firstNumbers[i]);
                result.Add(secondNumbers[i]);

            }
            int difrent = Math.Abs(firstNumbers.Count - secondNumbers.Count);
            if (firstNumbers.Count > secondNumbers.Count)
            {
                for (int i = 0; i < difrent; i++)
                {
                    result.Add(firstNumbers[firstNumbers.Count - difrent + i]);
                }

            }
            else
            {
                for (int i = 0; i < difrent; i++)
                {
                    result.Add(secondNumbers[secondNumbers.Count - difrent + i]);
                }

            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
