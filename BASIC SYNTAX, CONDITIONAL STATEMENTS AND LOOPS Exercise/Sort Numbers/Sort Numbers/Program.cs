using System;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());
            int digit3 = int.Parse(Console.ReadLine());

            if (digit1>=digit2&&digit2>=digit3)
            {
                Console.WriteLine(digit1);
                Console.WriteLine(digit2);
                Console.WriteLine(digit3);
            }
            else if (digit1 >= digit3 && digit3 >= digit2)
            {
                Console.WriteLine(digit1);
                Console.WriteLine(digit3);
                Console.WriteLine(digit2);
            }
            else if (digit2>=digit1 && digit1 >= digit3)
            {
                Console.WriteLine(digit2);
                Console.WriteLine(digit1);
                Console.WriteLine(digit3);
            }
            else if (digit2 >= digit3 && digit3 >= digit1)
            {
                Console.WriteLine(digit2);
                Console.WriteLine(digit3);
                Console.WriteLine(digit1);
            }
            else if (digit3 >= digit2 && digit2 >= digit1)
            {
                Console.WriteLine(digit3);
                Console.WriteLine(digit2);
                Console.WriteLine(digit1);
            }
            else if (digit3 >= digit1 && digit1 >= digit2)
            {
                Console.WriteLine(digit3);
                Console.WriteLine(digit1);
                Console.WriteLine(digit2);
            }





        }
    }
}
