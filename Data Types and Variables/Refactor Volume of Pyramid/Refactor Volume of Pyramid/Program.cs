using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double Lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Widht = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height= double.Parse(Console.ReadLine());
            double result = 0;

            result = (Lenght * Widht * Height) / 3;
            Console.WriteLine($"Pyramid Volume: {result:f2}");

        }
    }
}
