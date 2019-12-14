using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string diggit = string.Empty;
            string latter = string.Empty;
            string other = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    diggit += text[i];
                }
                else if (char.IsLetter(text[i]))
                {
                    latter += text[i];
                }
                else
                {
                    other += text[i];
                }
            }

            Console.WriteLine(diggit);
            Console.WriteLine(latter);
            Console.WriteLine(other);
        }
    }
}
