using System;
using System.Linq;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = Console.ReadLine().ToLower().Split(" ");
            var dict = new Dictionary<string, int>();

            foreach (var item in world)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 1;
                }
                else
                {
                    dict[item]++;
                }
            }

            foreach (var item in dict)
            {
                if(item.Value % 2 != 0)
                {
                    Console.Write(item.Key+ " ");
                }
            }

          

        }
    }
}
