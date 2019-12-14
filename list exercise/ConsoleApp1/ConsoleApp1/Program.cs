using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int capacityOfOneWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "end")
                {
                    break;
                }

                if (input.Length == 2)
                {
                    wagons.Add(int.Parse(input[1]));
                }

                else
                {
                    int passengers = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacityOfOneWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ",wagons));
            
        }
    }
}
