using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondtDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int iteration = 0;
            
            while (true)
            {

                if (firstDeck[0] > secondtDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondtDeck[0]);
                    iteration++;
                }
                else if (secondtDeck[0] > firstDeck[0])
                {
                    secondtDeck.Add(secondtDeck[0]);
                    secondtDeck.Add(firstDeck[0]);
                    iteration++;
                }

                firstDeck.Remove(firstDeck[0]);
                secondtDeck.Remove(secondtDeck[0]);
                if (firstDeck.Count == 0)
                {
                    int sum = secondtDeck.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondtDeck.Count == 0)
                {
                    int sum = firstDeck.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }


            }
            Console.WriteLine(iteration);

                
        }
    }
}
