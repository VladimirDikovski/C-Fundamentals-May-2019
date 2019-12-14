using System;
using System.Linq;
using System.Collections.Generic;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudent = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string,List<double>>();

            for (int i = 0; i < countStudent; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                    dict[name].Add(grade);
                    
                }
                else
                {
                    dict[name].Add(grade);
                }
            }



            var Filterdict = dict.Where(x => x.Value.Average() >= 4.5).OrderByDescending(x=>x.Value.Average()).
                ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in Filterdict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
            
        }
    }
}
