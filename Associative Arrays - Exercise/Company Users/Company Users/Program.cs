using System;
using System.Linq;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("->");
                if (input[0]=="End")
                {
                    break;
                }
                string company = input[0];
                string employId = input[1];

                if (!dict.ContainsKey(company))
                {
                      dict[company] = new List<string>();
                      dict[company].Add(employId);
              
                }
                else          
                {
                    if (!dict[company].Contains(employId))
                    {
                        dict[company].Add(employId);
                    }
                        
                }

            }
           
            var filterList = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in filterList)
            {
                Console.WriteLine($"{item.Key}");

                var listitems = item.Value;
                foreach (var item2 in listitems)
                {
                    Console.WriteLine($"--{item2}");
                }
            }
        }
    }
}
