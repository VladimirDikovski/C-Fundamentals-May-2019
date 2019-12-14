using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute += 30;
            int time = 0;

            if (minute > 60)
            {
                  
                hours++;
                minute -= 60; ;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.Write($"{hours}:{minute:d2}");
        }

       
    }
}
