using System;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int year = 100 * centuries;

            int days = (int)(year * 365.2422);
            int hours = days * 24;
            int minute = hours * 60;

            Console.WriteLine($"{centuries} centuries = {year} years = {days} days = {hours} hours = {minute} minutes");


        }
    }
}
