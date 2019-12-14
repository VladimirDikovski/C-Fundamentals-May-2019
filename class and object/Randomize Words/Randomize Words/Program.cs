using System;
using System.Linq;
using System.Collections.Generic;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = Console.ReadLine().Split(" ").ToList();
            var random = new Random();

            for (int i = 0; i <texts.Count;i++)
            {
                var randomIndex = random.Next(0, texts.Count);
                var randomElemnt = texts[randomIndex];
                var element = texts[i];
                texts[randomIndex] = element;
                texts[i] = randomElemnt;
            }

            foreach (var item in texts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
