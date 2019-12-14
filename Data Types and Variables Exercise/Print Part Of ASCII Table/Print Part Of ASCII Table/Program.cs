using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startAsci = int.Parse(Console.ReadLine());
            int SecondAsci =int.Parse(Console.ReadLine());

            for (int i = startAsci; i <= SecondAsci; i++)
            {

                Console.Write((char)i + " ");
            }
        }
    }
}
