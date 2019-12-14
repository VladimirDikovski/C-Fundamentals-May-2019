using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
           char charOne = char.Parse(Console.ReadLine());
           char charTwo = char.Parse(Console.ReadLine());
           char charThree = char.Parse(Console.ReadLine());
           string result =charOne.ToString() + charTwo.ToString() + charThree.ToString();
            Console.WriteLine(result);

        }
    }
}
