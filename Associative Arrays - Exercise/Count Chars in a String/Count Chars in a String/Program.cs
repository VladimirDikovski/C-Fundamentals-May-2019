using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            dict = CountSymbol(word, dict);

            PrintElemnts(dict);
            

        }
        static  Dictionary<char,int> CountSymbol(string word , Dictionary<char, int> dict)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char Symbol = word[i];
                if (Symbol != ' ')
                {
                    if (!dict.ContainsKey(Symbol))
                    {
                        dict[Symbol] = 0;
                    }

                       dict[Symbol]++;               
                }

            }

            return dict;
        }

        static void PrintElemnts(Dictionary<char, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
