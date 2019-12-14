using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int countity = int.Parse(Console.ReadLine());

            double result = OrderPrice(order, countity);
            Console.WriteLine($"{result:f2}");
        }

        static double OrderPrice(string order ,int countity)
        {
            double result = 0;

            if(order =="coffee")
            {
                result = countity * 1.50;

            }
           else if (order == "water")
            {
                result = countity * 1.00;

            }
            else if (order == "coke")
            {
                result = countity * 1.40;

            }
            else if (order == "snacks")
            {
                result = countity * 2.00;

            }

            return result;
        }
    }
}
