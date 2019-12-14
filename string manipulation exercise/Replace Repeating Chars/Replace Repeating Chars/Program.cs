using System;
using System.Linq;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string FinalResult = String.Empty;
          
            for (int i = 0; i < text.Length; i++)
            {
                char Symbol = text[i];
                FinalResult += Symbol;
                text = text.TrimStart(Symbol);
                i--;

            }
            Console.WriteLine(FinalResult);
        }
    }
}
