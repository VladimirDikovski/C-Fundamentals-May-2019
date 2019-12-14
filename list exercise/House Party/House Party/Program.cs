using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int countComand = int.Parse(Console.ReadLine());
            List<string> namesAction = new List<string>();

            for (int i = 0; i < countComand; i++)
            {
                string [] input = Console.ReadLine().Split(" ");
                if (input.Length == 3)
                {
                    if (!namesAction.Contains(input[0]))
                    {
                        namesAction.Add(input[0]);
                    }
                    else if (namesAction.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                     
                }
               else  if (input.Length == 4)
                {
                    if (namesAction.Contains(input[0]))
                    {
                        namesAction.Remove(input[0]);
                    }
                    else if (!namesAction.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
               
               
            }

            for (int i = 0; i < namesAction.Count; i++)
            {
                Console.WriteLine(namesAction[i]);
            }
        }
    }
}
