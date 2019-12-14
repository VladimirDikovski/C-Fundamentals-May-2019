using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            MatchCollection result = regex.Matches(text);

            foreach (Match item in result)
            {
                Console.Write(item.Value+" ");
            }
           
        }
    }
}
