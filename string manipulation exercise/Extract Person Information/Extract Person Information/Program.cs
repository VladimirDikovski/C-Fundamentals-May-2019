using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int countN = int.Parse(Console.ReadLine());
            string name = string.Empty;
            string age = string.Empty;

            for (int i = 0; i < countN; i++)
            {
                string input = Console.ReadLine();
                int indexOfName = input.IndexOf('@');
                int LastInfexOfName = input.LastIndexOf('|');
                int betweenIndex = Math.Abs(indexOfName - LastInfexOfName);
                name = input.Substring(indexOfName+1,betweenIndex-1);
                indexOfName = input.IndexOf('#');
                LastInfexOfName = input.LastIndexOf('*');
                betweenIndex= Math.Abs(indexOfName - LastInfexOfName);
                age = input.Substring(indexOfName + 1, betweenIndex - 1);

                Console.WriteLine($"{name} is {age} years old.");
                
            }
        }
    }
}
