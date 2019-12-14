using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {


            var dict = new Dictionary<string, List<string>>();


            while (true)
            {
                string[] input = Console.ReadLine().Split(":");
                if (input[0] == "end")
                {
                    break;
                }
                string courses = input[0];
                string studens = input[1];

                if (!dict.ContainsKey(courses))
                {
                    dict[courses] = new List<string>();
                    dict[courses].Add(studens);

                }
                else
                {
                    dict[courses].Add(studens);

                }

            }

            var filterDict = dict.OrderByDescending(y => y.Value.Count).ToDictionary(x => x.Key, y => y.Value);
            filterDict = dict.Where(x => x.Value.Select(x+":"));

            foreach (var item in filterDict)

            {

                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                
                var list = item.Value;

                foreach (var item2 in list.OrderBy(x => x))
                {
                    Console.WriteLine($"--{item2}");

                }
            }



             

        }
    }
}    


