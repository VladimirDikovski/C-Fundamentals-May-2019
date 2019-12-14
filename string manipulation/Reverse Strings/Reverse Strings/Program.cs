using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string reverseText = string.Empty;
                string text = Console.ReadLine();
                if (text == "end")
                {
                    break;
                }
                

                for (int i = text.Length-1; i >=0; i--)
                {
                    reverseText += text[i];
                }

                Console.WriteLine($"{text} = {reverseText}");
            }
        }
    }
}
