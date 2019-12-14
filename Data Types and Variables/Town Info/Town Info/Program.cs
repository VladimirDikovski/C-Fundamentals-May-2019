using System;

namespace Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.Write($"Town {city} has population of {population} and area {area} square km.");
        }
    }
}
