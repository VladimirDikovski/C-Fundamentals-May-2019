using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            
            while (true)
            {
                string typeOperation = Console.ReadLine();
                if (typeOperation == "end")
                {
                    break;
                }
                string[] token = typeOperation.Split(" ");

                
                
                
                if (token[0] == "Add")
                {

                    digits.Add(int.Parse(token[1]));
                }
                else if (token[0] == "Remove")
                {
                    digits.Remove(int.Parse(token[1]));
                }
                else if(token[0]== "RemoveAt")
                {
                    digits.RemoveAt(int.Parse(token[1]));
                }
                else if(token[0]== "Insert")
                {
                    digits.Insert(int.Parse(token[2]), int.Parse(token[1]));
                }

               

            }

            Console.WriteLine(string.Join(" ", digits));
        }
    }
}
