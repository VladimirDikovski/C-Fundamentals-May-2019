using System;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split(" ");
            string concatanete = string.Empty;
            for (int i = 0; i <texts.Length; i++)
            {
                string firstSumboll = texts[i];
                for (int j = 0; j < firstSumboll.Length; j++)
                {
                    concatanete += firstSumboll;
                }
            }
            Console.WriteLine(concatanete);
        }
    }
}
