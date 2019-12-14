using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string world = Console.ReadLine();
                string Synonyms = Console.ReadLine();
 

                if (!dict.ContainsKey(world))
                {
                    dict[world] = new List<string>();
                }
                dict[world].Add(Synonyms);
            }

            foreach (var item in dict)
            {
                
                Console.WriteLine($"{item.Key} - {string.Join(","," ",item.Value)}");
            }
        }
    }
}
