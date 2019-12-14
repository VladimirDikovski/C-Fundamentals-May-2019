using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            double maxVolue = 0;
            string winnerName = string.Empty;

            for (int i = 0; i <n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                result = (double)Math.PI * Math.Pow(radius, 2) * height;

                if (result > maxVolue)
                {
                    winnerName = name;
                    maxVolue = result;
                    
                }
            }
            Console.WriteLine(winnerName);
        }
    }
}
