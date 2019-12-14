using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();
            List<string> result = new List<string>();

            while (true)
            {
                string[] typeComand = Console.ReadLine().Split();
                if(typeComand[0]== "3:1")
                {
                    break;
                }
                if (typeComand[0] == "merge")
                {
                    int parseStartIndex = int.Parse(typeComand[1]);
                    int parseEndIndex = int.Parse(typeComand[2]);
                    data[parseStartIndex] += data[parseEndIndex];
                    
                }



            }
        }
    }
}
