using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>digits = Console.ReadLine().Split(new[]{'|'},StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
           

            for (int i = digits.Count-1; i >= 0; i--)
            {
                
                string[]input = digits[i].Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(input);
                
            }
            
            Console.WriteLine(string.Join(" ",result));
           
           
        }
    }
}
