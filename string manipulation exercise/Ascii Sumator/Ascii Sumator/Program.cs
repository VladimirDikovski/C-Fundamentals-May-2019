using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();
            int asciValue = charOne;
            int asciValue2 = charTwo;
            int result = 0;

            for (int i = 0; i <randomString.Length; i++)
            {
                char firstSymbol = randomString[i];

                
                if (firstSymbol > asciValue && firstSymbol < asciValue2)
                {
                    result += firstSymbol;
                }
            }
            Console.WriteLine(result);
        }
    }
}
