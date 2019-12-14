using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 8 == 0)
                {
                    Console.WriteLine(i);

                }
               
            }
            
        }
    }
}
