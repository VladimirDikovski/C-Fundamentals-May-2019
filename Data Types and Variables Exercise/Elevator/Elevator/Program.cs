using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int curses = numberPeople / capacity;
            int extraCurses = numberPeople % capacity;

            if (extraCurses != 0)
            {
                curses++;
            }

            Console.WriteLine(curses);
        }
    }
}
