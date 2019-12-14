using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int Asci = symbol;

            if(Asci>=97 && Asci <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else if(Asci>=65 && Asci <= 90)
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
