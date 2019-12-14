using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCompare = Console.ReadLine();

            if (typeCompare == "int")
            {
                int firstDigit = int.Parse(Console.ReadLine());
                int secondtDigit = int.Parse(Console.ReadLine());
                int result = CompareTwoDigit(firstDigit,secondtDigit);
                Console.WriteLine(result);
            }
            else if(typeCompare== "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = CompareTwoChars(firstChar, secondChar);
                Console.WriteLine(result);
            }

            else if(typeCompare== "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string result = CompareTwoString(firstString, secondString);
                Console.WriteLine(result);

            }
            
        }

        static int CompareTwoDigit(int firstDigit,int secondDigit)
        {
            if (firstDigit > secondDigit)
            {
                return firstDigit;
            }

            else
            {
                return secondDigit;
            }

        }

        static char CompareTwoChars(char a,char b)
        {
           

            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }

        static string CompareTwoString(string a,string b)
        {
            
           

            if (a.CompareTo(b)>=0 )
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
