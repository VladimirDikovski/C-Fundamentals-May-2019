using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();

            int countRepley = int.Parse(Console.ReadLine());

            RepeatString(symbol, countRepley);

            
        }

        static void RepeatString(string symbol, int countRepiat)
        {

            for (int i = 0; i < countRepiat; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
