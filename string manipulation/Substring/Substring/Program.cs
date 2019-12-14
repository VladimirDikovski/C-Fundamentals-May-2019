using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstText = Console.ReadLine().ToLower();
            string secondText = Console.ReadLine().ToLower();


            while (true)
            {
                var value = secondText.IndexOf(firstText);

                if (value < 0)
                {
                    break;
                }
                secondText = secondText.Remove(value, firstText.Length);

            }
            Console.WriteLine(secondText);
        }
    }
}
