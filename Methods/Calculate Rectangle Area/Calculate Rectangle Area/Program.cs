using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double aSide = double.Parse(Console.ReadLine());
            double bSide = double.Parse(Console.ReadLine());
            double result = ReatRectangleArea(aSide, bSide);

            Console.WriteLine(result);

        }

        static double ReatRectangleArea(double sideA,double sideB)
        {
            double result = sideA * sideB;
            return result;
        }
    }
}
