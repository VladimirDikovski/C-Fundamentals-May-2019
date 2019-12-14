using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(" ").ToList();

            var onlyEvenWords = words.Where(x => x.Length % 2 == 0).ToList();

            foreach (var item in onlyEvenWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
