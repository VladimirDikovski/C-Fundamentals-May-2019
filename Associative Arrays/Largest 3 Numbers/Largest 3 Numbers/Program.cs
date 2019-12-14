using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            var sorterArray = numbers.OrderByDescending(x=>x).Take(3).ToList();

           

            foreach (var item in sorterArray)
            {
                Console.Write(item + " ");
            }



        }
    }
}
