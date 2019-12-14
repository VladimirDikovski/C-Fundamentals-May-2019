using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;


namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ' ' };

            string[] banWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string secondText = Console.ReadLine();

            for (int i = 0; i < banWords.Length; i++)
            {
                secondText = secondText.Replace(banWords[i], new string('*', banWords[i].Length));
            }

            Console.WriteLine(secondText);
          

        }
    }
}
